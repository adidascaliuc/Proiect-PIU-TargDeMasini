﻿namespace TargDeMasiniForm
{
    partial class OptiuneCautaForm
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
            this.dataGridAfisare = new System.Windows.Forms.DataGridView();
            this.pictureDeconectare = new System.Windows.Forms.PictureBox();
            this.lblFirma = new MetroFramework.Controls.MetroLabel();
            this.lblModel = new MetroFramework.Controls.MetroLabel();
            this.lblDeconectare = new MetroFramework.Controls.MetroLabel();
            this.txtFirma = new MetroFramework.Controls.MetroTextBox();
            this.txtModel = new MetroFramework.Controls.MetroTextBox();
            this.btnCauta = new MetroFramework.Controls.MetroButton();
            this.panelMeniu = new System.Windows.Forms.Panel();
            this.pictureInfo = new System.Windows.Forms.PictureBox();
            this.pctModifica = new System.Windows.Forms.PictureBox();
            this.pctCauta = new System.Windows.Forms.PictureBox();
            this.pctAdauga = new System.Windows.Forms.PictureBox();
            this.pctAfiseaza = new System.Windows.Forms.PictureBox();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnCautare = new System.Windows.Forms.Button();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfisare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeconectare)).BeginInit();
            this.panelMeniu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctModifica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCauta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdauga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAfiseaza)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAfisare
            // 
            this.dataGridAfisare.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridAfisare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAfisare.Location = new System.Drawing.Point(75, 65);
            this.dataGridAfisare.Name = "dataGridAfisare";
            this.dataGridAfisare.Size = new System.Drawing.Size(839, 350);
            this.dataGridAfisare.TabIndex = 55;
            // 
            // pictureDeconectare
            // 
            this.pictureDeconectare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureDeconectare.Image = global::TargDeMasiniForm.Properties.Resources.logOutPng;
            this.pictureDeconectare.Location = new System.Drawing.Point(880, 6);
            this.pictureDeconectare.Name = "pictureDeconectare";
            this.pictureDeconectare.Size = new System.Drawing.Size(23, 21);
            this.pictureDeconectare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDeconectare.TabIndex = 71;
            this.pictureDeconectare.TabStop = false;
            this.pictureDeconectare.Click += new System.EventHandler(this.pictureDeconectare_Click);
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(130, 13);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(46, 19);
            this.lblFirma.TabIndex = 72;
            this.lblFirma.Text = "Firma:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(130, 38);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(50, 19);
            this.lblModel.TabIndex = 73;
            this.lblModel.Text = "Model:";
            // 
            // lblDeconectare
            // 
            this.lblDeconectare.AutoSize = true;
            this.lblDeconectare.Location = new System.Drawing.Point(783, 8);
            this.lblDeconectare.Name = "lblDeconectare";
            this.lblDeconectare.Size = new System.Drawing.Size(82, 19);
            this.lblDeconectare.TabIndex = 74;
            this.lblDeconectare.Text = "Deconectare";
            this.lblDeconectare.Click += new System.EventHandler(this.lblDeconectare_Click);
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(267, 10);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(221, 23);
            this.txtFirma.TabIndex = 75;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(267, 39);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(221, 23);
            this.txtModel.TabIndex = 76;
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(524, 17);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 34);
            this.btnCauta.TabIndex = 77;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // panelMeniu
            // 
            this.panelMeniu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelMeniu.Controls.Add(this.pictureInfo);
            this.panelMeniu.Controls.Add(this.pctModifica);
            this.panelMeniu.Controls.Add(this.pctCauta);
            this.panelMeniu.Controls.Add(this.pctAdauga);
            this.panelMeniu.Controls.Add(this.pctAfiseaza);
            this.panelMeniu.Location = new System.Drawing.Point(0, -6);
            this.panelMeniu.Name = "panelMeniu";
            this.panelMeniu.Size = new System.Drawing.Size(75, 424);
            this.panelMeniu.TabIndex = 80;
            // 
            // pictureInfo
            // 
            this.pictureInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureInfo.Image = global::TargDeMasiniForm.Properties.Resources.infoPng;
            this.pictureInfo.Location = new System.Drawing.Point(5, 353);
            this.pictureInfo.Name = "pictureInfo";
            this.pictureInfo.Size = new System.Drawing.Size(55, 43);
            this.pictureInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureInfo.TabIndex = 4;
            this.pictureInfo.TabStop = false;
            this.pictureInfo.Click += new System.EventHandler(this.pictureInfo_Click);
            // 
            // pctModifica
            // 
            this.pctModifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctModifica.Image = global::TargDeMasiniForm.Properties.Resources.editPng;
            this.pctModifica.Location = new System.Drawing.Point(12, 278);
            this.pctModifica.Name = "pctModifica";
            this.pctModifica.Size = new System.Drawing.Size(46, 39);
            this.pctModifica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctModifica.TabIndex = 3;
            this.pctModifica.TabStop = false;
            this.pctModifica.Click += new System.EventHandler(this.pctModifica_Click);
            // 
            // pctCauta
            // 
            this.pctCauta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctCauta.Image = global::TargDeMasiniForm.Properties.Resources.searchPng;
            this.pctCauta.Location = new System.Drawing.Point(3, 183);
            this.pctCauta.Name = "pctCauta";
            this.pctCauta.Size = new System.Drawing.Size(55, 45);
            this.pctCauta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCauta.TabIndex = 2;
            this.pctCauta.TabStop = false;
            this.pctCauta.Click += new System.EventHandler(this.pctCauta_Click);
            // 
            // pctAdauga
            // 
            this.pctAdauga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctAdauga.Image = global::TargDeMasiniForm.Properties.Resources.addPng;
            this.pctAdauga.Location = new System.Drawing.Point(12, 19);
            this.pctAdauga.Name = "pctAdauga";
            this.pctAdauga.Size = new System.Drawing.Size(46, 43);
            this.pctAdauga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAdauga.TabIndex = 1;
            this.pctAdauga.TabStop = false;
            this.pctAdauga.Click += new System.EventHandler(this.pctAdauga_Click);
            // 
            // pctAfiseaza
            // 
            this.pctAfiseaza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctAfiseaza.Image = global::TargDeMasiniForm.Properties.Resources.listPng;
            this.pctAfiseaza.Location = new System.Drawing.Point(12, 96);
            this.pctAfiseaza.Name = "pctAfiseaza";
            this.pctAfiseaza.Size = new System.Drawing.Size(46, 48);
            this.pctAfiseaza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAfiseaza.TabIndex = 0;
            this.pctAfiseaza.TabStop = false;
            this.pctAfiseaza.Click += new System.EventHandler(this.pctAfiseaza_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(0, 0);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(75, 23);
            this.btnModificare.TabIndex = 81;
            // 
            // btnCautare
            // 
            this.btnCautare.Location = new System.Drawing.Point(0, 0);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(75, 23);
            this.btnCautare.TabIndex = 83;
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(0, 0);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(75, 23);
            this.btnAfisare.TabIndex = 82;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(0, 0);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 84;
            // 
            // OptiuneCautaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 411);
            this.Controls.Add(this.panelMeniu);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtFirma);
            this.Controls.Add(this.lblDeconectare);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblFirma);
            this.Controls.Add(this.pictureDeconectare);
            this.Controls.Add(this.dataGridAfisare);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OptiuneCautaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Car Shop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAfisare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeconectare)).EndInit();
            this.panelMeniu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctModifica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCauta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAdauga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAfiseaza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridAfisare;
        private System.Windows.Forms.PictureBox pictureDeconectare;
        private MetroFramework.Controls.MetroLabel lblFirma;
        private MetroFramework.Controls.MetroLabel lblModel;
        private MetroFramework.Controls.MetroLabel lblDeconectare;
        private MetroFramework.Controls.MetroTextBox txtFirma;
        private MetroFramework.Controls.MetroTextBox txtModel;
        private MetroFramework.Controls.MetroButton btnCauta;
        private System.Windows.Forms.Panel panelMeniu;
        private System.Windows.Forms.PictureBox pictureInfo;
        private System.Windows.Forms.PictureBox pctModifica;
        private System.Windows.Forms.PictureBox pctCauta;
        private System.Windows.Forms.PictureBox pctAdauga;
        private System.Windows.Forms.PictureBox pctAfiseaza;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.Button btnAdauga;
    }
}