using Data_Layer.Entities;
using Models.Entities;
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

        public static List<MCountry> GetData(int PageNumber, int RowPerPage)
        {


            return clsCountry_DL.GetData(PageNumber,RowPerPage);
        }


    }



}
