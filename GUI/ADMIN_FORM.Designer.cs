namespace GUI
{
    partial class ADMIN_FORM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN_FORM));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thoonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnBậcCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnBậcThấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_TaoTaiKhoan = new System.Windows.Forms.Button();
            this.bt_ADMINFORM_GD = new System.Windows.Forms.Button();
            this.bt_TK1 = new System.Windows.Forms.Button();
            this.bt_TK2 = new System.Windows.Forms.Button();
            this.bt_REFERSH = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.bt_Search = new System.Windows.Forms.Button();
            this.button_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoonToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // thoonToolStripMenuItem
            // 
            this.thoonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnBậcCaoToolStripMenuItem,
            this.tàiKhoảnBậcThấpToolStripMenuItem});
            this.thoonToolStripMenuItem.Name = "thoonToolStripMenuItem";
            resources.ApplyResources(this.thoonToolStripMenuItem, "thoonToolStripMenuItem");
            // 
            // tàiKhoảnBậcCaoToolStripMenuItem
            // 
            this.tàiKhoảnBậcCaoToolStripMenuItem.Name = "tàiKhoảnBậcCaoToolStripMenuItem";
            resources.ApplyResources(this.tàiKhoảnBậcCaoToolStripMenuItem, "tàiKhoảnBậcCaoToolStripMenuItem");
            // 
            // tàiKhoảnBậcThấpToolStripMenuItem
            // 
            this.tàiKhoảnBậcThấpToolStripMenuItem.Name = "tàiKhoảnBậcThấpToolStripMenuItem";
            resources.ApplyResources(this.tàiKhoảnBậcThấpToolStripMenuItem, "tàiKhoảnBậcThấpToolStripMenuItem");
            // 
            // bt_TaoTaiKhoan
            // 
            resources.ApplyResources(this.bt_TaoTaiKhoan, "bt_TaoTaiKhoan");
            this.bt_TaoTaiKhoan.Name = "bt_TaoTaiKhoan";
            this.bt_TaoTaiKhoan.UseVisualStyleBackColor = true;
            this.bt_TaoTaiKhoan.Click += new System.EventHandler(this.bt_TaoTaiKhoan_Click);
            // 
            // bt_ADMINFORM_GD
            // 
            resources.ApplyResources(this.bt_ADMINFORM_GD, "bt_ADMINFORM_GD");
            this.bt_ADMINFORM_GD.Name = "bt_ADMINFORM_GD";
            this.bt_ADMINFORM_GD.UseVisualStyleBackColor = true;
            this.bt_ADMINFORM_GD.Click += new System.EventHandler(this.bt_ADMINFORM_GD_Click);
            // 
            // bt_TK1
            // 
            resources.ApplyResources(this.bt_TK1, "bt_TK1");
            this.bt_TK1.Name = "bt_TK1";
            this.bt_TK1.UseVisualStyleBackColor = true;
            this.bt_TK1.Click += new System.EventHandler(this.bt_TK1_Click);
            // 
            // bt_TK2
            // 
            resources.ApplyResources(this.bt_TK2, "bt_TK2");
            this.bt_TK2.Name = "bt_TK2";
            this.bt_TK2.UseVisualStyleBackColor = true;
            this.bt_TK2.Click += new System.EventHandler(this.bt_TK2_Click);
            // 
            // bt_REFERSH
            // 
            resources.ApplyResources(this.bt_REFERSH, "bt_REFERSH");
            this.bt_REFERSH.Name = "bt_REFERSH";
            this.bt_REFERSH.UseVisualStyleBackColor = true;
            this.bt_REFERSH.Click += new System.EventHandler(this.bt_REFERSH_Click);
            // 
            // tb_Search
            // 
            resources.ApplyResources(this.tb_Search, "tb_Search");
            this.tb_Search.Name = "tb_Search";
            // 
            // bt_Search
            // 
            resources.ApplyResources(this.bt_Search, "bt_Search");
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // button_Thoat
            // 
            resources.ApplyResources(this.button_Thoat, "button_Thoat");
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.UseVisualStyleBackColor = true;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // ADMIN_FORM
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.bt_REFERSH);
            this.Controls.Add(this.bt_TK2);
            this.Controls.Add(this.bt_TK1);
            this.Controls.Add(this.bt_ADMINFORM_GD);
            this.Controls.Add(this.bt_TaoTaiKhoan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ADMIN_FORM";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ADMIN_FORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thoonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnBậcCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnBậcThấpToolStripMenuItem;
        private System.Windows.Forms.Button bt_TaoTaiKhoan;
        private System.Windows.Forms.Button bt_ADMINFORM_GD;
        private System.Windows.Forms.Button bt_TK1;
        private System.Windows.Forms.Button bt_TK2;
        private System.Windows.Forms.Button bt_REFERSH;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.Button button_Thoat;
    }
}