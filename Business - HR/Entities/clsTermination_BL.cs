using Data_Layer.Entities;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Models.Entities.MTermination;

namespace Business___HR.Entities
{
    public class clsTermination_BL
    {   

        MTermination StrTermination;
        
        public clsTermination_BL(MTermination StrTermination) => this.StrTermination = StrTermination;


        public bool Add()
        {
            if (StrTermination.TerminationReason == 1)
                return false;

            return clsTermination_DL.Add(StrTermination);

        }
        
    
    
    }


}
