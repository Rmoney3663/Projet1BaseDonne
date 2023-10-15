namespace Projet1.Admin.GestionChambres
{
    partial class frmSupprimerChambre
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
            System.Windows.Forms.Label noChambreLabel;
            System.Windows.Forms.Label emplacementLabel;
            System.Windows.Forms.Label decorationsLabel;
            System.Windows.Forms.Label noTypeChambreLabel;
            this.b56Projet1Equipe7DataSet = new Projet1.B56Projet1Equipe7DataSet();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chambreTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.chambreTableAdapter();
            this.tableAdapterManager = new Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager();
            this.noChambreTextBox = new System.Windows.Forms.TextBox();
            this.emplacementTextBox = new System.Windows.Forms.TextBox();
            this.decorationsTextBox = new System.Windows.Forms.TextBox();
            this.noTypeChambreTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            noChambreLabel = new System.Windows.Forms.Label();
            emplacementLabel = new System.Windows.Forms.Label();
            decorationsLabel = new System.Windows.Forms.Label();
            noTypeChambreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noChambreLabel
            // 
            noChambreLabel.AutoSize = true;
            noChambreLabel.Location = new System.Drawing.Point(32, 54);
            noChambreLabel.Name = "noChambreLabel";
            noChambreLabel.Size = new System.Drawing.Size(67, 13);
            noChambreLabel.TabIndex = 1;
            noChambreLabel.Text = "no Chambre:";
            // 
            // emplacementLabel
            // 
            emplacementLabel.AutoSize = true;
            emplacementLabel.Location = new System.Drawing.Point(32, 80);
            emplacementLabel.Name = "emplacementLabel";
            emplacementLabel.Size = new System.Drawing.Size(73, 13);
            emplacementLabel.TabIndex = 3;
            emplacementLabel.Text = "emplacement:";
            // 
            // decorationsLabel
            // 
            decorationsLabel.AutoSize = true;
            decorationsLabel.Location = new System.Drawing.Point(32, 106);
            decorationsLabel.Name = "decorationsLabel";
            decorationsLabel.Size = new System.Drawing.Size(65, 13);
            decorationsLabel.TabIndex = 5;
            decorationsLabel.Text = "decorations:";
            // 
            // noTypeChambreLabel
            // 
            noTypeChambreLabel.AutoSize = true;
            noTypeChambreLabel.Location = new System.Drawing.Point(32, 132);
            noTypeChambreLabel.Name = "noTypeChambreLabel";
            noTypeChambreLabel.Size = new System.Drawing.Size(94, 13);
            noTypeChambreLabel.TabIndex = 7;
            noTypeChambreLabel.Text = "no Type Chambre:";
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
            // noChambreTextBox
            // 
            this.noChambreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chambreBindingSource, "noChambre", true));
            this.noChambreTextBox.Enabled = false;
            this.noChambreTextBox.Location = new System.Drawing.Point(132, 51);
            this.noChambreTextBox.Name = "noChambreTextBox";
            this.noChambreTextBox.Size = new System.Drawing.Size(100, 20);
            this.noChambreTextBox.TabIndex = 2;
            // 
            // emplacementTextBox
            // 
            this.emplacementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chambreBindingSource, "emplacement", true));
            this.emplacementTextBox.Enabled = false;
            this.emplacementTextBox.Location = new System.Drawing.Point(132, 77);
            this.emplacementTextBox.Name = "emplacementTextBox";
            this.emplacementTextBox.Size = new System.Drawing.Size(100, 20);
            this.emplacementTextBox.TabIndex = 4;
            // 
            // decorationsTextBox
            // 
            this.decorationsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chambreBindingSource, "decorations", true));
            this.decorationsTextBox.Enabled = false;
            this.decorationsTextBox.Location = new System.Drawing.Point(132, 103);
            this.decorationsTextBox.Name = "decorationsTextBox";
            this.decorationsTextBox.Size = new System.Drawing.Size(100, 20);
            this.decorationsTextBox.TabIndex = 6;
            // 
            // noTypeChambreTextBox
            // 
            this.noTypeChambreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.chambreBindingSource, "noTypeChambre", true));
            this.noTypeChambreTextBox.Enabled = false;
            this.noTypeChambreTextBox.Location = new System.Drawing.Point(132, 129);
            this.noTypeChambreTextBox.Name = "noTypeChambreTextBox";
            this.noTypeChambreTextBox.Size = new System.Drawing.Size(100, 20);
            this.noTypeChambreTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Supprimer Chambre";
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(12, 171);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(111, 23);
            this.btnFermer.TabIndex = 35;
            this.btnFermer.Text = "Annuler";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(140, 171);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(107, 23);
            this.btnSupprimer.TabIndex = 34;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // frmSupprimerChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 224);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(noChambreLabel);
            this.Controls.Add(this.noChambreTextBox);
            this.Controls.Add(emplacementLabel);
            this.Controls.Add(this.emplacementTextBox);
            this.Controls.Add(decorationsLabel);
            this.Controls.Add(this.decorationsTextBox);
            this.Controls.Add(noTypeChambreLabel);
            this.Controls.Add(this.noTypeChambreTextBox);
            this.Name = "frmSupprimerChambre";
            this.Text = "frmSupprimerChambre";
            this.Load += new System.EventHandler(this.frmSupprimerChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private B56Projet1Equipe7DataSet b56Projet1Equipe7DataSet;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.chambreTableAdapter chambreTableAdapter;
        private B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox noChambreTextBox;
        private System.Windows.Forms.TextBox emplacementTextBox;
        private System.Windows.Forms.TextBox decorationsTextBox;
        private System.Windows.Forms.TextBox noTypeChambreTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnSupprimer;
    }
}