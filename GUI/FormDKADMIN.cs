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
    public partial class FormDKADMIN : Form
    {
        public FormDKADMIN()
        {
            InitializeComponent();
        }
        Controller dieuhuong = new Controller();
        private void bt_DK_ADMIN_Click(object sender, EventArgs e)
        {
            try
            {
                int checkview;
                int id = int.Parse(tb_ID_REG_ADMIN.Text);
                checkview = dieuhuong.RegisterfromFORMLOGIN(tb_EMAIL_REG_AD.Text, tb_PASS_REG_ADMIN.Text,id);
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
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }
    }
}
