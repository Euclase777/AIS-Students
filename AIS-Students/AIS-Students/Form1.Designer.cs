namespace AIS_Students
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.AuthBGPanel = new System.Windows.Forms.Panel();
            this.buttonAuthEnter = new System.Windows.Forms.Button();
            this.textBoxAuthPassword = new System.Windows.Forms.TextBox();
            this.textBoxAuthLogin = new System.Windows.Forms.TextBox();
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.labelAuth = new System.Windows.Forms.Label();
            this.labelAuthLogin = new System.Windows.Forms.Label();
            this.labelAuthPassword = new System.Windows.Forms.Label();
            this.AuthPanel.SuspendLayout();
            this.AuthBGPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.Controls.Add(this.AuthBGPanel);
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(1099, 698);
            this.AuthPanel.TabIndex = 0;
            // 
            // AuthBGPanel
            // 
            this.AuthBGPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.AuthBGPanel.Controls.Add(this.buttonAuthEnter);
            this.AuthBGPanel.Controls.Add(this.textBoxAuthPassword);
            this.AuthBGPanel.Controls.Add(this.textBoxAuthLogin);
            this.AuthBGPanel.Controls.Add(this.buttonShowPassword);
            this.AuthBGPanel.Controls.Add(this.labelAuth);
            this.AuthBGPanel.Controls.Add(this.labelAuthLogin);
            this.AuthBGPanel.Controls.Add(this.labelAuthPassword);
            this.AuthBGPanel.Location = new System.Drawing.Point(383, 154);
            this.AuthBGPanel.Name = "AuthBGPanel";
            this.AuthBGPanel.Size = new System.Drawing.Size(333, 351);
            this.AuthBGPanel.TabIndex = 0;
            // 
            // buttonAuthEnter
            // 
            this.buttonAuthEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuthEnter.Location = new System.Drawing.Point(187, 278);
            this.buttonAuthEnter.Name = "buttonAuthEnter";
            this.buttonAuthEnter.Size = new System.Drawing.Size(117, 58);
            this.buttonAuthEnter.TabIndex = 9;
            this.buttonAuthEnter.Text = "→";
            this.buttonAuthEnter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAuthEnter.UseVisualStyleBackColor = true;
            this.buttonAuthEnter.Click += new System.EventHandler(this.buttonAuthEnter_Click);
            // 
            // textBoxAuthPassword
            // 
            this.textBoxAuthPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAuthPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxAuthPassword.Location = new System.Drawing.Point(29, 236);
            this.textBoxAuthPassword.MaxLength = 30;
            this.textBoxAuthPassword.Name = "textBoxAuthPassword";
            this.textBoxAuthPassword.PasswordChar = '*';
            this.textBoxAuthPassword.Size = new System.Drawing.Size(230, 32);
            this.textBoxAuthPassword.TabIndex = 7;
            this.textBoxAuthPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAuthPassword_KeyPress);
            // 
            // textBoxAuthLogin
            // 
            this.textBoxAuthLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.textBoxAuthLogin.Location = new System.Drawing.Point(29, 114);
            this.textBoxAuthLogin.MaxLength = 30;
            this.textBoxAuthLogin.Name = "textBoxAuthLogin";
            this.textBoxAuthLogin.Size = new System.Drawing.Size(274, 32);
            this.textBoxAuthLogin.TabIndex = 6;
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonShowPassword.BackgroundImage")));
            this.buttonShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonShowPassword.Location = new System.Drawing.Point(265, 233);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(39, 39);
            this.buttonShowPassword.TabIndex = 8;
            this.buttonShowPassword.UseVisualStyleBackColor = true;
            this.buttonShowPassword.Click += new System.EventHandler(this.buttonShowPassword_Click);
            // 
            // labelAuth
            // 
            this.labelAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuth.Location = new System.Drawing.Point(48, 22);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(236, 46);
            this.labelAuth.TabIndex = 5;
            this.labelAuth.Text = "Авторизуйтесь";
            // 
            // labelAuthLogin
            // 
            this.labelAuthLogin.AutoSize = true;
            this.labelAuthLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelAuthLogin.Location = new System.Drawing.Point(48, 85);
            this.labelAuthLogin.Name = "labelAuthLogin";
            this.labelAuthLogin.Size = new System.Drawing.Size(72, 26);
            this.labelAuthLogin.TabIndex = 4;
            this.labelAuthLogin.Text = "Логин";
            // 
            // labelAuthPassword
            // 
            this.labelAuthPassword.AutoSize = true;
            this.labelAuthPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelAuthPassword.Location = new System.Drawing.Point(48, 207);
            this.labelAuthPassword.Name = "labelAuthPassword";
            this.labelAuthPassword.Size = new System.Drawing.Size(89, 26);
            this.labelAuthPassword.TabIndex = 3;
            this.labelAuthPassword.Text = "Пароль";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.AuthPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.AuthPanel.ResumeLayout(false);
            this.AuthBGPanel.ResumeLayout(false);
            this.AuthBGPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Panel AuthBGPanel;
        private System.Windows.Forms.Button buttonAuthEnter;
        private System.Windows.Forms.TextBox textBoxAuthPassword;
        private System.Windows.Forms.TextBox textBoxAuthLogin;
        private System.Windows.Forms.Button buttonShowPassword;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.Label labelAuthLogin;
        private System.Windows.Forms.Label labelAuthPassword;
    }
}

