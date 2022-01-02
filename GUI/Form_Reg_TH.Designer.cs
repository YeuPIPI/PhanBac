namespace GUI
{
    partial class Form_Reg_TH
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_FORM_REG_Email = new System.Windows.Forms.TextBox();
            this.tb_FORM_REG_Pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_FORM_REG_PassCon = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // tb_FORM_REG_Email
            // 
            this.tb_FORM_REG_Email.Location = new System.Drawing.Point(352, 168);
            this.tb_FORM_REG_Email.Name = "tb_FORM_REG_Email";
            this.tb_FORM_REG_Email.Size = new System.Drawing.Size(100, 22);
            this.tb_FORM_REG_Email.TabIndex = 2;
            // 
            // tb_FORM_REG_Pass
            // 
            this.tb_FORM_REG_Pass.Location = new System.Drawing.Point(352, 227);
            this.tb_FORM_REG_Pass.Name = "tb_FORM_REG_Pass";
            this.tb_FORM_REG_Pass.Size = new System.Drawing.Size(100, 22);
            this.tb_FORM_REG_Pass.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "pass con";
            // 
            // tb_FORM_REG_PassCon
            // 
            this.tb_FORM_REG_PassCon.Location = new System.Drawing.Point(352, 281);
            this.tb_FORM_REG_PassCon.Name = "tb_FORM_REG_PassCon";
            this.tb_FORM_REG_PassCon.Size = new System.Drawing.Size(100, 22);
            this.tb_FORM_REG_PassCon.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "DANG KY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BT_FORM_REG_DK);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Form Dang ky";
            // 
            // Form_Reg_TH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_FORM_REG_PassCon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_FORM_REG_Pass);
            this.Controls.Add(this.tb_FORM_REG_Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Reg_TH";
            this.Text = "Form_Reg_TH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_FORM_REG_Email;
        private System.Windows.Forms.TextBox tb_FORM_REG_Pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_FORM_REG_PassCon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}