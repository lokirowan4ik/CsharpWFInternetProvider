namespace Курсовая
{
    partial class LoginPage
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
            ResultButton = new Button();
            LoginTextbox = new TextBox();
            PasswordTextbox = new TextBox();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            HelloLabel = new Label();
            EyeClose = new PictureBox();
            EyeOpen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)EyeClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EyeOpen).BeginInit();
            SuspendLayout();
            // 
            // ResultButton
            // 
            ResultButton.BackColor = Color.FromArgb(107, 119, 145);
            ResultButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ResultButton.Location = new Point(196, 385);
            ResultButton.Name = "ResultButton";
            ResultButton.Size = new Size(254, 75);
            ResultButton.TabIndex = 0;
            ResultButton.Text = "Увiйти";
            ResultButton.UseVisualStyleBackColor = false;
            ResultButton.Click += ResultButton_Click;
            // 
            // LoginTextbox
            // 
            LoginTextbox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LoginTextbox.Location = new Point(197, 131);
            LoginTextbox.Multiline = true;
            LoginTextbox.Name = "LoginTextbox";
            LoginTextbox.Size = new Size(254, 63);
            LoginTextbox.TabIndex = 1;
            LoginTextbox.TextChanged += LoginTextbox_TextChanged;
            // 
            // PasswordTextbox
            // 
            PasswordTextbox.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextbox.Location = new Point(197, 257);
            PasswordTextbox.Multiline = true;
            PasswordTextbox.Name = "PasswordTextbox";
            PasswordTextbox.Size = new Size(254, 63);
            PasswordTextbox.TabIndex = 2;
            PasswordTextbox.TextChanged += PasswordTextbox_TextChanged;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginLabel.Location = new Point(12, 143);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(156, 30);
            LoginLabel.TabIndex = 3;
            LoginLabel.Text = "Введіть логiн:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(12, 271);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(177, 30);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Введіть пароль:";
            // 
            // HelloLabel
            // 
            HelloLabel.AutoSize = true;
            HelloLabel.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            HelloLabel.Location = new Point(214, 9);
            HelloLabel.Name = "HelloLabel";
            HelloLabel.Size = new Size(210, 40);
            HelloLabel.TabIndex = 5;
            HelloLabel.Text = "Доброго дня!";
            // 
            // EyeClose
            // 
            EyeClose.BackColor = SystemColors.Window;
            EyeClose.Image = Properties.Resources.greyeye;
            EyeClose.Location = new Point(409, 281);
            EyeClose.Name = "EyeClose";
            EyeClose.Size = new Size(25, 20);
            EyeClose.SizeMode = PictureBoxSizeMode.Zoom;
            EyeClose.TabIndex = 7;
            EyeClose.TabStop = false;
            EyeClose.Visible = false;
            EyeClose.Click += EyeClose_Click;
            // 
            // EyeOpen
            // 
            EyeOpen.BackColor = SystemColors.Window;
            EyeOpen.Image = Properties.Resources.redeye;
            EyeOpen.Location = new Point(409, 281);
            EyeOpen.Name = "EyeOpen";
            EyeOpen.Size = new Size(25, 20);
            EyeOpen.SizeMode = PictureBoxSizeMode.Zoom;
            EyeOpen.TabIndex = 8;
            EyeOpen.TabStop = false;
            EyeOpen.Click += EyeOpen_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(107, 119, 125);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(637, 541);
            Controls.Add(EyeOpen);
            Controls.Add(EyeClose);
            Controls.Add(HelloLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(PasswordTextbox);
            Controls.Add(LoginTextbox);
            Controls.Add(ResultButton);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "LoginPage";
            Text = "Авторизацiя";
            Load += LoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)EyeClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)EyeOpen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ResultButton;
        private TextBox LoginTextbox;
        private TextBox PasswordTextbox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Label HelloLabel;
        private PictureBox EyeClose;
        private PictureBox EyeOpen;
    }
}