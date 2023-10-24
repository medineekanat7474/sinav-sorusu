namespace sınav_sorusu
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
            this.btnButton = new System.Windows.Forms.Button();
            this.rbTek = new System.Windows.Forms.RadioButton();
            this.rbÇift = new System.Windows.Forms.RadioButton();
            this.lstSayılar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(28, 41);
            this.btnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(132, 47);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "button";
            this.btnButton.UseVisualStyleBackColor = true;
            this.btnButton.Click += new System.EventHandler(this.btnButton_Click);
            // 
            // rbTek
            // 
            this.rbTek.AutoSize = true;
            this.rbTek.Location = new System.Drawing.Point(202, 41);
            this.rbTek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbTek.Name = "rbTek";
            this.rbTek.Size = new System.Drawing.Size(54, 20);
            this.rbTek.TabIndex = 1;
            this.rbTek.TabStop = true;
            this.rbTek.Text = "TEK";
            this.rbTek.UseVisualStyleBackColor = true;
            // 
            // rbÇift
            // 
            this.rbÇift.AutoSize = true;
            this.rbÇift.Location = new System.Drawing.Point(202, 69);
            this.rbÇift.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbÇift.Name = "rbÇift";
            this.rbÇift.Size = new System.Drawing.Size(58, 20);
            this.rbÇift.TabIndex = 2;
            this.rbÇift.TabStop = true;
            this.rbÇift.Text = "ÇİFT";
            this.rbÇift.UseVisualStyleBackColor = true;
            // 
            // lstSayılar
            // 
            this.lstSayılar.FormattingEnabled = true;
            this.lstSayılar.ItemHeight = 16;
            this.lstSayılar.Location = new System.Drawing.Point(333, 13);
            this.lstSayılar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSayılar.Name = "lstSayılar";
            this.lstSayılar.Size = new System.Drawing.Size(135, 228);
            this.lstSayılar.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 269);
            this.Controls.Add(this.lstSayılar);
            this.Controls.Add(this.rbÇift);
            this.Controls.Add(this.rbTek);
            this.Controls.Add(this.btnButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.RadioButton rbTek;
        private System.Windows.Forms.RadioButton rbÇift;
        private System.Windows.Forms.ListBox lstSayılar;
    }
}

