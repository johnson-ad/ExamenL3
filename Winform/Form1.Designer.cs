
namespace Winform
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
            this.btnSelecte = new System.Windows.Forms.Button();
            this.btnRecherche = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDenominationProduit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDProduit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgProduit = new System.Windows.Forms.DataGridView();
            this.txtCategorieProduit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQteProduit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPUProduit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelecte
            // 
            this.btnSelecte.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSelecte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecte.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSelecte.Location = new System.Drawing.Point(176, 19);
            this.btnSelecte.Name = "btnSelecte";
            this.btnSelecte.Size = new System.Drawing.Size(75, 23);
            this.btnSelecte.TabIndex = 19;
            this.btnSelecte.Text = "S&elect";
            this.btnSelecte.UseVisualStyleBackColor = false;
            this.btnSelecte.Click += new System.EventHandler(this.btnSelecte_Click);
            // 
            // btnRecherche
            // 
            this.btnRecherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecherche.Location = new System.Drawing.Point(23, 471);
            this.btnRecherche.Name = "btnRecherche";
            this.btnRecherche.Size = new System.Drawing.Size(75, 23);
            this.btnRecherche.TabIndex = 18;
            this.btnRecherche.Text = "&Find";
            this.btnRecherche.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(176, 471);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Yellow;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(176, 409);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(23, 409);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDenominationProduit
            // 
            this.txtDenominationProduit.Location = new System.Drawing.Point(12, 137);
            this.txtDenominationProduit.Name = "txtDenominationProduit";
            this.txtDenominationProduit.Size = new System.Drawing.Size(239, 20);
            this.txtDenominationProduit.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Denomination Produit";
            // 
            // txtIDProduit
            // 
            this.txtIDProduit.Location = new System.Drawing.Point(12, 57);
            this.txtIDProduit.Name = "txtIDProduit";
            this.txtIDProduit.Size = new System.Drawing.Size(239, 20);
            this.txtIDProduit.TabIndex = 12;
            this.txtIDProduit.TextChanged += new System.EventHandler(this.txtIDProduit_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID Pr&oduit";
            // 
            // DgProduit
            // 
            this.DgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProduit.Location = new System.Drawing.Point(313, 19);
            this.DgProduit.Name = "DgProduit";
            this.DgProduit.Size = new System.Drawing.Size(478, 475);
            this.DgProduit.TabIndex = 10;
            // 
            // txtCategorieProduit
            // 
            this.txtCategorieProduit.Location = new System.Drawing.Point(12, 200);
            this.txtCategorieProduit.Name = "txtCategorieProduit";
            this.txtCategorieProduit.Size = new System.Drawing.Size(239, 20);
            this.txtCategorieProduit.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Categorie Produit";
            // 
            // txtQteProduit
            // 
            this.txtQteProduit.Location = new System.Drawing.Point(12, 266);
            this.txtQteProduit.Name = "txtQteProduit";
            this.txtQteProduit.Size = new System.Drawing.Size(239, 20);
            this.txtQteProduit.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantite Produit";
            // 
            // txtPUProduit
            // 
            this.txtPUProduit.Location = new System.Drawing.Point(12, 338);
            this.txtPUProduit.Name = "txtPUProduit";
            this.txtPUProduit.Size = new System.Drawing.Size(239, 20);
            this.txtPUProduit.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "PU Produit";
            // 
            // btnExist
            // 
            this.btnExist.BackColor = System.Drawing.Color.Crimson;
            this.btnExist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExist.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExist.Location = new System.Drawing.Point(713, 500);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(75, 23);
            this.btnExist.TabIndex = 26;
            this.btnExist.Text = "Exist";
            this.btnExist.UseVisualStyleBackColor = false;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.ControlBox = false;
            this.Controls.Add(this.btnExist);
            this.Controls.Add(this.txtPUProduit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQteProduit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCategorieProduit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelecte);
            this.Controls.Add(this.btnRecherche);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDenominationProduit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDProduit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgProduit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelecte;
        private System.Windows.Forms.Button btnRecherche;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDenominationProduit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgProduit;
        private System.Windows.Forms.TextBox txtCategorieProduit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQteProduit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPUProduit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExist;
    }
}

