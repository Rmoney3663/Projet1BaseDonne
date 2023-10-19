namespace Projet1.Prepose
{
    partial class MenuPrepose
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réserverDesChambresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDéconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterLapplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b56Projet1Equipe7DataSet = new Projet1.B56Projet1Equipe7DataSet();
            this.planifSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planifSoinTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.planifSoinTableAdapter();
            this.tableAdapterManager = new Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem,
            this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem,
            this.réserverDesChambresToolStripMenuItem,
            this.seDéconnecterToolStripMenuItem,
            this.quitterLapplicationToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // gérerLesClientsEtLeursInvitésToolStripMenuItem
            // 
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem.Name = "gérerLesClientsEtLeursInvitésToolStripMenuItem";
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem.Text = "Gérer les clients et leurs invités ";
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem.Click += new System.EventHandler(this.gérerLesClientsEtLeursInvitésToolStripMenuItem_Click);
            // 
            // planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem
            // 
            this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem.Name = "planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem";
            this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem.Text = "Planifier des soins pour les clients et leurs invités";
            this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem.Click += new System.EventHandler(this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem_Click);
            // 
            // réserverDesChambresToolStripMenuItem
            // 
            this.réserverDesChambresToolStripMenuItem.Name = "réserverDesChambresToolStripMenuItem";
            this.réserverDesChambresToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.réserverDesChambresToolStripMenuItem.Text = "Réserver des chambres";
            this.réserverDesChambresToolStripMenuItem.Click += new System.EventHandler(this.réserverDesChambresToolStripMenuItem_Click);
            // 
            // seDéconnecterToolStripMenuItem
            // 
            this.seDéconnecterToolStripMenuItem.Name = "seDéconnecterToolStripMenuItem";
            this.seDéconnecterToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.seDéconnecterToolStripMenuItem.Text = "Se déconnecter";
            this.seDéconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDéconnecterToolStripMenuItem_Click);
            // 
            // quitterLapplicationToolStripMenuItem
            // 
            this.quitterLapplicationToolStripMenuItem.Name = "quitterLapplicationToolStripMenuItem";
            this.quitterLapplicationToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.quitterLapplicationToolStripMenuItem.Text = "Quitter l’application";
            this.quitterLapplicationToolStripMenuItem.Click += new System.EventHandler(this.quitterLapplicationToolStripMenuItem_Click);
            // 
            // b56Projet1Equipe7DataSet
            // 
            this.b56Projet1Equipe7DataSet.DataSetName = "B56Projet1Equipe7DataSet";
            this.b56Projet1Equipe7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planifSoinBindingSource
            // 
            this.planifSoinBindingSource.DataMember = "planifSoin";
            this.planifSoinBindingSource.DataSource = this.b56Projet1Equipe7DataSet;
            // 
            // planifSoinTableAdapter
            // 
            this.planifSoinTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.planifSoinTableAdapter = this.planifSoinTableAdapter;
            this.tableAdapterManager.reservationChambreTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.typeChambreTableAdapter = null;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // MenuPrepose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrepose";
            this.Text = "MenuPrepose";
            this.Load += new System.EventHandler(this.MenuPrepose_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesClientsEtLeursInvitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réserverDesChambresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDéconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterLapplicationToolStripMenuItem;
        private B56Projet1Equipe7DataSet b56Projet1Equipe7DataSet;
        private System.Windows.Forms.BindingSource planifSoinBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.planifSoinTableAdapter planifSoinTableAdapter;
        private B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}