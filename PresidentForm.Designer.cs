namespace EtkinlikOtomasyonSistemi
{
    partial class PresidentForm
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
            dgvKulupEtkinlikleri = new DataGridView();
            btnCreate = new Button();
            txtEventName = new TextBox();
            txtEventTime = new TextBox();
            txtEventLocation = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKulupEtkinlikleri).BeginInit();
            SuspendLayout();
            // 
            // dgvKulupEtkinlikleri
            // 
            dgvKulupEtkinlikleri.BackgroundColor = Color.Linen;
            dgvKulupEtkinlikleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKulupEtkinlikleri.Location = new Point(12, 140);
            dgvKulupEtkinlikleri.Name = "dgvKulupEtkinlikleri";
            dgvKulupEtkinlikleri.RowHeadersWidth = 51;
            dgvKulupEtkinlikleri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKulupEtkinlikleri.Size = new Size(760, 290);
            dgvKulupEtkinlikleri.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(340, 20);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(130, 107);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Etkinlik Oluştur";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // txtEventName
            // 
            txtEventName.Location = new Point(120, 20);
            txtEventName.Name = "txtEventName";
            txtEventName.Size = new Size(200, 27);
            txtEventName.TabIndex = 2;
            // 
            // txtEventTime
            // 
            txtEventTime.Location = new Point(120, 60);
            txtEventTime.Name = "txtEventTime";
            txtEventTime.Size = new Size(200, 27);
            txtEventTime.TabIndex = 3;
            // 
            // txtEventLocation
            // 
            txtEventLocation.Location = new Point(120, 100);
            txtEventLocation.Name = "txtEventLocation";
            txtEventLocation.Size = new Size(200, 27);
            txtEventLocation.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 5;
            label1.Text = "Etkinlik Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RosyBrown;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 6;
            label2.Text = "Saat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RosyBrown;
            label3.Location = new Point(12, 103);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 7;
            label3.Text = "Yer:";
            // 
            // 
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEventLocation);
            Controls.Add(txtEventTime);
            Controls.Add(txtEventName);
            Controls.Add(btnCreate);
            Controls.Add(dgvKulupEtkinlikleri);
            ForeColor = SystemColors.ControlText;
            Name = "PresidentForm";
            Text = "Kulüp Başkanı Paneli";
            ((System.ComponentModel.ISupportInitialize)dgvKulupEtkinlikleri).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKulupEtkinlikleri;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtEventTime;
        private System.Windows.Forms.TextBox txtEventLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
