namespace AIS_Students
{
    partial class FormAdmin
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
            this.panelMainAdmin = new System.Windows.Forms.Panel();
            this.panelAdminsAdmin = new System.Windows.Forms.Panel();
            this.buttonAdminsAddAdmin = new System.Windows.Forms.Button();
            this.buttonAdminsDeleteAdmin = new System.Windows.Forms.Button();
            this.buttonAdminsEditAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdminsFIOAdmin = new System.Windows.Forms.TextBox();
            this.dataGridViewAdminsAdmin = new System.Windows.Forms.DataGridView();
            this.panelTeachersAdmin = new System.Windows.Forms.Panel();
            this.buttonTeacherAddAdmin = new System.Windows.Forms.Button();
            this.buttonTeacherDeleteAdmin = new System.Windows.Forms.Button();
            this.buttonTeacherEditAdmin = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxTeacherFIOAdmin = new System.Windows.Forms.TextBox();
            this.dataGridViewTeacherAdmin = new System.Windows.Forms.DataGridView();
            this.panelStudentAdmin = new System.Windows.Forms.Panel();
            this.labelGroupsAdmin = new System.Windows.Forms.Label();
            this.checkedListBoxGroupStudentAdmin = new System.Windows.Forms.CheckedListBox();
            this.buttonStudentCreateAdmin = new System.Windows.Forms.Button();
            this.buttonStudentDeleteAdmin = new System.Windows.Forms.Button();
            this.labelStudentNameAdmin = new System.Windows.Forms.Label();
            this.textBoxStudentNameAdmin = new System.Windows.Forms.TextBox();
            this.dataGridViewStudentAdmin = new System.Windows.Forms.DataGridView();
            this.panelGroupAdmin = new System.Windows.Forms.Panel();
            this.textBoxGroupClassAdmin = new System.Windows.Forms.TextBox();
            this.buttonGroupCreateAdmin = new System.Windows.Forms.Button();
            this.buttonGroupDeleteAdmin = new System.Windows.Forms.Button();
            this.labelGroupClassAdmin = new System.Windows.Forms.Label();
            this.labelGroupNameAdmin = new System.Windows.Forms.Label();
            this.textBoxGroupNameAdmin = new System.Windows.Forms.TextBox();
            this.labelGroupFacultyAdmin = new System.Windows.Forms.Label();
            this.textBoxGroupFacultyAdmin = new System.Windows.Forms.TextBox();
            this.dataGridViewGroupAdmin = new System.Windows.Forms.DataGridView();
            this.panelSidebarAdmin = new System.Windows.Forms.Panel();
            this.buttonGroupAdmin = new System.Windows.Forms.Button();
            this.buttonStudentsAdmin = new System.Windows.Forms.Button();
            this.buttonTeachersAdmin = new System.Windows.Forms.Button();
            this.buttonAdminAdmin = new System.Windows.Forms.Button();
            this.panelMainAdmin.SuspendLayout();
            this.panelAdminsAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminsAdmin)).BeginInit();
            this.panelTeachersAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacherAdmin)).BeginInit();
            this.panelStudentAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentAdmin)).BeginInit();
            this.panelGroupAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupAdmin)).BeginInit();
            this.panelSidebarAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainAdmin
            // 
            this.panelMainAdmin.Controls.Add(this.panelStudentAdmin);
            this.panelMainAdmin.Controls.Add(this.panelGroupAdmin);
            this.panelMainAdmin.Controls.Add(this.panelAdminsAdmin);
            this.panelMainAdmin.Controls.Add(this.panelTeachersAdmin);
            this.panelMainAdmin.Location = new System.Drawing.Point(189, 0);
            this.panelMainAdmin.Name = "panelMainAdmin";
            this.panelMainAdmin.Size = new System.Drawing.Size(912, 700);
            this.panelMainAdmin.TabIndex = 11;
            // 
            // panelAdminsAdmin
            // 
            this.panelAdminsAdmin.Controls.Add(this.buttonAdminsAddAdmin);
            this.panelAdminsAdmin.Controls.Add(this.buttonAdminsDeleteAdmin);
            this.panelAdminsAdmin.Controls.Add(this.buttonAdminsEditAdmin);
            this.panelAdminsAdmin.Controls.Add(this.label1);
            this.panelAdminsAdmin.Controls.Add(this.textBoxAdminsFIOAdmin);
            this.panelAdminsAdmin.Controls.Add(this.dataGridViewAdminsAdmin);
            this.panelAdminsAdmin.Location = new System.Drawing.Point(40, 22);
            this.panelAdminsAdmin.Name = "panelAdminsAdmin";
            this.panelAdminsAdmin.Size = new System.Drawing.Size(805, 668);
            this.panelAdminsAdmin.TabIndex = 8;
            this.panelAdminsAdmin.Visible = false;
            // 
            // buttonAdminsAddAdmin
            // 
            this.buttonAdminsAddAdmin.Location = new System.Drawing.Point(33, 585);
            this.buttonAdminsAddAdmin.Name = "buttonAdminsAddAdmin";
            this.buttonAdminsAddAdmin.Size = new System.Drawing.Size(129, 38);
            this.buttonAdminsAddAdmin.TabIndex = 7;
            this.buttonAdminsAddAdmin.Text = "Добавить администратора";
            this.buttonAdminsAddAdmin.UseVisualStyleBackColor = true;
            this.buttonAdminsAddAdmin.Click += new System.EventHandler(this.buttonAdminsAddAdmin_Click);
            // 
            // buttonAdminsDeleteAdmin
            // 
            this.buttonAdminsDeleteAdmin.Location = new System.Drawing.Point(303, 585);
            this.buttonAdminsDeleteAdmin.Name = "buttonAdminsDeleteAdmin";
            this.buttonAdminsDeleteAdmin.Size = new System.Drawing.Size(129, 38);
            this.buttonAdminsDeleteAdmin.TabIndex = 9;
            this.buttonAdminsDeleteAdmin.Text = "Удалить администратора";
            this.buttonAdminsDeleteAdmin.UseVisualStyleBackColor = true;
            this.buttonAdminsDeleteAdmin.Click += new System.EventHandler(this.buttonAdminsDeleteAdmin_Click);
            // 
            // buttonAdminsEditAdmin
            // 
            this.buttonAdminsEditAdmin.Location = new System.Drawing.Point(168, 585);
            this.buttonAdminsEditAdmin.Name = "buttonAdminsEditAdmin";
            this.buttonAdminsEditAdmin.Size = new System.Drawing.Size(129, 38);
            this.buttonAdminsEditAdmin.TabIndex = 8;
            this.buttonAdminsEditAdmin.Text = "Сохранить изменения";
            this.buttonAdminsEditAdmin.UseVisualStyleBackColor = true;
            this.buttonAdminsEditAdmin.Click += new System.EventHandler(this.buttonAdminsEditAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 535);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // textBoxAdminsFIOAdmin
            // 
            this.textBoxAdminsFIOAdmin.Location = new System.Drawing.Point(33, 559);
            this.textBoxAdminsFIOAdmin.Name = "textBoxAdminsFIOAdmin";
            this.textBoxAdminsFIOAdmin.Size = new System.Drawing.Size(399, 20);
            this.textBoxAdminsFIOAdmin.TabIndex = 3;
            // 
            // dataGridViewAdminsAdmin
            // 
            this.dataGridViewAdminsAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewAdminsAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdminsAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.dataGridViewAdminsAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminsAdmin.Location = new System.Drawing.Point(33, 21);
            this.dataGridViewAdminsAdmin.MultiSelect = false;
            this.dataGridViewAdminsAdmin.Name = "dataGridViewAdminsAdmin";
            this.dataGridViewAdminsAdmin.ReadOnly = true;
            this.dataGridViewAdminsAdmin.Size = new System.Drawing.Size(751, 499);
            this.dataGridViewAdminsAdmin.TabIndex = 0;
            this.dataGridViewAdminsAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdminsAdmin_CellClick);
            // 
            // panelTeachersAdmin
            // 
            this.panelTeachersAdmin.Controls.Add(this.buttonTeacherAddAdmin);
            this.panelTeachersAdmin.Controls.Add(this.buttonTeacherDeleteAdmin);
            this.panelTeachersAdmin.Controls.Add(this.buttonTeacherEditAdmin);
            this.panelTeachersAdmin.Controls.Add(this.label17);
            this.panelTeachersAdmin.Controls.Add(this.textBoxTeacherFIOAdmin);
            this.panelTeachersAdmin.Controls.Add(this.dataGridViewTeacherAdmin);
            this.panelTeachersAdmin.Location = new System.Drawing.Point(41, 21);
            this.panelTeachersAdmin.Name = "panelTeachersAdmin";
            this.panelTeachersAdmin.Size = new System.Drawing.Size(805, 668);
            this.panelTeachersAdmin.TabIndex = 7;
            this.panelTeachersAdmin.Visible = false;
            // 
            // buttonTeacherAddAdmin
            // 
            this.buttonTeacherAddAdmin.Location = new System.Drawing.Point(33, 585);
            this.buttonTeacherAddAdmin.Name = "buttonTeacherAddAdmin";
            this.buttonTeacherAddAdmin.Size = new System.Drawing.Size(129, 38);
            this.buttonTeacherAddAdmin.TabIndex = 7;
            this.buttonTeacherAddAdmin.Text = "Добавить учителя";
            this.buttonTeacherAddAdmin.UseVisualStyleBackColor = true;
            this.buttonTeacherAddAdmin.Click += new System.EventHandler(this.buttonWorkersCreateAdministrator_Click);
            // 
            // buttonTeacherDeleteAdmin
            // 
            this.buttonTeacherDeleteAdmin.Location = new System.Drawing.Point(303, 585);
            this.buttonTeacherDeleteAdmin.Name = "buttonTeacherDeleteAdmin";
            this.buttonTeacherDeleteAdmin.Size = new System.Drawing.Size(129, 38);
            this.buttonTeacherDeleteAdmin.TabIndex = 9;
            this.buttonTeacherDeleteAdmin.Text = "Удалить выбранного рабочего";
            this.buttonTeacherDeleteAdmin.UseVisualStyleBackColor = true;
            this.buttonTeacherDeleteAdmin.Click += new System.EventHandler(this.buttonTeacherDeleteAdmin_Click);
            // 
            // buttonTeacherEditAdmin
            // 
            this.buttonTeacherEditAdmin.Location = new System.Drawing.Point(168, 585);
            this.buttonTeacherEditAdmin.Name = "buttonTeacherEditAdmin";
            this.buttonTeacherEditAdmin.Size = new System.Drawing.Size(129, 38);
            this.buttonTeacherEditAdmin.TabIndex = 8;
            this.buttonTeacherEditAdmin.Text = "Сохранить изменения выбранного рабочего";
            this.buttonTeacherEditAdmin.UseVisualStyleBackColor = true;
            this.buttonTeacherEditAdmin.Click += new System.EventHandler(this.buttonTeacherEditAdmin_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(33, 535);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "ФИО";
            // 
            // textBoxTeacherFIOAdmin
            // 
            this.textBoxTeacherFIOAdmin.Location = new System.Drawing.Point(33, 559);
            this.textBoxTeacherFIOAdmin.Name = "textBoxTeacherFIOAdmin";
            this.textBoxTeacherFIOAdmin.Size = new System.Drawing.Size(399, 20);
            this.textBoxTeacherFIOAdmin.TabIndex = 3;
            // 
            // dataGridViewTeacherAdmin
            // 
            this.dataGridViewTeacherAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewTeacherAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTeacherAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.dataGridViewTeacherAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacherAdmin.Location = new System.Drawing.Point(33, 21);
            this.dataGridViewTeacherAdmin.MultiSelect = false;
            this.dataGridViewTeacherAdmin.Name = "dataGridViewTeacherAdmin";
            this.dataGridViewTeacherAdmin.ReadOnly = true;
            this.dataGridViewTeacherAdmin.Size = new System.Drawing.Size(751, 499);
            this.dataGridViewTeacherAdmin.TabIndex = 0;
            this.dataGridViewTeacherAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWorkersAdministrator_CellClick);
            // 
            // panelStudentAdmin
            // 
            this.panelStudentAdmin.Controls.Add(this.labelGroupsAdmin);
            this.panelStudentAdmin.Controls.Add(this.checkedListBoxGroupStudentAdmin);
            this.panelStudentAdmin.Controls.Add(this.buttonStudentCreateAdmin);
            this.panelStudentAdmin.Controls.Add(this.buttonStudentDeleteAdmin);
            this.panelStudentAdmin.Controls.Add(this.labelStudentNameAdmin);
            this.panelStudentAdmin.Controls.Add(this.textBoxStudentNameAdmin);
            this.panelStudentAdmin.Controls.Add(this.dataGridViewStudentAdmin);
            this.panelStudentAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelStudentAdmin.Name = "panelStudentAdmin";
            this.panelStudentAdmin.Size = new System.Drawing.Size(805, 668);
            this.panelStudentAdmin.TabIndex = 5;
            this.panelStudentAdmin.Visible = false;
            // 
            // labelGroupsAdmin
            // 
            this.labelGroupsAdmin.AutoSize = true;
            this.labelGroupsAdmin.Location = new System.Drawing.Point(318, 535);
            this.labelGroupsAdmin.Name = "labelGroupsAdmin";
            this.labelGroupsAdmin.Size = new System.Drawing.Size(44, 13);
            this.labelGroupsAdmin.TabIndex = 12;
            this.labelGroupsAdmin.Text = "Группы";
            // 
            // checkedListBoxGroupStudentAdmin
            // 
            this.checkedListBoxGroupStudentAdmin.CheckOnClick = true;
            this.checkedListBoxGroupStudentAdmin.FormattingEnabled = true;
            this.checkedListBoxGroupStudentAdmin.Location = new System.Drawing.Point(321, 559);
            this.checkedListBoxGroupStudentAdmin.Name = "checkedListBoxGroupStudentAdmin";
            this.checkedListBoxGroupStudentAdmin.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxGroupStudentAdmin.TabIndex = 11;
            this.checkedListBoxGroupStudentAdmin.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxGroupStudentAdmin_ItemCheck);
            // 
            // buttonStudentCreateAdmin
            // 
            this.buttonStudentCreateAdmin.Location = new System.Drawing.Point(33, 585);
            this.buttonStudentCreateAdmin.Name = "buttonStudentCreateAdmin";
            this.buttonStudentCreateAdmin.Size = new System.Drawing.Size(129, 38);
            this.buttonStudentCreateAdmin.TabIndex = 8;
            this.buttonStudentCreateAdmin.Text = "Добавить студента";
            this.buttonStudentCreateAdmin.UseVisualStyleBackColor = true;
            this.buttonStudentCreateAdmin.Click += new System.EventHandler(this.buttonStudentCreateAdmin_Click);
            // 
            // buttonStudentDeleteAdmin
            // 
            this.buttonStudentDeleteAdmin.Location = new System.Drawing.Point(168, 585);
            this.buttonStudentDeleteAdmin.Name = "buttonStudentDeleteAdmin";
            this.buttonStudentDeleteAdmin.Size = new System.Drawing.Size(129, 38);
            this.buttonStudentDeleteAdmin.TabIndex = 10;
            this.buttonStudentDeleteAdmin.Text = "Удалить студента";
            this.buttonStudentDeleteAdmin.UseVisualStyleBackColor = true;
            this.buttonStudentDeleteAdmin.Click += new System.EventHandler(this.buttonStudentDeleteAdmin_Click);
            // 
            // labelStudentNameAdmin
            // 
            this.labelStudentNameAdmin.AutoSize = true;
            this.labelStudentNameAdmin.Location = new System.Drawing.Point(33, 535);
            this.labelStudentNameAdmin.Name = "labelStudentNameAdmin";
            this.labelStudentNameAdmin.Size = new System.Drawing.Size(82, 13);
            this.labelStudentNameAdmin.TabIndex = 4;
            this.labelStudentNameAdmin.Text = "ФИО студента";
            // 
            // textBoxStudentNameAdmin
            // 
            this.textBoxStudentNameAdmin.Location = new System.Drawing.Point(33, 559);
            this.textBoxStudentNameAdmin.Name = "textBoxStudentNameAdmin";
            this.textBoxStudentNameAdmin.Size = new System.Drawing.Size(264, 20);
            this.textBoxStudentNameAdmin.TabIndex = 3;
            // 
            // dataGridViewStudentAdmin
            // 
            this.dataGridViewStudentAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewStudentAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudentAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.dataGridViewStudentAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentAdmin.Location = new System.Drawing.Point(33, 21);
            this.dataGridViewStudentAdmin.MultiSelect = false;
            this.dataGridViewStudentAdmin.Name = "dataGridViewStudentAdmin";
            this.dataGridViewStudentAdmin.ReadOnly = true;
            this.dataGridViewStudentAdmin.Size = new System.Drawing.Size(751, 499);
            this.dataGridViewStudentAdmin.TabIndex = 0;
            this.dataGridViewStudentAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentAdmin_CellClick);
            // 
            // panelGroupAdmin
            // 
            this.panelGroupAdmin.Controls.Add(this.textBoxGroupClassAdmin);
            this.panelGroupAdmin.Controls.Add(this.buttonGroupCreateAdmin);
            this.panelGroupAdmin.Controls.Add(this.buttonGroupDeleteAdmin);
            this.panelGroupAdmin.Controls.Add(this.labelGroupClassAdmin);
            this.panelGroupAdmin.Controls.Add(this.labelGroupNameAdmin);
            this.panelGroupAdmin.Controls.Add(this.textBoxGroupNameAdmin);
            this.panelGroupAdmin.Controls.Add(this.labelGroupFacultyAdmin);
            this.panelGroupAdmin.Controls.Add(this.textBoxGroupFacultyAdmin);
            this.panelGroupAdmin.Controls.Add(this.dataGridViewGroupAdmin);
            this.panelGroupAdmin.Location = new System.Drawing.Point(41, 21);
            this.panelGroupAdmin.Name = "panelGroupAdmin";
            this.panelGroupAdmin.Size = new System.Drawing.Size(805, 668);
            this.panelGroupAdmin.TabIndex = 4;
            this.panelGroupAdmin.Visible = false;
            // 
            // textBoxGroupClassAdmin
            // 
            this.textBoxGroupClassAdmin.Location = new System.Drawing.Point(306, 501);
            this.textBoxGroupClassAdmin.Name = "textBoxGroupClassAdmin";
            this.textBoxGroupClassAdmin.Size = new System.Drawing.Size(129, 20);
            this.textBoxGroupClassAdmin.TabIndex = 501;
            // 
            // buttonGroupCreateAdmin
            // 
            this.buttonGroupCreateAdmin.Location = new System.Drawing.Point(33, 585);
            this.buttonGroupCreateAdmin.Name = "buttonGroupCreateAdmin";
            this.buttonGroupCreateAdmin.Size = new System.Drawing.Size(129, 38);
            this.buttonGroupCreateAdmin.TabIndex = 8;
            this.buttonGroupCreateAdmin.Text = "Добавить группу";
            this.buttonGroupCreateAdmin.UseVisualStyleBackColor = true;
            this.buttonGroupCreateAdmin.Click += new System.EventHandler(this.buttonGroupCreateAdmin_Click);
            // 
            // buttonGroupDeleteAdmin
            // 
            this.buttonGroupDeleteAdmin.Location = new System.Drawing.Point(168, 585);
            this.buttonGroupDeleteAdmin.Name = "buttonGroupDeleteAdmin";
            this.buttonGroupDeleteAdmin.Size = new System.Drawing.Size(129, 38);
            this.buttonGroupDeleteAdmin.TabIndex = 10;
            this.buttonGroupDeleteAdmin.Text = "Удалить выбранную группу";
            this.buttonGroupDeleteAdmin.UseVisualStyleBackColor = true;
            this.buttonGroupDeleteAdmin.Click += new System.EventHandler(this.buttonGroupDeleteAdmin_Click);
            // 
            // labelGroupClassAdmin
            // 
            this.labelGroupClassAdmin.AutoSize = true;
            this.labelGroupClassAdmin.Location = new System.Drawing.Point(303, 477);
            this.labelGroupClassAdmin.Name = "labelGroupClassAdmin";
            this.labelGroupClassAdmin.Size = new System.Drawing.Size(31, 13);
            this.labelGroupClassAdmin.TabIndex = 500;
            this.labelGroupClassAdmin.Text = "Курс";
            // 
            // labelGroupNameAdmin
            // 
            this.labelGroupNameAdmin.AutoSize = true;
            this.labelGroupNameAdmin.Location = new System.Drawing.Point(168, 477);
            this.labelGroupNameAdmin.Name = "labelGroupNameAdmin";
            this.labelGroupNameAdmin.Size = new System.Drawing.Size(42, 13);
            this.labelGroupNameAdmin.TabIndex = 8;
            this.labelGroupNameAdmin.Text = "Группа";
            // 
            // textBoxGroupNameAdmin
            // 
            this.textBoxGroupNameAdmin.Location = new System.Drawing.Point(168, 501);
            this.textBoxGroupNameAdmin.Name = "textBoxGroupNameAdmin";
            this.textBoxGroupNameAdmin.Size = new System.Drawing.Size(129, 20);
            this.textBoxGroupNameAdmin.TabIndex = 4;
            // 
            // labelGroupFacultyAdmin
            // 
            this.labelGroupFacultyAdmin.AutoSize = true;
            this.labelGroupFacultyAdmin.Location = new System.Drawing.Point(33, 477);
            this.labelGroupFacultyAdmin.Name = "labelGroupFacultyAdmin";
            this.labelGroupFacultyAdmin.Size = new System.Drawing.Size(85, 13);
            this.labelGroupFacultyAdmin.TabIndex = 4;
            this.labelGroupFacultyAdmin.Text = "Специальность";
            // 
            // textBoxGroupFacultyAdmin
            // 
            this.textBoxGroupFacultyAdmin.Location = new System.Drawing.Point(33, 501);
            this.textBoxGroupFacultyAdmin.Name = "textBoxGroupFacultyAdmin";
            this.textBoxGroupFacultyAdmin.Size = new System.Drawing.Size(129, 20);
            this.textBoxGroupFacultyAdmin.TabIndex = 3;
            // 
            // dataGridViewGroupAdmin
            // 
            this.dataGridViewGroupAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewGroupAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGroupAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.dataGridViewGroupAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroupAdmin.Location = new System.Drawing.Point(33, 21);
            this.dataGridViewGroupAdmin.MultiSelect = false;
            this.dataGridViewGroupAdmin.Name = "dataGridViewGroupAdmin";
            this.dataGridViewGroupAdmin.ReadOnly = true;
            this.dataGridViewGroupAdmin.Size = new System.Drawing.Size(751, 438);
            this.dataGridViewGroupAdmin.TabIndex = 0;
            // 
            // panelSidebarAdmin
            // 
            this.panelSidebarAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panelSidebarAdmin.Controls.Add(this.buttonGroupAdmin);
            this.panelSidebarAdmin.Controls.Add(this.buttonStudentsAdmin);
            this.panelSidebarAdmin.Controls.Add(this.buttonTeachersAdmin);
            this.panelSidebarAdmin.Controls.Add(this.buttonAdminAdmin);
            this.panelSidebarAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelSidebarAdmin.Name = "panelSidebarAdmin";
            this.panelSidebarAdmin.Size = new System.Drawing.Size(189, 700);
            this.panelSidebarAdmin.TabIndex = 12;
            // 
            // buttonGroupAdmin
            // 
            this.buttonGroupAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonGroupAdmin.FlatAppearance.BorderSize = 0;
            this.buttonGroupAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroupAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGroupAdmin.Location = new System.Drawing.Point(20, 20);
            this.buttonGroupAdmin.Name = "buttonGroupAdmin";
            this.buttonGroupAdmin.Size = new System.Drawing.Size(144, 42);
            this.buttonGroupAdmin.TabIndex = 1;
            this.buttonGroupAdmin.Text = "Группы";
            this.buttonGroupAdmin.UseVisualStyleBackColor = false;
            this.buttonGroupAdmin.Click += new System.EventHandler(this.buttonGroupAdmin_Click);
            // 
            // buttonStudentsAdmin
            // 
            this.buttonStudentsAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonStudentsAdmin.FlatAppearance.BorderSize = 0;
            this.buttonStudentsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentsAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentsAdmin.Location = new System.Drawing.Point(20, 90);
            this.buttonStudentsAdmin.Name = "buttonStudentsAdmin";
            this.buttonStudentsAdmin.Size = new System.Drawing.Size(144, 42);
            this.buttonStudentsAdmin.TabIndex = 2;
            this.buttonStudentsAdmin.Text = "Студенты";
            this.buttonStudentsAdmin.UseVisualStyleBackColor = true;
            this.buttonStudentsAdmin.Click += new System.EventHandler(this.buttonStudentsAdmin_Click);
            // 
            // buttonTeachersAdmin
            // 
            this.buttonTeachersAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonTeachersAdmin.FlatAppearance.BorderSize = 0;
            this.buttonTeachersAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTeachersAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTeachersAdmin.Location = new System.Drawing.Point(20, 160);
            this.buttonTeachersAdmin.Name = "buttonTeachersAdmin";
            this.buttonTeachersAdmin.Size = new System.Drawing.Size(144, 42);
            this.buttonTeachersAdmin.TabIndex = 3;
            this.buttonTeachersAdmin.Text = "Учителя";
            this.buttonTeachersAdmin.UseVisualStyleBackColor = true;
            this.buttonTeachersAdmin.Click += new System.EventHandler(this.buttonTeachersAdmin_Click);
            // 
            // buttonAdminAdmin
            // 
            this.buttonAdminAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonAdminAdmin.FlatAppearance.BorderSize = 0;
            this.buttonAdminAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdminAdmin.Location = new System.Drawing.Point(20, 230);
            this.buttonAdminAdmin.Name = "buttonAdminAdmin";
            this.buttonAdminAdmin.Size = new System.Drawing.Size(144, 42);
            this.buttonAdminAdmin.TabIndex = 4;
            this.buttonAdminAdmin.Text = "Администрация";
            this.buttonAdminAdmin.UseVisualStyleBackColor = true;
            this.buttonAdminAdmin.Click += new System.EventHandler(this.buttonAdminAdmin_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.panelSidebarAdmin);
            this.Controls.Add(this.panelMainAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Админ-панель";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panelMainAdmin.ResumeLayout(false);
            this.panelAdminsAdmin.ResumeLayout(false);
            this.panelAdminsAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminsAdmin)).EndInit();
            this.panelTeachersAdmin.ResumeLayout(false);
            this.panelTeachersAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacherAdmin)).EndInit();
            this.panelStudentAdmin.ResumeLayout(false);
            this.panelStudentAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentAdmin)).EndInit();
            this.panelGroupAdmin.ResumeLayout(false);
            this.panelGroupAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroupAdmin)).EndInit();
            this.panelSidebarAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainAdmin;
        private System.Windows.Forms.Panel panelTeachersAdmin;
        private System.Windows.Forms.Button buttonTeacherAddAdmin;
        private System.Windows.Forms.Button buttonTeacherDeleteAdmin;
        private System.Windows.Forms.Button buttonTeacherEditAdmin;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxTeacherFIOAdmin;
        private System.Windows.Forms.DataGridView dataGridViewTeacherAdmin;
        private System.Windows.Forms.Panel panelStudentAdmin;
        private System.Windows.Forms.Button buttonStudentCreateAdmin;
        private System.Windows.Forms.Button buttonStudentDeleteAdmin;
        private System.Windows.Forms.Label labelStudentNameAdmin;
        private System.Windows.Forms.TextBox textBoxStudentNameAdmin;
        private System.Windows.Forms.DataGridView dataGridViewStudentAdmin;
        private System.Windows.Forms.Panel panelGroupAdmin;
        private System.Windows.Forms.Button buttonGroupCreateAdmin;
        private System.Windows.Forms.Button buttonGroupDeleteAdmin;
        private System.Windows.Forms.Label labelGroupClassAdmin;
        private System.Windows.Forms.Label labelGroupNameAdmin;
        private System.Windows.Forms.TextBox textBoxGroupNameAdmin;
        private System.Windows.Forms.Label labelGroupFacultyAdmin;
        private System.Windows.Forms.TextBox textBoxGroupFacultyAdmin;
        private System.Windows.Forms.DataGridView dataGridViewGroupAdmin;
        private System.Windows.Forms.Panel panelSidebarAdmin;
        private System.Windows.Forms.Button buttonAdminAdmin;
        private System.Windows.Forms.Button buttonTeachersAdmin;
        private System.Windows.Forms.Button buttonStudentsAdmin;
        private System.Windows.Forms.Button buttonGroupAdmin;
        private System.Windows.Forms.TextBox textBoxGroupClassAdmin;
        private System.Windows.Forms.Label labelGroupsAdmin;
        private System.Windows.Forms.CheckedListBox checkedListBoxGroupStudentAdmin;
        private System.Windows.Forms.Panel panelAdminsAdmin;
        private System.Windows.Forms.Button buttonAdminsAddAdmin;
        private System.Windows.Forms.Button buttonAdminsDeleteAdmin;
        private System.Windows.Forms.Button buttonAdminsEditAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdminsFIOAdmin;
        private System.Windows.Forms.DataGridView dataGridViewAdminsAdmin;
    }
}