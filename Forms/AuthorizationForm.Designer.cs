
namespace WSR2
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.captchaPictureBox = new System.Windows.Forms.PictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.captchaLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.captchaTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.guestButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.captchaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // captchaPictureBox
            // 
            this.captchaPictureBox.Location = new System.Drawing.Point(15, 101);
            this.captchaPictureBox.Name = "captchaPictureBox";
            this.captchaPictureBox.Size = new System.Drawing.Size(392, 192);
            this.captchaPictureBox.TabIndex = 0;
            this.captchaPictureBox.TabStop = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(12, 17);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(110, 19);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Введите логин";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(12, 55);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(116, 19);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Введите пароль";
            // 
            // captchaLabel
            // 
            this.captchaLabel.AutoSize = true;
            this.captchaLabel.Location = new System.Drawing.Point(12, 313);
            this.captchaLabel.Name = "captchaLabel";
            this.captchaLabel.Size = new System.Drawing.Size(200, 19);
            this.captchaLabel.TabIndex = 3;
            this.captchaLabel.Text = "Повторите капчу с картинки";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(160, 14);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(247, 26);
            this.loginTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(160, 52);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(247, 26);
            this.passwordTextBox.TabIndex = 5;
            // 
            // captchaTextBox
            // 
            this.captchaTextBox.Location = new System.Drawing.Point(216, 313);
            this.captchaTextBox.Name = "captchaTextBox";
            this.captchaTextBox.Size = new System.Drawing.Size(191, 26);
            this.captchaTextBox.TabIndex = 6;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.SystemColors.Control;
            this.loginButton.Location = new System.Drawing.Point(332, 344);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 26);
            this.loginButton.TabIndex = 7;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(178, 344);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(148, 26);
            this.refreshButton.TabIndex = 8;
            this.refreshButton.Text = "Обновить капчу";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // guestButton
            // 
            this.guestButton.Location = new System.Drawing.Point(15, 344);
            this.guestButton.Name = "guestButton";
            this.guestButton.Size = new System.Drawing.Size(157, 26);
            this.guestButton.TabIndex = 9;
            this.guestButton.Text = "Войти как гость";
            this.guestButton.UseVisualStyleBackColor = true;
            this.guestButton.Click += new System.EventHandler(this.GuestButton_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(423, 385);
            this.Controls.Add(this.guestButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.captchaTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.captchaLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.captchaPictureBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ООО \"Ювелир\": Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.captchaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox captchaPictureBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label captchaLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox captchaTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button guestButton;
    }
}

