namespace Project__2_V1
{
    partial class frmGrades
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
            grpQuiz = new GroupBox();
            txtQuizDropped = new TextBox();
            txtAverageQuiz = new TextBox();
            lblAverageQuiz = new Label();
            txtQuiz3 = new TextBox();
            txtQuiz2 = new TextBox();
            txtQuiz1 = new TextBox();
            lblQuiz3 = new Label();
            lblQuiz2 = new Label();
            lblQuiz = new Label();
            grpMidAndFinal = new GroupBox();
            txtFinal = new TextBox();
            txtMidterm = new TextBox();
            lblFinal = new Label();
            lblMidterm = new Label();
            grpTotal = new GroupBox();
            btnClear = new Button();
            txtTotalLtr = new TextBox();
            lblTotalLtr = new Label();
            btnCalculate = new Button();
            txtTotal = new TextBox();
            lblTotalGrade = new Label();
            grpQuiz.SuspendLayout();
            grpMidAndFinal.SuspendLayout();
            grpTotal.SuspendLayout();
            SuspendLayout();
            // 
            // grpQuiz
            // 
            grpQuiz.BackColor = SystemColors.ActiveCaption;
            grpQuiz.Controls.Add(txtQuizDropped);
            grpQuiz.Controls.Add(txtAverageQuiz);
            grpQuiz.Controls.Add(lblAverageQuiz);
            grpQuiz.Controls.Add(txtQuiz3);
            grpQuiz.Controls.Add(txtQuiz2);
            grpQuiz.Controls.Add(txtQuiz1);
            grpQuiz.Controls.Add(lblQuiz3);
            grpQuiz.Controls.Add(lblQuiz2);
            grpQuiz.Controls.Add(lblQuiz);
            grpQuiz.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpQuiz.ForeColor = SystemColors.ActiveCaptionText;
            grpQuiz.Location = new Point(63, 12);
            grpQuiz.Name = "grpQuiz";
            grpQuiz.Size = new Size(820, 196);
            grpQuiz.TabIndex = 0;
            grpQuiz.TabStop = false;
            grpQuiz.Text = "Enter your quiz grades:";
            // 
            // txtQuizDropped
            // 
            txtQuizDropped.BorderStyle = BorderStyle.FixedSingle;
            txtQuizDropped.Location = new Point(34, 122);
            txtQuizDropped.Name = "txtQuizDropped";
            txtQuizDropped.Size = new Size(545, 25);
            txtQuizDropped.TabIndex = 8;
            txtQuizDropped.Visible = false;
            // 
            // txtAverageQuiz
            // 
            txtAverageQuiz.Location = new Point(194, 153);
            txtAverageQuiz.Name = "txtAverageQuiz";
            txtAverageQuiz.Size = new Size(100, 25);
            txtAverageQuiz.TabIndex = 7;
            txtAverageQuiz.Visible = false;
            // 
            // lblAverageQuiz
            // 
            lblAverageQuiz.AutoSize = true;
            lblAverageQuiz.Location = new Point(30, 161);
            lblAverageQuiz.Name = "lblAverageQuiz";
            lblAverageQuiz.Size = new Size(133, 17);
            lblAverageQuiz.TabIndex = 6;
            lblAverageQuiz.Text = "Average Quiz grade:";
            lblAverageQuiz.Visible = false;
            // 
            // txtQuiz3
            // 
            txtQuiz3.Location = new Point(103, 91);
            txtQuiz3.Name = "txtQuiz3";
            txtQuiz3.Size = new Size(100, 25);
            txtQuiz3.TabIndex = 5;
            // 
            // txtQuiz2
            // 
            txtQuiz2.Location = new Point(103, 60);
            txtQuiz2.Name = "txtQuiz2";
            txtQuiz2.Size = new Size(100, 25);
            txtQuiz2.TabIndex = 4;
            // 
            // txtQuiz1
            // 
            txtQuiz1.Location = new Point(103, 29);
            txtQuiz1.Name = "txtQuiz1";
            txtQuiz1.Size = new Size(100, 25);
            txtQuiz1.TabIndex = 3;
            // 
            // lblQuiz3
            // 
            lblQuiz3.AutoSize = true;
            lblQuiz3.Location = new Point(32, 92);
            lblQuiz3.Name = "lblQuiz3";
            lblQuiz3.Size = new Size(51, 17);
            lblQuiz3.TabIndex = 2;
            lblQuiz3.Text = "Quiz 3:";
            // 
            // lblQuiz2
            // 
            lblQuiz2.AutoSize = true;
            lblQuiz2.Location = new Point(32, 63);
            lblQuiz2.Name = "lblQuiz2";
            lblQuiz2.Size = new Size(51, 17);
            lblQuiz2.TabIndex = 1;
            lblQuiz2.Text = "Quiz 2:";
            // 
            // lblQuiz
            // 
            lblQuiz.AutoSize = true;
            lblQuiz.Location = new Point(32, 35);
            lblQuiz.Name = "lblQuiz";
            lblQuiz.Size = new Size(51, 17);
            lblQuiz.TabIndex = 0;
            lblQuiz.Text = "Quiz 1:";
            // 
            // grpMidAndFinal
            // 
            grpMidAndFinal.BackColor = SystemColors.ActiveCaption;
            grpMidAndFinal.Controls.Add(txtFinal);
            grpMidAndFinal.Controls.Add(txtMidterm);
            grpMidAndFinal.Controls.Add(lblFinal);
            grpMidAndFinal.Controls.Add(lblMidterm);
            grpMidAndFinal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMidAndFinal.ForeColor = SystemColors.ActiveCaptionText;
            grpMidAndFinal.Location = new Point(63, 214);
            grpMidAndFinal.Name = "grpMidAndFinal";
            grpMidAndFinal.Size = new Size(294, 147);
            grpMidAndFinal.TabIndex = 1;
            grpMidAndFinal.TabStop = false;
            grpMidAndFinal.Text = "Enter your midterm and final exam grade:";
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(160, 71);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(100, 25);
            txtFinal.TabIndex = 7;
            // 
            // txtMidterm
            // 
            txtMidterm.Location = new Point(160, 31);
            txtMidterm.Name = "txtMidterm";
            txtMidterm.Size = new Size(100, 25);
            txtMidterm.TabIndex = 6;
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Location = new Point(32, 79);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(119, 17);
            lblFinal.TabIndex = 4;
            lblFinal.Text = "Final Exam Grade:";
            // 
            // lblMidterm
            // 
            lblMidterm.AutoSize = true;
            lblMidterm.Location = new Point(32, 39);
            lblMidterm.Name = "lblMidterm";
            lblMidterm.Size = new Size(105, 17);
            lblMidterm.TabIndex = 3;
            lblMidterm.Text = "Midterm Grade:";
            // 
            // grpTotal
            // 
            grpTotal.BackColor = SystemColors.ActiveCaption;
            grpTotal.Controls.Add(btnClear);
            grpTotal.Controls.Add(txtTotalLtr);
            grpTotal.Controls.Add(lblTotalLtr);
            grpTotal.Controls.Add(btnCalculate);
            grpTotal.Controls.Add(txtTotal);
            grpTotal.Controls.Add(lblTotalGrade);
            grpTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpTotal.Location = new Point(63, 381);
            grpTotal.Name = "grpTotal";
            grpTotal.Size = new Size(305, 198);
            grpTotal.TabIndex = 2;
            grpTotal.TabStop = false;
            grpTotal.Text = "Total Grade:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(34, 141);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 27);
            btnClear.TabIndex = 4;
            btnClear.Text = "Press to clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtTotalLtr
            // 
            txtTotalLtr.Location = new Point(160, 101);
            txtTotalLtr.Name = "txtTotalLtr";
            txtTotalLtr.Size = new Size(100, 23);
            txtTotalLtr.TabIndex = 10;
            // 
            // lblTotalLtr
            // 
            lblTotalLtr.AutoSize = true;
            lblTotalLtr.Location = new Point(32, 104);
            lblTotalLtr.Name = "lblTotalLtr";
            lblTotalLtr.Size = new Size(107, 15);
            lblTotalLtr.TabIndex = 9;
            lblTotalLtr.Text = "Total letter grade:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(32, 22);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(131, 27);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Press to calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(160, 55);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 8;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // lblTotalGrade
            // 
            lblTotalGrade.AutoSize = true;
            lblTotalGrade.Location = new Point(32, 63);
            lblTotalGrade.Name = "lblTotalGrade";
            lblTotalGrade.Size = new Size(93, 15);
            lblTotalGrade.TabIndex = 5;
            lblTotalGrade.Text = "Total grade (%):";
            // 
            // frmGrades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(992, 591);
            Controls.Add(grpTotal);
            Controls.Add(grpMidAndFinal);
            Controls.Add(grpQuiz);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "frmGrades";
            Text = "Grade Summary";
            grpQuiz.ResumeLayout(false);
            grpQuiz.PerformLayout();
            grpMidAndFinal.ResumeLayout(false);
            grpMidAndFinal.PerformLayout();
            grpTotal.ResumeLayout(false);
            grpTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpQuiz;
        private GroupBox grpMidAndFinal;
        private Label lblQuiz3;
        private Label lblQuiz2;
        private Label lblQuiz;
        private Label lblFinal;
        private Label lblMidterm;
        private GroupBox grpTotal;
        private Label lblTotalGrade;
        private TextBox txtQuiz3;
        private TextBox txtQuiz2;
        private TextBox txtQuiz1;
        private TextBox txtFinal;
        private TextBox txtMidterm;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Label lblAverageQuiz;
        private TextBox txtAverageQuiz;
        private Button btnClear;
        private TextBox txtTotalLtr;
        private Label lblTotalLtr;
        private TextBox txtQuizDropped;
    }
}
