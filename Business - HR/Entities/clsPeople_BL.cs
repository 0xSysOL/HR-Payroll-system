    using Data_Layer.Entities;
    using Models.Entities;
using Models.Enums;
using System.Data;
using static Models.Enums.M_Enums;
    namespace Business___HR.Entities
    {
        public class clsPeople_BL
        {

            public MPeople people;



            eMode mode;
            public clsPeople_BL(MPeople people)
            {

                this.people = people;
                mode = eMode.Add;
            }

            public bool Save()
            {
                switch (mode)
                {
                    case eMode.Add:
                        // Feat: In Future We Can Call Event To Send ID
                        people.Person_ID = clsPeople_DL.Add(people);
                        break;

                    case eMode.Update:
                        break;



                }
                return false;

            }


        public static DataTable GetAll()
        {
            return clsPeople_DL.GetAll();
        }


        public static DataTable SelectRecords(M_eColumnsName.ePeople[] People)
        {


            // Here


            return null;
            //return clsPeople_DL.SelectRecords(Structure);
        }

        }


    }
