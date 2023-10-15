namespace Projet1.Prepose.PlanificationSoins
{
    partial class frmAjouterPlanifSoin
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
            System.Windows.Forms.Label noPersonneLabel;
            System.Windows.Forms.Label noAssistantLabel;
            System.Windows.Forms.Label dateHeureLabel;
            System.Windows.Forms.Label noSoinLabel;
            this.b56Projet1Equipe7DataSet = new Projet1.B56Projet1Equipe7DataSet();
            this.cbNoPersonne = new System.Windows.Forms.ComboBox();
            this.cbNoAssistant = new System.Windows.Forms.ComboBox();
            this.dateHeureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbNoSoin = new System.Windows.Forms.ComboBox();
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.soinTableAdapter();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            noPersonneLabel = new System.Windows.Forms.Label();
            noAssistantLabel = new System.Windows.Forms.Label();
            dateHeureLabel = new System.Windows.Forms.Label();
            noSoinLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noPersonneLabel
            // 
            noPersonneLabel.AutoSize = true;
            noPersonneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            noPersonneLabel.Location = new System.Drawing.Point(30, 79);
            noPersonneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noPersonneLabel.Name = "noPersonneLabel";
            noPersonneLabel.Size = new System.Drawing.Size(179, 15);
            noPersonneLabel.TabIndex = 1;
            noPersonneLabel.Text = "Personne (client ou invité):";
            // 
            // noAssistantLabel
            // 
            noAssistantLabel.AutoSize = true;
            noAssistantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            noAssistantLabel.Location = new System.Drawing.Point(30, 128);
            noAssistantLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noAssistantLabel.Name = "noAssistantLabel";
            noAssistantLabel.Size = new System.Drawing.Size(68, 15);
            noAssistantLabel.TabIndex = 3;
            noAssistantLabel.Text = "Assistant:";
            // 
            // dateHeureLabel
            // 
            dateHeureLabel.AutoSize = true;
            dateHeureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dateHeureLabel.Location = new System.Drawing.Point(30, 153);
            dateHeureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateHeureLabel.Name = "dateHeureLabel";
            dateHeureLabel.Size = new System.Drawing.Size(82, 15);
            dateHeureLabel.TabIndex = 5;
            dateHeureLabel.Text = "date Heure:";
            // 
            // noSoinLabel
            // 
            noSoinLabel.AutoSize = true;
            noSoinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            noSoinLabel.Location = new System.Drawing.Point(30, 103);
            noSoinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noSoinLabel.Name = "noSoinLabel";
            noSoinLabel.Size = new System.Drawing.Size(40, 15);
            noSoinLabel.TabIndex = 7;
            noSoinLabel.Text = "Soin:";
            // 
            // b56Projet1Equipe7DataSet
            // 
            this.b56Projet1Equipe7DataSet.DataSetName = "B56Projet1Equipe7DataSet";
            this.b56Projet1Equipe7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbNoPersonne
            // 
            this.cbNoPersonne.DisplayMember = "noInvite";
            this.cbNoPersonne.FormattingEnabled = true;
            this.cbNoPersonne.Location = new System.Drawing.Point(223, 78);
            this.cbNoPersonne.Margin = new System.Windows.Forms.Padding(2);
            this.cbNoPersonne.Name = "cbNoPersonne";
            this.cbNoPersonne.Size = new System.Drawing.Size(184, 21);
            this.cbNoPersonne.TabIndex = 2;
            this.cbNoPersonne.ValueMember = "noInvite";
            // 
            // cbNoAssistant
            // 
            this.cbNoAssistant.DisplayMember = "noAssistant";
            this.cbNoAssistant.FormattingEnabled = true;
            this.cbNoAssistant.Location = new System.Drawing.Point(223, 127);
            this.cbNoAssistant.Margin = new System.Windows.Forms.Padding(2);
            this.cbNoAssistant.Name = "cbNoAssistant";
            this.cbNoAssistant.Size = new System.Drawing.Size(184, 21);
            this.cbNoAssistant.TabIndex = 4;
            this.cbNoAssistant.ValueMember = "noAssistant";
            // 
            // dateHeureDateTimePicker
            // 
            this.dateHeureDateTimePicker.Location = new System.Drawing.Point(223, 151);
            this.dateHeureDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateHeureDateTimePicker.Name = "dateHeureDateTimePicker";
            this.dateHeureDateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.dateHeureDateTimePicker.TabIndex = 6;
            // 
            // cbNoSoin
            // 
            this.cbNoSoin.FormattingEnabled = true;
            this.cbNoSoin.Location = new System.Drawing.Point(223, 102);
            this.cbNoSoin.Margin = new System.Windows.Forms.Padding(2);
            this.cbNoSoin.Name = "cbNoSoin";
            this.cbNoSoin.Size = new System.Drawing.Size(184, 21);
            this.cbNoSoin.TabIndex = 8;
            this.cbNoSoin.SelectedValueChanged += new System.EventHandler(this.remplirCbAssistant);
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
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnAnnuler.Location = new System.Drawing.Point(232, 197);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(101, 32);
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
            this.btnAjouter.Location = new System.Drawing.Point(96, 197);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(101, 32);
            this.btnAjouter.TabIndex = 20;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(77, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nouvelle planification de soin";
            // 
            // frmAjouterPlanifSoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 249);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(noPersonneLabel);
            this.Controls.Add(this.cbNoPersonne);
            this.Controls.Add(noAssistantLabel);
            this.Controls.Add(this.cbNoAssistant);
            this.Controls.Add(dateHeureLabel);
            this.Controls.Add(this.dateHeureDateTimePicker);
            this.Controls.Add(noSoinLabel);
            this.Controls.Add(this.cbNoSoin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAjouterPlanifSoin";
            this.Text = "Ajout d\'une nouvelle planification de soin";
            this.Load += new System.EventHandler(this.frmAjouterPlanifSoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private B56Projet1Equipe7DataSet b56Projet1Equipe7DataSet;
        private System.Windows.Forms.ComboBox cbNoPersonne;
        private System.Windows.Forms.ComboBox cbNoAssistant;
        private System.Windows.Forms.DateTimePicker dateHeureDateTimePicker;
        private System.Windows.Forms.ComboBox cbNoSoin;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.soinTableAdapter soinTableAdapter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label1;
    }
}