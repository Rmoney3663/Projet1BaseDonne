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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomUtilisateurLabel;
            System.Windows.Forms.Label passwordLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.b56Projet1Equipe7DataSet = new Projet1.B56Projet1Equipe7DataSet();
            this.typeUtilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeUtilisateurTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.typeUtilisateurTableAdapter();
            this.tableAdapterManager = new Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager();
            this.utilisateurTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.utilisateurTableAdapter();
            this.cbTypeUser = new System.Windows.Forms.ComboBox();
            this.utilisateurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            nomUtilisateurLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
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
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(55, 101);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 21;
            passwordLabel.Text = "password:";
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
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(58, 181);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(111, 23);
            this.btnFermer.TabIndex = 18;
            this.btnFermer.Text = "Annuler";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(186, 181);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(107, 23);
            this.btnModifier.TabIndex = 17;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
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
            // b56Projet1Equipe7DataSet
            // 
            this.b56Projet1Equipe7DataSet.DataSetName = "B56Projet1Equipe7DataSet";
            this.b56Projet1Equipe7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // utilisateurTableAdapter
            // 
            this.utilisateurTableAdapter.ClearBeforeFill = true;
            // 
            // cbTypeUser
            // 
            this.cbTypeUser.DataSource = this.typeUtilisateurBindingSource;
            this.cbTypeUser.DisplayMember = "identification";
            this.cbTypeUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeUser.FormattingEnabled = true;
            this.cbTypeUser.Location = new System.Drawing.Point(143, 137);
            this.cbTypeUser.Name = "cbTypeUser";
            this.cbTypeUser.Size = new System.Drawing.Size(150, 21);
            this.cbTypeUser.TabIndex = 27;
            this.cbTypeUser.ValueMember = "noTypeUtilisateur";
            // 
            // utilisateurBindingSource
            // 
            this.utilisateurBindingSource.DataMember = "utilisateur";
            this.utilisateurBindingSource.DataSource = this.b56Projet1Equipe7DataSet;
            // 
            // txtPassword
            // 
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "password", true));
            this.txtPassword.Location = new System.Drawing.Point(143, 98);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(150, 20);
            this.txtPassword.TabIndex = 28;
            // 
            // txtUser
            // 
            this.txtUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.utilisateurBindingSource, "nomUtilisateur", true));
            this.txtUser.Location = new System.Drawing.Point(143, 60);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(150, 20);
            this.txtUser.TabIndex = 29;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmModifierUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 258);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbTypeUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(nomUtilisateurLabel);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnModifier);
            this.Name = "frmModifierUtilisateur";
            this.Text = "frmModifierUtilisateur";
            this.Load += new System.EventHandler(this.frmModifierUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeUtilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilisateurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label label3;
        private B56Projet1Equipe7DataSet b56Projet1Equipe7DataSet;
        private System.Windows.Forms.BindingSource typeUtilisateurBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.typeUtilisateurTableAdapter typeUtilisateurTableAdapter;
        private B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private B56Projet1Equipe7DataSetTableAdapters.utilisateurTableAdapter utilisateurTableAdapter;
        private System.Windows.Forms.ComboBox cbTypeUser;
        private System.Windows.Forms.BindingSource utilisateurBindingSource;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}