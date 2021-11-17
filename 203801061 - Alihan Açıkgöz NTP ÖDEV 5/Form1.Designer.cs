
namespace Ntp4
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.textboxAdi = new System.Windows.Forms.TextBox();
            this.textboxSoyadi = new System.Windows.Forms.TextBox();
            this.buttonBasla = new System.Windows.Forms.Button();
            this.radioOrta = new System.Windows.Forms.RadioButton();
            this.radioKolay = new System.Windows.Forms.RadioButton();
            this.radioZor = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBaslik.Cursor = System.Windows.Forms.Cursors.No;
            this.lblBaslik.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(34, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(302, 37);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Buton Yakalama Oyunu";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdi.Location = new System.Drawing.Point(55, 97);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(46, 20);
            this.lblAdi.TabIndex = 1;
            this.lblAdi.Text = "Adınız";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyadi.Location = new System.Drawing.Point(33, 134);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(68, 20);
            this.lblSoyadi.TabIndex = 2;
            this.lblSoyadi.Text = "Soyadınız";
            // 
            // textboxAdi
            // 
            this.textboxAdi.Location = new System.Drawing.Point(107, 97);
            this.textboxAdi.Name = "textboxAdi";
            this.textboxAdi.Size = new System.Drawing.Size(111, 20);
            this.textboxAdi.TabIndex = 3;
            // 
            // textboxSoyadi
            // 
            this.textboxSoyadi.Location = new System.Drawing.Point(107, 136);
            this.textboxSoyadi.Name = "textboxSoyadi";
            this.textboxSoyadi.Size = new System.Drawing.Size(111, 20);
            this.textboxSoyadi.TabIndex = 4;
            // 
            // buttonBasla
            // 
            this.buttonBasla.BackColor = System.Drawing.Color.Red;
            this.buttonBasla.ForeColor = System.Drawing.Color.Black;
            this.buttonBasla.Location = new System.Drawing.Point(120, 228);
            this.buttonBasla.Name = "buttonBasla";
            this.buttonBasla.Size = new System.Drawing.Size(108, 36);
            this.buttonBasla.TabIndex = 5;
            this.buttonBasla.Text = "Oyuna Başla";
            this.buttonBasla.UseVisualStyleBackColor = false;
            this.buttonBasla.Click += new System.EventHandler(this.buttonBasla_Click);
            // 
            // radioOrta
            // 
            this.radioOrta.AutoSize = true;
            this.radioOrta.Location = new System.Drawing.Point(138, 193);
            this.radioOrta.Name = "radioOrta";
            this.radioOrta.Size = new System.Drawing.Size(80, 17);
            this.radioOrta.TabIndex = 6;
            this.radioOrta.TabStop = true;
            this.radioOrta.Text = "Orta Seviye";
            this.radioOrta.UseVisualStyleBackColor = true;
            this.radioOrta.CheckedChanged += new System.EventHandler(this.radioOrta_CheckedChanged);
            // 
            // radioKolay
            // 
            this.radioKolay.AutoSize = true;
            this.radioKolay.Location = new System.Drawing.Point(37, 193);
            this.radioKolay.Name = "radioKolay";
            this.radioKolay.Size = new System.Drawing.Size(86, 17);
            this.radioKolay.TabIndex = 6;
            this.radioKolay.TabStop = true;
            this.radioKolay.Text = "Kolay Seviye";
            this.radioKolay.UseVisualStyleBackColor = true;
            this.radioKolay.CheckedChanged += new System.EventHandler(this.radioKolay_CheckedChanged);
            // 
            // radioZor
            // 
            this.radioZor.AutoSize = true;
            this.radioZor.Location = new System.Drawing.Point(239, 193);
            this.radioZor.Name = "radioZor";
            this.radioZor.Size = new System.Drawing.Size(76, 17);
            this.radioZor.TabIndex = 7;
            this.radioZor.TabStop = true;
            this.radioZor.Text = "Zor Seviye";
            this.radioZor.UseVisualStyleBackColor = true;
            this.radioZor.CheckedChanged += new System.EventHandler(this.radioZor_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(361, 292);
            this.Controls.Add(this.radioZor);
            this.Controls.Add(this.radioKolay);
            this.Controls.Add(this.radioOrta);
            this.Controls.Add(this.buttonBasla);
            this.Controls.Add(this.textboxSoyadi);
            this.Controls.Add(this.textboxAdi);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.lblBaslik);
            this.Name = "Form1";
            this.Text = "Oyuna Giriş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.TextBox textboxAdi;
        private System.Windows.Forms.TextBox textboxSoyadi;
        private System.Windows.Forms.RadioButton radioOrta;
        private System.Windows.Forms.RadioButton radioZor;
        public System.Windows.Forms.RadioButton radioKolay;
        public System.Windows.Forms.Button buttonBasla;
    }
}

