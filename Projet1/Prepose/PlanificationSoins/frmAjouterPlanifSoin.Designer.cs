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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjouterPlanifSoin));
            this.b56Projet1Equipe7DataSet = new Projet1.B56Projet1Equipe7DataSet();
            this.planifSoinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planifSoinTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.planifSoinTableAdapter();
            this.tableAdapterManager = new Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager();
            this.clientTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.clientTableAdapter();
            this.inviteTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.inviteTableAdapter();
            this.planifSoinBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.planifSoinBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.noPersonneComboBox = new System.Windows.Forms.ComboBox();
            this.inviteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.noAssistantComboBox = new System.Windows.Forms.ComboBox();
            this.dateHeureDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.noSoinComboBox = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assistantTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.assistantTableAdapter();
            this.soinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soinTableAdapter = new Projet1.B56Projet1Equipe7DataSetTableAdapters.soinTableAdapter();
            noPersonneLabel = new System.Windows.Forms.Label();
            noAssistantLabel = new System.Windows.Forms.Label();
            dateHeureLabel = new System.Windows.Forms.Label();
            noSoinLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinBindingNavigator)).BeginInit();
            this.planifSoinBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noPersonneLabel
            // 
            noPersonneLabel.AutoSize = true;
            noPersonneLabel.Location = new System.Drawing.Point(70, 69);
            noPersonneLabel.Name = "noPersonneLabel";
            noPersonneLabel.Size = new System.Drawing.Size(86, 16);
            noPersonneLabel.TabIndex = 1;
            noPersonneLabel.Text = "no Personne:";
            // 
            // noAssistantLabel
            // 
            noAssistantLabel.AutoSize = true;
            noAssistantLabel.Location = new System.Drawing.Point(70, 99);
            noAssistantLabel.Name = "noAssistantLabel";
            noAssistantLabel.Size = new System.Drawing.Size(82, 16);
            noAssistantLabel.TabIndex = 3;
            noAssistantLabel.Text = "no Assistant:";
            // 
            // dateHeureLabel
            // 
            dateHeureLabel.AutoSize = true;
            dateHeureLabel.Location = new System.Drawing.Point(70, 130);
            dateHeureLabel.Name = "dateHeureLabel";
            dateHeureLabel.Size = new System.Drawing.Size(77, 16);
            dateHeureLabel.TabIndex = 5;
            dateHeureLabel.Text = "date Heure:";
            // 
            // noSoinLabel
            // 
            noSoinLabel.AutoSize = true;
            noSoinLabel.Location = new System.Drawing.Point(70, 157);
            noSoinLabel.Name = "noSoinLabel";
            noSoinLabel.Size = new System.Drawing.Size(55, 16);
            noSoinLabel.TabIndex = 7;
            noSoinLabel.Text = "no Soin:";
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
            this.tableAdapterManager.clientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.inviteTableAdapter = this.inviteTableAdapter;
            this.tableAdapterManager.planifSoinTableAdapter = this.planifSoinTableAdapter;
            this.tableAdapterManager.reservationChambreTableAdapter = null;
            this.tableAdapterManager.soinTableAdapter = null;
            this.tableAdapterManager.typeChambreTableAdapter = null;
            this.tableAdapterManager.typeSoinTableAdapter = null;
            this.tableAdapterManager.typeUtilisateurTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projet1.B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.utilisateurTableAdapter = null;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // inviteTableAdapter
            // 
            this.inviteTableAdapter.ClearBeforeFill = true;
            // 
            // planifSoinBindingNavigator
            // 
            this.planifSoinBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.planifSoinBindingNavigator.BindingSource = this.planifSoinBindingSource;
            this.planifSoinBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.planifSoinBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.planifSoinBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.planifSoinBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.planifSoinBindingNavigatorSaveItem});
            this.planifSoinBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.planifSoinBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.planifSoinBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.planifSoinBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.planifSoinBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.planifSoinBindingNavigator.Name = "planifSoinBindingNavigator";
            this.planifSoinBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.planifSoinBindingNavigator.Size = new System.Drawing.Size(453, 27);
            this.planifSoinBindingNavigator.TabIndex = 0;
            this.planifSoinBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // planifSoinBindingNavigatorSaveItem
            // 
            this.planifSoinBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.planifSoinBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("planifSoinBindingNavigatorSaveItem.Image")));
            this.planifSoinBindingNavigatorSaveItem.Name = "planifSoinBindingNavigatorSaveItem";
            this.planifSoinBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.planifSoinBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.planifSoinBindingNavigatorSaveItem.Click += new System.EventHandler(this.planifSoinBindingNavigatorSaveItem_Click);
            // 
            // noPersonneComboBox
            // 
            this.noPersonneComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planifSoinBindingSource, "noPersonne", true));
            this.noPersonneComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.planifSoinBindingSource, "noPersonne", true));
            this.noPersonneComboBox.DataSource = this.inviteBindingSource;
            this.noPersonneComboBox.DisplayMember = "nomPrenom";
            this.noPersonneComboBox.FormattingEnabled = true;
            this.noPersonneComboBox.Location = new System.Drawing.Point(162, 66);
            this.noPersonneComboBox.Name = "noPersonneComboBox";
            this.noPersonneComboBox.Size = new System.Drawing.Size(200, 24);
            this.noPersonneComboBox.TabIndex = 2;
            this.noPersonneComboBox.ValueMember = "noInvite";
            // 
            // inviteBindingSource
            // 
            this.inviteBindingSource.DataMember = "invite";
            this.inviteBindingSource.DataSource = this.b56Projet1Equipe7DataSet;
            // 
            // noAssistantComboBox
            // 
            this.noAssistantComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planifSoinBindingSource, "noAssistant", true));
            this.noAssistantComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.planifSoinBindingSource, "noPersonne", true));
            this.noAssistantComboBox.DataSource = this.assistantBindingSource;
            this.noAssistantComboBox.DisplayMember = "nom";
            this.noAssistantComboBox.FormattingEnabled = true;
            this.noAssistantComboBox.Location = new System.Drawing.Point(162, 96);
            this.noAssistantComboBox.Name = "noAssistantComboBox";
            this.noAssistantComboBox.Size = new System.Drawing.Size(200, 24);
            this.noAssistantComboBox.TabIndex = 4;
            this.noAssistantComboBox.ValueMember = "noAssistant";
            // 
            // dateHeureDateTimePicker
            // 
            this.dateHeureDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.planifSoinBindingSource, "dateHeure", true));
            this.dateHeureDateTimePicker.Location = new System.Drawing.Point(162, 126);
            this.dateHeureDateTimePicker.Name = "dateHeureDateTimePicker";
            this.dateHeureDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateHeureDateTimePicker.TabIndex = 6;
            // 
            // noSoinComboBox
            // 
            this.noSoinComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.planifSoinBindingSource, "noSoin", true));
            this.noSoinComboBox.DataSource = this.soinBindingSource;
            this.noSoinComboBox.DisplayMember = "description";
            this.noSoinComboBox.FormattingEnabled = true;
            this.noSoinComboBox.Location = new System.Drawing.Point(162, 154);
            this.noSoinComboBox.Name = "noSoinComboBox";
            this.noSoinComboBox.Size = new System.Drawing.Size(200, 24);
            this.noSoinComboBox.TabIndex = 8;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "client";
            this.clientBindingSource.DataSource = this.b56Projet1Equipe7DataSet;
            // 
            // assistantBindingSource
            // 
            this.assistantBindingSource.DataMember = "assistant";
            this.assistantBindingSource.DataSource = this.b56Projet1Equipe7DataSet;
            // 
            // assistantTableAdapter
            // 
            this.assistantTableAdapter.ClearBeforeFill = true;
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
            // frmAjouterPlanifSoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 271);
            this.Controls.Add(noPersonneLabel);
            this.Controls.Add(this.noPersonneComboBox);
            this.Controls.Add(noAssistantLabel);
            this.Controls.Add(this.noAssistantComboBox);
            this.Controls.Add(dateHeureLabel);
            this.Controls.Add(this.dateHeureDateTimePicker);
            this.Controls.Add(noSoinLabel);
            this.Controls.Add(this.noSoinComboBox);
            this.Controls.Add(this.planifSoinBindingNavigator);
            this.Name = "frmAjouterPlanifSoin";
            this.Text = "frmAjouterPlanifSoin";
            this.Load += new System.EventHandler(this.frmAjouterPlanifSoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.b56Projet1Equipe7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planifSoinBindingNavigator)).EndInit();
            this.planifSoinBindingNavigator.ResumeLayout(false);
            this.planifSoinBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inviteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assistantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soinBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private B56Projet1Equipe7DataSet b56Projet1Equipe7DataSet;
        private System.Windows.Forms.BindingSource planifSoinBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.planifSoinTableAdapter planifSoinTableAdapter;
        private B56Projet1Equipe7DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator planifSoinBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton planifSoinBindingNavigatorSaveItem;
        private System.Windows.Forms.ComboBox noPersonneComboBox;
        private System.Windows.Forms.ComboBox noAssistantComboBox;
        private System.Windows.Forms.DateTimePicker dateHeureDateTimePicker;
        private System.Windows.Forms.ComboBox noSoinComboBox;
        private B56Projet1Equipe7DataSetTableAdapters.clientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.inviteTableAdapter inviteTableAdapter;
        private System.Windows.Forms.BindingSource inviteBindingSource;
        private System.Windows.Forms.BindingSource assistantBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.assistantTableAdapter assistantTableAdapter;
        private System.Windows.Forms.BindingSource soinBindingSource;
        private B56Projet1Equipe7DataSetTableAdapters.soinTableAdapter soinTableAdapter;
    }
}