
namespace AP3_GestionHackathon
{
    partial class connexionAdmin
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
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_connect = new System.Windows.Forms.Button();
            this.chbox_hide = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connexion";

            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(110, 153);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(198, 22);
            this.txt_login.TabIndex = 1;

            // 
            // txt_mdp
            // 
            this.txt_mdp.Location = new System.Drawing.Point(110, 223);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.PasswordChar = '*';
            this.txt_mdp.Size = new System.Drawing.Size(198, 22);
            this.txt_mdp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "login";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "password";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(158, 282);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            // 
            // chbox_hide
            // 
            this.chbox_hide.AutoSize = true;
            this.chbox_hide.Location = new System.Drawing.Point(327, 225);
            this.chbox_hide.Name = "chbox_hide";
            this.chbox_hide.Size = new System.Drawing.Size(85, 21);
            this.chbox_hide.TabIndex = 6;
            this.chbox_hide.Text = "masquer";
            this.chbox_hide.UseVisualStyleBackColor = true;

            // 
            // connexionAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 351);
            this.Controls.Add(this.chbox_hide);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.label1);
            this.Name = "connexionAdmin";
            this.Text = "connexionAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.CheckBox chbox_hide;
    }
}