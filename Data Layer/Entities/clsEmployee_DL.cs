using Data_Layer.Configuration;
using Microsoft.Data.SqlClient;
using Models.Entities;
using System.Data;
using static Data_Layer.clsQueries;
using static Data_Layer.Utilities_DB;
namespace Data_Layer.Entities
{
    public class clsEmployee_DL
    {


        public static int? Add(MEmployee Structure)
        {

            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {

                SqlCommand command = GetSQL_Command(clsQEmployee.Add, connection, CommandType.StoredProcedure);
                AddParametersWithValue<MEmployee>(command, Structure);
                AddValueToManagerID(command, Structure.ManagerID);
                connection.Open();
                object Result = Scalar_Execute(command);
                return Result != null ? Convert.ToInt32(Result) : null;


            }


        }
        public static bool Update(MEmployee Structure)
        {


            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = GetSQL_Command(clsQEmployee.Update, connection, CommandType.StoredProcedure);


                AddParametersWithValue<MEmployee>(command, Structure);
                AddValueToManagerID(command, Structure.ManagerID);

                connection.Open();
                return Convert.ToBoolean(ExecuteNoneQu(command));




            }

        }

        public static bool IsEmployeeExists(int EmployeeID)
        {
            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = GetSQL_Command(clsQEmployee.IsEmployeeExists, connection, CommandType.StoredProcedure);

                command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                connection.Open();

                object Result = Scalar_Execute(command);
                return Convert.ToBoolean(Result);
            }
        }

        public static MEmployee GetEmployeeByID(int EmployeeID)
        {

            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {

                SqlCommand command = GetSQL_Command(clsQEmployee.GetEmployeeByID, connection, CommandType.StoredProcedure);
                command.Parameters.AddWithValue("EmployeeID", EmployeeID);

                connection.Open();

                return GetFirstOBFromList(ConvertRowsToClassesOB<MEmployee>(SelectRecords_Execute(command)));
            }

        }
        public static List<MEmployee> SelectRecordsAndChooseColumns(MEmployee Structure)
        {

            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = GetSQL_Command(clsQEmployee.SelectRecordsAndChooseColumns, connection, CommandType.StoredProcedure);
                command.Parameters.AddWithValue("@ColumnNames", AddParametersToString<MPeople>(Structure));
                connection.Open();
                return ConvertRowsToClassesOB<MEmployee>(SelectRecords_Execute(command));

            }

        }
        public static List<MEmployee> SelectRecords(int PageNumber, int RowsPerPage)
        {

            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = GetSQL_Command(clsQEmployee.SelectRecords, connection, CommandType.StoredProcedure);
                AddPaginationToSqlCommand(command, PageNumber, RowsPerPage);

                connection.Open();
                return ConvertRowsToClassesOB<MEmployee>(SelectRecords_Execute(command));

            }

        }
        public static bool Delete(int EmployeeID)
        {


            using (SqlConnection connection = clsSetting.GetSqlConnection())
            {
                SqlCommand command = GetSQL_Command(clsQEmployee.Delete, connection, CommandType.StoredProcedure);

                command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                connection.Open();
                // Feat: You Can Added To Function
                short Result = Convert.ToInt16(ExecuteNoneQu(command));
                return Result != 0 ? true : false;
            }


        }
    }


}
