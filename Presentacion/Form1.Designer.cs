﻿namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.lblGeneral = new System.Windows.Forms.Label();
            this.dgvGeneral = new System.Windows.Forms.DataGridView();
            this.tpCelulares = new System.Windows.Forms.TabPage();
            this.lblCelulares = new System.Windows.Forms.Label();
            this.dgvCelulares = new System.Windows.Forms.DataGridView();
            this.tpTelevisores = new System.Windows.Forms.TabPage();
            this.lblTelevisores = new System.Windows.Forms.Label();
            this.dgvTelevisores = new System.Windows.Forms.DataGridView();
            this.tpMedia = new System.Windows.Forms.TabPage();
            this.lblMedia = new System.Windows.Forms.Label();
            this.dgvMedia = new System.Windows.Forms.DataGridView();
            this.tpAudio = new System.Windows.Forms.TabPage();
            this.dgvAudio = new System.Windows.Forms.DataGridView();
            this.lblAudio = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctbGeneral = new System.Windows.Forms.PictureBox();
            this.pctbCelulares = new System.Windows.Forms.PictureBox();
            this.pctbTelevisores = new System.Windows.Forms.PictureBox();
            this.pctbMedia = new System.Windows.Forms.PictureBox();
            this.pctbAudio = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).BeginInit();
            this.tpCelulares.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCelulares)).BeginInit();
            this.tpTelevisores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelevisores)).BeginInit();
            this.tpMedia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).BeginInit();
            this.tpAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbCelulares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbTelevisores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbAudio)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tpGeneral);
            this.tabControl.Controls.Add(this.tpCelulares);
            this.tabControl.Controls.Add(this.tpTelevisores);
            this.tabControl.Controls.Add(this.tpMedia);
            this.tabControl.Controls.Add(this.tpAudio);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 38);
            this.tabControl.MaximumSize = new System.Drawing.Size(1084, 501);
            this.tabControl.MinimumSize = new System.Drawing.Size(688, 401);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1084, 501);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.pctbGeneral);
            this.tpGeneral.Controls.Add(this.lblGeneral);
            this.tpGeneral.Controls.Add(this.dgvGeneral);
            this.tpGeneral.Location = new System.Drawing.Point(4, 25);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(1076, 472);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // lblGeneral
            // 
            this.lblGeneral.AutoSize = true;
            this.lblGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneral.Location = new System.Drawing.Point(6, 45);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(148, 18);
            this.lblGeneral.TabIndex = 1;
            this.lblGeneral.Text = "Todos los Productos";
            // 
            // dgvGeneral
            // 
            this.dgvGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneral.Location = new System.Drawing.Point(6, 66);
            this.dgvGeneral.MaximumSize = new System.Drawing.Size(701, 401);
            this.dgvGeneral.MinimumSize = new System.Drawing.Size(701, 401);
            this.dgvGeneral.Name = "dgvGeneral";
            this.dgvGeneral.Size = new System.Drawing.Size(701, 401);
            this.dgvGeneral.TabIndex = 0;
            this.dgvGeneral.SelectionChanged += new System.EventHandler(this.dgvGeneral_SelectionChanged);
            // 
            // tpCelulares
            // 
            this.tpCelulares.Controls.Add(this.pctbCelulares);
            this.tpCelulares.Controls.Add(this.lblCelulares);
            this.tpCelulares.Controls.Add(this.dgvCelulares);
            this.tpCelulares.Location = new System.Drawing.Point(4, 25);
            this.tpCelulares.Name = "tpCelulares";
            this.tpCelulares.Padding = new System.Windows.Forms.Padding(3);
            this.tpCelulares.Size = new System.Drawing.Size(1076, 472);
            this.tpCelulares.TabIndex = 1;
            this.tpCelulares.Text = "Celulares";
            this.tpCelulares.UseVisualStyleBackColor = true;
            // 
            // lblCelulares
            // 
            this.lblCelulares.AutoSize = true;
            this.lblCelulares.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelulares.Location = new System.Drawing.Point(7, 47);
            this.lblCelulares.Name = "lblCelulares";
            this.lblCelulares.Size = new System.Drawing.Size(70, 18);
            this.lblCelulares.TabIndex = 1;
            this.lblCelulares.Text = "Celulares";
            // 
            // dgvCelulares
            // 
            this.dgvCelulares.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCelulares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCelulares.Location = new System.Drawing.Point(6, 66);
            this.dgvCelulares.MaximumSize = new System.Drawing.Size(701, 401);
            this.dgvCelulares.MinimumSize = new System.Drawing.Size(701, 401);
            this.dgvCelulares.Name = "dgvCelulares";
            this.dgvCelulares.Size = new System.Drawing.Size(701, 401);
            this.dgvCelulares.TabIndex = 0;
            this.dgvCelulares.SelectionChanged += new System.EventHandler(this.dgvCelulares_SelectionChanged);
            // 
            // tpTelevisores
            // 
            this.tpTelevisores.Controls.Add(this.pctbTelevisores);
            this.tpTelevisores.Controls.Add(this.lblTelevisores);
            this.tpTelevisores.Controls.Add(this.dgvTelevisores);
            this.tpTelevisores.Location = new System.Drawing.Point(4, 25);
            this.tpTelevisores.Name = "tpTelevisores";
            this.tpTelevisores.Size = new System.Drawing.Size(1076, 472);
            this.tpTelevisores.TabIndex = 2;
            this.tpTelevisores.Text = "Televisores";
            this.tpTelevisores.UseVisualStyleBackColor = true;
            // 
            // lblTelevisores
            // 
            this.lblTelevisores.AutoSize = true;
            this.lblTelevisores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelevisores.Location = new System.Drawing.Point(6, 47);
            this.lblTelevisores.Name = "lblTelevisores";
            this.lblTelevisores.Size = new System.Drawing.Size(84, 18);
            this.lblTelevisores.TabIndex = 1;
            this.lblTelevisores.Text = "Televisores";
            // 
            // dgvTelevisores
            // 
            this.dgvTelevisores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTelevisores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelevisores.Location = new System.Drawing.Point(6, 66);
            this.dgvTelevisores.MaximumSize = new System.Drawing.Size(701, 401);
            this.dgvTelevisores.MinimumSize = new System.Drawing.Size(701, 401);
            this.dgvTelevisores.Name = "dgvTelevisores";
            this.dgvTelevisores.Size = new System.Drawing.Size(701, 401);
            this.dgvTelevisores.TabIndex = 0;
            this.dgvTelevisores.SelectionChanged += new System.EventHandler(this.dgvTelevisores_SelectionChanged);
            // 
            // tpMedia
            // 
            this.tpMedia.Controls.Add(this.pctbMedia);
            this.tpMedia.Controls.Add(this.lblMedia);
            this.tpMedia.Controls.Add(this.dgvMedia);
            this.tpMedia.Location = new System.Drawing.Point(4, 25);
            this.tpMedia.Name = "tpMedia";
            this.tpMedia.Size = new System.Drawing.Size(1076, 472);
            this.tpMedia.TabIndex = 3;
            this.tpMedia.Text = "Media";
            this.tpMedia.UseVisualStyleBackColor = true;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(6, 47);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(52, 18);
            this.lblMedia.TabIndex = 1;
            this.lblMedia.Text = " Media";
            // 
            // dgvMedia
            // 
            this.dgvMedia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMedia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedia.Location = new System.Drawing.Point(6, 66);
            this.dgvMedia.MaximumSize = new System.Drawing.Size(701, 401);
            this.dgvMedia.MinimumSize = new System.Drawing.Size(701, 401);
            this.dgvMedia.Name = "dgvMedia";
            this.dgvMedia.Size = new System.Drawing.Size(701, 401);
            this.dgvMedia.TabIndex = 0;
            this.dgvMedia.SelectionChanged += new System.EventHandler(this.dgvMedia_SelectionChanged);
            // 
            // tpAudio
            // 
            this.tpAudio.Controls.Add(this.pctbAudio);
            this.tpAudio.Controls.Add(this.dgvAudio);
            this.tpAudio.Controls.Add(this.lblAudio);
            this.tpAudio.Location = new System.Drawing.Point(4, 25);
            this.tpAudio.Name = "tpAudio";
            this.tpAudio.Size = new System.Drawing.Size(1076, 472);
            this.tpAudio.TabIndex = 4;
            this.tpAudio.Text = "Audio";
            this.tpAudio.UseVisualStyleBackColor = true;
            // 
            // dgvAudio
            // 
            this.dgvAudio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAudio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAudio.Location = new System.Drawing.Point(6, 66);
            this.dgvAudio.MaximumSize = new System.Drawing.Size(701, 401);
            this.dgvAudio.MinimumSize = new System.Drawing.Size(701, 401);
            this.dgvAudio.Name = "dgvAudio";
            this.dgvAudio.Size = new System.Drawing.Size(701, 401);
            this.dgvAudio.TabIndex = 1;
            this.dgvAudio.SelectionChanged += new System.EventHandler(this.dgvAudio_SelectionChanged);
            // 
            // lblAudio
            // 
            this.lblAudio.AutoSize = true;
            this.lblAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAudio.Location = new System.Drawing.Point(6, 47);
            this.lblAudio.Name = "lblAudio";
            this.lblAudio.Size = new System.Drawing.Size(45, 18);
            this.lblAudio.TabIndex = 0;
            this.lblAudio.Text = "Audio";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(120, 22);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Gestor de stock";
            // 
            // pctbGeneral
            // 
            this.pctbGeneral.Location = new System.Drawing.Point(713, 66);
            this.pctbGeneral.Name = "pctbGeneral";
            this.pctbGeneral.Size = new System.Drawing.Size(357, 266);
            this.pctbGeneral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctbGeneral.TabIndex = 2;
            this.pctbGeneral.TabStop = false;
            // 
            // pctbCelulares
            // 
            this.pctbCelulares.Location = new System.Drawing.Point(713, 66);
            this.pctbCelulares.Name = "pctbCelulares";
            this.pctbCelulares.Size = new System.Drawing.Size(357, 266);
            this.pctbCelulares.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctbCelulares.TabIndex = 3;
            this.pctbCelulares.TabStop = false;
            // 
            // pctbTelevisores
            // 
            this.pctbTelevisores.Location = new System.Drawing.Point(713, 66);
            this.pctbTelevisores.Name = "pctbTelevisores";
            this.pctbTelevisores.Size = new System.Drawing.Size(357, 266);
            this.pctbTelevisores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctbTelevisores.TabIndex = 3;
            this.pctbTelevisores.TabStop = false;
            // 
            // pctbMedia
            // 
            this.pctbMedia.Location = new System.Drawing.Point(713, 66);
            this.pctbMedia.Name = "pctbMedia";
            this.pctbMedia.Size = new System.Drawing.Size(357, 266);
            this.pctbMedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctbMedia.TabIndex = 3;
            this.pctbMedia.TabStop = false;
            // 
            // pctbAudio
            // 
            this.pctbAudio.Location = new System.Drawing.Point(713, 66);
            this.pctbAudio.Name = "pctbAudio";
            this.pctbAudio.Size = new System.Drawing.Size(357, 266);
            this.pctbAudio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctbAudio.TabIndex = 3;
            this.pctbAudio.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 591);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1136, 630);
            this.MinimumSize = new System.Drawing.Size(1136, 630);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).EndInit();
            this.tpCelulares.ResumeLayout(false);
            this.tpCelulares.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCelulares)).EndInit();
            this.tpTelevisores.ResumeLayout(false);
            this.tpTelevisores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelevisores)).EndInit();
            this.tpMedia.ResumeLayout(false);
            this.tpMedia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedia)).EndInit();
            this.tpAudio.ResumeLayout(false);
            this.tpAudio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbCelulares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbTelevisores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbAudio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.TabPage tpCelulares;
        private System.Windows.Forms.TabPage tpTelevisores;
        private System.Windows.Forms.TabPage tpMedia;
        private System.Windows.Forms.TabPage tpAudio;
        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblGeneral;
        private System.Windows.Forms.DataGridView dgvGeneral;
        private System.Windows.Forms.DataGridView dgvCelulares;
        private System.Windows.Forms.Label lblCelulares;
        private System.Windows.Forms.DataGridView dgvTelevisores;
        private System.Windows.Forms.Label lblTelevisores;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.DataGridView dgvMedia;
        private System.Windows.Forms.DataGridView dgvAudio;
        private System.Windows.Forms.Label lblAudio;
        private System.Windows.Forms.PictureBox pctbGeneral;
        private System.Windows.Forms.PictureBox pctbCelulares;
        private System.Windows.Forms.PictureBox pctbTelevisores;
        private System.Windows.Forms.PictureBox pctbMedia;
        private System.Windows.Forms.PictureBox pctbAudio;
    }
}

