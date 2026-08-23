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
            StrApplication.ApplicationID = ApplicationID;


        }


        public bool Save()
        {

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




    }



}
