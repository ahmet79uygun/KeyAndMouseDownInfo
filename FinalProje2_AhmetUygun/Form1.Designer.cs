
namespace FinalProje2_AhmetUygun
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
            this.myKeyAndMouseDownInfo1 = new FinalProje2_AhmetUygun.MyKeyAndMouseDownInfo();
            this.SuspendLayout();
            // 
            // myKeyAndMouseDownInfo1
            // 
            this.myKeyAndMouseDownInfo1.Location = new System.Drawing.Point(0, 0);
            this.myKeyAndMouseDownInfo1.Name = "myKeyAndMouseDownInfo1";
            this.myKeyAndMouseDownInfo1.Size = new System.Drawing.Size(503, 255);
            this.myKeyAndMouseDownInfo1.TabIndex = 0;
            this.myKeyAndMouseDownInfo1.Text = "myKeyAndMouseDownInfo1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 240);
            this.Controls.Add(this.myKeyAndMouseDownInfo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyKeyAndMouseDownInfo myKeyAndMouseDownInfo1;
    }
}

