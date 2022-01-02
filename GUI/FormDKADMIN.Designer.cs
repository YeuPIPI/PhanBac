namespace GUI
{
    partial class FormDKADMIN
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
            this.tb_EMAIL_REG_AD = new System.Windows.Forms.TextBox();
            this.tb_PASS_REG_ADMIN = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ID_REG_ADMIN = new System.Windows.Forms.TextBox();
            this.bt_DK_ADMIN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_EMAIL_REG_AD
            // 
            this.tb_EMAIL_REG_AD.Location = new System.Drawing.Point(235, 81);
            this.tb_EMAIL_REG_AD.Name = "tb_EMAIL_REG_AD";
            this.tb_EMAIL_REG_AD.Size = new System.Drawing.Size(100, 22);
            this.tb_EMAIL_REG_AD.TabIndex = 0;
            // 
            // tb_PASS_REG_ADMIN
            // 
            this.tb_PASS_REG_ADMIN.Location = new System.Drawing.Point(235, 131);
            this.tb_PASS_REG_ADMIN.Name = "tb_PASS_REG_ADMIN";
            this.tb_PASS_REG_ADMIN.Size = new System.Drawing.Size(100, 22);
            this.tb_PASS_REG_ADMIN.TabIndex = 1;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(109, 86);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 16);
            this.email.TabIndex = 2;
            this.email.Text = "Email";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(112, 131);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(66, 16);
            this.password.TabIndex = 3;
            this.password.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "id";
            // 
            // tb_ID_REG_ADMIN
            // 
            this.tb_ID_REG_ADMIN.Location = new System.Drawing.Point(235, 186);
            this.tb_ID_REG_ADMIN.Name = "tb_ID_REG_ADMIN";
            this.tb_ID_REG_ADMIN.Size = new System.Drawing.Size(100, 22);
            this.tb_ID_REG_ADMIN.TabIndex = 5;
            // 
            // bt_DK_ADMIN
            // 
            this.bt_DK_ADMIN.Location = new System.Drawing.Point(196, 251);
            this.bt_DK_ADMIN.Name = "bt_DK_ADMIN";
            this.bt_DK_ADMIN.Size = new System.Drawing.Size(95, 37);
            this.bt_DK_ADMIN.TabIndex = 6;
            this.bt_DK_ADMIN.Text = "DANG KY";
            this.bt_DK_ADMIN.UseVisualStyleBackColor = true;
            this.bt_DK_ADMIN.Click += new System.EventHandler(this.bt_DK_ADMIN_Click);
            // 
            // FormDKADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 329);
            this.Controls.Add(this.bt_DK_ADMIN);
            this.Controls.Add(this.tb_ID_REG_ADMIN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.tb_PASS_REG_ADMIN);
            this.Controls.Add(this.tb_EMAIL_REG_AD);
            this.Name = "FormDKADMIN";
            this.Text = "FormDKADMIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_EMAIL_REG_AD;
        private System.Windows.Forms.TextBox tb_PASS_REG_ADMIN;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ID_REG_ADMIN;
        private System.Windows.Forms.Button bt_DK_ADMIN;
    }
}