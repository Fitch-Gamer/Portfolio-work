namespace Line_matcher
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
            this.ImgFile = new System.Windows.Forms.OpenFileDialog();
            this.ImgBut = new System.Windows.Forms.Button();
            this.RawImg = new System.Windows.Forms.PictureBox();
            this.ProcBut = new System.Windows.Forms.Button();
            this.WhiteImg = new System.Windows.Forms.PictureBox();
            this.MinRange = new System.Windows.Forms.TextBox();
            this.MaxRange = new System.Windows.Forms.TextBox();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.PixelNum = new System.Windows.Forms.TextBox();
            this.PicBlockRem1 = new System.Windows.Forms.PictureBox();
            this.PicBlockRem2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RawImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBlockRem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBlockRem2)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgFile
            // 
            this.ImgFile.FileName = "openFileDialog1";
            // 
            // ImgBut
            // 
            this.ImgBut.Location = new System.Drawing.Point(43, 50);
            this.ImgBut.Name = "ImgBut";
            this.ImgBut.Size = new System.Drawing.Size(113, 30);
            this.ImgBut.TabIndex = 0;
            this.ImgBut.Text = "Open Image";
            this.ImgBut.UseVisualStyleBackColor = true;
            this.ImgBut.Click += new System.EventHandler(this.ImgBut_Click);
            // 
            // RawImg
            // 
            this.RawImg.Location = new System.Drawing.Point(12, 97);
            this.RawImg.Name = "RawImg";
            this.RawImg.Size = new System.Drawing.Size(476, 447);
            this.RawImg.TabIndex = 1;
            this.RawImg.TabStop = false;
            // 
            // ProcBut
            // 
            this.ProcBut.Location = new System.Drawing.Point(221, 54);
            this.ProcBut.Name = "ProcBut";
            this.ProcBut.Size = new System.Drawing.Size(75, 23);
            this.ProcBut.TabIndex = 2;
            this.ProcBut.Text = "Process";
            this.ProcBut.UseVisualStyleBackColor = true;
            this.ProcBut.Click += new System.EventHandler(this.ProcBut_Click);
            // 
            // WhiteImg
            // 
            this.WhiteImg.Location = new System.Drawing.Point(745, 12);
            this.WhiteImg.Name = "WhiteImg";
            this.WhiteImg.Size = new System.Drawing.Size(435, 317);
            this.WhiteImg.TabIndex = 3;
            this.WhiteImg.TabStop = false;
            // 
            // MinRange
            // 
            this.MinRange.Location = new System.Drawing.Point(12, 12);
            this.MinRange.Name = "MinRange";
            this.MinRange.Size = new System.Drawing.Size(100, 20);
            this.MinRange.TabIndex = 4;
            this.MinRange.Text = "50";
            // 
            // MaxRange
            // 
            this.MaxRange.Location = new System.Drawing.Point(135, 12);
            this.MaxRange.Name = "MaxRange";
            this.MaxRange.Size = new System.Drawing.Size(100, 20);
            this.MaxRange.TabIndex = 5;
            this.MaxRange.Text = "19";
            // 
            // CountBox
            // 
            this.CountBox.Location = new System.Drawing.Point(263, 12);
            this.CountBox.Name = "CountBox";
            this.CountBox.Size = new System.Drawing.Size(100, 20);
            this.CountBox.TabIndex = 6;
            this.CountBox.Text = "30";
            // 
            // PixelNum
            // 
            this.PixelNum.Location = new System.Drawing.Point(510, 60);
            this.PixelNum.Name = "PixelNum";
            this.PixelNum.Size = new System.Drawing.Size(100, 20);
            this.PixelNum.TabIndex = 7;
            this.PixelNum.Text = "150";
            // 
            // PicBlockRem1
            // 
            this.PicBlockRem1.Location = new System.Drawing.Point(745, 335);
            this.PicBlockRem1.Name = "PicBlockRem1";
            this.PicBlockRem1.Size = new System.Drawing.Size(435, 317);
            this.PicBlockRem1.TabIndex = 8;
            this.PicBlockRem1.TabStop = false;
            // 
            // PicBlockRem2
            // 
            this.PicBlockRem2.Location = new System.Drawing.Point(1186, 153);
            this.PicBlockRem2.Name = "PicBlockRem2";
            this.PicBlockRem2.Size = new System.Drawing.Size(435, 317);
            this.PicBlockRem2.TabIndex = 9;
            this.PicBlockRem2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1649, 764);
            this.Controls.Add(this.PicBlockRem2);
            this.Controls.Add(this.PicBlockRem1);
            this.Controls.Add(this.PixelNum);
            this.Controls.Add(this.CountBox);
            this.Controls.Add(this.MaxRange);
            this.Controls.Add(this.MinRange);
            this.Controls.Add(this.WhiteImg);
            this.Controls.Add(this.ProcBut);
            this.Controls.Add(this.RawImg);
            this.Controls.Add(this.ImgBut);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RawImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhiteImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBlockRem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBlockRem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ImgFile;
        private System.Windows.Forms.Button ImgBut;
        private System.Windows.Forms.PictureBox RawImg;
        private System.Windows.Forms.Button ProcBut;
        private System.Windows.Forms.PictureBox WhiteImg;
        private System.Windows.Forms.TextBox MinRange;
        private System.Windows.Forms.TextBox MaxRange;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.TextBox PixelNum;
        private System.Windows.Forms.PictureBox PicBlockRem1;
        private System.Windows.Forms.PictureBox PicBlockRem2;
    }
}

