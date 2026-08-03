using Data_Layer.Configuration;
using Microsoft.Data.SqlClient;
using Models.Entities;
using System.Data;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Data_Layer
{
    internal class Utilities_DB
    {

        /// <summary>
        /// initialize SqlCommand
        /// </summary>
        /// <param name="TextQ"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static SqlCommand GetSQL_Command(string TextQ, SqlConnection connection,CommandType commandType)
        {
            SqlCommand command = new SqlCommand(TextQ, connection);
            command.CommandType = commandType;
            return command;
        }



        /// <summary>
        /// you can use This Method For
        /// Types Queries Like (SELECT * TableName).
        /// </summary>
        /// <param name="command"></param>
        /// <returns>DataTable</returns>
        public static DataTable SelectRecords_Execute(SqlCommand command)
        {


            DataTable data = new DataTable();
            try
            {

                using (SqlDataReader reader = command.ExecuteReader())
                {


                    data.Load(reader);

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            return data;

        }
  
        public static int? Inserting_Execute(SqlCommand command)
        {
            int? ID = null;
            try 
            {
                ID = Convert.ToInt32(command.ExecuteScalar());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return ID;
        }

        public static string MyReplaceString(string Text, string OldValue, string newValue)
        {


            return Text.Replace(OldValue, newValue);
        }
     
        /// <summary>
        /// we Should Use This Method For Inserting That We Add 3-4 or more 
        /// parameters Ather wise this Method Nussery to use and
        /// will take resources for nothing
        /// </summary>
        /// <param name="command">SqlCommand</param>
        /// <param name="TableOb" >
        /// Table Object If You Want Know What Type Will send From this Method
        /// See Class namespace Models.Entities</param>
        
        public static void AddParametersWithValue(SqlCommand command, object TableOb)
        {

            if (TableOb == null || command == null)
                return;


            Type Reflection = TableOb.GetType();
            PropertyInfo []propertyInfo = Reflection.GetProperties();


            foreach(var prop in propertyInfo)
            {
                var MyAttr = prop.GetCustomAttribute<ForParametersAttribute>();
                if (MyAttr != null && prop.GetValue(TableOb) != null)
                    command.Parameters.AddWithValue(MyAttr.ParameterNameInSQL, prop.GetValue(TableOb));

            }


        }
        /// <summary>
        /// 
        /// this Function Take two Parameter,
        /// command and TableOb.
        /// <TableOb> See In Variable Came from outside,
        /// if Is Null He Will Not Add the Column to string Variable
        /// If Not He Will Add Like that 
        /// Example: "PersonID,FirstName", And Method Will Added to string
        /// why this Important Because To Send As String Text To Database as parameters
        /// And There will be Process in DB , and selected The Columns That Send it
        /// Example: when you Send Just "PersonID" the Server
        /// Just Return one Column > PersonID, not else.
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// 
        /// <param name="TableOb"></param>
        /// <returns></returns>
        public static string AddParametersToString(SqlCommand command, object TableOb)
        {
            if (TableOb == null || command == null)
                return null;

            string ColumnsName = "";

            Type Reflection = TableOb.GetType();
            PropertyInfo[] propInfo = Reflection.GetProperties();

            foreach(var Property in propInfo)
            {

                if ( Property.GetValue(TableOb) != null)
                {
                    var MyAttr = Property.GetCustomAttribute<ForParametersAttribute>();
                    if(MyAttr != null)
                    ColumnsName += MyAttr.ParameterNameInSQL + ",";
                }
            }

            if (ColumnsName.Length > 0)
                return ColumnsName.Remove(ColumnsName.Length - 1);
            else
                return "";
        }



        public static object Scalar_Execute(SqlCommand command)
        {

            try
            {
                return command.ExecuteScalar();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            return null;



        }
        public static object ExecuteNoneQu(SqlCommand command)
        {

            try
            {



                return command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            return null;



        }

    }
}
