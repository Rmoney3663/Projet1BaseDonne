namespace Projet1.Admin
{
    partial class frmAjouterUtilisateur
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
            System.Windows.Forms.Label nomUtilisateurLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label noTypeUtilisateurLabel;
            this.b56Projet1Equipe7DataSet = new Projet1.B56Projet1Equipe7DataSet();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilisateurTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.utilisateurTableAdapter();
            this.tableAdapterManager = new Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.nomUtilisateurTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.typeUtilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeUtilisateurTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.typeUtilisateurTableAdapter();
            this.typeUtilisateurComboBox = new System.Windows.Forms.ComboBox();
            nomUtilisateurLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            noTypeUtilisateurLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // b56Projet1Equipe7DataSet
            // 
            this.b56Projet1Equipe7DataSet.DataSetName = "B56Projet1Equipe7DataSet";
            this.b56Projet1Equipe7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.b56Projet1Equipe7DataSet;
            // 
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.planifSoinTableAdapter = null;
            this.tableAdapterManager.reservationChambreTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.typeChambreTableAdapter = null;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = this.typeUtilisateurTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = this.utilisateurTableAdapter;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(261, 73);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(261, 111);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 23);
            this.btnFermer.TabIndex = 10;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // nomUtilisateurLabel
            // 
            nomUtilisateurLabel.AutoSize = true;
            nomUtilisateurLabel.Location = new System.Drawing.Point(50, 78);
            nomUtilisateurLabel.Name = "nomUtilisateurLabel";
            nomUtilisateurLabel.Size = new System.Drawing.Size(79, 13);
            nomUtilisateurLabel.TabIndex = 12;
            nomUtilisateurLabel.Text = "nom Utilisateur:";
            // 
            // nomUtilisateurTextBox
            // 
            this.nomUtilisateurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "nomUtilisateur", true));
            this.nomUtilisateurTextBox.Location = new System.Drawing.Point(154, 75);
            this.nomUtilisateurTextBox.Name = "nomUtilisateurTextBox";
            this.nomUtilisateurTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomUtilisateurTextBox.TabIndex = 13;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(50, 116);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 14;
            passwordLabel.Text = "password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(154, 113);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 15;
            // 
            // noTypeUtilisateurLabel
            // 
            noTypeUtilisateurLabel.AutoSize = true;
            noTypeUtilisateurLabel.Location = new System.Drawing.Point(50, 151);
            noTypeUtilisateurLabel.Name = "noTypeUtilisateurLabel";
            noTypeUtilisateurLabel.Size = new System.Drawing.Size(98, 13);
            noTypeUtilisateurLabel.TabIndex = 16;
            noTypeUtilisateurLabel.Text = "no Type Utilisateur:";
            // 
            // typeUtilisateurBindingSource
            // 
            this.typeUtilisateurBindingSource.DataMember = "typeUtilisateur";
            this.typeUtilisateurBindingSource.DataSource = this.b56Projet1Equipe7DataSet;
            // 
            // typeUtilisateurTableAdapter
            // 
            this.typeUtilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // typeUtilisateurComboBox
            // 
            this.typeUtilisateurComboBox.DataSource = this.typeUtilisateurBindingSource;
            this.typeUtilisateurComboBox.DisplayMember = "identification";
            this.typeUtilisateurComboBox.FormattingEnabled = true;
            this.typeUtilisateurComboBox.Location = new System.Drawing.Point(154, 148);
            this.typeUtilisateurComboBox.Name = "typeUtilisateurComboBox";
            this.typeUtilisateurComboBox.Size = new System.Drawing.Size(182, 21);
            this.typeUtilisateurComboBox.TabIndex = 17;
            this.typeUtilisateurComboBox.ValueMember = "noTypeUtilisateur";
            // 
            // frmAjouterUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 283);
            this.Controls.Add(this.typeUtilisateurComboBox);
            this.Controls.Add(nomUtilisateurLabel);
            this.Controls.Add(this.nomUtilisateurTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(noTypeUtilisateurLabel);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnAjouter);
            this.Name = "frmAjouterUtilisateur";
            this.Text = "frmAjouter";
            this.Load += new System.EventHandler(this.frmAjouterUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private B56Projet1Equipe7DataSet b56Projet1Equipe7DataSet;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private B56Projet1Equipe7DataSetTableAdapters.typeUtilisateurTableAdapter typeUtilisateurTableAdapter;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.TextBox nomUtilisateurTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.BindingSource typeUtilisateurBindingSource;
        private System.Windows.Forms.ComboBox typeUtilisateurComboBox;
    }
}