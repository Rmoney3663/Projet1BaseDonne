namespace Projet1.Admin.GestionAssistants
{
    partial class frmAjouterAssistant
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
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label specialitesLabel;
            System.Windows.Forms.Label remarquesLabel;
            this.b56Projet1Equipe7DataSet = new Projet1.B56Projet1Equipe7DataSet();
            this.assistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.assistantTableAdapter();
            this.tableAdapterManager = new Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.specialitesTextBox = new System.Windows.Forms.TextBox();
            this.remarquesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            prenomLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            specialitesLabel = new System.Windows.Forms.Label();
            remarquesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // b56Projet1Equipe7DataSet
            // 
            this.b56Projet1Equipe7DataSet.DataSetName = "B56Projet1Equipe7DataSet";
            this.b56Projet1Equipe7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assistantBindingSource
            // 
            this.assistantBindingSource.DataMember = "assistant";
            this.assistantBindingSource.DataSource = this.b56Projet1Equipe7DataSet;
            // 
            // assistantTableAdapter
            // 
            this.assistantTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = this.assistantTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
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
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(51, 55);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(45, 13);
            prenomLabel.TabIndex = 3;
            prenomLabel.Text = "prenom:";
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assistantBindingSource, "prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(124, 52);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox.TabIndex = 4;
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(51, 81);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(30, 13);
            nomLabel.TabIndex = 5;
            nomLabel.Text = "nom:";
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assistantBindingSource, "nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(124, 78);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 6;
            // 
            // specialitesLabel
            // 
            specialitesLabel.AutoSize = true;
            specialitesLabel.Location = new System.Drawing.Point(51, 107);
            specialitesLabel.Name = "specialitesLabel";
            specialitesLabel.Size = new System.Drawing.Size(59, 13);
            specialitesLabel.TabIndex = 7;
            specialitesLabel.Text = "specialites:";
            // 
            // specialitesTextBox
            // 
            this.specialitesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assistantBindingSource, "specialites", true));
            this.specialitesTextBox.Location = new System.Drawing.Point(124, 104);
            this.specialitesTextBox.Name = "specialitesTextBox";
            this.specialitesTextBox.Size = new System.Drawing.Size(100, 20);
            this.specialitesTextBox.TabIndex = 8;
            // 
            // remarquesLabel
            // 
            remarquesLabel.AutoSize = true;
            remarquesLabel.Location = new System.Drawing.Point(51, 133);
            remarquesLabel.Name = "remarquesLabel";
            remarquesLabel.Size = new System.Drawing.Size(59, 13);
            remarquesLabel.TabIndex = 9;
            remarquesLabel.Text = "remarques:";
            // 
            // remarquesTextBox
            // 
            this.remarquesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assistantBindingSource, "remarques", true));
            this.remarquesTextBox.Location = new System.Drawing.Point(124, 130);
            this.remarquesTextBox.Name = "remarquesTextBox";
            this.remarquesTextBox.Size = new System.Drawing.Size(100, 20);
            this.remarquesTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ajouter Assistant";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnAnnuler.Location = new System.Drawing.Point(156, 172);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(98, 32);
            this.btnAnnuler.TabIndex = 32;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Black;
            this.btnAjouter.Location = new System.Drawing.Point(31, 172);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(98, 32);
            this.btnAjouter.TabIndex = 31;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmAjouterAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 233);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(specialitesLabel);
            this.Controls.Add(this.specialitesTextBox);
            this.Controls.Add(remarquesLabel);
            this.Controls.Add(this.remarquesTextBox);
            this.Name = "frmAjouterAssistant";
            this.Text = "frmAjouterAssistant";
            this.Load += new System.EventHandler(this.frmAjouterAssistant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private B56Projet1Equipe7DataSet b56Projet1Equipe7DataSet;
        private System.Windows.Forms.BindingSource assistantBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.assistantTableAdapter assistantTableAdapter;
        private B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox specialitesTextBox;
        private System.Windows.Forms.TextBox remarquesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}