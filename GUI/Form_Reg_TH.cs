using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace GUI
{
    public partial class Form_Reg_TH : Form
    {
        public Form_Reg_TH()
        {
            InitializeComponent();
        }
        Controller dieuhuong = new Controller();
        private void BT_FORM_REG_DK(object sender, EventArgs e)
        {
            try
            {               
                if (tb_FORM_REG_Pass.Text.Equals(tb_FORM_REG_PassCon.Text))
                    {                    
                            int id = 2;
                            int checkview = 0;
                            checkview = dieuhuong.RegisterfromFORMLOGIN(tb_FORM_REG_Email.Text, tb_FORM_REG_Pass.Text,id);
                            if (checkview == 1)
                            {
                                MessageBox.Show("DANG KY THANH CONG");
                            }
                            else
                            {
                                MessageBox.Show(" DANG KY THAT BAI EMAIL NAY DA DC DANG KY HOAC BAN DA DUNG KY TU DAC BIET" +
                                    "VUI LONG XEM LAI TAI KHOAN DANG KY");
                            }
                        }
                    else
                    {
                        MessageBox.Show("MAT KHAU KHONG GIONG NHAU");
                    }            
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }
    }
}
