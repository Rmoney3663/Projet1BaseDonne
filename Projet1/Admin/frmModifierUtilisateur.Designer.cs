namespace Projet1.Admin
{
    partial class frmModifierUtilisateur
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
            System.Windows.Forms.Label nomUtilisateurLabel;
            System.Windows.Forms.Label passwordLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.cbTypeUser = new System.Windows.Forms.ComboBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            nomUtilisateurLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "type d\'utilisateur";
            // 
            // cbTypeUser
            // 
            this.cbTypeUser.DisplayMember = "identification";
            this.cbTypeUser.FormattingEnabled = true;
            this.cbTypeUser.Location = new System.Drawing.Point(159, 137);
            this.cbTypeUser.Name = "cbTypeUser";
            this.cbTypeUser.Size = new System.Drawing.Size(134, 21);
            this.cbTypeUser.TabIndex = 22;
            this.cbTypeUser.ValueMember = "noTypeUtilisateur";
            // 
            // nomUtilisateurLabel
            // 
            nomUtilisateurLabel.AutoSize = true;
            nomUtilisateurLabel.Location = new System.Drawing.Point(55, 63);
            nomUtilisateurLabel.Name = "nomUtilisateurLabel";
            nomUtilisateurLabel.Size = new System.Drawing.Size(79, 13);
            nomUtilisateurLabel.TabIndex = 19;
            nomUtilisateurLabel.Text = "nom Utilisateur:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(159, 60);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(134, 20);
            this.txtUser.TabIndex = 20;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(55, 101);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 21;
            passwordLabel.Text = "password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(159, 98);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(134, 20);
            this.txtPassword.TabIndex = 23;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(58, 181);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(111, 23);
            this.btnFermer.TabIndex = 18;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(186, 181);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(107, 23);
            this.btnModifier.TabIndex = 17;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Modifier Utilisateur";
            // 
            // frmModifierUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 258);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTypeUser);
            this.Controls.Add(nomUtilisateurLabel);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnModifier);
            this.Name = "frmModifierUtilisateur";
            this.Text = "frmModifierUtilisateur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTypeUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label label3;
    }
}