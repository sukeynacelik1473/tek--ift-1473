namespace tek_çiftoyunu
{
    partial class Form1
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblSayı = new System.Windows.Forms.Label();
            this.btnUret = new System.Windows.Forms.Button();
            this.btnTek = new System.Windows.Forms.Button();
            this.btnCift = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(13, 53);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(44, 16);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "sayı=";
            // 
            // lblSayı
            // 
            this.lblSayı.AutoSize = true;
            this.lblSayı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayı.Location = new System.Drawing.Point(63, 56);
            this.lblSayı.Name = "lblSayı";
            this.lblSayı.Size = new System.Drawing.Size(15, 16);
            this.lblSayı.TabIndex = 1;
            this.lblSayı.Text = "0";
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(119, 56);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(78, 58);
            this.btnUret.TabIndex = 2;
            this.btnUret.Text = "sayı Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // btnTek
            // 
            this.btnTek.Location = new System.Drawing.Point(19, 108);
            this.btnTek.Name = "btnTek";
            this.btnTek.Size = new System.Drawing.Size(78, 59);
            this.btnTek.TabIndex = 3;
            this.btnTek.Text = "tek sayı ";
            this.btnTek.UseVisualStyleBackColor = true;
            this.btnTek.Click += new System.EventHandler(this.btnTek_Click);
            // 
            // btnCift
            // 
            this.btnCift.Location = new System.Drawing.Point(119, 108);
            this.btnCift.Name = "btnCift";
            this.btnCift.Size = new System.Drawing.Size(78, 59);
            this.btnCift.TabIndex = 4;
            this.btnCift.Text = "çift sayı";
            this.btnCift.UseVisualStyleBackColor = true;
            this.btnCift.Click += new System.EventHandler(this.btnCift_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(16, 208);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(34, 13);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "puan ";
            this.lbl2.Click += new System.EventHandler(this.lblPuan_Click);
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.Location = new System.Drawing.Point(57, 208);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(13, 13);
            this.lblPuan.TabIndex = 6;
            this.lblPuan.Text = "o";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnCift);
            this.Controls.Add(this.btnTek);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.lblSayı);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblSayı;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.Button btnTek;
        private System.Windows.Forms.Button btnCift;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblPuan;
    }
}

