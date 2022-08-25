namespace SesliSessizApp
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
            this.lkelime = new System.Windows.Forms.Label();
            this.tbKelime = new System.Windows.Forms.TextBox();
            this.rbSesli = new System.Windows.Forms.RadioButton();
            this.rbSessiz = new System.Windows.Forms.RadioButton();
            this.bBul = new System.Windows.Forms.Button();
            this.bTemizle = new System.Windows.Forms.Button();
            this.rtbSonuc = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lkelime
            // 
            this.lkelime.AutoSize = true;
            this.lkelime.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lkelime.Location = new System.Drawing.Point(12, 9);
            this.lkelime.Name = "lkelime";
            this.lkelime.Size = new System.Drawing.Size(91, 31);
            this.lkelime.TabIndex = 0;
            this.lkelime.Text = "Kelime";
            // 
            // tbKelime
            // 
            this.tbKelime.Location = new System.Drawing.Point(109, 12);
            this.tbKelime.Name = "tbKelime";
            this.tbKelime.Size = new System.Drawing.Size(100, 23);
            this.tbKelime.TabIndex = 1;
            // 
            // rbSesli
            // 
            this.rbSesli.AutoSize = true;
            this.rbSesli.Checked = true;
            this.rbSesli.Location = new System.Drawing.Point(51, 41);
            this.rbSesli.Name = "rbSesli";
            this.rbSesli.Size = new System.Drawing.Size(48, 19);
            this.rbSesli.TabIndex = 2;
            this.rbSesli.TabStop = true;
            this.rbSesli.Text = "Sesli";
            this.rbSesli.UseVisualStyleBackColor = true;
            // 
            // rbSessiz
            // 
            this.rbSessiz.AutoSize = true;
            this.rbSessiz.Location = new System.Drawing.Point(154, 41);
            this.rbSessiz.Name = "rbSessiz";
            this.rbSessiz.Size = new System.Drawing.Size(55, 19);
            this.rbSessiz.TabIndex = 2;
            this.rbSessiz.TabStop = true;
            this.rbSessiz.Text = "Sessiz";
            this.rbSessiz.UseVisualStyleBackColor = true;
            // 
            // bBul
            // 
            this.bBul.Location = new System.Drawing.Point(53, 66);
            this.bBul.Name = "bBul";
            this.bBul.Size = new System.Drawing.Size(75, 23);
            this.bBul.TabIndex = 3;
            this.bBul.Text = "Bul";
            this.bBul.UseVisualStyleBackColor = true;
            this.bBul.Click += new System.EventHandler(this.bBul_Click);
            // 
            // bTemizle
            // 
            this.bTemizle.Location = new System.Drawing.Point(134, 66);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(75, 23);
            this.bTemizle.TabIndex = 3;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = true;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // rtbSonuc
            // 
            this.rtbSonuc.Location = new System.Drawing.Point(12, 95);
            this.rtbSonuc.Name = "rtbSonuc";
            this.rtbSonuc.Size = new System.Drawing.Size(197, 109);
            this.rtbSonuc.TabIndex = 4;
            this.rtbSonuc.Text = "";
            this.rtbSonuc.TextChanged += new System.EventHandler(this.rtbSonuc_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 212);
            this.Controls.Add(this.rtbSonuc);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.bBul);
            this.Controls.Add(this.rbSessiz);
            this.Controls.Add(this.rbSesli);
            this.Controls.Add(this.tbKelime);
            this.Controls.Add(this.lkelime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesli Sessiz Harf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lkelime;
        private TextBox tbKelime;
        private RadioButton rbSesli;
        private RadioButton rbSessiz;
        private Button bBul;
        private Button bTemizle;
        private RichTextBox rtbSonuc;
    }
}