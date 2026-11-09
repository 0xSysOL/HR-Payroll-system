using Data_Layer.Errore_Catching;
using Models;
using Models.Entities;

namespace Business___HR.Entities
{
    public class clsClient_BL
    {


        public static async Task Start(MErrorInformation e) => await clsClient_DL.Start(e);


    }


}
