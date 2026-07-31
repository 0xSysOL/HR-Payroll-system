using Data_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business___HR.Entities
{
    public class clsCountry_BL
    {

        public static DataTable GetAll()
        {


            return clsCountry_DL.GetAll();
        }


    }



}
