using MechlalaDll;

namespace Delegates_HWS_7._10
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.lblStudentList = new System.Windows.Forms.Label();
            this.btnGradeUnder50Filter = new System.Windows.Forms.Button();
            this.btnFIrstLast = new System.Windows.Forms.Button();
            this.gridStudents = new System.Windows.Forms.DataGridView();
            this.btnSumDebts = new System.Windows.Forms.Button();
            this.btnSumPaid = new System.Windows.Forms.Button();
            this.btnAgeAverage = new System.Windows.Forms.Button();
            this.btnGradeAverage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(31, 31);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(39, 23);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(105, 31);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(39, 23);
            this.txtNum2.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(186, 31);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(39, 23);
            this.txtResult.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(31, 78);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(105, 78);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(59, 36);
            this.btnSub.TabIndex = 1;
            this.btnSub.Text = "Sub";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentList.Location = new System.Drawing.Point(422, 31);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(109, 25);
            this.lblStudentList.TabIndex = 3;
            this.lblStudentList.Text = "Student List";
            // 
            // btnGradeUnder50Filter
            // 
            this.btnGradeUnder50Filter.Location = new System.Drawing.Point(31, 163);
            this.btnGradeUnder50Filter.Name = "btnGradeUnder50Filter";
            this.btnGradeUnder50Filter.Size = new System.Drawing.Size(153, 59);
            this.btnGradeUnder50Filter.TabIndex = 4;
            this.btnGradeUnder50Filter.Text = "is there a student whith grade under 50?";
            this.btnGradeUnder50Filter.UseVisualStyleBackColor = true;
            this.btnGradeUnder50Filter.Click += new System.EventHandler(this.btnGradeUnder50Filter_Click);
            // 
            // btnFIrstLast
            // 
            this.btnFIrstLast.Location = new System.Drawing.Point(31, 228);
            this.btnFIrstLast.Name = "btnFIrstLast";
            this.btnFIrstLast.Size = new System.Drawing.Size(153, 73);
            this.btnFIrstLast.TabIndex = 5;
            this.btnFIrstLast.Text = "Is There  A Student  With Same First Name First Latter And Last Name First Latter" +
    "?";
            this.btnFIrstLast.UseVisualStyleBackColor = true;
            this.btnFIrstLast.Click += new System.EventHandler(this.btnFIrstLast_Click);
            // 
            // gridStudents
            // 
            this.gridStudents.BackgroundColor = System.Drawing.Color.LightGray;
            this.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudents.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.gridStudents.Location = new System.Drawing.Point(309, 78);
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.RowTemplate.Height = 25;
            this.gridStudents.Size = new System.Drawing.Size(455, 397);
            this.gridStudents.TabIndex = 6;
            // 
            // btnSumDebts
            // 
            this.btnSumDebts.Location = new System.Drawing.Point(31, 356);
            this.btnSumDebts.Name = "btnSumDebts";
            this.btnSumDebts.Size = new System.Drawing.Size(153, 46);
            this.btnSumDebts.TabIndex = 7;
            this.btnSumDebts.Text = "Sum All Debts";
            this.btnSumDebts.UseVisualStyleBackColor = true;
            this.btnSumDebts.Click += new System.EventHandler(this.btnSumDebts_Click);
            // 
            // btnSumPaid
            // 
            this.btnSumPaid.Location = new System.Drawing.Point(31, 307);
            this.btnSumPaid.Name = "btnSumPaid";
            this.btnSumPaid.Size = new System.Drawing.Size(153, 43);
            this.btnSumPaid.TabIndex = 8;
            this.btnSumPaid.Text = "Sum All Paid";
            this.btnSumPaid.UseVisualStyleBackColor = true;
            this.btnSumPaid.Click += new System.EventHandler(this.btnSumPaid_Click);
            // 
            // btnAgeAverage
            // 
            this.btnAgeAverage.Location = new System.Drawing.Point(31, 409);
            this.btnAgeAverage.Name = "btnAgeAverage";
            this.btnAgeAverage.Size = new System.Drawing.Size(153, 37);
            this.btnAgeAverage.TabIndex = 9;
            this.btnAgeAverage.Text = "Age Average";
            this.btnAgeAverage.UseVisualStyleBackColor = true;
            this.btnAgeAverage.Click += new System.EventHandler(this.btnAgeAverage_Click);
            // 
            // btnGradeAverage
            // 
            this.btnGradeAverage.Location = new System.Drawing.Point(31, 451);
            this.btnGradeAverage.Name = "btnGradeAverage";
            this.btnGradeAverage.Size = new System.Drawing.Size(153, 36);
            this.btnGradeAverage.TabIndex = 10;
            this.btnGradeAverage.Text = "Grade Average";
            this.btnGradeAverage.UseVisualStyleBackColor = true;
            this.btnGradeAverage.Click += new System.EventHandler(this.btnGradeAverage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 519);
            this.Controls.Add(this.btnGradeAverage);
            this.Controls.Add(this.btnAgeAverage);
            this.Controls.Add(this.btnSumPaid);
            this.Controls.Add(this.btnSumDebts);
            this.Controls.Add(this.gridStudents);
            this.Controls.Add(this.btnFIrstLast);
            this.Controls.Add(this.btnGradeUnder50Filter);
            this.Controls.Add(this.lblStudentList);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Label lblStudentList;
        private System.Windows.Forms.Button btnGradeUnder50Filter;
        private System.Windows.Forms.Button btnFIrstLast;
        private System.Windows.Forms.DataGridView gridStudents;
        private System.Windows.Forms.Button btnSumDebts;
        private System.Windows.Forms.Button btnSumPaid;
        private System.Windows.Forms.Button btnAgeAverage;
        private System.Windows.Forms.Button btnGradeAverage;
    }
}

