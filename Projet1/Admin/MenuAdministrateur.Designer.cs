namespace Projet1.Admin
{
    partial class MenuAdministrateur
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
            this.gérerLesUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesAssistantsEtLesSoinsQuilsOffrentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesSoinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerLesChambresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réserverDesChambrespourLesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserDesRapportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDéconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterLapplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b56Projet1Equipe7DataSet = new Projet1.B56Projet1Equipe7DataSet();
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.soinTableAdapter();
            this.tableAdapterManager = new Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
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
            this.gérerLesUtilisateursToolStripMenuItem,
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem,
            this.gérerLesAssistantsEtLesSoinsQuilsOffrentToolStripMenuItem,
            this.gérerLesSoinsToolStripMenuItem,
            this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem,
            this.gérerLesChambresToolStripMenuItem,
            this.réserverDesChambrespourLesClientsToolStripMenuItem,
            this.visualiserDesRapportsToolStripMenuItem,
            this.seDéconnecterToolStripMenuItem,
            this.quitterLapplicationToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // gérerLesUtilisateursToolStripMenuItem
            // 
            this.gérerLesUtilisateursToolStripMenuItem.Name = "gérerLesUtilisateursToolStripMenuItem";
            this.gérerLesUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.gérerLesUtilisateursToolStripMenuItem.Text = "Gérer les utilisateurs";
            this.gérerLesUtilisateursToolStripMenuItem.Click += new System.EventHandler(this.gérerLesUtilisateursToolStripMenuItem_Click);
            // 
            // gérerLesClientsEtLeursInvitésToolStripMenuItem
            // 
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem.Name = "gérerLesClientsEtLeursInvitésToolStripMenuItem";
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem.Text = "Gérer les clients et leurs invités";
            this.gérerLesClientsEtLeursInvitésToolStripMenuItem.Click += new System.EventHandler(this.gérerLesClientsEtLeursInvitésToolStripMenuItem_Click);
            // 
            // gérerLesAssistantsEtLesSoinsQuilsOffrentToolStripMenuItem
            // 
            this.gérerLesAssistantsEtLesSoinsQuilsOffrentToolStripMenuItem.Name = "gérerLesAssistantsEtLesSoinsQuilsOffrentToolStripMenuItem";
            this.gérerLesAssistantsEtLesSoinsQuilsOffrentToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.gérerLesAssistantsEtLesSoinsQuilsOffrentToolStripMenuItem.Text = "Gérer les assistants et les soins qu’ils offrent";
            this.gérerLesAssistantsEtLesSoinsQuilsOffrentToolStripMenuItem.Click += new System.EventHandler(this.gérerLesAssistantsEtLesSoinsQuilsOffrentToolStripMenuItem_Click);
            // 
            // gérerLesSoinsToolStripMenuItem
            // 
            this.gérerLesSoinsToolStripMenuItem.Name = "gérerLesSoinsToolStripMenuItem";
            this.gérerLesSoinsToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.gérerLesSoinsToolStripMenuItem.Text = "Gérer les soins";
            this.gérerLesSoinsToolStripMenuItem.Click += new System.EventHandler(this.gérerLesSoinsToolStripMenuItem_Click);
            // 
            // planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem
            // 
            this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem.Name = "planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem";
            this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem.Text = "Planifier des soins pour les clients et leurs invités";
            this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem.Click += new System.EventHandler(this.planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem_Click);
            // 
            // gérerLesChambresToolStripMenuItem
            // 
            this.gérerLesChambresToolStripMenuItem.Name = "gérerLesChambresToolStripMenuItem";
            this.gérerLesChambresToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.gérerLesChambresToolStripMenuItem.Text = "Gérer les chambres";
            this.gérerLesChambresToolStripMenuItem.Click += new System.EventHandler(this.gérerLesChambresToolStripMenuItem_Click);
            // 
            // réserverDesChambrespourLesClientsToolStripMenuItem
            // 
            this.réserverDesChambrespourLesClientsToolStripMenuItem.Name = "réserverDesChambrespourLesClientsToolStripMenuItem";
            this.réserverDesChambrespourLesClientsToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.réserverDesChambrespourLesClientsToolStripMenuItem.Text = "Réserver des chambres (pour les clients)";
            this.réserverDesChambrespourLesClientsToolStripMenuItem.Click += new System.EventHandler(this.réserverDesChambrespourLesClientsToolStripMenuItem_Click);
            // 
            // visualiserDesRapportsToolStripMenuItem
            // 
            this.visualiserDesRapportsToolStripMenuItem.Name = "visualiserDesRapportsToolStripMenuItem";
            this.visualiserDesRapportsToolStripMenuItem.Size = new System.Drawing.Size(328, 22);
            this.visualiserDesRapportsToolStripMenuItem.Text = "Visualiser des rapports";
            this.visualiserDesRapportsToolStripMenuItem.Click += new System.EventHandler(this.visualiserDesRapportsToolStripMenuItem_Click);
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
            this.tableAdapterManager.assistantSoinTableAdapter = null;
            this.tableAdapterManager.assistantTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.chambreTableAdapter = null;
            this.tableAdapterManager.clientTableAdapter = null;
            this.tableAdapterManager.inviteTableAdapter = null;
            this.tableAdapterManager.planifSoinTableAdapter = null;
            this.tableAdapterManager.reservationChambreTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = this.soinTableAdapter;
            this.tableAdapterManager.typeChambreTableAdapter = null;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // MenuAdministrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MenuAdministrateur";
            this.Text = "Menu d\'administrateur";
            this.Load += new System.EventHandler(this.MenuAdministrateur_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesUtilisateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesClientsEtLeursInvitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesAssistantsEtLesSoinsQuilsOffrentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesSoinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planifierDesSoinsPourLesClientsEtLeursInvitésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerLesChambresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réserverDesChambrespourLesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserDesRapportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDéconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterLapplicationToolStripMenuItem;
        private B56Projet1Equipe7DataSet b56Projet1Equipe7DataSet;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.soinTableAdapter soinTableAdapter;
        private B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}