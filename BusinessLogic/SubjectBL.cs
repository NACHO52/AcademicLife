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
        public static DataTable SubjectGetAll()
        {
            DataTable dt = new DataTable();
            dt = new SubjectDAO().GetAll();
            return dt;
        }
        public static DataTable SubjectGetByStore(string name, string code, int? credits, int? hours, int? period, int? status)
        {
            DataTable dt = new DataTable();
            dt = new SubjectDAO().GetByStore(name, code, credits, hours, period, status);
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

        public static void EditedSubject(Subject obj)
        {
            new SubjectDAO().SaveEdited(obj);
        }

        public static void SaveSubject(Subject obj)
        {
            if(obj.Id == 0)
            {
                InsertSubject(obj);
            }
            else
            {
                EditedSubject(obj);
            }
        }

        public static string PeriodGetNameByValue(int v)
        {
            string message = string.Empty;
            switch (v)
            {
                case 1:
                    message = "Primer Cuatrimestre";
                    break;
                case 2:
                    message = "Segundo Cuatrimestre";
                    break;
                case 3:
                    message = "Tercer Cuatrimestre";
                    break;
                case 4:
                    message = "Cuarto Cuatrimestre";
                    break;
                case 5:
                    message = "Quinto Cuatrimestre";
                    break;
                case 6:
                    message = "Sexto Cuatrimestre";
                    break;
                case 7:
                    message = "Séptimo Cuatrimestre";
                    break;
                case 8:
                    message = "Octavo Cuatrimestre";
                    break;
                case 9:
                    message = "Noveno Cuatrimestre";
                    break;
                case 10:
                    message = "Décimo Cuatrimestre";
                    break;
                case 11:
                    message = "Undécimo Cuatrimestre";
                    break;
                case 12:
                    message = "Duodécimo Cuatrimestre";
                    break;
            }
            return message;
        }
    }
}
