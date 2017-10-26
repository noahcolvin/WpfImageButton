using CustomControls;

namespace UIPlayground
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
            this.imageButton1 = new UIPlayground.ImageButton();
            this.superButton1 = new SuperButton();
            this.elementHost2 = new System.Windows.Forms.Integration.ElementHost();
            this.wpfImageButton1 = new UIPlayground.WpfImageButton();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // imageButton1
            // 
            this.imageButton1.Location = new System.Drawing.Point(64, 12);
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(160, 40);
            this.imageButton1.TabIndex = 2;
            this.imageButton1.Text = "imageButton1";
            this.imageButton1.UseVisualStyleBackColor = true;
            // 
            // elementHost2
            // 
            this.elementHost2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost2.Location = new System.Drawing.Point(3, 155);
            this.elementHost2.Name = "elementHost2";
            this.elementHost2.Size = new System.Drawing.Size(269, 94);
            this.elementHost2.TabIndex = 3;
            this.elementHost2.Text = "elementHost2";
            this.elementHost2.Child = this.wpfImageButton1;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(12, 49);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(200, 100);
            this.elementHost1.TabIndex = 4;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.superButton1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.elementHost2);
            this.Controls.Add(this.imageButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ImageButton imageButton1;
        private SuperButton superButton1;
        private System.Windows.Forms.Integration.ElementHost elementHost2;
        private WpfImageButton wpfImageButton1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
    }
}

