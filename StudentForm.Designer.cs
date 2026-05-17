using System;
using System.Drawing;
using System.Linq;
namespace EtkinlikOtomasyonSistemi
{
    partial class StudentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvKatildigimEtkinlikler = new DataGridView();
            dgvTumEtkinlikler = new DataGridView();
            btnKatil = new Button();
            label1 = new Label();
            label2 = new Label();
            btnAyril = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKatildigimEtkinlikler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTumEtkinlikler).BeginInit();
            SuspendLayout();
          

            dgvKatildigimEtkinlikler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvKatildigimEtkinlikler.BackgroundColor = Color.Linen;
            dgvKatildigimEtkinlikler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKatildigimEtkinlikler.Location = new Point(12, 32);
            dgvKatildigimEtkinlikler.Name = "dgvKatildigimEtkinlikler";
            dgvKatildigimEtkinlikler.RowHeadersWidth = 51;
            dgvKatildigimEtkinlikler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKatildigimEtkinlikler.Size = new Size(750, 150);
            dgvKatildigimEtkinlikler.TabIndex = 0;
           

            dgvTumEtkinlikler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTumEtkinlikler.BackgroundColor = Color.Linen;
            dgvTumEtkinlikler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTumEtkinlikler.Location = new Point(12, 242);
            dgvTumEtkinlikler.Name = "dgvTumEtkinlikler";
            dgvTumEtkinlikler.RowHeadersWidth = 51;
            dgvTumEtkinlikler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTumEtkinlikler.Size = new Size(750, 150);
            dgvTumEtkinlikler.TabIndex = 1;
            

            btnKatil.BackColor = Color.RosyBrown;
            btnKatil.Location = new Point(292, 398);
            btnKatil.Name = "btnKatil";
            btnKatil.Size = new Size(165, 40);
            btnKatil.TabIndex = 2;
            btnKatil.Text = "Seçili Etkinliğe Katıl";
            btnKatil.UseVisualStyleBackColor = false;
           


            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 3;
            label1.Text = "Katıldığım Etkinlikler";
            


            label2.AutoSize = true;
            label2.Location = new Point(12, 195);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 4;
            label2.Text = "Tüm Etkinlikler";
          


            btnAyril.BackColor = Color.RosyBrown;
            btnAyril.Location = new Point(292, 195);
            btnAyril.Name = "btnAyril";
            btnAyril.Size = new Size(165, 29);
            btnAyril.TabIndex = 5;
            btnAyril.Text = "Seçili Etkinlikten Ayrıl";
            btnAyril.UseVisualStyleBackColor = false;
          


            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAyril);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKatil);
            Controls.Add(dgvTumEtkinlikler);
            Controls.Add(dgvKatildigimEtkinlikler);
            Name = "StudentForm";
            Text = "Öğrenci Paneli";
            ((System.ComponentModel.ISupportInitialize)dgvKatildigimEtkinlikler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTumEtkinlikler).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKatildigimEtkinlikler;
        private System.Windows.Forms.DataGridView dgvTumEtkinlikler;
        private System.Windows.Forms.Button btnKatil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Button btnAyril;
    }
}