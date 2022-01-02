using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace GUI
{
    public interface Class_New_Form
    {
         void New_Form();
    }
    public class Class_New_Form_Reg
    {
        
        public void New_Form(Form a , Form b)
        {
            a.Hide();
            b.ShowDialog();
        }
    }
}
