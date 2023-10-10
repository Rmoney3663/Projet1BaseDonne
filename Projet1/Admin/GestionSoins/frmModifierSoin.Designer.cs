namespace Projet1.Admin.GestionSoins
{
    partial class frmModifierSoin
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
            System.Windows.Forms.Label noSoinLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label dureeLabel;
            System.Windows.Forms.Label noTypeSoinLabel;
            System.Windows.Forms.Label prixLabel;
            this.cbTypeSoin = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbDuree = new System.Windows.Forms.TextBox();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b56Projet1Equipe7DataSet = new Projet1.B56Projet1Equipe7DataSet();
            this.typeSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeSoinTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.typeSoinTableAdapter();
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.soinTableAdapter();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            noSoinLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            dureeLabel = new System.Windows.Forms.Label();
            noTypeSoinLabel = new System.Windows.Forms.Label();
            prixLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTypeSoin
            // 
            this.cbTypeSoin.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.soinBindingSource, "noTypeSoin", true));
            this.cbTypeSoin.DataSource = this.typeSoinBindingSource;
            this.cbTypeSoin.DisplayMember = "description";
            this.cbTypeSoin.FormattingEnabled = true;
            this.cbTypeSoin.Location = new System.Drawing.Point(165, 167);
            this.cbTypeSoin.Name = "cbTypeSoin";
            this.cbTypeSoin.Size = new System.Drawing.Size(233, 24);
            this.cbTypeSoin.TabIndex = 42;
            this.cbTypeSoin.ValueMember = "noTypeSoin";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnAnnuler.Location = new System.Drawing.Point(237, 252);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(130, 39);
            this.btnAnnuler.TabIndex = 43;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.PaleGreen;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.Black;
            this.btnModifier.Location = new System.Drawing.Point(71, 252);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(130, 39);
            this.btnModifier.TabIndex = 41;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // noSoinLabel
            // 
            noSoinLabel.AutoSize = true;
            noSoinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noSoinLabel.Location = new System.Drawing.Point(40, 85);
            noSoinLabel.Name = "noSoinLabel";
            noSoinLabel.Size = new System.Drawing.Size(110, 18);
            noSoinLabel.TabIndex = 32;
            noSoinLabel.Text = "Numéro soin:";
            // 
            // tbNo
            // 
            this.tbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNo.Location = new System.Drawing.Point(165, 82);
            this.tbNo.MaxLength = 50;
            this.tbNo.Name = "tbNo";
            this.tbNo.ReadOnly = true;
            this.tbNo.Size = new System.Drawing.Size(233, 24);
            this.tbNo.TabIndex = 33;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.Location = new System.Drawing.Point(40, 113);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(99, 18);
            descriptionLabel.TabIndex = 34;
            descriptionLabel.Text = "Description:";
            // 
            // tbDesc
            // 
            this.tbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesc.Location = new System.Drawing.Point(165, 110);
            this.tbDesc.MaxLength = 50;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(233, 24);
            this.tbDesc.TabIndex = 35;
            // 
            // dureeLabel
            // 
            dureeLabel.AutoSize = true;
            dureeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dureeLabel.Location = new System.Drawing.Point(40, 141);
            dureeLabel.Name = "dureeLabel";
            dureeLabel.Size = new System.Drawing.Size(102, 18);
            dureeLabel.TabIndex = 36;
            dureeLabel.Text = "Durée (min):";
            // 
            // tbDuree
            // 
            this.tbDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDuree.Location = new System.Drawing.Point(165, 138);
            this.tbDuree.MaxLength = 50;
            this.tbDuree.Name = "tbDuree";
            this.tbDuree.ReadOnly = true;
            this.tbDuree.Size = new System.Drawing.Size(233, 24);
            this.tbDuree.TabIndex = 37;
            // 
            // noTypeSoinLabel
            // 
            noTypeSoinLabel.AutoSize = true;
            noTypeSoinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noTypeSoinLabel.Location = new System.Drawing.Point(40, 169);
            noTypeSoinLabel.Name = "noTypeSoinLabel";
            noTypeSoinLabel.Size = new System.Drawing.Size(86, 18);
            noTypeSoinLabel.TabIndex = 38;
            noTypeSoinLabel.Text = "Type soin:";
            // 
            // prixLabel
            // 
            prixLabel.AutoSize = true;
            prixLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prixLabel.Location = new System.Drawing.Point(40, 197);
            prixLabel.Name = "prixLabel";
            prixLabel.Size = new System.Drawing.Size(42, 18);
            prixLabel.TabIndex = 39;
            prixLabel.Text = "Prix:";
            // 
            // tbPrix
            // 
            this.tbPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrix.Location = new System.Drawing.Point(165, 194);
            this.tbPrix.MaxLength = 50;
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(233, 24);
            this.tbPrix.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(145, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Modifier soin";
            // 
            // b56Projet1Equipe7DataSet
            // 
            this.b56Projet1Equipe7DataSet.DataSetName = "B56Projet1Equipe7DataSet";
            this.b56Projet1Equipe7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeSoinBindingSource
            // 
            this.typeSoinBindingSource.DataMember = "typeSoin";
            this.typeSoinBindingSource.DataSource = this.b56Projet1Equipe7DataSet;
            // 
            // typeSoinTableAdapter
            // 
            this.typeSoinTableAdapter.ClearBeforeFill = true;
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
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmModifierSoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 316);
            this.Controls.Add(this.cbTypeSoin);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(noSoinLabel);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(dureeLabel);
            this.Controls.Add(this.tbDuree);
            this.Controls.Add(noTypeSoinLabel);
            this.Controls.Add(prixLabel);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.label1);
            this.Name = "frmModifierSoin";
            this.Text = "Modifier un soin";
            this.Load += new System.EventHandler(this.frmModifierSoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTypeSoin;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbDuree;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.Label label1;
        private B56Projet1Equipe7DataSet b56Projet1Equipe7DataSet;
        private System.Windows.Forms.BindingSource typeSoinBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.typeSoinTableAdapter typeSoinTableAdapter;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.soinTableAdapter soinTableAdapter;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}