using DAO;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class SystemUserBL
    {
        public static SystemUser SystemUserGetMainUser()
        {
            return new SystemUserDAO().GetMainUser();
        }
    }
}
