namespace cKaraListKontrol
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
            this.components = new System.ComponentModel.Container();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.tmrFullLoaded = new System.Windows.Forms.Timer(this.components);
            this.lblDurum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tmrZamanlayici = new System.Windows.Forms.Timer(this.components);
            this.btnBaslat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // wb
            // 
            this.wb.Location = new System.Drawing.Point(44, 77);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(192, 20);
            this.wb.TabIndex = 3;
            this.wb.Visible = false;
            this.wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.web_DocumentCompleted);
            // 
            // tmrFullLoaded
            // 
            this.tmrFullLoaded.Interval = 500;
            this.tmrFullLoaded.Tick += new System.EventHandler(this.tmrFullLoaded_Tick);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(70, 138);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(254, 31);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Text = "-TEST YAPILMADI-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(58, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alanadı / IP girip, BAŞLAT butonuna basın.";
            // 
            // tmrZamanlayici
            // 
            this.tmrZamanlayici.Interval = 360000;
            this.tmrZamanlayici.Tick += new System.EventHandler(this.tmrZamanlayici_Tick);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(242, 74);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(93, 23);
            this.btnBaslat.TabIndex = 18;
            this.btnBaslat.Text = "BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Zamanlayıcı (MS):";
            // 
            // txtMS
            // 
            this.txtMS.Location = new System.Drawing.Point(149, 44);
            this.txtMS.Name = "txtMS";
            this.txtMS.Size = new System.Drawing.Size(186, 20);
            this.txtMS.TabIndex = 17;
            this.txtMS.Text = "3600000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Alanadı / IP :";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(149, 18);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(186, 20);
            this.txtUrl.TabIndex = 15;
            this.txtUrl.Text = "mail.yusufdoru.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 199);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.wb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Kara Liste Kontrolü 1.0 - www.yusufdoru.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.Timer tmrFullLoaded;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrZamanlayici;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
    }
}

