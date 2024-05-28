namespace Курсовая.Формы.Создание_рабочих
{
    partial class AddWorker
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
            Create_Worker = new Button();
            WorkerPbCorrectEmai = new PictureBox();
            WorkerPbCorrectPhon = new PictureBox();
            CountrySpecForTelephoneCb = new ComboBox();
            Gender_label = new Label();
            Gender_combobox = new ComboBox();
            Name_brigade_combobox = new ComboBox();
            label_brwr_speciality = new Label();
            label_brwr_mnane = new Label();
            label_brwr_lname = new Label();
            label_brwr_fname = new Label();
            label_brwr_email = new Label();
            label_brwr_phone = new Label();
            label_brwr_login = new Label();
            textBox_brwr_speciality = new TextBox();
            textBox_brwr_mname = new TextBox();
            textBox_brwr_lname = new TextBox();
            textBox_brwr_fname = new TextBox();
            textBox_brwr_email = new TextBox();
            textBox_brwr_phone = new TextBox();
            textBox_brwr_login = new TextBox();
            label_br_name = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)WorkerPbCorrectEmai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WorkerPbCorrectPhon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Create_Worker
            // 
            Create_Worker.BackColor = Color.DarkSeaGreen;
            Create_Worker.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Create_Worker.Location = new Point(198, 472);
            Create_Worker.Name = "Create_Worker";
            Create_Worker.Size = new Size(308, 63);
            Create_Worker.TabIndex = 4;
            Create_Worker.Text = "Добавить";
            Create_Worker.UseVisualStyleBackColor = false;
            Create_Worker.Click += Create_Worker_Click;
            // 
            // WorkerPbCorrectEmai
            // 
            WorkerPbCorrectEmai.Location = new Point(517, 295);
            WorkerPbCorrectEmai.Name = "WorkerPbCorrectEmai";
            WorkerPbCorrectEmai.Size = new Size(21, 22);
            WorkerPbCorrectEmai.TabIndex = 43;
            WorkerPbCorrectEmai.TabStop = false;
            // 
            // WorkerPbCorrectPhon
            // 
            WorkerPbCorrectPhon.Location = new Point(517, 250);
            WorkerPbCorrectPhon.Name = "WorkerPbCorrectPhon";
            WorkerPbCorrectPhon.Size = new Size(21, 22);
            WorkerPbCorrectPhon.TabIndex = 42;
            WorkerPbCorrectPhon.TabStop = false;
            // 
            // CountrySpecForTelephoneCb
            // 
            CountrySpecForTelephoneCb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CountrySpecForTelephoneCb.Items.AddRange(new object[] { "+38", "+7", "+1", "+44" });
            CountrySpecForTelephoneCb.Location = new Point(299, 249);
            CountrySpecForTelephoneCb.Name = "CountrySpecForTelephoneCb";
            CountrySpecForTelephoneCb.Size = new Size(62, 33);
            CountrySpecForTelephoneCb.TabIndex = 41;
            CountrySpecForTelephoneCb.SelectedIndexChanged += CountrySpecForTelephoneCb_SelectedIndexChanged_1;
            // 
            // Gender_label
            // 
            Gender_label.AutoSize = true;
            Gender_label.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            Gender_label.Location = new Point(206, 209);
            Gender_label.Name = "Gender_label";
            Gender_label.Size = new Size(78, 32);
            Gender_label.TabIndex = 40;
            Gender_label.Text = "Стать:";
            // 
            // Gender_combobox
            // 
            Gender_combobox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Gender_combobox.Location = new Point(299, 210);
            Gender_combobox.Name = "Gender_combobox";
            Gender_combobox.Size = new Size(205, 33);
            Gender_combobox.TabIndex = 39;
            // 
            // Name_brigade_combobox
            // 
            Name_brigade_combobox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name_brigade_combobox.Location = new Point(299, 141);
            Name_brigade_combobox.Name = "Name_brigade_combobox";
            Name_brigade_combobox.Size = new Size(205, 33);
            Name_brigade_combobox.TabIndex = 27;
            // 
            // label_brwr_speciality
            // 
            label_brwr_speciality.AutoSize = true;
            label_brwr_speciality.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_brwr_speciality.Location = new Point(106, 315);
            label_brwr_speciality.Name = "label_brwr_speciality";
            label_brwr_speciality.Size = new Size(171, 32);
            label_brwr_speciality.TabIndex = 38;
            label_brwr_speciality.Text = "Спецiальнiсть:";
            // 
            // label_brwr_mnane
            // 
            label_brwr_mnane.AutoSize = true;
            label_brwr_mnane.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_brwr_mnane.Location = new Point(134, 114);
            label_brwr_mnane.Name = "label_brwr_mnane";
            label_brwr_mnane.Size = new Size(150, 32);
            label_brwr_mnane.TabIndex = 37;
            label_brwr_mnane.Text = "По батьковi:";
            // 
            // label_brwr_lname
            // 
            label_brwr_lname.AutoSize = true;
            label_brwr_lname.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_brwr_lname.Location = new Point(157, 82);
            label_brwr_lname.Name = "label_brwr_lname";
            label_brwr_lname.Size = new Size(127, 32);
            label_brwr_lname.TabIndex = 36;
            label_brwr_lname.Text = "Прізвище:";
            // 
            // label_brwr_fname
            // 
            label_brwr_fname.AutoSize = true;
            label_brwr_fname.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_brwr_fname.Location = new Point(217, 50);
            label_brwr_fname.Name = "label_brwr_fname";
            label_brwr_fname.Size = new Size(60, 32);
            label_brwr_fname.TabIndex = 35;
            label_brwr_fname.Text = "Iм'я:";
            // 
            // label_brwr_email
            // 
            label_brwr_email.AutoSize = true;
            label_brwr_email.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_brwr_email.Location = new Point(179, 283);
            label_brwr_email.Name = "label_brwr_email";
            label_brwr_email.Size = new Size(98, 32);
            label_brwr_email.TabIndex = 34;
            label_brwr_email.Text = "Е-мейл:";
            // 
            // label_brwr_phone
            // 
            label_brwr_phone.AutoSize = true;
            label_brwr_phone.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_brwr_phone.Location = new Point(169, 250);
            label_brwr_phone.Name = "label_brwr_phone";
            label_brwr_phone.Size = new Size(115, 32);
            label_brwr_phone.TabIndex = 33;
            label_brwr_phone.Text = "Телефон:";
            // 
            // label_brwr_login
            // 
            label_brwr_login.AutoSize = true;
            label_brwr_login.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_brwr_login.Location = new Point(206, 174);
            label_brwr_login.Name = "label_brwr_login";
            label_brwr_login.Size = new Size(78, 32);
            label_brwr_login.TabIndex = 32;
            label_brwr_login.Text = "Логiн:";
            // 
            // textBox_brwr_speciality
            // 
            textBox_brwr_speciality.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_brwr_speciality.Location = new Point(299, 315);
            textBox_brwr_speciality.Name = "textBox_brwr_speciality";
            textBox_brwr_speciality.Size = new Size(205, 33);
            textBox_brwr_speciality.TabIndex = 31;
            textBox_brwr_speciality.TextChanged += textBox_brwr_speciality_TextChanged;
            textBox_brwr_speciality.KeyPress += KeyPressForAllWhoString;
            // 
            // textBox_brwr_mname
            // 
            textBox_brwr_mname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_brwr_mname.Location = new Point(299, 111);
            textBox_brwr_mname.Name = "textBox_brwr_mname";
            textBox_brwr_mname.Size = new Size(205, 33);
            textBox_brwr_mname.TabIndex = 30;
            textBox_brwr_mname.TextChanged += textBox_brwr_mname_TextChanged;
            textBox_brwr_mname.KeyPress += KeyPressForAllWhoString;
            // 
            // textBox_brwr_lname
            // 
            textBox_brwr_lname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_brwr_lname.Location = new Point(299, 79);
            textBox_brwr_lname.Name = "textBox_brwr_lname";
            textBox_brwr_lname.Size = new Size(205, 33);
            textBox_brwr_lname.TabIndex = 29;
            textBox_brwr_lname.TextChanged += textBox_brwr_lname_TextChanged;
            textBox_brwr_lname.KeyPress += KeyPressForAllWhoString;
            // 
            // textBox_brwr_fname
            // 
            textBox_brwr_fname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_brwr_fname.Location = new Point(299, 46);
            textBox_brwr_fname.Name = "textBox_brwr_fname";
            textBox_brwr_fname.Size = new Size(205, 33);
            textBox_brwr_fname.TabIndex = 28;
            textBox_brwr_fname.TextChanged += textBox_brwr_fname_TextChanged;
            textBox_brwr_fname.KeyPress += KeyPressForAllWhoString;
            // 
            // textBox_brwr_email
            // 
            textBox_brwr_email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_brwr_email.Location = new Point(299, 284);
            textBox_brwr_email.Name = "textBox_brwr_email";
            textBox_brwr_email.Size = new Size(205, 33);
            textBox_brwr_email.TabIndex = 26;
            textBox_brwr_email.TextChanged += textBox_brwr_email_TextChanged;
            // 
            // textBox_brwr_phone
            // 
            textBox_brwr_phone.Enabled = false;
            textBox_brwr_phone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_brwr_phone.Location = new Point(360, 249);
            textBox_brwr_phone.Name = "textBox_brwr_phone";
            textBox_brwr_phone.Size = new Size(144, 33);
            textBox_brwr_phone.TabIndex = 25;
            textBox_brwr_phone.TextChanged += textBox_brwr_phone_TextChanged;
            // 
            // textBox_brwr_login
            // 
            textBox_brwr_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_brwr_login.Location = new Point(299, 171);
            textBox_brwr_login.Name = "textBox_brwr_login";
            textBox_brwr_login.Size = new Size(205, 33);
            textBox_brwr_login.TabIndex = 24;
            textBox_brwr_login.TextChanged += textBox_brwr_login_TextChanged;
            textBox_brwr_login.KeyPress += KeyPressForAllWhoString;
            // 
            // label_br_name
            // 
            label_br_name.AutoSize = true;
            label_br_name.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_br_name.Location = new Point(103, 142);
            label_br_name.Name = "label_br_name";
            label_br_name.Size = new Size(181, 32);
            label_br_name.TabIndex = 23;
            label_br_name.Text = "Назва бригади:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(107, 119, 140);
            panel1.Controls.Add(Name_brigade_combobox);
            panel1.Controls.Add(WorkerPbCorrectEmai);
            panel1.Controls.Add(label_br_name);
            panel1.Controls.Add(WorkerPbCorrectPhon);
            panel1.Controls.Add(textBox_brwr_login);
            panel1.Controls.Add(CountrySpecForTelephoneCb);
            panel1.Controls.Add(textBox_brwr_phone);
            panel1.Controls.Add(Gender_label);
            panel1.Controls.Add(textBox_brwr_email);
            panel1.Controls.Add(Gender_combobox);
            panel1.Controls.Add(textBox_brwr_fname);
            panel1.Controls.Add(textBox_brwr_lname);
            panel1.Controls.Add(label_brwr_speciality);
            panel1.Controls.Add(textBox_brwr_mname);
            panel1.Controls.Add(label_brwr_mnane);
            panel1.Controls.Add(textBox_brwr_speciality);
            panel1.Controls.Add(label_brwr_lname);
            panel1.Controls.Add(label_brwr_login);
            panel1.Controls.Add(label_brwr_fname);
            panel1.Controls.Add(label_brwr_phone);
            panel1.Controls.Add(label_brwr_email);
            panel1.Location = new Point(-8, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 381);
            panel1.TabIndex = 44;
            // 
            // AddWorker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(107, 119, 130);
            ClientSize = new Size(701, 590);
            Controls.Add(panel1);
            Controls.Add(Create_Worker);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddWorker";
            Text = "Додати робітника";
            Load += AddWorker_Load;
            ((System.ComponentModel.ISupportInitialize)WorkerPbCorrectEmai).EndInit();
            ((System.ComponentModel.ISupportInitialize)WorkerPbCorrectPhon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button Create_Worker;
        private PictureBox WorkerPbCorrectEmai;
        private PictureBox WorkerPbCorrectPhon;
        private ComboBox CountrySpecForTelephoneCb;
        private Label Gender_label;
        private ComboBox Gender_combobox;
        private ComboBox Name_brigade_combobox;
        private Label label_brwr_speciality;
        private Label label_brwr_mnane;
        private Label label_brwr_lname;
        private Label label_brwr_fname;
        private Label label_brwr_email;
        private Label label_brwr_phone;
        private Label label_brwr_login;
        private TextBox textBox_brwr_speciality;
        private TextBox textBox_brwr_mname;
        private TextBox textBox_brwr_lname;
        private TextBox textBox_brwr_fname;
        private TextBox textBox_brwr_email;
        private TextBox textBox_brwr_phone;
        private TextBox textBox_brwr_login;
        private Label label_br_name;
        private Panel panel1;
    }
}