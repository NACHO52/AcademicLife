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
    public class SystemUserDAO
    {
        public SystemUser GetMainUser()
        {
            DataTable dt = Conection.GetUnique("SystemUser", 1);
            SystemUser obj = new SystemUser();
            foreach (DataRow dr in dt.Select("Id = 1"))
            {
                obj.FirstName = dr["FirstName"].ToString();
                obj.LastName = dr["LastName"].ToString();
            }
            return obj;
        }
    }
}
