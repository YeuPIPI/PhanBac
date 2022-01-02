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
    public partial class Form_Change_TH : Form
    {
        public Form_Change_TH()
        {
            InitializeComponent();
        }
        Controller dieuhuong = new Controller();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_Form_Change_TH_Password.Text.Equals(tb_Form_Change_TH_Password_change.Text) == false)
                {
                    int check = dieuhuong.ChangefromFORMLOGIN(tb_Form_Change_TH_Email.Text, tb_Form_Change_TH_Password_change.Text);
                    if (check == 1)
                    {
                        MessageBox.Show("Thay doi mat khau thanh cong");

                    }
                    else
                    {
                        MessageBox.Show("BAN DA DUNG KY TU DAC BIET TRONG MAT KHAU MOI VUI LONG XEM LAI");
                    }
                }
                else
                {
                    MessageBox.Show("MAT KHAU MOI GIONG VOI MAT KHAU CU");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
