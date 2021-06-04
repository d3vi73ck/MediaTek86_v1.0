
namespace MediaTek86.Views
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLeave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxLogin = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 54);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnLeave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(415, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(299, 54);
            this.panel5.TabIndex = 1;
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.Red;
            this.btnLeave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLeave.Location = new System.Drawing.Point(0, 0);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(299, 54);
            this.btnLeave.TabIndex = 0;
            this.btnLeave.Text = "Quitter";
            this.btnLeave.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLogin);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(417, 54);
            this.panel4.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnLogin.IconColor = System.Drawing.Color.White;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.Location = new System.Drawing.Point(0, 0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(417, 54);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.lblLogin);
            this.panel2.Controls.Add(this.txtboxPassword);
            this.panel2.Controls.Add(this.txtboxLogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 204);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(714, 82);
            this.panel3.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("hooge 05_55", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(118, 152);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(141, 25);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password :";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("hooge 05_55", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(118, 101);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(95, 25);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login : ";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(281, 155);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(285, 22);
            this.txtboxPassword.TabIndex = 1;
            // 
            // txtboxLogin
            // 
            this.txtboxLogin.Location = new System.Drawing.Point(281, 105);
            this.txtboxLogin.Name = "txtboxLogin";
            this.txtboxLogin.Size = new System.Drawing.Size(285, 22);
            this.txtboxLogin.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 258);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtboxPassword;
        private System.Windows.Forms.TextBox txtboxLogin;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnLogin;
    }
}