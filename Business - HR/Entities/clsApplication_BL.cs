using Data_Layer.Entities;
using Models.Entities;
using static Models.Enums.M_Enums;
namespace Business___HR.Entities
{
    public class clsApplication_BL
    {

       public MApplication StrApplication;
        eMode mode;

        public clsApplication_BL()
        {
            mode = eMode.Add;
            StrApplication = new MApplication();

        }
        public clsApplication_BL(int ApplicationID, eApplicationType type) : this()
        {
            mode = eMode.Update;
            StrApplication.Status = (byte)type;
            StrApplication.Application_ID = ApplicationID;


        }

        // Add
        // Update
        public bool Save()
        {

            switch (mode)
            {

                case eMode.Add:
                    StrApplication.Application_ID = clsApplication_DL.Add(StrApplication);
                    return StrApplication.Application_ID != null;

                case eMode.Update:
                    return clsApplication_DL.Update(StrApplication);

            }

            return false;
        }


        // GetApplicationByID
        public int? GetApplicationID()
        {
            // Under Development
            return 0;
        }

        // Update SelectRecords
        // SelectRecords

    }



}
