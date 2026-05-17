using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace EtkinlikOtomasyonSistemi
{
    partial class AdminForm
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
            dgvOgrenciler = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).BeginInit();
            SuspendLayout();
           


            dgvOgrenciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvOgrenciler.BackgroundColor = Color.Linen;
            dgvOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciler.Location = new Point(43, 31);
            dgvOgrenciler.Name = "dgvOgrenciler";
            dgvOgrenciler.RowHeadersWidth = 51;
            dgvOgrenciler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgrenciler.Size = new Size(729, 371);
            dgvOgrenciler.TabIndex = 0;
           


            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvOgrenciler);
            Name = "AdminForm";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOgrenciler;
    }
}