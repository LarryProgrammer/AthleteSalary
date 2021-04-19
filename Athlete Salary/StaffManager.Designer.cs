namespace Athlete_Salary
{
    partial class StaffManager
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
            this.lblRemaining = new System.Windows.Forms.Label();
            this.lblSpent = new System.Windows.Forms.Label();
            this.lblRemainingPrompt = new System.Windows.Forms.Label();
            this.lblSpentPrompt = new System.Windows.Forms.Label();
            this.lblAthletePrompt = new System.Windows.Forms.Label();
            this.btnSalary = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblEmployeesPrompt = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.drpPosition = new System.Windows.Forms.ComboBox();
            this.txtHireName = new System.Windows.Forms.TextBox();
            this.btnHire = new System.Windows.Forms.Button();
            this.lblPositionPrompt = new System.Windows.Forms.Label();
            this.lblNamePrompt = new System.Windows.Forms.Label();
            this.lblHirePrompt = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHiredEmployees = new System.Windows.Forms.Label();
            this.DeletBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRemaining
            // 
            this.lblRemaining.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemaining.Location = new System.Drawing.Point(200, 506);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Size = new System.Drawing.Size(148, 19);
            this.lblRemaining.TabIndex = 37;
            // 
            // lblSpent
            // 
            this.lblSpent.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpent.Location = new System.Drawing.Point(200, 481);
            this.lblSpent.Name = "lblSpent";
            this.lblSpent.Size = new System.Drawing.Size(148, 19);
            this.lblSpent.TabIndex = 36;
            // 
            // lblRemainingPrompt
            // 
            this.lblRemainingPrompt.AutoSize = true;
            this.lblRemainingPrompt.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingPrompt.Location = new System.Drawing.Point(36, 505);
            this.lblRemainingPrompt.Name = "lblRemainingPrompt";
            this.lblRemainingPrompt.Size = new System.Drawing.Size(148, 19);
            this.lblRemainingPrompt.TabIndex = 35;
            this.lblRemainingPrompt.Text = "Salary Remaining:";
            // 
            // lblSpentPrompt
            // 
            this.lblSpentPrompt.AutoSize = true;
            this.lblSpentPrompt.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpentPrompt.Location = new System.Drawing.Point(73, 480);
            this.lblSpentPrompt.Name = "lblSpentPrompt";
            this.lblSpentPrompt.Size = new System.Drawing.Size(111, 19);
            this.lblSpentPrompt.TabIndex = 34;
            this.lblSpentPrompt.Text = "Salary Spent:";
            // 
            // lblAthletePrompt
            // 
            this.lblAthletePrompt.AutoSize = true;
            this.lblAthletePrompt.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAthletePrompt.Location = new System.Drawing.Point(443, 33);
            this.lblAthletePrompt.Name = "lblAthletePrompt";
            this.lblAthletePrompt.Size = new System.Drawing.Size(159, 28);
            this.lblAthletePrompt.TabIndex = 33;
            this.lblAthletePrompt.Text = "Athlete\'s Info";
            // 
            // btnSalary
            // 
            this.btnSalary.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.Location = new System.Drawing.Point(570, 136);
            this.btnSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(100, 30);
            this.btnSalary.TabIndex = 3;
            this.btnSalary.Text = "Set Salary";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(510, 103);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(160, 22);
            this.txtSalary.TabIndex = 2;
            // 
            // lblEmployeesPrompt
            // 
            this.lblEmployeesPrompt.AutoSize = true;
            this.lblEmployeesPrompt.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeesPrompt.Location = new System.Drawing.Point(31, 184);
            this.lblEmployeesPrompt.Name = "lblEmployeesPrompt";
            this.lblEmployeesPrompt.Size = new System.Drawing.Size(224, 28);
            this.lblEmployeesPrompt.TabIndex = 28;
            this.lblEmployeesPrompt.Text = "Employees Salaries";
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(189, 130);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 30);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // drpPosition
            // 
            this.drpPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpPosition.Enabled = false;
            this.drpPosition.FormattingEnabled = true;
            this.drpPosition.Items.AddRange(new object[] {
            "Lawyer",
            "Personal Assistant",
            "Trainer",
            "Agent"});
            this.drpPosition.Location = new System.Drawing.Point(133, 97);
            this.drpPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpPosition.Name = "drpPosition";
            this.drpPosition.Size = new System.Drawing.Size(139, 24);
            this.drpPosition.TabIndex = 5;
            // 
            // txtHireName
            // 
            this.txtHireName.Enabled = false;
            this.txtHireName.Location = new System.Drawing.Point(133, 65);
            this.txtHireName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHireName.MaxLength = 20;
            this.txtHireName.Name = "txtHireName";
            this.txtHireName.Size = new System.Drawing.Size(139, 22);
            this.txtHireName.TabIndex = 4;
            // 
            // btnHire
            // 
            this.btnHire.Enabled = false;
            this.btnHire.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHire.Location = new System.Drawing.Point(57, 130);
            this.btnHire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(127, 30);
            this.btnHire.TabIndex = 6;
            this.btnHire.Text = "Hire";
            this.btnHire.UseVisualStyleBackColor = true;
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // lblPositionPrompt
            // 
            this.lblPositionPrompt.AutoSize = true;
            this.lblPositionPrompt.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionPrompt.Location = new System.Drawing.Point(30, 97);
            this.lblPositionPrompt.Name = "lblPositionPrompt";
            this.lblPositionPrompt.Size = new System.Drawing.Size(90, 20);
            this.lblPositionPrompt.TabIndex = 23;
            this.lblPositionPrompt.Text = "Position:";
            // 
            // lblNamePrompt
            // 
            this.lblNamePrompt.AutoSize = true;
            this.lblNamePrompt.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePrompt.Location = new System.Drawing.Point(53, 65);
            this.lblNamePrompt.Name = "lblNamePrompt";
            this.lblNamePrompt.Size = new System.Drawing.Size(67, 20);
            this.lblNamePrompt.TabIndex = 22;
            this.lblNamePrompt.Text = "Name:";
            // 
            // lblHirePrompt
            // 
            this.lblHirePrompt.AutoSize = true;
            this.lblHirePrompt.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHirePrompt.Location = new System.Drawing.Point(31, 21);
            this.lblHirePrompt.Name = "lblHirePrompt";
            this.lblHirePrompt.Size = new System.Drawing.Size(182, 28);
            this.lblHirePrompt.TabIndex = 21;
            this.lblHirePrompt.Text = "Hire Employees";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToOrderColumns = true;
            this.dgvEmployees.AllowUserToResizeRows = false;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(34, 219);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 51;
            this.dgvEmployees.RowTemplate.Height = 24;
            this.dgvEmployees.Size = new System.Drawing.Size(636, 227);
            this.dgvEmployees.TabIndex = 39;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(510, 71);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(160, 22);
            this.txtEmpName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Salary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Name:";
            // 
            // lblHiredEmployees
            // 
            this.lblHiredEmployees.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiredEmployees.Location = new System.Drawing.Point(36, 454);
            this.lblHiredEmployees.Name = "lblHiredEmployees";
            this.lblHiredEmployees.Size = new System.Drawing.Size(540, 22);
            this.lblHiredEmployees.TabIndex = 43;
            this.lblHiredEmployees.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeletBtn
            // 
            this.DeletBtn.Enabled = false;
            this.DeletBtn.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletBtn.Location = new System.Drawing.Point(591, 451);
            this.DeletBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeletBtn.Name = "DeletBtn";
            this.DeletBtn.Size = new System.Drawing.Size(79, 30);
            this.DeletBtn.TabIndex = 44;
            this.DeletBtn.Text = "Delete";
            this.DeletBtn.UseVisualStyleBackColor = true;
            this.DeletBtn.Click += new System.EventHandler(this.DeletBtn_Click);
            // 
            // StaffManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 557);
            this.Controls.Add(this.DeletBtn);
            this.Controls.Add(this.lblHiredEmployees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.lblRemaining);
            this.Controls.Add(this.lblSpent);
            this.Controls.Add(this.lblRemainingPrompt);
            this.Controls.Add(this.lblSpentPrompt);
            this.Controls.Add(this.lblAthletePrompt);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblEmployeesPrompt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.drpPosition);
            this.Controls.Add(this.txtHireName);
            this.Controls.Add(this.btnHire);
            this.Controls.Add(this.lblPositionPrompt);
            this.Controls.Add(this.lblNamePrompt);
            this.Controls.Add(this.lblHirePrompt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StaffManager";
            this.Text = "StaffManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffManager_FormClosing);
            this.Load += new System.EventHandler(this.StaffManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRemaining;
        private System.Windows.Forms.Label lblSpent;
        private System.Windows.Forms.Label lblRemainingPrompt;
        private System.Windows.Forms.Label lblSpentPrompt;
        private System.Windows.Forms.Label lblAthletePrompt;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblEmployeesPrompt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox drpPosition;
        private System.Windows.Forms.TextBox txtHireName;
        private System.Windows.Forms.Button btnHire;
        private System.Windows.Forms.Label lblPositionPrompt;
        private System.Windows.Forms.Label lblNamePrompt;
        private System.Windows.Forms.Label lblHirePrompt;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHiredEmployees;
        private System.Windows.Forms.Button DeletBtn;
    }
}