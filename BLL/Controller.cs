using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;
using System.Data;
namespace BLL
{
    public  class Controller
    {

        List<Person> admin = new List<Person>();
        ConnectToSQL ass = new ConnectToSQL();
        public static bool Check(string InputCheck)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if (regexItem.IsMatch(InputCheck))
            {
                return true;
            }
            return false;   
        }
        public int LoginfromFORMLOGIN(string EmAil, string PassWord)
        {
            int checkControl = 0;           
            Person ta = new Person();
            ta.Email = EmAil;
            ta.Password = PassWord;
            admin.Add(ta);
            checkControl = ass.SELECT(ta);
            if (checkControl == 1) return 1;
            if(checkControl == 2) return 2; 
            else return 0;
        }
        public int RegisterfromFORMLOGIN(string EmAil, string PassWord , int id)
        {
            { 
                int checkControl = 0;
                if (Check(EmAil) == false || Check(PassWord) == false)
                {
                    return 0;
                }
                Person ta = new Person();
                ta.Email = EmAil;
                ta.Password = PassWord;
                ta.Id = id;
                admin.Add(ta);
                checkControl = ass.REGISTER(ta);
                if (checkControl == 1) return 1;
                else return 0;
            }
            
        }
        public int ChangefromFORMLOGIN(string EmAil, string PassWord)
        {
            int checkControl = 0;
            if (Check(EmAil) == false || Check(PassWord) == false)
            {
                return 0;
            }
            Person ta = new Person();
            ta.Email = EmAil;
            ta.Password = PassWord;
            admin.Add(ta);
            checkControl = ass.CHANGE_PASSWORD(ta);
            if (checkControl == 1) return 1;
            else return 0;
        }
        public DataTable DataFromADMIN()
        {
            DataTable dt = new DataTable();
            dt = ass.CONNECTTABLE();
            return dt;
        }
        public DataTable DataFromADMIN_TK(int id)
        {
            DataTable dt = new DataTable();
            dt = ass.CONNECTTABLE_TK(id);
            return dt;
        }
        public DataTable DataFromADMIN_TK_SEARCH(string search)
        {
            DataTable dt = new DataTable();
            dt = ass.CONNECTTABLE_TK_SEARCH(search);
            return dt;
        }
    }
}
