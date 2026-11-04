using Models;
using Models.Entities;
using Setting___HR_Client___WS_Server;
using System.IO.Pipes;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;
namespace Data_Layer.Errore_Catching
{




    public static class clsClient_DL
    {
        // Change Pip name from hardcode to  App.config 
        private static NamedPipeClientStream PipeClientStream = new NamedPipeClientStream(".", 
            GetValuesFromAppConfig.GetValueInTag("NameOfPipe").Item1, PipeDirection.Out);
        private static SemaphoreSlim slim = new SemaphoreSlim(1, 1);

        public static async void Start(MErrorInformation StrError)
        {
            
            await slim.WaitAsync();


            try
            {
                PipeClientStream.Connect();
                StreamString SS = new StreamString(PipeClientStream);
                await SS.WriteStringAsync(JsonSerializer.Serialize(StrError));

            }
            finally
            {
                try
                {
                    PipeClientStream.Dispose();
                }
                finally
                {
                    slim.Release();
                }

            }




        }



    }
    internal class StreamString
    {
        private Stream ioStream;
        private UnicodeEncoding streamEncoding;

        public StreamString(Stream ioStream)
        {
            this.ioStream = ioStream;
            streamEncoding = new UnicodeEncoding();
        }


        public async Task<int> WriteStringAsync(string outString)
        {


            byte[] outBuffer = streamEncoding.GetBytes(outString);
            int len = outBuffer.Length;
            if (len > UInt16.MaxValue)
            {
                len = (int)UInt16.MaxValue;
            }
            ioStream.WriteByte((byte)(len / 256));
            ioStream.WriteByte((byte)(len & 255));
            ioStream.Write(outBuffer, 0, len);
            ioStream.Flush();

            return outBuffer.Length + 2;
        }
    }

}
