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
    public partial class ADMIN_FORM : Form
    {
        Controller bll = new Controller();
        public ADMIN_FORM()
        {
            InitializeComponent();
        }
        
        public void CONNECTTABLE()
        {
            DataTable dt = new DataTable();
            dt = bll.DataFromADMIN();
            dataGridView1.DataSource = dt;  
        }       
        private void ADMIN_FORM_Load(object sender, EventArgs e)
        {
            CONNECTTABLE();
           
        }
        private void bt_ADMINFORM_GD_Click(object sender, EventArgs e)
        {          
            this.Hide();
            Form_XULY a = new Form_XULY();
            a.ShowDialog();
            this.Show();
        }
        private void bt_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDKADMIN a = new FormDKADMIN();
            a.ShowDialog();
            this.Show();
        }
        private void bt_REFERSH_Click(object sender, EventArgs e)
        {
            CONNECTTABLE();
        }
        private void bt_TK1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bll.DataFromADMIN_TK(1);
            //dataGridView_TK.DataSource = dt;
            dataGridView1.DataSource = dt;  
        }
        private void bt_TK2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = bll.DataFromADMIN_TK(2);
            //dataGridView_TK.DataSource = dt;
            dataGridView1.DataSource = dt;
        }
        private void bt_Search_Click(object sender, EventArgs e)
        {
            string String_SEARCH = tb_Search.Text;
            DataTable dt = new DataTable();
            dt = bll.DataFromADMIN_TK_SEARCH(String_SEARCH);
            dataGridView1.DataSource = dt;           
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
