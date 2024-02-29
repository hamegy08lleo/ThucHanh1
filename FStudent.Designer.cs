namespace ThucHanh1
{
    partial class FStudent
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ucStudent = new ThucHanh1.UCInfomartion();
            this.SuspendLayout();
            // 
            // ucStudent
            // 
            this.ucStudent.Location = new System.Drawing.Point(-1, -1);
            this.ucStudent.Name = "ucStudent";
            this.ucStudent.Size = new System.Drawing.Size(1777, 760);
            this.ucStudent.TabIndex = 5;
            this.ucStudent.Load += new System.EventHandler(this.ucInfomartion1_Load);
            // 
            // FStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1825, 756);
            this.Controls.Add(this.ucStudent);
            this.Name = "FStudent";
            this.Text = "FStudent";
            this.Load += new System.EventHandler(this.FStudent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UCInfomartion ucStudent;
    }
}