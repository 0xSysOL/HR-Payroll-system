using Data_Layer.Entities;
using Models.Entities;
using static Models.Enums.M_Enums;
namespace Business___HR.Entities
{
    public class clsApplication_BL
    {

        private MApplication StrApplication;
        eMode mode;

        public clsApplication_BL(MApplication StrApplication)
        {
            mode = eMode.Add;
            this.StrApplication = StrApplication;
        }


        public clsApplication_BL(int ApplicationID, eApplicationStatus StatusType)
        {
            mode = eMode.Update;
            StrApplication.Status = (byte)StatusType;
            StrApplication.ApplicationID = ApplicationID;

        }


        public bool Save()
        {
            if (mode == eMode.Update && !IsApplicationExists((int)StrApplication.ApplicationID))
                return false;
            else if (mode == eMode.Update && !IsApplicationNew((int)StrApplication.ApplicationID))
                return false;


            switch (mode)
            {

                case eMode.Add:
                    StrApplication.ApplicationID = clsApplication_DL.Add(StrApplication);
                    return StrApplication.ApplicationID != null;

                case eMode.Update:
                    return clsApplication_DL.Update(StrApplication);

            }

            return false;
        }




        // Update SelectRecords
        // SelectRecords

        public static List<MApplication> SelectRecords(int PageNumber, int RowPerPage)
        {

            return clsApplication_DL.SelectRecords(PageNumber, RowPerPage);
        }
        public static MApplication GetApplicationByID(int ID)
        {

            return clsApplication_DL.GetApplication(ID);
        }

        public static bool IsApplicationExists(int ID)
        {

            return clsApplication_DL.IsApplicationExists(ID);
        }
        public static bool IsApplicationNew(int ID)
        {
            return clsApplication_DL.IsApplicationNew(ID);
        }


    }



}
