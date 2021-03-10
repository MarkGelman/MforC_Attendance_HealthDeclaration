
namespace MforC_Attendance_HealthDeclaration
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
            this.rdbAttendanceFull = new System.Windows.Forms.RadioButton();
            this.rdbAttendance = new System.Windows.Forms.RadioButton();
            this.rdbNoAttendance = new System.Windows.Forms.RadioButton();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.dgvA_HD = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtRemark = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA_HD)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbAttendanceFull
            // 
            this.rdbAttendanceFull.AutoSize = true;
            this.rdbAttendanceFull.Location = new System.Drawing.Point(700, 12);
            this.rdbAttendanceFull.Name = "rdbAttendanceFull";
            this.rdbAttendanceFull.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbAttendanceFull.Size = new System.Drawing.Size(84, 17);
            this.rdbAttendanceFull.TabIndex = 0;
            this.rdbAttendanceFull.TabStop = true;
            this.rdbAttendanceFull.Text = "נוכח והביא";
            this.rdbAttendanceFull.UseVisualStyleBackColor = true;
            this.rdbAttendanceFull.CheckedChanged += new System.EventHandler(this.rdbAttendanceFull_CheckedChanged);
            // 
            // rdbAttendance
            // 
            this.rdbAttendance.AutoSize = true;
            this.rdbAttendance.Location = new System.Drawing.Point(682, 51);
            this.rdbAttendance.Name = "rdbAttendance";
            this.rdbAttendance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbAttendance.Size = new System.Drawing.Size(102, 17);
            this.rdbAttendance.TabIndex = 1;
            this.rdbAttendance.TabStop = true;
            this.rdbAttendance.Text = "נוכח ולא הביא";
            this.rdbAttendance.UseVisualStyleBackColor = true;
            this.rdbAttendance.CheckedChanged += new System.EventHandler(this.rdbAttendance_CheckedChanged);
            // 
            // rdbNoAttendance
            // 
            this.rdbNoAttendance.AutoSize = true;
            this.rdbNoAttendance.Location = new System.Drawing.Point(717, 88);
            this.rdbNoAttendance.Name = "rdbNoAttendance";
            this.rdbNoAttendance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbNoAttendance.Size = new System.Drawing.Size(67, 17);
            this.rdbNoAttendance.TabIndex = 2;
            this.rdbNoAttendance.TabStop = true;
            this.rdbNoAttendance.Text = "לא נוכח";
            this.rdbNoAttendance.UseVisualStyleBackColor = true;
            this.rdbNoAttendance.CheckedChanged += new System.EventHandler(this.rdbNoAttendance_CheckedChanged);
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(291, 5);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvStudents.Size = new System.Drawing.Size(350, 447);
            this.dgvStudents.TabIndex = 3;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            // 
            // dgvA_HD
            // 
            this.dgvA_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvA_HD.Location = new System.Drawing.Point(13, 5);
            this.dgvA_HD.Name = "dgvA_HD";
            this.dgvA_HD.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvA_HD.Size = new System.Drawing.Size(272, 447);
            this.dgvA_HD.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(664, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(682, 180);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(100, 20);
            this.txtRemark.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvA_HD);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.rdbNoAttendance);
            this.Controls.Add(this.rdbAttendance);
            this.Controls.Add(this.rdbAttendanceFull);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvA_HD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbAttendanceFull;
        private System.Windows.Forms.RadioButton rdbAttendance;
        private System.Windows.Forms.RadioButton rdbNoAttendance;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridView dgvA_HD;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtRemark;
    }
}

