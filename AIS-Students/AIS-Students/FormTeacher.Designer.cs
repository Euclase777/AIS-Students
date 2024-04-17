namespace AIS_Students
{
    partial class FormTeacher
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
            this.panelSidebarAdministrator = new System.Windows.Forms.Panel();
            this.buttonAssignsTeacher = new System.Windows.Forms.Button();
            this.buttonMarksTeacher = new System.Windows.Forms.Button();
            this.panelMainTeacher = new System.Windows.Forms.Panel();
            this.panelMarkTeacher = new System.Windows.Forms.Panel();
            this.buttonMarkAddTeacher = new System.Windows.Forms.Button();
            this.buttonMarkDeleteTeacher = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMarkMarkTeacher = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkedListBoxMarkSubjectTeacher = new System.Windows.Forms.CheckedListBox();
            this.dataGridViewMarkTeacher = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerMarkTeacher = new System.Windows.Forms.DateTimePicker();
            this.checkedListBoxMarkAssignTeacher = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxMarkStudentTeacher = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSidebarAdministrator.SuspendLayout();
            this.panelMainTeacher.SuspendLayout();
            this.panelMarkTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarkTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebarAdministrator
            // 
            this.panelSidebarAdministrator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panelSidebarAdministrator.Controls.Add(this.buttonAssignsTeacher);
            this.panelSidebarAdministrator.Controls.Add(this.buttonMarksTeacher);
            this.panelSidebarAdministrator.Location = new System.Drawing.Point(0, 0);
            this.panelSidebarAdministrator.Name = "panelSidebarAdministrator";
            this.panelSidebarAdministrator.Size = new System.Drawing.Size(189, 700);
            this.panelSidebarAdministrator.TabIndex = 10;
            // 
            // buttonAssignsTeacher
            // 
            this.buttonAssignsTeacher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAssignsTeacher.FlatAppearance.BorderSize = 0;
            this.buttonAssignsTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssignsTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAssignsTeacher.Location = new System.Drawing.Point(20, 90);
            this.buttonAssignsTeacher.Name = "buttonAssignsTeacher";
            this.buttonAssignsTeacher.Size = new System.Drawing.Size(144, 42);
            this.buttonAssignsTeacher.TabIndex = 2;
            this.buttonAssignsTeacher.Text = "Работы";
            this.buttonAssignsTeacher.UseVisualStyleBackColor = true;
            // 
            // buttonMarksTeacher
            // 
            this.buttonMarksTeacher.FlatAppearance.BorderSize = 0;
            this.buttonMarksTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMarksTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMarksTeacher.Location = new System.Drawing.Point(20, 20);
            this.buttonMarksTeacher.Name = "buttonMarksTeacher";
            this.buttonMarksTeacher.Size = new System.Drawing.Size(144, 42);
            this.buttonMarksTeacher.TabIndex = 1;
            this.buttonMarksTeacher.Text = "Оценки";
            this.buttonMarksTeacher.UseVisualStyleBackColor = true;
            this.buttonMarksTeacher.Click += new System.EventHandler(this.buttonOrdersAdministrator_Click);
            // 
            // panelMainTeacher
            // 
            this.panelMainTeacher.Controls.Add(this.panelMarkTeacher);
            this.panelMainTeacher.Location = new System.Drawing.Point(189, 0);
            this.panelMainTeacher.Name = "panelMainTeacher";
            this.panelMainTeacher.Size = new System.Drawing.Size(912, 700);
            this.panelMainTeacher.TabIndex = 11;
            // 
            // panelMarkTeacher
            // 
            this.panelMarkTeacher.Controls.Add(this.label1);
            this.panelMarkTeacher.Controls.Add(this.checkedListBoxMarkStudentTeacher);
            this.panelMarkTeacher.Controls.Add(this.checkedListBoxMarkAssignTeacher);
            this.panelMarkTeacher.Controls.Add(this.buttonMarkAddTeacher);
            this.panelMarkTeacher.Controls.Add(this.dateTimePickerMarkTeacher);
            this.panelMarkTeacher.Controls.Add(this.buttonMarkDeleteTeacher);
            this.panelMarkTeacher.Controls.Add(this.label2);
            this.panelMarkTeacher.Controls.Add(this.label4);
            this.panelMarkTeacher.Controls.Add(this.textBoxMarkMarkTeacher);
            this.panelMarkTeacher.Controls.Add(this.label6);
            this.panelMarkTeacher.Controls.Add(this.label7);
            this.panelMarkTeacher.Controls.Add(this.checkedListBoxMarkSubjectTeacher);
            this.panelMarkTeacher.Controls.Add(this.dataGridViewMarkTeacher);
            this.panelMarkTeacher.Location = new System.Drawing.Point(41, 21);
            this.panelMarkTeacher.Name = "panelMarkTeacher";
            this.panelMarkTeacher.Size = new System.Drawing.Size(805, 668);
            this.panelMarkTeacher.TabIndex = 4;
            this.panelMarkTeacher.Visible = false;
            // 
            // buttonMarkAddTeacher
            // 
            this.buttonMarkAddTeacher.Location = new System.Drawing.Point(168, 585);
            this.buttonMarkAddTeacher.Name = "buttonMarkAddTeacher";
            this.buttonMarkAddTeacher.Size = new System.Drawing.Size(129, 38);
            this.buttonMarkAddTeacher.TabIndex = 8;
            this.buttonMarkAddTeacher.Text = "Добавить запись";
            this.buttonMarkAddTeacher.UseVisualStyleBackColor = true;
            this.buttonMarkAddTeacher.Click += new System.EventHandler(this.buttonOrdersCreateAdministrator_Click);
            // 
            // buttonMarkDeleteTeacher
            // 
            this.buttonMarkDeleteTeacher.Location = new System.Drawing.Point(303, 585);
            this.buttonMarkDeleteTeacher.Name = "buttonMarkDeleteTeacher";
            this.buttonMarkDeleteTeacher.Size = new System.Drawing.Size(129, 38);
            this.buttonMarkDeleteTeacher.TabIndex = 10;
            this.buttonMarkDeleteTeacher.Text = "Удалить выбранную запись";
            this.buttonMarkDeleteTeacher.UseVisualStyleBackColor = true;
            this.buttonMarkDeleteTeacher.Click += new System.EventHandler(this.buttonOrdersDeleteAdministrator_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Оценка";
            // 
            // textBoxMarkMarkTeacher
            // 
            this.textBoxMarkMarkTeacher.Location = new System.Drawing.Point(168, 484);
            this.textBoxMarkMarkTeacher.Name = "textBoxMarkMarkTeacher";
            this.textBoxMarkMarkTeacher.Size = new System.Drawing.Size(129, 20);
            this.textBoxMarkMarkTeacher.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(615, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Предмет";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 468);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "ФИО Студента";
            // 
            // checkedListBoxMarkSubjectTeacher
            // 
            this.checkedListBoxMarkSubjectTeacher.CheckOnClick = true;
            this.checkedListBoxMarkSubjectTeacher.FormattingEnabled = true;
            this.checkedListBoxMarkSubjectTeacher.Location = new System.Drawing.Point(618, 484);
            this.checkedListBoxMarkSubjectTeacher.Name = "checkedListBoxMarkSubjectTeacher";
            this.checkedListBoxMarkSubjectTeacher.Size = new System.Drawing.Size(166, 139);
            this.checkedListBoxMarkSubjectTeacher.TabIndex = 1;
            this.checkedListBoxMarkSubjectTeacher.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxOrdersServicesAdministrator_ItemCheck);
            // 
            // dataGridViewMarkTeacher
            // 
            this.dataGridViewMarkTeacher.AllowUserToDeleteRows = false;
            this.dataGridViewMarkTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMarkTeacher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.dataGridViewMarkTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarkTeacher.Location = new System.Drawing.Point(33, 21);
            this.dataGridViewMarkTeacher.MultiSelect = false;
            this.dataGridViewMarkTeacher.Name = "dataGridViewMarkTeacher";
            this.dataGridViewMarkTeacher.ReadOnly = true;
            this.dataGridViewMarkTeacher.Size = new System.Drawing.Size(751, 438);
            this.dataGridViewMarkTeacher.TabIndex = 0;
            this.dataGridViewMarkTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrdersAdministrator_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 500;
            this.label2.Text = "Дата сдачи";
            // 
            // dateTimePickerMarkTeacher
            // 
            this.dateTimePickerMarkTeacher.Location = new System.Drawing.Point(303, 484);
            this.dateTimePickerMarkTeacher.Name = "dateTimePickerMarkTeacher";
            this.dateTimePickerMarkTeacher.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerMarkTeacher.TabIndex = 6;
            // 
            // checkedListBoxMarkAssignTeacher
            // 
            this.checkedListBoxMarkAssignTeacher.CheckOnClick = true;
            this.checkedListBoxMarkAssignTeacher.FormattingEnabled = true;
            this.checkedListBoxMarkAssignTeacher.Location = new System.Drawing.Point(438, 484);
            this.checkedListBoxMarkAssignTeacher.Name = "checkedListBoxMarkAssignTeacher";
            this.checkedListBoxMarkAssignTeacher.Size = new System.Drawing.Size(166, 139);
            this.checkedListBoxMarkAssignTeacher.TabIndex = 501;
            this.checkedListBoxMarkAssignTeacher.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // checkedListBoxMarkStudentTeacher
            // 
            this.checkedListBoxMarkStudentTeacher.CheckOnClick = true;
            this.checkedListBoxMarkStudentTeacher.FormattingEnabled = true;
            this.checkedListBoxMarkStudentTeacher.Location = new System.Drawing.Point(33, 484);
            this.checkedListBoxMarkStudentTeacher.Name = "checkedListBoxMarkStudentTeacher";
            this.checkedListBoxMarkStudentTeacher.Size = new System.Drawing.Size(129, 139);
            this.checkedListBoxMarkStudentTeacher.TabIndex = 502;
            this.checkedListBoxMarkStudentTeacher.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox2_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 503;
            this.label1.Text = "Работа";
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelMainTeacher);
            this.Controls.Add(this.panelSidebarAdministrator);
            this.Name = "FormTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Успеваемость";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTeacher_FormClosed);
            this.panelSidebarAdministrator.ResumeLayout(false);
            this.panelMainTeacher.ResumeLayout(false);
            this.panelMarkTeacher.ResumeLayout(false);
            this.panelMarkTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarkTeacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebarAdministrator;
        private System.Windows.Forms.Button buttonAssignsTeacher;
        private System.Windows.Forms.Button buttonMarksTeacher;
        private System.Windows.Forms.Panel panelMainTeacher;
        private System.Windows.Forms.Panel panelMarkTeacher;
        private System.Windows.Forms.Button buttonMarkAddTeacher;
        private System.Windows.Forms.Button buttonMarkDeleteTeacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMarkMarkTeacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox checkedListBoxMarkSubjectTeacher;
        private System.Windows.Forms.DataGridView dataGridViewMarkTeacher;
        private System.Windows.Forms.DateTimePicker dateTimePickerMarkTeacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBoxMarkAssignTeacher;
        private System.Windows.Forms.CheckedListBox checkedListBoxMarkStudentTeacher;
        private System.Windows.Forms.Label label1;
    }
}