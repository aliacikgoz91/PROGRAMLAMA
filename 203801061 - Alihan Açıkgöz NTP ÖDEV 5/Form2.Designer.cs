
namespace Ntp4
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.pnlSkor = new System.Windows.Forms.Panel();
            this.btnBasla = new System.Windows.Forms.Button();
            this.lblSayac = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.lblVeriCek = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlSkor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSkor
            // 
            this.pnlSkor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSkor.BackColor = System.Drawing.Color.RoyalBlue;
            this.pnlSkor.Controls.Add(this.btnBasla);
            this.pnlSkor.Controls.Add(this.lblSayac);
            this.pnlSkor.Controls.Add(this.lblSkor);
            this.pnlSkor.Controls.Add(this.lblVeriCek);
            this.pnlSkor.Location = new System.Drawing.Point(541, 2);
            this.pnlSkor.Name = "pnlSkor";
            this.pnlSkor.Size = new System.Drawing.Size(175, 148);
            this.pnlSkor.TabIndex = 0;
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.Black;
            this.btnBasla.Location = new System.Drawing.Point(6, 26);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(101, 37);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.Text = "Oyuna Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Location = new System.Drawing.Point(10, 79);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(37, 13);
            this.lblSayac.TabIndex = 1;
            this.lblSayac.Text = "Sayaç";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.BackColor = System.Drawing.Color.Transparent;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.ForeColor = System.Drawing.Color.Transparent;
            this.lblSkor.Location = new System.Drawing.Point(10, 105);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSkor.Size = new System.Drawing.Size(88, 13);
            this.lblSkor.TabIndex = 1;
            this.lblSkor.Text = "SKORUNUZ : ";
            // 
            // lblVeriCek
            // 
            this.lblVeriCek.AutoSize = true;
            this.lblVeriCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeriCek.Location = new System.Drawing.Point(10, 7);
            this.lblVeriCek.Name = "lblVeriCek";
            this.lblVeriCek.Size = new System.Drawing.Size(97, 16);
            this.lblVeriCek.TabIndex = 0;
            this.lblVeriCek.Text = "Ad ve Soyad";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(706, 444);
            this.Controls.Add(this.pnlSkor);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlSkor.ResumeLayout(false);
            this.pnlSkor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSkor;
        private System.Windows.Forms.Label lblVeriCek;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblSayac;
    }
}