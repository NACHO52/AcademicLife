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
    public static class SubjectBL
    {
        public static DataTable ShowSubjects()
        {
            DataTable dt = new DataTable();
            dt = new SubjectDAO().ShowSubjects();
            return dt;
        }

        public static void InsertSubject(Subject subject)
        {
            new SubjectDAO().InsertSubjects(subject);
        }

        public static void DeleteSubject(int id)
        {
            new SubjectDAO().Delete(id);
        }
    }
}
