namespace Projet1.Prepose.GestionClientsInvites
{
    partial class frmAjoutClient
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
            this.b56Projet1Equipe7DataSet = new Projet1.B56Projet1Equipe7DataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.clientTableAdapter();
            this.tableAdapterManager = new Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.tbPays = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbCodePostal = new System.Windows.Forms.TextBox();
            this.dpInscription = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbNoClient = new System.Windows.Forms.TextBox();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            paysLabel = new System.Windows.Forms.Label();
            adresseLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            dateInscriptionLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomLabel.Location = new System.Drawing.Point(44, 106);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(49, 18);
            nomLabel.TabIndex = 3;
            nomLabel.Text = "Nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prenomLabel.Location = new System.Drawing.Point(44, 134);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(72, 18);
            prenomLabel.TabIndex = 5;
            prenomLabel.Text = "Prénom:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            villeLabel.Location = new System.Drawing.Point(44, 161);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(44, 18);
            villeLabel.TabIndex = 7;
            villeLabel.Text = "Ville:";
            // 
            // paysLabel
            // 
            paysLabel.AutoSize = true;
            paysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paysLabel.Location = new System.Drawing.Point(44, 190);
            paysLabel.Name = "paysLabel";
            paysLabel.Size = new System.Drawing.Size(50, 18);
            paysLabel.TabIndex = 9;
            paysLabel.Text = "Pays:";
            // 
            // adresseLabel
            // 
            adresseLabel.AutoSize = true;
            adresseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adresseLabel.Location = new System.Drawing.Point(44, 219);
            adresseLabel.Name = "adresseLabel";
            adresseLabel.Size = new System.Drawing.Size(74, 18);
            adresseLabel.TabIndex = 11;
            adresseLabel.Text = "Adresse:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codePostalLabel.Location = new System.Drawing.Point(44, 247);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(104, 18);
            codePostalLabel.TabIndex = 13;
            codePostalLabel.Text = "Code postal:";
            // 
            // dateInscriptionLabel
            // 
            dateInscriptionLabel.AutoSize = true;
            dateInscriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateInscriptionLabel.Location = new System.Drawing.Point(44, 276);
            dateInscriptionLabel.Name = "dateInscriptionLabel";
            dateInscriptionLabel.Size = new System.Drawing.Size(131, 18);
            dateInscriptionLabel.TabIndex = 15;
            dateInscriptionLabel.Text = "Date Inscription:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(44, 78);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 18);
            label2.TabIndex = 39;
            label2.Text = "Numéro client:";
            // 
            // b56Projet1Equipe7DataSet
            // 
            this.b56Projet1Equipe7DataSet.DataSetName = "B56Projet1Equipe7DataSet";
            this.b56Projet1Equipe7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.b56Projet1Equipe7DataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.planifSoinTableAdapter = null;
            this.tableAdapterManager.reservationChambreTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.typeChambreTableAdapter = null;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // tbNom
            // 
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "nom", true));
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(213, 102);
            this.tbNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNom.MaxLength = 50;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(227, 24);
            this.tbNom.TabIndex = 4;
            // 
            // tbPrenom
            // 
            this.tbPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "prenom", true));
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrenom.Location = new System.Drawing.Point(213, 130);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrenom.MaxLength = 50;
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(227, 24);
            this.tbPrenom.TabIndex = 6;
            // 
            // tbVille
            // 
            this.tbVille.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ville", true));
            this.tbVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVille.Location = new System.Drawing.Point(213, 159);
            this.tbVille.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVille.MaxLength = 50;
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(227, 24);
            this.tbVille.TabIndex = 8;
            // 
            // tbPays
            // 
            this.tbPays.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "pays", true));
            this.tbPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPays.Location = new System.Drawing.Point(213, 187);
            this.tbPays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPays.MaxLength = 50;
            this.tbPays.Name = "tbPays";
            this.tbPays.Size = new System.Drawing.Size(227, 24);
            this.tbPays.TabIndex = 10;
            // 
            // tbAdresse
            // 
            this.tbAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "adresse", true));
            this.tbAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdresse.Location = new System.Drawing.Point(213, 215);
            this.tbAdresse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdresse.MaxLength = 50;
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(227, 24);
            this.tbAdresse.TabIndex = 12;
            // 
            // tbCodePostal
            // 
            this.tbCodePostal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "codePostal", true));
            this.tbCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodePostal.Location = new System.Drawing.Point(213, 244);
            this.tbCodePostal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodePostal.MaxLength = 50;
            this.tbCodePostal.Name = "tbCodePostal";
            this.tbCodePostal.Size = new System.Drawing.Size(227, 24);
            this.tbCodePostal.TabIndex = 14;
            // 
            // dpInscription
            // 
            this.dpInscription.Checked = false;
            this.dpInscription.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientBindingSource, "dateInscription", true));
            this.dpInscription.Enabled = false;
            this.dpInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpInscription.Location = new System.Drawing.Point(213, 272);
            this.dpInscription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpInscription.Name = "dpInscription";
            this.dpInscription.Size = new System.Drawing.Size(227, 24);
            this.dpInscription.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(137, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nouveau client";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Black;
            this.btnAjouter.Location = new System.Drawing.Point(83, 319);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(135, 39);
            this.btnAjouter.TabIndex = 18;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnAnnuler.Location = new System.Drawing.Point(265, 319);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(135, 39);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // tbNoClient
            // 
            this.tbNoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoClient.Location = new System.Drawing.Point(213, 74);
            this.tbNoClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNoClient.Name = "tbNoClient";
            this.tbNoClient.ReadOnly = true;
            this.tbNoClient.Size = new System.Drawing.Size(227, 24);
            this.tbNoClient.TabIndex = 40;
            // 
            // frmAjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 383);
            this.Controls.Add(label2);
            this.Controls.Add(this.tbNoClient);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAjoutClient";
            this.Text = "Ajout d\'un nouveau client";
            this.Load += new System.EventHandler(this.frmAjoutClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private B56Projet1Equipe7DataSet b56Projet1Equipe7DataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.TextBox tbPays;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbCodePostal;
        private System.Windows.Forms.DateTimePicker dpInscription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.TextBox tbNoClient;
    }
}