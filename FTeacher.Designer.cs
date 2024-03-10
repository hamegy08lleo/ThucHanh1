using System.Windows.Forms;

namespace ThucHanh1
{
    partial class FTeacher
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
            this.ucTeacher = new ThucHanh1.UCInfomartion();
            this.btnChangeToStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucTeacher
            // 
            this.ucTeacher.Location = new System.Drawing.Point(-2, -1);
            this.ucTeacher.Name = "ucTeacher";
            this.ucTeacher.Size = new System.Drawing.Size(1817, 744);
            this.ucTeacher.TabIndex = 0;
            // 
            // btnChangeToStudent
            // 
            this.btnChangeToStudent.Location = new System.Drawing.Point(1494, 625);
            this.btnChangeToStudent.Name = "btnChangeToStudent";
            this.btnChangeToStudent.Size = new System.Drawing.Size(228, 87);
            this.btnChangeToStudent.TabIndex = 1;
            this.btnChangeToStudent.Text = "Chang To Student Form";
            this.btnChangeToStudent.UseVisualStyleBackColor = true;
            // 
            // FTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 796);
            this.Controls.Add(this.btnChangeToStudent);
            this.Controls.Add(this.ucTeacher);
            this.Name = "FTeacher";
            this.Text = "Teacher Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private UCInfomartion ucTeacher;
        private System.Windows.Forms.Button btnChangeToStudent;

        public UCInfomartion UcTeacher { get => ucTeacher; set => ucTeacher = value; }
        public Button BtnChangeToStudent { get => btnChangeToStudent; set => btnChangeToStudent = value; }
    }
}