namespace SesliSessizApp
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
            this.rtbCumle = new System.Windows.Forms.RichTextBox();
            this.bBul = new System.Windows.Forms.Button();
            this.tbCumle = new System.Windows.Forms.TextBox();
            this.lkelime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbCumle
            // 
            this.rtbCumle.Location = new System.Drawing.Point(45, 98);
            this.rtbCumle.Name = "rtbCumle";
            this.rtbCumle.Size = new System.Drawing.Size(465, 109);
            this.rtbCumle.TabIndex = 8;
            this.rtbCumle.Text = "";
            this.rtbCumle.TextChanged += new System.EventHandler(this.rtbCumle_TextChanged);
            // 
            // bBul
            // 
            this.bBul.Location = new System.Drawing.Point(136, 59);
            this.bBul.Name = "bBul";
            this.bBul.Size = new System.Drawing.Size(241, 23);
            this.bBul.TabIndex = 7;
            this.bBul.Text = "Düzelt";
            this.bBul.UseVisualStyleBackColor = true;
            this.bBul.Click += new System.EventHandler(this.bBul_Click);
            // 
            // tbCumle
            // 
            this.tbCumle.Location = new System.Drawing.Point(114, 12);
            this.tbCumle.Name = "tbCumle";
            this.tbCumle.Size = new System.Drawing.Size(374, 23);
            this.tbCumle.TabIndex = 6;
            // 
            // lkelime
            // 
            this.lkelime.AutoSize = true;
            this.lkelime.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lkelime.Location = new System.Drawing.Point(23, 12);
            this.lkelime.Name = "lkelime";
            this.lkelime.Size = new System.Drawing.Size(85, 31);
            this.lkelime.TabIndex = 5;
            this.lkelime.Text = "Cümle";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 226);
            this.Controls.Add(this.rtbCumle);
            this.Controls.Add(this.bBul);
            this.Controls.Add(this.tbCumle);
            this.Controls.Add(this.lkelime);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox rtbCumle;
        private Button bBul;
        private TextBox tbCumle;
        private Label lkelime;
    }
}