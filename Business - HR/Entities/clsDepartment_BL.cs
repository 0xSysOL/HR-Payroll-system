using Data_Layer.Entities;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business___HR.Entities
{
    public class clsDepartment_BL
    {

        MDepartment DepartmentOB;
        public clsDepartment_BL(MDepartment DepartmentOB)
        {

            this.DepartmentOB = DepartmentOB;
        }

        public bool Add()
        {

            DepartmentOB.Department_ID = clsDepartment_DL.Add(DepartmentOB);

            return DepartmentOB.Department_ID != null ? true : false;



        }

       
    }


}
