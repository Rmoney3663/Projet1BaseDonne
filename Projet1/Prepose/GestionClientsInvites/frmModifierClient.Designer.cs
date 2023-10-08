namespace Projet1.Prepose.GestionClientsInvites
{
    partial class frmModifierClient
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label villeLabel;
            System.Windows.Forms.Label paysLabel;
            System.Windows.Forms.Label adresseLabel;
            System.Windows.Forms.Label codePostalLabel;
            System.Windows.Forms.Label dateInscriptionLabel;
            System.Windows.Forms.Label label2;
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbPays = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbCodePostal = new System.Windows.Forms.TextBox();
            this.dpInscription = new System.Windows.Forms.DateTimePicker();
            this.tbNoClient = new System.Windows.Forms.TextBox();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            paysLabel = new System.Windows.Forms.Label();
            adresseLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            dateInscriptionLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomLabel.Location = new System.Drawing.Point(29, 121);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(49, 18);
            nomLabel.TabIndex = 20;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenomLabel.Location = new System.Drawing.Point(29, 149);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(72, 18);
            prenomLabel.TabIndex = 22;
            prenomLabel.Text = "Prénom:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            villeLabel.Location = new System.Drawing.Point(29, 176);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(44, 18);
            villeLabel.TabIndex = 24;
            villeLabel.Text = "Ville:";
            // 
            // paysLabel
            // 
            paysLabel.AutoSize = true;
            paysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paysLabel.Location = new System.Drawing.Point(29, 204);
            paysLabel.Name = "paysLabel";
            paysLabel.Size = new System.Drawing.Size(50, 18);
            paysLabel.TabIndex = 26;
            paysLabel.Text = "Pays:";
            // 
            // adresseLabel
            // 
            adresseLabel.AutoSize = true;
            adresseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adresseLabel.Location = new System.Drawing.Point(29, 234);
            adresseLabel.Name = "adresseLabel";
            adresseLabel.Size = new System.Drawing.Size(74, 18);
            adresseLabel.TabIndex = 28;
            adresseLabel.Text = "Adresse:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codePostalLabel.Location = new System.Drawing.Point(29, 262);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(104, 18);
            codePostalLabel.TabIndex = 30;
            codePostalLabel.Text = "Code postal:";
            // 
            // dateInscriptionLabel
            // 
            dateInscriptionLabel.AutoSize = true;
            dateInscriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateInscriptionLabel.Location = new System.Drawing.Point(29, 290);
            dateInscriptionLabel.Name = "dateInscriptionLabel";
            dateInscriptionLabel.Size = new System.Drawing.Size(144, 18);
            dateInscriptionLabel.TabIndex = 32;
            dateInscriptionLabel.Text = "Date d\'inscription:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(29, 92);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 18);
            label2.TabIndex = 37;
            label2.Text = "Numéro client:";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnAnnuler.Location = new System.Drawing.Point(263, 334);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(135, 39);
            this.btnAnnuler.TabIndex = 36;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.PaleGreen;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.Black;
            this.btnModifier.Location = new System.Drawing.Point(80, 334);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(135, 39);
            this.btnModifier.TabIndex = 35;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(147, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Modifier client";
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(215, 117);
            this.tbNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNom.MaxLength = 50;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(227, 24);
            this.tbNom.TabIndex = 21;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.Location = new System.Drawing.Point(215, 145);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrenom.MaxLength = 50;
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(227, 24);
            this.tbPrenom.TabIndex = 23;
            // 
            // tbVille
            // 
            this.tbVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVille.Location = new System.Drawing.Point(215, 174);
            this.tbVille.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVille.MaxLength = 50;
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(227, 24);
            this.tbVille.TabIndex = 25;
            // 
            // tbPays
            // 
            this.tbPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPays.Location = new System.Drawing.Point(215, 202);
            this.tbPays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPays.MaxLength = 50;
            this.tbPays.Name = "tbPays";
            this.tbPays.Size = new System.Drawing.Size(227, 24);
            this.tbPays.TabIndex = 27;
            // 
            // tbAdresse
            // 
            this.tbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresse.Location = new System.Drawing.Point(215, 230);
            this.tbAdresse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdresse.MaxLength = 50;
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(227, 24);
            this.tbAdresse.TabIndex = 29;
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodePostal.Location = new System.Drawing.Point(215, 258);
            this.tbCodePostal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodePostal.MaxLength = 50;
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.Size = new System.Drawing.Size(227, 24);
            this.tbCodePostal.TabIndex = 31;
            // 
            // dpInscription
            // 
            this.dpInscription.Checked = false;
            this.dpInscription.Enabled = false;
            this.dpInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpInscription.Location = new System.Drawing.Point(215, 287);
            this.dpInscription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpInscription.Name = "dpInscription";
            this.dpInscription.Size = new System.Drawing.Size(227, 24);
            this.dpInscription.TabIndex = 33;
            // 
            // tbNoClient
            // 
            this.tbNoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoClient.Location = new System.Drawing.Point(215, 89);
            this.tbNoClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNoClient.Name = "tbNoClient";
            this.tbNoClient.ReadOnly = true;
            this.tbNoClient.Size = new System.Drawing.Size(227, 24);
            this.tbNoClient.TabIndex = 38;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmModifierClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 393);
            this.Controls.Add(label2);
            this.Controls.Add(this.tbNoClient);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.label1);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.tbVille);
            this.Controls.Add(paysLabel);
            this.Controls.Add(this.tbPays);
            this.Controls.Add(adresseLabel);
            this.Controls.Add(this.tbAdresse);
            this.Controls.Add(codePostalLabel);
            this.Controls.Add(this.tbCodePostal);
            this.Controls.Add(dateInscriptionLabel);
            this.Controls.Add(this.dpInscription);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModifierClient";
            this.Text = "Modification d\'un client";
            this.Load += new System.EventHandler(this.frmModifierClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbPays;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbCodePostal;
        private System.Windows.Forms.DateTimePicker dpInscription;
        private System.Windows.Forms.TextBox tbNoClient;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}