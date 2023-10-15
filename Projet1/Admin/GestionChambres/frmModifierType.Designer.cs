namespace Projet1.Admin.GestionChambres
{
    partial class frmModifierType
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
            System.Windows.Forms.Label noTypeChambreLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label prixHautLabel;
            System.Windows.Forms.Label prixBasLabel;
            System.Windows.Forms.Label prixMoyenLabel;
            this.b56Projet1Equipe7DataSet = new Projet1.B56Projet1Equipe7DataSet();
            this.typeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeChambreTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.typeChambreTableAdapter();
            this.tableAdapterManager = new Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager();
            this.noTypeChambreTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.prixHautTextBox = new System.Windows.Forms.TextBox();
            this.prixBasTextBox = new System.Windows.Forms.TextBox();
            this.prixMoyenTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            noTypeChambreLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            prixHautLabel = new System.Windows.Forms.Label();
            prixBasLabel = new System.Windows.Forms.Label();
            prixMoyenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // b56Projet1Equipe7DataSet
            // 
            this.b56Projet1Equipe7DataSet.DataSetName = "B56Projet1Equipe7DataSet";
            this.b56Projet1Equipe7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeChambreBindingSource
            // 
            this.typeChambreBindingSource.DataMember = "typeChambre";
            this.typeChambreBindingSource.DataSource = this.b56Projet1Equipe7DataSet;
            // 
            // typeChambreTableAdapter
            // 
            this.typeChambreTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.typeChambreTableAdapter = this.typeChambreTableAdapter;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // noTypeChambreLabel
            // 
            noTypeChambreLabel.AutoSize = true;
            noTypeChambreLabel.Location = new System.Drawing.Point(43, 54);
            noTypeChambreLabel.Name = "noTypeChambreLabel";
            noTypeChambreLabel.Size = new System.Drawing.Size(94, 13);
            noTypeChambreLabel.TabIndex = 1;
            noTypeChambreLabel.Text = "no Type Chambre:";
            // 
            // noTypeChambreTextBox
            // 
            this.noTypeChambreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "noTypeChambre", true));
            this.noTypeChambreTextBox.Enabled = false;
            this.noTypeChambreTextBox.Location = new System.Drawing.Point(143, 51);
            this.noTypeChambreTextBox.Name = "noTypeChambreTextBox";
            this.noTypeChambreTextBox.Size = new System.Drawing.Size(100, 20);
            this.noTypeChambreTextBox.TabIndex = 2;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(43, 80);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 13);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(143, 77);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // prixHautLabel
            // 
            prixHautLabel.AutoSize = true;
            prixHautLabel.Location = new System.Drawing.Point(43, 106);
            prixHautLabel.Name = "prixHautLabel";
            prixHautLabel.Size = new System.Drawing.Size(52, 13);
            prixHautLabel.TabIndex = 5;
            prixHautLabel.Text = "prix Haut:";
            // 
            // prixHautTextBox
            // 
            this.prixHautTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "prixHaut", true));
            this.prixHautTextBox.Location = new System.Drawing.Point(143, 103);
            this.prixHautTextBox.Name = "prixHautTextBox";
            this.prixHautTextBox.Size = new System.Drawing.Size(100, 20);
            this.prixHautTextBox.TabIndex = 6;
            // 
            // prixBasLabel
            // 
            prixBasLabel.AutoSize = true;
            prixBasLabel.Location = new System.Drawing.Point(43, 132);
            prixBasLabel.Name = "prixBasLabel";
            prixBasLabel.Size = new System.Drawing.Size(47, 13);
            prixBasLabel.TabIndex = 7;
            prixBasLabel.Text = "prix Bas:";
            // 
            // prixBasTextBox
            // 
            this.prixBasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "prixBas", true));
            this.prixBasTextBox.Location = new System.Drawing.Point(143, 129);
            this.prixBasTextBox.Name = "prixBasTextBox";
            this.prixBasTextBox.Size = new System.Drawing.Size(100, 20);
            this.prixBasTextBox.TabIndex = 8;
            // 
            // prixMoyenLabel
            // 
            prixMoyenLabel.AutoSize = true;
            prixMoyenLabel.Location = new System.Drawing.Point(43, 158);
            prixMoyenLabel.Name = "prixMoyenLabel";
            prixMoyenLabel.Size = new System.Drawing.Size(61, 13);
            prixMoyenLabel.TabIndex = 9;
            prixMoyenLabel.Text = "prix Moyen:";
            // 
            // prixMoyenTextBox
            // 
            this.prixMoyenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "prixMoyen", true));
            this.prixMoyenTextBox.Location = new System.Drawing.Point(143, 155);
            this.prixMoyenTextBox.Name = "prixMoyenTextBox";
            this.prixMoyenTextBox.Size = new System.Drawing.Size(100, 20);
            this.prixMoyenTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Modifier Type Chambre";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnAnnuler.Location = new System.Drawing.Point(152, 190);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(98, 32);
            this.btnAnnuler.TabIndex = 45;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.PaleGreen;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.Black;
            this.btnModifier.Location = new System.Drawing.Point(27, 190);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(98, 32);
            this.btnModifier.TabIndex = 44;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmModifierType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 258);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.label1);
            this.Controls.Add(noTypeChambreLabel);
            this.Controls.Add(this.noTypeChambreTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(prixHautLabel);
            this.Controls.Add(this.prixHautTextBox);
            this.Controls.Add(prixBasLabel);
            this.Controls.Add(this.prixBasTextBox);
            this.Controls.Add(prixMoyenLabel);
            this.Controls.Add(this.prixMoyenTextBox);
            this.Name = "frmModifierType";
            this.Text = "frmModifierType";
            this.Load += new System.EventHandler(this.frmModifierType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private B56Projet1Equipe7DataSet b56Projet1Equipe7DataSet;
        private System.Windows.Forms.BindingSource typeChambreBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.typeChambreTableAdapter typeChambreTableAdapter;
        private B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox noTypeChambreTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox prixHautTextBox;
        private System.Windows.Forms.TextBox prixBasTextBox;
        private System.Windows.Forms.TextBox prixMoyenTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}