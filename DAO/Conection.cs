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
        public static DataTable ShowData(string tableName)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = OpenConection();
            cmd.CommandText = "Select * from " + tableName;
            //Para StoresProcedures usar esto:
            //cmd.CommandType = CommandType.StoredProcedure;
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

            cmd.CommandText = "insert into " + tableName + " values (" + parametersStr + ")";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public static void DeleteData(string tableName, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conection.OpenConection();

            cmd.CommandText = "DELETE " + tableName + " where Id = " + id.ToString();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
