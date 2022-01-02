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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        Controller dieuhuong = new Controller();
        Class_New_Form_Reg new_Form_Reg = new Class_New_Form_Reg(); 
        private void button4_Click(object sender, EventArgs ev)
        {
            
            this.Close();
        }

        private void Login_Form_BUTTON(object sender, EventArgs e)
        {
            try
            {
                int checkview = 0;
                checkview = dieuhuong.LoginfromFORMLOGIN(tb_Email_Login.Text, tb_Password_Login.Text);
                
                if (checkview == 1)
                {
                    MessageBox.Show("DANG NHAP THANH CONG BANG TAI KHOAN BAC CAO ");
                    this.Hide();
                    ADMIN_FORM f2 = new ADMIN_FORM();
                    f2.ShowDialog();
                    this.Show();                   
                }
                if (checkview == 2)
                {
                    MessageBox.Show("Dang nhap thanh cong bang tai khoan thuong");
                    this.Hide();
                    Form_XULY f3 = new Form_XULY();
                    f3.ShowDialog();
                    this.Show();
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.email3 = Properties.Settings.Default.email2;
                Properties.Settings.Default.password3 = Properties.Settings.Default.password2;
                Properties.Settings.Default.email2 = Properties.Settings.Default.email1;
                Properties.Settings.Default.password2 = Properties.Settings.Default.password1;
                Properties.Settings.Default.email1 = tb_Email_Login.Text;
                Properties.Settings.Default.password1 = tb_Password_Login.Text;
                Properties.Settings.Default.Save();
            }
        }
        private void bt_Form_Login_DK(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form_Reg_TH form_Reg_TH = new Form_Reg_TH();
                form_Reg_TH.ShowDialog();
                this.Show();
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);

            }
        }
        private void bt_Form_Login_Change(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Form_Change_TH form_Change_TH = new Form_Change_TH();
                form_Change_TH.ShowDialog();
                this.Show();
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);

            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            try
            {
                bt_DN1.Text = Properties.Settings.Default.email1;
                bt_DN2.Text = Properties.Settings.Default.email2;
                bt_DN3.Text = Properties.Settings.Default.email3;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void bt_LuuTk(object sender, EventArgs e)
        {
            List<string> LuuTK1 = new List<string>();
            LuuTK1.Add(Properties.Settings.Default.email1);
            LuuTK1.Add(Properties.Settings.Default.email2);
            LuuTK1.Add(Properties.Settings.Default.email3);
            List<string> LuuTK2 = new List<string>();
            LuuTK2.Add(Properties.Settings.Default.password1);
            LuuTK2.Add(Properties.Settings.Default.password2);
            LuuTK2.Add(Properties.Settings.Default.password3);
            Button b = (Button)(sender);
            string a = b.Text;
            for(int i = 0; i < LuuTK1.Count; i++)
            {
                if (a.Equals(LuuTK1[i]))
                {
                    int checkview = 0;
                    checkview = dieuhuong.LoginfromFORMLOGIN(LuuTK1[i],LuuTK2[i]);
                    if (checkview == 1)
                    {
                        MessageBox.Show("DANG NHAP THANH CONG BANG TAI KHOAN BAC CAO ");
                        this.Hide();
                        ADMIN_FORM f2 = new ADMIN_FORM();
                        f2.ShowDialog();
                        this.Show();
                    }
                    if (checkview == 2)
                    {
                        MessageBox.Show("Dang nhap thanh cong bang tai khoan thuong");
                        this.Hide();
                        Form_XULY f3 = new Form_XULY();
                        f3.ShowDialog();
                        this.Show();
                    }
                }
            }
                    
        }

    }
}
