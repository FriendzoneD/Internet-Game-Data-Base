namespace IGDB
{
    partial class Registration
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblRetype = new System.Windows.Forms.Label();
            this.txtRetypePass = new System.Windows.Forms.TextBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblLine2 = new System.Windows.Forms.Label();
            this.btnCancelReg = new System.Windows.Forms.Button();
            this.btnNextReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPassword.Location = new System.Drawing.Point(28, 111);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 19);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUsername.Location = new System.Drawing.Point(28, 69);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 19);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(32, 86);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(232, 20);
            this.txtUser.TabIndex = 6;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(32, 128);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(232, 20);
            this.txtPass.TabIndex = 7;
            // 
            // lblRetype
            // 
            this.lblRetype.AutoSize = true;
            this.lblRetype.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetype.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRetype.Location = new System.Drawing.Point(28, 153);
            this.lblRetype.Name = "lblRetype";
            this.lblRetype.Size = new System.Drawing.Size(120, 19);
            this.lblRetype.TabIndex = 8;
            this.lblRetype.Text = "Retype Password";
            // 
            // txtRetypePass
            // 
            this.txtRetypePass.Location = new System.Drawing.Point(32, 172);
            this.txtRetypePass.Name = "txtRetypePass";
            this.txtRetypePass.Size = new System.Drawing.Size(232, 20);
            this.txtRetypePass.TabIndex = 9;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.ForeColor = System.Drawing.Color.Silver;
            this.lblTip.Location = new System.Drawing.Point(29, 19);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(221, 39);
            this.lblTip.TabIndex = 10;
            this.lblTip.Text = "Please provide the below information.\r\nBe sure to make your password hard to gues" +
    "s.\r\nTry to use at least more than 5 letters.";
            // 
            // lblLine2
            // 
            this.lblLine2.AutoSize = true;
            this.lblLine2.ForeColor = System.Drawing.Color.Silver;
            this.lblLine2.Location = new System.Drawing.Point(11, 224);
            this.lblLine2.Name = "lblLine2";
            this.lblLine2.Size = new System.Drawing.Size(277, 13);
            this.lblLine2.TabIndex = 11;
            this.lblLine2.Text = "_____________________________________________";
            // 
            // btnCancelReg
            // 
            this.btnCancelReg.Location = new System.Drawing.Point(210, 249);
            this.btnCancelReg.Name = "btnCancelReg";
            this.btnCancelReg.Size = new System.Drawing.Size(75, 23);
            this.btnCancelReg.TabIndex = 12;
            this.btnCancelReg.Text = "Cancel";
            this.btnCancelReg.UseVisualStyleBackColor = true;
            this.btnCancelReg.Click += new System.EventHandler(this.btnCancelReg_Click);
            // 
            // btnNextReg
            // 
            this.btnNextReg.Location = new System.Drawing.Point(129, 249);
            this.btnNextReg.Name = "btnNextReg";
            this.btnNextReg.Size = new System.Drawing.Size(75, 23);
            this.btnNextReg.TabIndex = 13;
            this.btnNextReg.Text = "Next";
            this.btnNextReg.UseVisualStyleBackColor = true;
            this.btnNextReg.Click += new System.EventHandler(this.btnNextReg_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(297, 287);
            this.Controls.Add(this.btnNextReg);
            this.Controls.Add(this.btnCancelReg);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.txtRetypePass);
            this.Controls.Add(this.lblRetype);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLine2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblRetype;
        private System.Windows.Forms.TextBox txtRetypePass;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblLine2;
        private System.Windows.Forms.Button btnCancelReg;
        private System.Windows.Forms.Button btnNextReg;


    }
}