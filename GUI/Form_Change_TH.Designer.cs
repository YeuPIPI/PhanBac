namespace GUI
{
    partial class Form_Change_TH
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
            this.email = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.tb_Form_Change_TH_Email = new System.Windows.Forms.TextBox();
            this.tb_Form_Change_TH_Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_Form_Change_TH_Password_change = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(202, 141);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(40, 16);
            this.email.TabIndex = 0;
            this.email.Text = "email";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(202, 195);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(66, 16);
            this.pass.TabIndex = 1;
            this.pass.Text = "password";
            // 
            // tb_Form_Change_TH_Email
            // 
            this.tb_Form_Change_TH_Email.Location = new System.Drawing.Point(360, 135);
            this.tb_Form_Change_TH_Email.Name = "tb_Form_Change_TH_Email";
            this.tb_Form_Change_TH_Email.Size = new System.Drawing.Size(100, 22);
            this.tb_Form_Change_TH_Email.TabIndex = 2;
            // 
            // tb_Form_Change_TH_Password
            // 
            this.tb_Form_Change_TH_Password.Location = new System.Drawing.Point(360, 189);
            this.tb_Form_Change_TH_Password.Name = "tb_Form_Change_TH_Password";
            this.tb_Form_Change_TH_Password.Size = new System.Drawing.Size(100, 22);
            this.tb_Form_Change_TH_Password.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "thay doi mat khau";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_Form_Change_TH_Password_change
            // 
            this.tb_Form_Change_TH_Password_change.Location = new System.Drawing.Point(360, 250);
            this.tb_Form_Change_TH_Password_change.Name = "tb_Form_Change_TH_Password_change";
            this.tb_Form_Change_TH_Password_change.Size = new System.Drawing.Size(100, 22);
            this.tb_Form_Change_TH_Password_change.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "password change";
            // 
            // Form_Change_TH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Form_Change_TH_Password_change);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Form_Change_TH_Password);
            this.Controls.Add(this.tb_Form_Change_TH_Email);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.email);
            this.Name = "Form_Change_TH";
            this.Text = "Form_Change_TH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox tb_Form_Change_TH_Email;
        private System.Windows.Forms.TextBox tb_Form_Change_TH_Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_Form_Change_TH_Password_change;
        private System.Windows.Forms.Label label3;
    }
}