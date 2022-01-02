using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using DAL;
namespace BLL
{
    
    public abstract class Register_DK
    {
        public abstract string Register();

    }
    public enum Register_DK_Type
    {
        REG_TH,
        REG_AD
    }
    public class Register_DK_TH : Register_DK
    {
        public override string Register()
        {
            return "REG_TH";
        }
    }
    public class Register_DK_AD : Register_DK
    {
        public override string Register()
        {
            return "REG_AD";
        }
    }
    public class FACTORY_REGIS
    {
        ConnectToSQL ass = new ConnectToSQL();
        public FACTORY_REGIS() { }
        public string Reg_TH(Register_DK_TH a1)
        {
            string b = a1.Register();
            return b;
        }
        public string Reg_AD(Register_DK_AD a2)
        {
            string b = a2.Register();
            return b;
        }
        public int RegisterfromFORMLOGIN(string EmAil, string PassWord, int id , string K_DK)
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
                checkControl = ass.SELECT(ta);
                if (checkControl == 1) return 1;
                else return 0;
            }

        }
        public static bool Check(string InputCheck)
        {
            var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

            if (regexItem.IsMatch(InputCheck))
            {
                return true;
            }
            return false;
        }
    }
}
