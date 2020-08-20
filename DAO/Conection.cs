using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class Conection
    {
        private static SqlConnection conection = new SqlConnection("Data Source=NACHO\\SQLEXPRESS;Initial Catalog=AcademicLife;Persist Security Info=True;User ID=sa;Password=pacha");

        public static SqlConnection OpenConection()
        {
            if(conection.State == System.Data.ConnectionState.Closed)
            {
                conection.Open();
            }
            return conection;
        }
        public static SqlConnection CloseConection()
        {
            if (conection.State == System.Data.ConnectionState.Open)
            {
                conection.Close();
            }
            return conection;
        }
        public static DataTable GetAll(string tableName)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = OpenConection();
            cmd.CommandText = "Select * from [" + tableName + "]";
            //Para StoresProcedures usar esto:
            //cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            CloseConection();
            return dt;
        }
        public static DataTable GetByStore(string spName, IList<SqlParameter> parameters)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = OpenConection();
            //var parametersStr = String.Join(",", parameters);
            cmd.CommandText = spName;
            cmd.CommandType = CommandType.StoredProcedure;

            foreach (SqlParameter item in parameters)
            {
                cmd.Parameters.AddWithValue(item.ParameterName, item.Value);
            }
            //cmd.Parameters.AddWithValue("@name", "");
            //cmd.Parameters.AddWithValue("@code", "");
            //cmd.Parameters.AddWithValue("@credits", null);
            //cmd.Parameters.AddWithValue("@hours", null);
            //cmd.Parameters.AddWithValue("@period", null);
            //cmd.Parameters.AddWithValue("@status", null);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            CloseConection();
            return dt;
        }

        public static void InsertData(string tableName, List<string> parameters)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conection.OpenConection();
            var parametersStr = String.Join(",", parameters);

            cmd.CommandText = "insert into [" + tableName + "] values (" + parametersStr + ")";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public static void EditData(string tableName, List<string> parameters, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conection.OpenConection();
            var parametersStr = String.Join(",", parameters);

            cmd.CommandText = "update [" + tableName + "] set " + parametersStr + "WHERE Id = " + id;
            //cmd.CommandText = "update " + tableName + " values (" + parametersStr + ")";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public static void DeleteData(string tableName, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conection.OpenConection();

            cmd.CommandText = "DELETE [" + tableName + "] where Id = " + id.ToString();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
