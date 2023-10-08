﻿namespace Projet1.Prepose.GestionClientsInvites
{
    partial class frmModifierInvite
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label nomPrenomLabel;
            System.Windows.Forms.Label noClientLabel;
            this.tbNoInvite = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbNoClient = new System.Windows.Forms.TextBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            label2 = new System.Windows.Forms.Label();
            nomPrenomLabel = new System.Windows.Forms.Label();
            noClientLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(23, 68);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(100, 15);
            label2.TabIndex = 37;
            label2.Text = "Numéro invité:";
            // 
            // tbNoInvite
            // 
            this.tbNoInvite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoInvite.Location = new System.Drawing.Point(137, 64);
            this.tbNoInvite.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoInvite.Name = "tbNoInvite";
            this.tbNoInvite.ReadOnly = true;
            this.tbNoInvite.Size = new System.Drawing.Size(146, 21);
            this.tbNoInvite.TabIndex = 38;
            // 
            // nomPrenomLabel
            // 
            nomPrenomLabel.AutoSize = true;
            nomPrenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            nomPrenomLabel.Location = new System.Drawing.Point(23, 91);
            nomPrenomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomPrenomLabel.Name = "nomPrenomLabel";
            nomPrenomLabel.Size = new System.Drawing.Size(110, 15);
            nomPrenomLabel.TabIndex = 33;
            nomPrenomLabel.Text = "Nom et prénom:";
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(137, 87);
            this.tbNom.Margin = new System.Windows.Forms.Padding(2);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(146, 21);
            this.tbNom.TabIndex = 34;
            // 
            // noClientLabel
            // 
            noClientLabel.AutoSize = true;
            noClientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            noClientLabel.Location = new System.Drawing.Point(23, 114);
            noClientLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noClientLabel.Name = "noClientLabel";
            noClientLabel.Size = new System.Drawing.Size(101, 15);
            noClientLabel.TabIndex = 35;
            noClientLabel.Text = "Numéro client:";
            // 
            // tbNoClient
            // 
            this.tbNoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoClient.Location = new System.Drawing.Point(137, 110);
            this.tbNoClient.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoClient.Name = "tbNoClient";
            this.tbNoClient.ReadOnly = true;
            this.tbNoClient.Size = new System.Drawing.Size(146, 21);
            this.tbNoClient.TabIndex = 36;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.ForeColor = System.Drawing.Color.Black;
            this.btnAnnuler.Location = new System.Drawing.Point(167, 149);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(101, 32);
            this.btnAnnuler.TabIndex = 32;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.PaleGreen;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.Black;
            this.btnModifier.Location = new System.Drawing.Point(39, 149);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(101, 32);
            this.btnModifier.TabIndex = 31;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(85, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Modifier invité";
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmModifierInvite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 203);
            this.Controls.Add(label2);
            this.Controls.Add(this.tbNoInvite);
            this.Controls.Add(nomPrenomLabel);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(noClientLabel);
            this.Controls.Add(this.tbNoClient);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.label1);
            this.Name = "frmModifierInvite";
            this.Text = "Modification de l\'invité";
            this.Load += new System.EventHandler(this.frmModifierInvite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNoInvite;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbNoClient;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}