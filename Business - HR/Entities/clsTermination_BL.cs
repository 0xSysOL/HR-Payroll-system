using Data_Layer.Entities;
using Models.Entities;

namespace Business___HR.Entities
{
    public class clsTermination_BL
    {

        MTermination StrTermination;

        public clsTermination_BL(MTermination StrTermination)
        {
            this.StrTermination = StrTermination;
        }

        public bool CheckFromInputsBeforAdding()
        {
            if (StrTermination.TerminationDate == null)
                return true;
            else if (StrTermination.CreateByUserID == null)
                return true;
            else if (StrTermination.Description == null)
                return true;
            else if (StrTermination.EmployeeID == null)
                return true;
            else if (StrTermination.TerminationReason == null)
                return true;
            else if (StrTermination.TerminationReason > 3 || StrTermination.TerminationReason < 1)
            {
                return true;
            }

            return false;
        }
        public bool Add()
        {


            if (CheckFromInputsBeforAdding())
                return false;

            if (!clsEmployee_BL.IsEmployeeExists((int)StrTermination.EmployeeID))
                return false;

            if (!clsUser_BL.IsUserIDExists((int)StrTermination.CreateByUserID))
                return false;

         
            StrTermination.TerminationID = clsTermination_DL.Add(StrTermination);
            return StrTermination.TerminationID != null;


        }



    }


}
