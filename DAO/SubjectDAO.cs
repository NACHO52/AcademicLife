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
        public DataTable GetAll()
        {
            return Conection.GetAll("Subject");
        }
        public void InsertSubjects(Subject subject)
        {
            List<string> parameters = new List<string>();
            parameters.Add("'" + subject.Name + "'");
            parameters.Add("'" + subject.Code + "'");
            parameters.Add("'" + subject.Credits + "'");
            parameters.Add("'" + subject.Hours + "'");
            parameters.Add("'" + (int)subject.Period + "'");
            parameters.Add("'" + subject.Status + "'");
            Conection.InsertData("Subject", parameters);
        }

        public DataTable GetByStore(string name, string code, int? credits, int? hours, int? period, int? status)
        {
            //IList<string> parameters = new List<string>();
            //parameters.Add("'" + name + "'");
            //parameters.Add("'" + code + "'");
            //parameters.Add(VerifyNumericValueParameter(credits));
            //parameters.Add(VerifyNumericValueParameter(hours));
            //parameters.Add(VerifyNumericValueParameter(period));
            //parameters.Add(VerifyNumericValueParameter(status));

            IList<SqlParameter> sqlParameters = new List<SqlParameter>();
            sqlParameters.Add(new SqlParameter("@name", name));
            sqlParameters.Add(new SqlParameter("@code", code));
            sqlParameters.Add(new SqlParameter("@credits", (credits)));
            sqlParameters.Add(new SqlParameter("@hours", (hours)));
            sqlParameters.Add(new SqlParameter("@period", (period)));
            sqlParameters.Add(new SqlParameter("@status", (status)));

            return Conection.GetByStore("SubjectGet", sqlParameters);
        }

        private int? VerifyNumericValueParameter(int? number)
        {
            if (number.HasValue)
            {
                return number;
            }
            else
            {
                return null;
            }
        }

        public void SaveEdited(Subject subject)
        {
            List<string> parameters = new List<string>();
            parameters.Add("Name = '" + subject.Name + "'");
            parameters.Add("Code = '" + subject.Code + "'");
            parameters.Add("Credits = '" + subject.Credits + "'");
            parameters.Add("Hours = '" + subject.Hours + "'");
            parameters.Add("Period = '" + (int)subject.Period + "'");
            parameters.Add("Status = '" + (int)subject.Status + "'");
            Conection.EditData("Subject", parameters, subject.Id);
        }

        public void Delete(int id)
        {
            Conection.DeleteData("Subject", id);
        }
    }
}
