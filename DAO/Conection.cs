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
        public static SqlConnection OpenConection()
        {
            SqlConnection conection = new SqlConnection("Data Source=NACHO\\SQLEXPRESS;Initial Catalog=AcademicLife;Persist Security Info=True;User ID=sa;Password=pacha");
            if (conection.State == System.Data.ConnectionState.Closed)
            {
                conection.Open();
            }
            return conection;
        }
        public static SqlConnection CloseConection()
        {
            SqlConnection conection = new SqlConnection("Data Source=NACHO\\SQLEXPRESS;Initial Catalog=AcademicLife;Persist Security Info=True;User ID=sa;Password=pacha");
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
        public static DataTable GetUnique(string tableName, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = OpenConection();
            cmd.CommandText = "SELECT * FROM [" + tableName + "] WHERE Id = " + id;
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

            cmd.CommandText = "INSERT INTO [" + tableName + "] VALUES (" + parametersStr + ")";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
        public static void EditData(string tableName, List<string> parameters, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conection.OpenConection();
            var parametersStr = String.Join(",", parameters);

            cmd.CommandText = "UPDATE [" + tableName + "] SET " + parametersStr + "WHERE Id = " + id;
            //cmd.CommandText = "update " + tableName + " values (" + parametersStr + ")";
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        public static void DeleteData(string tableName, int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conection.OpenConection();

            cmd.CommandText = "DELETE [" + tableName + "] WHERE Id = " + id.ToString();
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }
    }
}
