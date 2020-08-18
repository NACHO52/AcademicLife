using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SubjectDAO
    {
        public DataTable ShowSubjects()
        {
            return Conection.ShowData("Subject");
        }
        public void InsertSubjects(Subject subject)
        {
            List<string> parameters = new List<string>();
            parameters.Add("'" + subject.Name + "'");
            parameters.Add("'" + subject.Code + "'");
            Conection.InsertData("Subject", parameters);
        }

        public void Delete(int id)
        {
            Conection.DeleteData("Subject", id);
        }
    }
}
