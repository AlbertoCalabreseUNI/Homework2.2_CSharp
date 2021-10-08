
namespace Homework2._2_CSharp
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
            this.myPictureBox1 = new Homework2._2_CSharp.MyPictureBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // myPictureBox1
            // 
            this.myPictureBox1.Image = global::Homework2._2_CSharp.Properties.Resources.cat;
            this.myPictureBox1.Location = new System.Drawing.Point(94, 35);
            this.myPictureBox1.Name = "myPictureBox1";
            this.myPictureBox1.Size = new System.Drawing.Size(261, 294);
            this.myPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myPictureBox1.TabIndex = 0;
            this.myPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myPictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyPictureBox myPictureBox1;
    }
}

