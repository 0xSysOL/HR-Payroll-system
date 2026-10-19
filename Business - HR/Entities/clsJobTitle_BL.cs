using Data_Layer.Entities;
using Models.Entities;
using Models.Enums;
using static Models.Enums.M_Enums;
namespace Business___HR.Entities
{
    public class clsJobTitle_BL
    {

        MJobTitle JobTitle;
        eMode mode;
        public clsJobTitle_BL(string Title)
        {
            JobTitle = new MJobTitle();
            JobTitle.Title = Title;
        }

        public bool Save()
        {


            switch (mode)
            {
                case eMode.Add:
                    JobTitle.ID = clsJobTitle_DL.Add(JobTitle.Title);
                    return JobTitle.ID != -1 ? true : false;

                case eMode.Update:

                    break;


            }

            return false;

        }



    }


}
