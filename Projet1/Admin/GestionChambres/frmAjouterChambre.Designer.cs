namespace Projet1.Admin.GestionChambres
{
    partial class frmAjouterChambre
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
            System.Windows.Forms.Label emplacementLabel;
            System.Windows.Forms.Label decorationsLabel;
            this.b56Projet1Equipe7DataSet = new Projet1.B56Projet1Equipe7DataSet();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chambreTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.chambreTableAdapter();
            this.tableAdapterManager = new Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager();
            this.emplacementTextBox = new System.Windows.Forms.TextBox();
            this.decorationsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            emplacementLabel = new System.Windows.Forms.Label();
            decorationsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // emplacementLabel
            // 
            emplacementLabel.AutoSize = true;
            emplacementLabel.Location = new System.Drawing.Point(37, 57);
            emplacementLabel.Name = "emplacementLabel";
            emplacementLabel.Size = new System.Drawing.Size(73, 13);
            emplacementLabel.TabIndex = 3;
            emplacementLabel.Text = "emplacement:";
            // 
            // decorationsLabel
            // 
            decorationsLabel.AutoSize = true;
            decorationsLabel.Location = new System.Drawing.Point(37, 83);
            decorationsLabel.Name = "decorationsLabel";
            decorationsLabel.Size = new System.Drawing.Size(65, 13);
            decorationsLabel.TabIndex = 5;
            decorationsLabel.Text = "decorations:";
            // 
            // b56Projet1Equipe7DataSet
            // 
            this.b56Projet1Equipe7DataSet.DataSetName = "B56Projet1Equipe7DataSet";
            this.b56Projet1Equipe7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "chambre";
            this.chambreBindingSource.DataSource = this.b56Projet1Equipe7DataSet;
            // 
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = this.chambreTableAdapter;
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
            // emplacementTextBox
            // 
            this.emplacementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chambreBindingSource, "emplacement", true));
            this.emplacementTextBox.Location = new System.Drawing.Point(137, 54);
            this.emplacementTextBox.Name = "emplacementTextBox";
            this.emplacementTextBox.Size = new System.Drawing.Size(100, 20);
            this.emplacementTextBox.TabIndex = 4;
            // 
            // decorationsTextBox
            // 
            this.decorationsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chambreBindingSource, "decorations", true));
            this.decorationsTextBox.Location = new System.Drawing.Point(137, 80);
            this.decorationsTextBox.Name = "decorationsTextBox";
            this.decorationsTextBox.Size = new System.Drawing.Size(100, 20);
            this.decorationsTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ajouter un chambre ";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnAnnuler.Location = new System.Drawing.Point(140, 123);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(98, 32);
            this.btnAnnuler.TabIndex = 34;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Black;
            this.btnAjouter.Location = new System.Drawing.Point(31, 123);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(98, 32);
            this.btnAjouter.TabIndex = 33;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmAjouterChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 196);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(emplacementLabel);
            this.Controls.Add(this.emplacementTextBox);
            this.Controls.Add(decorationsLabel);
            this.Controls.Add(this.decorationsTextBox);
            this.Name = "frmAjouterChambre";
            this.Text = "frmAjouterChambre";
            this.Load += new System.EventHandler(this.frmAjouterChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private B56Projet1Equipe7DataSet b56Projet1Equipe7DataSet;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.chambreTableAdapter chambreTableAdapter;
        private B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox emplacementTextBox;
        private System.Windows.Forms.TextBox decorationsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}