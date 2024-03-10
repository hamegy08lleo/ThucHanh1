using System.ComponentModel;
using System.Windows.Forms;

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
            this.btnChangeToTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucStudent
            // 
            this.ucStudent.Location = new System.Drawing.Point(-1, -1);
            this.ucStudent.Name = "ucStudent";
            this.ucStudent.Size = new System.Drawing.Size(1777, 760);
            this.ucStudent.TabIndex = 5;
            // 
            // btnChangeToTeacher
            // 
            this.btnChangeToTeacher.Location = new System.Drawing.Point(1492, 624);
            this.btnChangeToTeacher.Name = "btnChangeToTeacher";
            this.btnChangeToTeacher.Size = new System.Drawing.Size(233, 92);
            this.btnChangeToTeacher.TabIndex = 6;
            this.btnChangeToTeacher.Text = "Change To Teacher Form";
            this.btnChangeToTeacher.UseVisualStyleBackColor = true;
            // 
            // FStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1825, 756);
            this.Controls.Add(this.btnChangeToTeacher);
            this.Controls.Add(this.ucStudent);
            this.Name = "FStudent";
            this.Text = "Student Manager";
            this.Load += new System.EventHandler(this.FStudent_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UCInfomartion ucStudent;
        private System.Windows.Forms.Button btnChangeToTeacher;

        public BackgroundWorker BackgroundWorker1 { get => backgroundWorker1; set => backgroundWorker1 = value; }
        public UCInfomartion UcStudent { get => ucStudent; set => ucStudent = value; }
        public Button BtnChangeToTeacher { get => btnChangeToTeacher; set => btnChangeToTeacher = value; }
    }
}