using System.IO.Pipes;
using System.Text;

namespace Data_Layer.Errore_Catching
{
    public class clsClient
    {

        NamedPipeClientStream PipeClientStream;


        public clsClient()
        {
            // Change Pip name from hardcode to  App.config 
            PipeClientStream = new NamedPipeClientStream(".", "TEST",PipeDirection.Out);


        }

        public void Start()
        {
            PipeClientStream.Connect();

            StreamString SS = new StreamString(PipeClientStream);

            SS.WriteString("Hi Do You See me 1");

          

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

     
        public int WriteString(string outString)
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
