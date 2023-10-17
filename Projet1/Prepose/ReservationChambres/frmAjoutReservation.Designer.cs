namespace Projet1.Prepose.ReservationChambres
{
    partial class frmAjoutReservation
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
            System.Windows.Forms.Label noClientLabel;
            System.Windows.Forms.Label noChambreLabel;
            System.Windows.Forms.Label dateArriveeLabel;
            System.Windows.Forms.Label dateDepartLabel;
            System.Windows.Forms.Label nbPersonnesLabel;
            this.dateArriveeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateDepartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.b56Projet1Equipe7DataSet = new Projet1.B56Projet1Equipe7DataSet();
            this.reservationChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationChambreTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.reservationChambreTableAdapter();
            this.tableAdapterManager = new Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.clientTableAdapter();
            this.chambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chambreTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.chambreTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.typeChambreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeChambreTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.typeChambreTableAdapter();
            this.chambreBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgChambres = new System.Windows.Forms.DataGridView();
            noClientLabel = new System.Windows.Forms.Label();
            noChambreLabel = new System.Windows.Forms.Label();
            dateArriveeLabel = new System.Windows.Forms.Label();
            dateDepartLabel = new System.Windows.Forms.Label();
            nbPersonnesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChambres)).BeginInit();
            this.SuspendLayout();
            // 
            // noClientLabel
            // 
            noClientLabel.AutoSize = true;
            noClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            noClientLabel.Location = new System.Drawing.Point(39, 85);
            noClientLabel.Name = "noClientLabel";
            noClientLabel.Size = new System.Drawing.Size(56, 18);
            noClientLabel.TabIndex = 1;
            noClientLabel.Text = "Client:";
            // 
            // noChambreLabel
            // 
            noChambreLabel.AutoSize = true;
            noChambreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            noChambreLabel.Location = new System.Drawing.Point(39, 220);
            noChambreLabel.Name = "noChambreLabel";
            noChambreLabel.Size = new System.Drawing.Size(81, 18);
            noChambreLabel.TabIndex = 3;
            noChambreLabel.Text = "Chambre:";
            // 
            // dateArriveeLabel
            // 
            dateArriveeLabel.AutoSize = true;
            dateArriveeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dateArriveeLabel.Location = new System.Drawing.Point(39, 114);
            dateArriveeLabel.Name = "dateArriveeLabel";
            dateArriveeLabel.Size = new System.Drawing.Size(117, 18);
            dateArriveeLabel.TabIndex = 5;
            dateArriveeLabel.Text = "Date d\'arrivée:";
            // 
            // dateArriveeDateTimePicker
            // 
            this.dateArriveeDateTimePicker.Location = new System.Drawing.Point(206, 111);
            this.dateArriveeDateTimePicker.Name = "dateArriveeDateTimePicker";
            this.dateArriveeDateTimePicker.Size = new System.Drawing.Size(288, 22);
            this.dateArriveeDateTimePicker.TabIndex = 6;
            // 
            // dateDepartLabel
            // 
            dateDepartLabel.AutoSize = true;
            dateDepartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dateDepartLabel.Location = new System.Drawing.Point(39, 142);
            dateDepartLabel.Name = "dateDepartLabel";
            dateDepartLabel.Size = new System.Drawing.Size(123, 18);
            dateDepartLabel.TabIndex = 7;
            dateDepartLabel.Text = "Date de départ:";
            // 
            // dateDepartDateTimePicker
            // 
            this.dateDepartDateTimePicker.Location = new System.Drawing.Point(206, 139);
            this.dateDepartDateTimePicker.Name = "dateDepartDateTimePicker";
            this.dateDepartDateTimePicker.Size = new System.Drawing.Size(288, 22);
            this.dateDepartDateTimePicker.TabIndex = 8;
            // 
            // nbPersonnesLabel
            // 
            nbPersonnesLabel.AutoSize = true;
            nbPersonnesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            nbPersonnesLabel.Location = new System.Drawing.Point(39, 169);
            nbPersonnesLabel.Name = "nbPersonnesLabel";
            nbPersonnesLabel.Size = new System.Drawing.Size(141, 18);
            nbPersonnesLabel.TabIndex = 9;
            nbPersonnesLabel.Text = "Nb de personnes:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(206, 169);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(98, 22);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // b56Projet1Equipe7DataSet
            // 
            this.b56Projet1Equipe7DataSet.DataSetName = "B56Projet1Equipe7DataSet";
            this.b56Projet1Equipe7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationChambreBindingSource
            // 
            this.reservationChambreBindingSource.DataMember = "reservationChambre";
            this.reservationChambreBindingSource.DataSource = this.b56Projet1Equipe7DataSet;
            // 
            // reservationChambreTableAdapter
            // 
            this.reservationChambreTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = this.chambreTableAdapter;
            this.tableAdapterManager.clientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.planifSoinTableAdapter = null;
            this.tableAdapterManager.reservationChambreTableAdapter = this.reservationChambreTableAdapter;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.typeChambreTableAdapter = this.typeChambreTableAdapter;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // cbClient
            // 
            this.cbClient.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.reservationChambreBindingSource, "noClient", true));
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(206, 81);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(288, 24);
            this.cbClient.TabIndex = 13;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.b56Projet1Equipe7DataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(115, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nouvelle réservation de chambre";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnAnnuler.Location = new System.Drawing.Point(344, 440);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(135, 39);
            this.btnAnnuler.TabIndex = 25;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Black;
            this.btnAjouter.Location = new System.Drawing.Point(163, 440);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(135, 39);
            this.btnAjouter.TabIndex = 24;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
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
            // chambreBindingSource1
            // 
            this.chambreBindingSource1.DataMember = "fk_noTypeChambre";
            this.chambreBindingSource1.DataSource = this.typeChambreBindingSource;
            // 
            // dgChambres
            // 
            this.dgChambres.AllowUserToAddRows = false;
            this.dgChambres.AllowUserToDeleteRows = false;
            this.dgChambres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChambres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChambres.Location = new System.Drawing.Point(42, 241);
            this.dgChambres.MultiSelect = false;
            this.dgChambres.Name = "dgChambres";
            this.dgChambres.ReadOnly = true;
            this.dgChambres.RowHeadersWidth = 51;
            this.dgChambres.RowTemplate.Height = 24;
            this.dgChambres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChambres.Size = new System.Drawing.Size(556, 181);
            this.dgChambres.TabIndex = 13;
            // 
            // frmAjoutReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 496);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgChambres);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(noClientLabel);
            this.Controls.Add(noChambreLabel);
            this.Controls.Add(dateArriveeLabel);
            this.Controls.Add(this.dateArriveeDateTimePicker);
            this.Controls.Add(dateDepartLabel);
            this.Controls.Add(this.dateDepartDateTimePicker);
            this.Controls.Add(nbPersonnesLabel);
            this.Name = "frmAjoutReservation";
            this.Text = "frmAjoutReservation";
            this.Load += new System.EventHandler(this.frmAjoutReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeChambreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chambreBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChambres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateArriveeDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateDepartDateTimePicker;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private B56Projet1Equipe7DataSet b56Projet1Equipe7DataSet;
        private System.Windows.Forms.BindingSource reservationChambreBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.reservationChambreTableAdapter reservationChambreTableAdapter;
        private B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbClient;
        private B56Projet1Equipe7DataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.chambreTableAdapter chambreTableAdapter;
        private System.Windows.Forms.BindingSource chambreBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private B56Projet1Equipe7DataSetTableAdapters.typeChambreTableAdapter typeChambreTableAdapter;
        private System.Windows.Forms.BindingSource typeChambreBindingSource;
        private System.Windows.Forms.BindingSource chambreBindingSource1;
        private System.Windows.Forms.DataGridView dgChambres;
    }
}