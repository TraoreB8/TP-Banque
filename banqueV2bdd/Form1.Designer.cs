﻿namespace banqueV2bdd
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crediterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.découvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnQuitter = new System.Windows.Forms.Button();
            this.tbSaisie = new System.Windows.Forms.TextBox();
            this.listBanque = new System.Windows.Forms.ListBox();
            this.lbMontant = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationToolStripMenuItem,
            this.modificationToolStripMenuItem,
            this.ouvrirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crediterToolStripMenuItem,
            this.debiterToolStripMenuItem});
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.operationToolStripMenuItem.Text = "Operation";
            // 
            // crediterToolStripMenuItem
            // 
            this.crediterToolStripMenuItem.Name = "crediterToolStripMenuItem";
            this.crediterToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.crediterToolStripMenuItem.Text = "Crediter";
            // 
            // debiterToolStripMenuItem
            // 
            this.debiterToolStripMenuItem.Name = "debiterToolStripMenuItem";
            this.debiterToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.debiterToolStripMenuItem.Text = "Debiter";
            // 
            // modificationToolStripMenuItem
            // 
            this.modificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.découvertToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            this.modificationToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.modificationToolStripMenuItem.Text = "Modification";
            // 
            // découvertToolStripMenuItem
            // 
            this.découvertToolStripMenuItem.Name = "découvertToolStripMenuItem";
            this.découvertToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.découvertToolStripMenuItem.Text = "Découvert";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(326, 412);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 21;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // tbSaisie
            // 
            this.tbSaisie.Location = new System.Drawing.Point(171, 283);
            this.tbSaisie.Name = "tbSaisie";
            this.tbSaisie.Size = new System.Drawing.Size(100, 20);
            this.tbSaisie.TabIndex = 20;
            // 
            // listBanque
            // 
            this.listBanque.FormattingEnabled = true;
            this.listBanque.Location = new System.Drawing.Point(22, 123);
            this.listBanque.Name = "listBanque";
            this.listBanque.Size = new System.Drawing.Size(379, 134);
            this.listBanque.TabIndex = 19;
            this.listBanque.SelectedIndexChanged += new System.EventHandler(this.listBanque_SelectedIndexChanged);
            // 
            // lbMontant
            // 
            this.lbMontant.AutoSize = true;
            this.lbMontant.Location = new System.Drawing.Point(21, 290);
            this.lbMontant.Name = "lbMontant";
            this.lbMontant.Size = new System.Drawing.Size(96, 13);
            this.lbMontant.TabIndex = 18;
            this.lbMontant.Text = "Montant du débit : ";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(186, 321);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 17;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.tbSaisie);
            this.Controls.Add(this.listBanque);
            this.Controls.Add(this.lbMontant);
            this.Controls.Add(this.btnValider);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crediterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem découvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.TextBox tbSaisie;
        private System.Windows.Forms.ListBox listBanque;
        private System.Windows.Forms.Label lbMontant;
        private System.Windows.Forms.Button btnValider;
    }
}

