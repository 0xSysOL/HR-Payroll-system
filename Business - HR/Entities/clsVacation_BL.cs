using Business___HR.Utilities;
using Data_Layer.Entities;
using Models.Entities;
using static Business___HR.Utilities.clsUtilities;
namespace Business___HR.Entities
{
    public class clsVacation_BL
    {
        MVacation StrVacation;
        public clsVacation_BL(MVacation vacation)
        {
            StrVacation = vacation;

        }
        private bool ValidateVacationData()
        {
            // 1. Check Vacation Reason
            if (IsTextNullorEmpty(StrVacation.VacationReason))
            {
                throw new BusinessException(1, "Vacation reason cannot be null or empty");
            }

            // 2. Check Vacation ID
            if (StrVacation.VacationID == null)
            {
                throw new BusinessException(2, "Vacation ID cannot be null");
            }

            if (StrVacation.VacationID <= 0)
            {
                throw new BusinessException(3, "Vacation ID must be greater than zero");
            }

            // 3. Check Application ID
            if (StrVacation.ApplicationID == null)
            {
                throw new BusinessException(4, "Application ID cannot be null");
            }

            if (StrVacation.ApplicationID <= 0)
            {
                throw new BusinessException(5, "Application ID must be greater than zero");
            }

            // 4. Check Begin Date
            if (StrVacation.BeginDate < DateTime.Now)
            {
                throw new BusinessException(6, "Begin date cannot be in the past");
            }

            // 5. Check End Date
            if (StrVacation.EndDate <= DateTime.Now)
            {
                throw new BusinessException(7, "End date must be in the future");
            }

            return false;

        }
        public bool Add()
        {
            if (ValidateVacationData())
                return false;


            return clsVacation_DL.Add(StrVacation);

        }


    }


}
