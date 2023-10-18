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
            this.dpArrivee = new System.Windows.Forms.DateTimePicker();
            this.dpDepart = new System.Windows.Forms.DateTimePicker();
            this.numNbPers = new System.Windows.Forms.NumericUpDown();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.dgChambres = new System.Windows.Forms.DataGridView();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            noClientLabel = new System.Windows.Forms.Label();
            noChambreLabel = new System.Windows.Forms.Label();
            dateArriveeLabel = new System.Windows.Forms.Label();
            dateDepartLabel = new System.Windows.Forms.Label();
            nbPersonnesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNbPers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChambres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
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
            // dpArrivee
            // 
            this.dpArrivee.Location = new System.Drawing.Point(206, 111);
            this.dpArrivee.Name = "dpArrivee";
            this.dpArrivee.Size = new System.Drawing.Size(288, 22);
            this.dpArrivee.TabIndex = 6;
            // 
            // dpDepart
            // 
            this.dpDepart.Location = new System.Drawing.Point(206, 139);
            this.dpDepart.Name = "dpDepart";
            this.dpDepart.Size = new System.Drawing.Size(288, 22);
            this.dpDepart.TabIndex = 8;
            // 
            // numNbPers
            // 
            this.numNbPers.Location = new System.Drawing.Point(206, 169);
            this.numNbPers.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numNbPers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNbPers.Name = "numNbPers";
            this.numNbPers.Size = new System.Drawing.Size(98, 22);
            this.numNbPers.TabIndex = 11;
            this.numNbPers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(206, 81);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(288, 24);
            this.cbClient.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 25);
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
            this.btnAnnuler.Location = new System.Drawing.Point(586, 121);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(135, 39);
            this.btnAnnuler.TabIndex = 25;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.Black;
            this.btnAjouter.Location = new System.Drawing.Point(586, 78);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(135, 39);
            this.btnAjouter.TabIndex = 24;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
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
            this.dgChambres.Size = new System.Drawing.Size(701, 181);
            this.dgChambres.TabIndex = 13;
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmAjoutReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 456);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgChambres);
            this.Controls.Add(this.cbClient);
            this.Controls.Add(this.numNbPers);
            this.Controls.Add(noClientLabel);
            this.Controls.Add(noChambreLabel);
            this.Controls.Add(dateArriveeLabel);
            this.Controls.Add(this.dpArrivee);
            this.Controls.Add(dateDepartLabel);
            this.Controls.Add(this.dpDepart);
            this.Controls.Add(nbPersonnesLabel);
            this.Name = "frmAjoutReservation";
            this.Text = "frmAjoutReservation";
            this.Load += new System.EventHandler(this.frmAjoutReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNbPers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgChambres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dpArrivee;
        private System.Windows.Forms.DateTimePicker dpDepart;
        private System.Windows.Forms.NumericUpDown numNbPers;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.DataGridView dgChambres;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}