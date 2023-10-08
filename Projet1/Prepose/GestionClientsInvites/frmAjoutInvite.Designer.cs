namespace Projet1.Prepose.GestionClientsInvites
{
    partial class frmAjoutInvite
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
            System.Windows.Forms.Label nomPrenomLabel;
            System.Windows.Forms.Label noClientLabel;
            System.Windows.Forms.Label label2;
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.b56Projet1Equipe7DataSet = new Projet1.B56Projet1Equipe7DataSet();
            this.inviteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inviteTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.inviteTableAdapter();
            this.tableAdapterManager = new Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbNoClient = new System.Windows.Forms.TextBox();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbNoInvite = new System.Windows.Forms.TextBox();
            nomPrenomLabel = new System.Windows.Forms.Label();
            noClientLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // nomPrenomLabel
            // 
            nomPrenomLabel.AutoSize = true;
            nomPrenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            nomPrenomLabel.Location = new System.Drawing.Point(16, 117);
            nomPrenomLabel.Name = "nomPrenomLabel";
            nomPrenomLabel.Size = new System.Drawing.Size(130, 18);
            nomPrenomLabel.TabIndex = 24;
            nomPrenomLabel.Text = "Nom et prénom:";
            // 
            // noClientLabel
            // 
            noClientLabel.AutoSize = true;
            noClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            noClientLabel.Location = new System.Drawing.Point(16, 145);
            noClientLabel.Name = "noClientLabel";
            noClientLabel.Size = new System.Drawing.Size(118, 18);
            noClientLabel.TabIndex = 26;
            noClientLabel.Text = "Numéro client:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(16, 89);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(117, 18);
            label2.TabIndex = 28;
            label2.Text = "Numéro invité:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(99, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nouvel invité";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnAnnuler.Location = new System.Drawing.Point(208, 188);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(135, 39);
            this.btnAnnuler.TabIndex = 21;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Black;
            this.btnAjouter.Location = new System.Drawing.Point(37, 188);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(135, 39);
            this.btnAjouter.TabIndex = 20;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // b56Projet1Equipe7DataSet
            // 
            this.b56Projet1Equipe7DataSet.DataSetName = "B56Projet1Equipe7DataSet";
            this.b56Projet1Equipe7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inviteBindingSource
            // 
            this.inviteBindingSource.DataMember = "invite";
            this.inviteBindingSource.DataSource = this.b56Projet1Equipe7DataSet;
            // 
            // inviteTableAdapter
            // 
            this.inviteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = this.inviteTableAdapter;
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
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inviteBindingSource, "nomPrenom", true));
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(168, 112);
            this.tbNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNom.MaxLength = 50;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(193, 24);
            this.tbNom.TabIndex = 25;
            // 
            // tbNoClient
            // 
            this.tbNoClient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inviteBindingSource, "noClient", true));
            this.tbNoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoClient.Location = new System.Drawing.Point(168, 140);
            this.tbNoClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNoClient.Name = "tbNoClient";
            this.tbNoClient.ReadOnly = true;
            this.tbNoClient.Size = new System.Drawing.Size(193, 24);
            this.tbNoClient.TabIndex = 27;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // tbNoInvite
            // 
            this.tbNoInvite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inviteBindingSource, "noClient", true));
            this.tbNoInvite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoInvite.Location = new System.Drawing.Point(168, 84);
            this.tbNoInvite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNoInvite.Name = "tbNoInvite";
            this.tbNoInvite.ReadOnly = true;
            this.tbNoInvite.Size = new System.Drawing.Size(193, 24);
            this.tbNoInvite.TabIndex = 29;
            // 
            // frmAjoutInvite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 252);
            this.Controls.Add(label2);
            this.Controls.Add(this.tbNoInvite);
            this.Controls.Add(nomPrenomLabel);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(noClientLabel);
            this.Controls.Add(this.tbNoClient);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAjoutInvite";
            this.Text = "Ajout de l\'invité";
            this.Load += new System.EventHandler(this.frmAjoutInvite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private B56Projet1Equipe7DataSet b56Projet1Equipe7DataSet;
        private System.Windows.Forms.BindingSource inviteBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.inviteTableAdapter inviteTableAdapter;
        private B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbNoClient;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.TextBox tbNoInvite;
    }
}