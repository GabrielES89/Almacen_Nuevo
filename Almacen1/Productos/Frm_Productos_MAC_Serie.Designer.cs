﻿namespace Almacen1.Productos
{
    partial class Frm_Productos_MAC_Serie
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
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.PanelDGV = new System.Windows.Forms.Panel();
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.btnAgregarSerie = new System.Windows.Forms.Button();
            this.btnAgregarMAC = new System.Windows.Forms.Button();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.lblMAC = new System.Windows.Forms.Label();
            this.PanelSerie = new System.Windows.Forms.Panel();
            this.PanelMAC = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.PanelDGV.SuspendLayout();
            this.PanelSerie.SuspendLayout();
            this.PanelMAC.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV1
            // 
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV1.Location = new System.Drawing.Point(0, 0);
            this.DGV1.Name = "DGV1";
            this.DGV1.Size = new System.Drawing.Size(617, 450);
            this.DGV1.TabIndex = 0;
            // 
            // PanelDGV
            // 
            this.PanelDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDGV.Controls.Add(this.DGV1);
            this.PanelDGV.Location = new System.Drawing.Point(183, 0);
            this.PanelDGV.Name = "PanelDGV";
            this.PanelDGV.Size = new System.Drawing.Size(617, 450);
            this.PanelDGV.TabIndex = 1;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(76, 19);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(50, 22);
            this.lblSerie.TabIndex = 2;
            this.lblSerie.Text = "Serie";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(50, 44);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 20);
            this.txtSerie.TabIndex = 3;
            // 
            // btnAgregarSerie
            // 
            this.btnAgregarSerie.FlatAppearance.BorderSize = 0;
            this.btnAgregarSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSerie.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAgregarSerie.Location = new System.Drawing.Point(33, 70);
            this.btnAgregarSerie.Name = "btnAgregarSerie";
            this.btnAgregarSerie.Size = new System.Drawing.Size(135, 36);
            this.btnAgregarSerie.TabIndex = 4;
            this.btnAgregarSerie.Text = "Agregar Serie";
            this.btnAgregarSerie.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMAC
            // 
            this.btnAgregarMAC.FlatAppearance.BorderSize = 0;
            this.btnAgregarMAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMAC.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAgregarMAC.Location = new System.Drawing.Point(33, 57);
            this.btnAgregarMAC.Name = "btnAgregarMAC";
            this.btnAgregarMAC.Size = new System.Drawing.Size(135, 36);
            this.btnAgregarMAC.TabIndex = 7;
            this.btnAgregarMAC.Text = "Agregar MAC";
            this.btnAgregarMAC.UseVisualStyleBackColor = true;
            // 
            // txtMAC
            // 
            this.txtMAC.Location = new System.Drawing.Point(50, 31);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.Size = new System.Drawing.Size(100, 20);
            this.txtMAC.TabIndex = 6;
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAC.Location = new System.Drawing.Point(76, 6);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(53, 22);
            this.lblMAC.TabIndex = 5;
            this.lblMAC.Text = "MAC";
            // 
            // PanelSerie
            // 
            this.PanelSerie.Controls.Add(this.txtSerie);
            this.PanelSerie.Controls.Add(this.lblSerie);
            this.PanelSerie.Controls.Add(this.btnAgregarSerie);
            this.PanelSerie.Location = new System.Drawing.Point(-3, 0);
            this.PanelSerie.Name = "PanelSerie";
            this.PanelSerie.Size = new System.Drawing.Size(180, 123);
            this.PanelSerie.TabIndex = 8;
            // 
            // PanelMAC
            // 
            this.PanelMAC.Controls.Add(this.lblMAC);
            this.PanelMAC.Controls.Add(this.txtMAC);
            this.PanelMAC.Controls.Add(this.btnAgregarMAC);
            this.PanelMAC.Location = new System.Drawing.Point(-3, 138);
            this.PanelMAC.Name = "PanelMAC";
            this.PanelMAC.Size = new System.Drawing.Size(180, 104);
            this.PanelMAC.TabIndex = 9;
            // 
            // Frm_Productos_MAC_Serie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelMAC);
            this.Controls.Add(this.PanelSerie);
            this.Controls.Add(this.PanelDGV);
            this.Name = "Frm_Productos_MAC_Serie";
            this.Load += new System.EventHandler(this.Frm_Productos_MAC_Serie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.PanelDGV.ResumeLayout(false);
            this.PanelSerie.ResumeLayout(false);
            this.PanelSerie.PerformLayout();
            this.PanelMAC.ResumeLayout(false);
            this.PanelMAC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Panel PanelDGV;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Button btnAgregarSerie;
        private System.Windows.Forms.Button btnAgregarMAC;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Label lblMAC;
        private System.Windows.Forms.Panel PanelSerie;
        private System.Windows.Forms.Panel PanelMAC;
    }
}