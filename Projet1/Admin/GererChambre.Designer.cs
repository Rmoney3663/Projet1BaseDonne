namespace Projet1.Admin
{
    partial class GererChambre
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
            this.chambreTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.chambreTableAdapter();
            this.noTypeChambreTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.prixHautTextBox = new System.Windows.Forms.TextBox();
            this.prixBasTextBox = new System.Windows.Forms.TextBox();
            this.prixMoyenTextBox = new System.Windows.Forms.TextBox();
            this.chambreDataGridView = new System.Windows.Forms.DataGridView();
            this.noChambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decorations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTypeChambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFermer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotale = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouterChambre = new System.Windows.Forms.Button();
            this.btnModificationChambre = new System.Windows.Forms.Button();
            this.btnSupprimerChambre = new System.Windows.Forms.Button();
            this.btnSupprimerType = new System.Windows.Forms.Button();
            this.btnModifierType = new System.Windows.Forms.Button();
            this.btnAjouterType = new System.Windows.Forms.Button();
            noTypeChambreLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            prixHautLabel = new System.Windows.Forms.Label();
            prixBasLabel = new System.Windows.Forms.Label();
            prixMoyenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noTypeChambreLabel
            // 
            noTypeChambreLabel.AutoSize = true;
            noTypeChambreLabel.Location = new System.Drawing.Point(13, 106);
            noTypeChambreLabel.Name = "noTypeChambreLabel";
            noTypeChambreLabel.Size = new System.Drawing.Size(94, 13);
            noTypeChambreLabel.TabIndex = 1;
            noTypeChambreLabel.Text = "no Type Chambre:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(13, 148);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 13);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "description:";
            // 
            // prixHautLabel
            // 
            prixHautLabel.AutoSize = true;
            prixHautLabel.Location = new System.Drawing.Point(13, 187);
            prixHautLabel.Name = "prixHautLabel";
            prixHautLabel.Size = new System.Drawing.Size(52, 13);
            prixHautLabel.TabIndex = 5;
            prixHautLabel.Text = "prix Haut:";
            // 
            // prixBasLabel
            // 
            prixBasLabel.AutoSize = true;
            prixBasLabel.Location = new System.Drawing.Point(13, 229);
            prixBasLabel.Name = "prixBasLabel";
            prixBasLabel.Size = new System.Drawing.Size(47, 13);
            prixBasLabel.TabIndex = 7;
            prixBasLabel.Text = "prix Bas:";
            // 
            // prixMoyenLabel
            // 
            prixMoyenLabel.AutoSize = true;
            prixMoyenLabel.Location = new System.Drawing.Point(13, 267);
            prixMoyenLabel.Name = "prixMoyenLabel";
            prixMoyenLabel.Size = new System.Drawing.Size(61, 13);
            prixMoyenLabel.TabIndex = 9;
            prixMoyenLabel.Text = "prix Moyen:";
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
            this.tableAdapterManager.chambreTableAdapter = this.chambreTableAdapter;
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
            // chambreTableAdapter
            // 
            this.chambreTableAdapter.ClearBeforeFill = true;
            // 
            // noTypeChambreTextBox
            // 
            this.noTypeChambreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "noTypeChambre", true));
            this.noTypeChambreTextBox.Enabled = false;
            this.noTypeChambreTextBox.Location = new System.Drawing.Point(113, 103);
            this.noTypeChambreTextBox.Name = "noTypeChambreTextBox";
            this.noTypeChambreTextBox.ReadOnly = true;
            this.noTypeChambreTextBox.Size = new System.Drawing.Size(100, 20);
            this.noTypeChambreTextBox.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "description", true));
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(113, 145);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // prixHautTextBox
            // 
            this.prixHautTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "prixHaut", true));
            this.prixHautTextBox.Enabled = false;
            this.prixHautTextBox.Location = new System.Drawing.Point(113, 184);
            this.prixHautTextBox.Name = "prixHautTextBox";
            this.prixHautTextBox.ReadOnly = true;
            this.prixHautTextBox.Size = new System.Drawing.Size(100, 20);
            this.prixHautTextBox.TabIndex = 6;
            // 
            // prixBasTextBox
            // 
            this.prixBasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "prixBas", true));
            this.prixBasTextBox.Enabled = false;
            this.prixBasTextBox.Location = new System.Drawing.Point(113, 226);
            this.prixBasTextBox.Name = "prixBasTextBox";
            this.prixBasTextBox.ReadOnly = true;
            this.prixBasTextBox.Size = new System.Drawing.Size(100, 20);
            this.prixBasTextBox.TabIndex = 8;
            // 
            // prixMoyenTextBox
            // 
            this.prixMoyenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.typeChambreBindingSource, "prixMoyen", true));
            this.prixMoyenTextBox.Enabled = false;
            this.prixMoyenTextBox.Location = new System.Drawing.Point(113, 264);
            this.prixMoyenTextBox.Name = "prixMoyenTextBox";
            this.prixMoyenTextBox.ReadOnly = true;
            this.prixMoyenTextBox.Size = new System.Drawing.Size(100, 20);
            this.prixMoyenTextBox.TabIndex = 10;
            // 
            // chambreDataGridView
            // 
            this.chambreDataGridView.AllowUserToResizeColumns = false;
            this.chambreDataGridView.AllowUserToResizeRows = false;
            this.chambreDataGridView.AutoGenerateColumns = false;
            this.chambreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.chambreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chambreDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noChambre,
            this.emplacement,
            this.decorations,
            this.noTypeChambre});
            this.chambreDataGridView.DataSource = this.chambreBindingSource;
            this.chambreDataGridView.Location = new System.Drawing.Point(280, 103);
            this.chambreDataGridView.Name = "chambreDataGridView";
            this.chambreDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.chambreDataGridView.Size = new System.Drawing.Size(343, 177);
            this.chambreDataGridView.TabIndex = 11;
            // 
            // noChambre
            // 
            this.noChambre.DataPropertyName = "noChambre";
            this.noChambre.HeaderText = "noChambre";
            this.noChambre.Name = "noChambre";
            this.noChambre.ReadOnly = true;
            // 
            // emplacement
            // 
            this.emplacement.DataPropertyName = "emplacement";
            this.emplacement.HeaderText = "emplacement";
            this.emplacement.Name = "emplacement";
            this.emplacement.ReadOnly = true;
            // 
            // decorations
            // 
            this.decorations.DataPropertyName = "decorations";
            this.decorations.HeaderText = "decorations";
            this.decorations.Name = "decorations";
            this.decorations.ReadOnly = true;
            // 
            // noTypeChambre
            // 
            this.noTypeChambre.DataPropertyName = "noTypeChambre";
            this.noTypeChambre.HeaderText = "noTypeChambre";
            this.noTypeChambre.Name = "noTypeChambre";
            this.noTypeChambre.ReadOnly = true;
            this.noTypeChambre.Visible = false;
            // 
            // chambreBindingSource
            // 
            this.chambreBindingSource.DataMember = "fk_noTypeChambre";
            this.chambreBindingSource.DataSource = this.typeChambreBindingSource;
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.Black;
            this.btnFermer.Location = new System.Drawing.Point(645, 7);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(93, 33);
            this.btnFermer.TabIndex = 38;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 26);
            this.label3.TabIndex = 37;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotale
            // 
            this.lbTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotale.Location = new System.Drawing.Point(333, 13);
            this.lbTotale.Name = "lbTotale";
            this.lbTotale.Size = new System.Drawing.Size(28, 26);
            this.lbTotale.TabIndex = 36;
            this.lbTotale.Text = "0";
            this.lbTotale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPosition
            // 
            this.lbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.Location = new System.Drawing.Point(276, 13);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(27, 26);
            this.lbPosition.TabIndex = 35;
            this.lbPosition.Text = "0";
            this.lbPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(512, 12);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(128, 27);
            this.btnLast.TabIndex = 34;
            this.btnLast.Text = "Dernière Type";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(378, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(128, 27);
            this.btnNext.TabIndex = 33;
            this.btnNext.Text = "Prochaine Type";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(141, 12);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(128, 27);
            this.btnPrevious.TabIndex = 32;
            this.btnPrevious.Text = "Assistant Type";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(16, 12);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(119, 27);
            this.btnFirst.TabIndex = 31;
            this.btnFirst.Text = "Première Type";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Info de type de chambre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(276, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Liste de Chambre de ce type";
            // 
            // btnAjouterChambre
            // 
            this.btnAjouterChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterChambre.Location = new System.Drawing.Point(336, 298);
            this.btnAjouterChambre.Name = "btnAjouterChambre";
            this.btnAjouterChambre.Size = new System.Drawing.Size(200, 28);
            this.btnAjouterChambre.TabIndex = 41;
            this.btnAjouterChambre.Text = "Ajout Chambre";
            this.btnAjouterChambre.UseVisualStyleBackColor = true;
            this.btnAjouterChambre.Click += new System.EventHandler(this.btnAjouterChambre_Click);
            // 
            // btnModificationChambre
            // 
            this.btnModificationChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificationChambre.Location = new System.Drawing.Point(336, 332);
            this.btnModificationChambre.Name = "btnModificationChambre";
            this.btnModificationChambre.Size = new System.Drawing.Size(199, 28);
            this.btnModificationChambre.TabIndex = 42;
            this.btnModificationChambre.Text = "Modifier Chambre";
            this.btnModificationChambre.UseVisualStyleBackColor = true;
            this.btnModificationChambre.Click += new System.EventHandler(this.btnModificationChambre_Click);
            // 
            // btnSupprimerChambre
            // 
            this.btnSupprimerChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerChambre.Location = new System.Drawing.Point(335, 366);
            this.btnSupprimerChambre.Name = "btnSupprimerChambre";
            this.btnSupprimerChambre.Size = new System.Drawing.Size(200, 28);
            this.btnSupprimerChambre.TabIndex = 43;
            this.btnSupprimerChambre.Text = "Supprimer Chambre";
            this.btnSupprimerChambre.UseVisualStyleBackColor = true;
            this.btnSupprimerChambre.Click += new System.EventHandler(this.btnSupprimerChambre_Click);
            // 
            // btnSupprimerType
            // 
            this.btnSupprimerType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerType.Location = new System.Drawing.Point(16, 366);
            this.btnSupprimerType.Name = "btnSupprimerType";
            this.btnSupprimerType.Size = new System.Drawing.Size(200, 28);
            this.btnSupprimerType.TabIndex = 46;
            this.btnSupprimerType.Text = "Supprimer Type Chambre";
            this.btnSupprimerType.UseVisualStyleBackColor = true;
            this.btnSupprimerType.Click += new System.EventHandler(this.btnSupprimerType_Click);
            // 
            // btnModifierType
            // 
            this.btnModifierType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierType.Location = new System.Drawing.Point(16, 332);
            this.btnModifierType.Name = "btnModifierType";
            this.btnModifierType.Size = new System.Drawing.Size(200, 28);
            this.btnModifierType.TabIndex = 45;
            this.btnModifierType.Text = "Modifier Type Chambre";
            this.btnModifierType.UseVisualStyleBackColor = true;
            this.btnModifierType.Click += new System.EventHandler(this.btnModifierType_Click);
            // 
            // btnAjouterType
            // 
            this.btnAjouterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterType.Location = new System.Drawing.Point(16, 298);
            this.btnAjouterType.Name = "btnAjouterType";
            this.btnAjouterType.Size = new System.Drawing.Size(200, 28);
            this.btnAjouterType.TabIndex = 44;
            this.btnAjouterType.Text = "Ajout Type Chambre";
            this.btnAjouterType.UseVisualStyleBackColor = true;
            this.btnAjouterType.Click += new System.EventHandler(this.btnAjouterType_Click);
            // 
            // GererChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 430);
            this.Controls.Add(this.btnSupprimerType);
            this.Controls.Add(this.btnModifierType);
            this.Controls.Add(this.btnAjouterType);
            this.Controls.Add(this.btnSupprimerChambre);
            this.Controls.Add(this.btnModificationChambre);
            this.Controls.Add(this.btnAjouterChambre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTotale);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.chambreDataGridView);
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
            this.Name = "GererChambre";
            this.Text = "GererChambre";
            this.Load += new System.EventHandler(this.GererChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
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
        private B56Projet1Equipe7DataSetTableAdapters.chambreTableAdapter chambreTableAdapter;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private System.Windows.Forms.DataGridView chambreDataGridView;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotale;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjouterChambre;
        private System.Windows.Forms.Button btnModificationChambre;
        private System.Windows.Forms.Button btnSupprimerChambre;
        private System.Windows.Forms.Button btnSupprimerType;
        private System.Windows.Forms.Button btnModifierType;
        private System.Windows.Forms.Button btnAjouterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn noChambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn emplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn decorations;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTypeChambre;
    }
}