namespace Projet1.Admin
{
    partial class GererAssistants
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
            System.Windows.Forms.Label noAssistantLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label specialitesLabel;
            System.Windows.Forms.Label remarquesLabel;
            this.b56Projet1Equipe7DataSet = new Projet1.B56Projet1Equipe7DataSet();
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.soinTableAdapter();
            this.tableAdapterManager = new Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager();
            this.assistantSoinTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.assistantSoinTableAdapter();
            this.assistantTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.assistantTableAdapter();
            this.planifSoinTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.planifSoinTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.assistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantSoinDataGridView = new System.Windows.Forms.DataGridView();
            this.noAssistantTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.specialitesTextBox = new System.Windows.Forms.TextBox();
            this.remarquesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouterSoins = new System.Windows.Forms.Button();
            this.btnSupprimerSoins = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbTotale = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.noAssistant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assistantSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planifSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            noAssistantLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            specialitesLabel = new System.Windows.Forms.Label();
            remarquesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noAssistantLabel
            // 
            noAssistantLabel.AutoSize = true;
            noAssistantLabel.Location = new System.Drawing.Point(13, 96);
            noAssistantLabel.Name = "noAssistantLabel";
            noAssistantLabel.Size = new System.Drawing.Size(67, 13);
            noAssistantLabel.TabIndex = 3;
            noAssistantLabel.Text = "no Assistant:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(13, 122);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(45, 13);
            prenomLabel.TabIndex = 5;
            prenomLabel.Text = "prenom:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(13, 148);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(30, 13);
            nomLabel.TabIndex = 7;
            nomLabel.Text = "nom:";
            // 
            // specialitesLabel
            // 
            specialitesLabel.AutoSize = true;
            specialitesLabel.Location = new System.Drawing.Point(13, 174);
            specialitesLabel.Name = "specialitesLabel";
            specialitesLabel.Size = new System.Drawing.Size(59, 13);
            specialitesLabel.TabIndex = 9;
            specialitesLabel.Text = "specialites:";
            // 
            // remarquesLabel
            // 
            remarquesLabel.AutoSize = true;
            remarquesLabel.Location = new System.Drawing.Point(13, 200);
            remarquesLabel.Name = "remarquesLabel";
            remarquesLabel.Size = new System.Drawing.Size(59, 13);
            remarquesLabel.TabIndex = 11;
            remarquesLabel.Text = "remarques:";
            // 
            // b56Projet1Equipe7DataSet
            // 
            this.b56Projet1Equipe7DataSet.DataSetName = "B56Projet1Equipe7DataSet";
            this.b56Projet1Equipe7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soinBindingSource
            // 
            this.soinBindingSource.DataMember = "soin";
            this.soinBindingSource.DataSource = this.b56Projet1Equipe7DataSet;
            // 
            // soinTableAdapter
            // 
            this.soinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = this.assistantSoinTableAdapter;
            this.tableAdapterManager.assistantTableAdapter = this.assistantTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.planifSoinTableAdapter = this.planifSoinTableAdapter;
            this.tableAdapterManager.reservationChambreTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = this.soinTableAdapter;
            this.tableAdapterManager.typeChambreTableAdapter = null;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // assistantSoinTableAdapter
            // 
            this.assistantSoinTableAdapter.ClearBeforeFill = true;
            // 
            // assistantTableAdapter
            // 
            this.assistantTableAdapter.ClearBeforeFill = true;
            // 
            // planifSoinTableAdapter
            // 
            this.planifSoinTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des soins";
            // 
            // assistantBindingSource
            // 
            this.assistantBindingSource.DataMember = "assistant";
            this.assistantBindingSource.DataSource = this.b56Projet1Equipe7DataSet;
            // 
            // assistantSoinDataGridView
            // 
            this.assistantSoinDataGridView.AutoGenerateColumns = false;
            this.assistantSoinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.assistantSoinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noAssistant,
            this.noSoin});
            this.assistantSoinDataGridView.DataSource = this.assistantSoinBindingSource;
            this.assistantSoinDataGridView.Location = new System.Drawing.Point(335, 87);
            this.assistantSoinDataGridView.Name = "assistantSoinDataGridView";
            this.assistantSoinDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.assistantSoinDataGridView.Size = new System.Drawing.Size(243, 164);
            this.assistantSoinDataGridView.TabIndex = 2;
            // 
            // noAssistantTextBox
            // 
            this.noAssistantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assistantBindingSource, "noAssistant", true));
            this.noAssistantTextBox.Location = new System.Drawing.Point(86, 93);
            this.noAssistantTextBox.Name = "noAssistantTextBox";
            this.noAssistantTextBox.ReadOnly = true;
            this.noAssistantTextBox.Size = new System.Drawing.Size(100, 20);
            this.noAssistantTextBox.TabIndex = 4;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assistantBindingSource, "prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(86, 119);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.ReadOnly = true;
            this.prenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox.TabIndex = 6;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assistantBindingSource, "nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(86, 145);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.ReadOnly = true;
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 8;
            // 
            // specialitesTextBox
            // 
            this.specialitesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assistantBindingSource, "specialites", true));
            this.specialitesTextBox.Location = new System.Drawing.Point(86, 171);
            this.specialitesTextBox.Name = "specialitesTextBox";
            this.specialitesTextBox.ReadOnly = true;
            this.specialitesTextBox.Size = new System.Drawing.Size(100, 20);
            this.specialitesTextBox.TabIndex = 10;
            // 
            // remarquesTextBox
            // 
            this.remarquesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assistantBindingSource, "remarques", true));
            this.remarquesTextBox.Location = new System.Drawing.Point(86, 197);
            this.remarquesTextBox.Name = "remarquesTextBox";
            this.remarquesTextBox.ReadOnly = true;
            this.remarquesTextBox.Size = new System.Drawing.Size(100, 20);
            this.remarquesTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Info sur assistant";
            // 
            // btnAjout
            // 
            this.btnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.Location = new System.Drawing.Point(16, 223);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(176, 28);
            this.btnAjout.TabIndex = 14;
            this.btnAjout.Text = "Ajout Assistant";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(16, 257);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(176, 28);
            this.btnModifier.TabIndex = 15;
            this.btnModifier.Text = "Modifier Assistant";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(16, 291);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(176, 28);
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "Supprimer Assistant";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAjouterSoins
            // 
            this.btnAjouterSoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterSoins.Location = new System.Drawing.Point(351, 257);
            this.btnAjouterSoins.Name = "btnAjouterSoins";
            this.btnAjouterSoins.Size = new System.Drawing.Size(176, 28);
            this.btnAjouterSoins.TabIndex = 17;
            this.btnAjouterSoins.Text = "Ajout Soins";
            this.btnAjouterSoins.UseVisualStyleBackColor = true;
            this.btnAjouterSoins.Click += new System.EventHandler(this.btnAjouterSoins_Click);
            // 
            // btnSupprimerSoins
            // 
            this.btnSupprimerSoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerSoins.Location = new System.Drawing.Point(351, 291);
            this.btnSupprimerSoins.Name = "btnSupprimerSoins";
            this.btnSupprimerSoins.Size = new System.Drawing.Size(176, 28);
            this.btnSupprimerSoins.TabIndex = 18;
            this.btnSupprimerSoins.Text = "Supprimer Soins";
            this.btnSupprimerSoins.UseVisualStyleBackColor = true;
            this.btnSupprimerSoins.Click += new System.EventHandler(this.btnSupprimerSoins_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(12, 12);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(119, 27);
            this.btnFirst.TabIndex = 19;
            this.btnFirst.Text = "Première Assistant";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(137, 12);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(128, 27);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.Text = "Assistant Precedent";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(374, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(128, 27);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Prochaine Assistant";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(508, 12);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(128, 27);
            this.btnLast.TabIndex = 22;
            this.btnLast.Text = "Dernière Assistant";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lbPosition
            // 
            this.lbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.Location = new System.Drawing.Point(272, 13);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(27, 26);
            this.lbPosition.TabIndex = 23;
            this.lbPosition.Text = "0";
            this.lbPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotale
            // 
            this.lbTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotale.Location = new System.Drawing.Point(329, 13);
            this.lbTotale.Name = "lbTotale";
            this.lbTotale.Size = new System.Drawing.Size(28, 26);
            this.lbTotale.TabIndex = 24;
            this.lbTotale.Text = "0";
            this.lbTotale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.ForeColor = System.Drawing.Color.Black;
            this.btnFermer.Location = new System.Drawing.Point(641, 7);
            this.btnFermer.Margin = new System.Windows.Forms.Padding(2);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(93, 33);
            this.btnFermer.TabIndex = 30;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // noAssistant
            // 
            this.noAssistant.DataPropertyName = "noAssistant";
            this.noAssistant.HeaderText = "noAssistant";
            this.noAssistant.Name = "noAssistant";
            this.noAssistant.ReadOnly = true;
            this.noAssistant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // noSoin
            // 
            this.noSoin.DataPropertyName = "noSoin";
            this.noSoin.HeaderText = "noSoin";
            this.noSoin.Name = "noSoin";
            this.noSoin.ReadOnly = true;
            this.noSoin.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // assistantSoinBindingSource
            // 
            this.assistantSoinBindingSource.DataMember = "fk_noAssistantAssistantSoin";
            this.assistantSoinBindingSource.DataSource = this.assistantBindingSource;
            // 
            // planifSoinBindingSource
            // 
            this.planifSoinBindingSource.DataMember = "fk_noAssistantPlanifSoin";
            this.planifSoinBindingSource.DataSource = this.assistantBindingSource;
            // 
            // GererAssistants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 367);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTotale);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnSupprimerSoins);
            this.Controls.Add(this.btnAjouterSoins);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.label2);
            this.Controls.Add(noAssistantLabel);
            this.Controls.Add(this.noAssistantTextBox);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(specialitesLabel);
            this.Controls.Add(this.specialitesTextBox);
            this.Controls.Add(remarquesLabel);
            this.Controls.Add(this.remarquesTextBox);
            this.Controls.Add(this.assistantSoinDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "GererAssistants";
            this.Text = "Assistants Suivant";
            this.Load += new System.EventHandler(this.GererAssistants_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private B56Projet1Equipe7DataSet b56Projet1Equipe7DataSet;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.soinTableAdapter soinTableAdapter;
        private B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private B56Projet1Equipe7DataSetTableAdapters.assistantTableAdapter assistantTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource assistantBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.planifSoinTableAdapter planifSoinTableAdapter;
        private System.Windows.Forms.BindingSource planifSoinBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.assistantSoinTableAdapter assistantSoinTableAdapter;
        private System.Windows.Forms.BindingSource assistantSoinBindingSource;
        private System.Windows.Forms.DataGridView assistantSoinDataGridView;
        private System.Windows.Forms.TextBox noAssistantTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox specialitesTextBox;
        private System.Windows.Forms.TextBox remarquesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouterSoins;
        private System.Windows.Forms.Button btnSupprimerSoins;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn noAssistant;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSoin;
        private System.Windows.Forms.Label lbTotale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFermer;
    }
}