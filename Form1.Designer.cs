namespace EtkinlikOtomasyonSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGirisYap = new Button();
            btnKaydol = new Button();
            label1 = new Label();
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            label3 = new Label();
            txtSifre = new TextBox();
            label4 = new Label();
            SuspendLayout();
            

            btnGirisYap.BackColor = SystemColors.ScrollBar;
            btnGirisYap.Location = new Point(153, 256);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(173, 29);
            btnGirisYap.TabIndex = 0;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = false;
          
            
            btnKaydol.BackColor = Color.RosyBrown;
            btnKaydol.Location = new Point(553, 332);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(173, 29);
            btnKaydol.TabIndex = 1;
            btnKaydol.Text = "Kayıt Ol";
            btnKaydol.UseVisualStyleBackColor = false;
           

            label1.AutoSize = true;
            label1.Location = new Point(31, 123);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı :";
            

            label2.AutoSize = true;
            label2.Location = new Point(82, 179);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Şifre :";
            

            txtKullaniciAdi.Location = new Point(134, 123);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(192, 27);
            txtKullaniciAdi.TabIndex = 4;
            txtKullaniciAdi.TextChanged += txtKullaniciAdi_TextChanged;
            

            label3.AutoSize = true;
            label3.BackColor = Color.MistyRose;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 52);
            label3.Name = "label3";
            label3.Size = new Size(671, 34);
            label3.TabIndex = 5;
            label3.Text = "ETKİNLİK KATILIM MERKEZİNE HOŞGELDİNİZ";
            

            txtSifre.Location = new Point(134, 179);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(192, 27);
            txtSifre.TabIndex = 6;
           

            label4.AutoSize = true;
            label4.BackColor = Color.Snow;
            label4.Font = new Font("Sitka Heading", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label4.Location = new Point(367, 296);
            label4.Name = "label4";
            label4.Size = new Size(155, 26);
            label4.TabIndex = 7;
            label4.Text = "Hesabın yok mu ?!";
           
            
         
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtSifre);
            Controls.Add(label3);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKaydol);
            Controls.Add(btnGirisYap);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGirisYap;
        private Button btnKaydol;
        private Label label1;
        private Label label2;
        private TextBox txtKullaniciAdi;
        private Label label3;
        private TextBox txtSifre;
        private Label label4;
    }
}
