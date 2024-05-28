namespace Курсовая.Формы.Добавления_новых_значений_в_таблицы
{
    partial class AddBrig
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
            Create_Brigade = new Button();
            panel1 = new Panel();
            BrigNameTbMain = new TextBox();
            br_specl = new Label();
            br_PCountL = new Label();
            BrigadesSpecTbMain = new TextBox();
            BrigadesPCountTbMain = new TextBox();
            Br_NameL = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Create_Brigade
            // 
            Create_Brigade.BackColor = Color.DarkSeaGreen;
            Create_Brigade.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Create_Brigade.Location = new Point(94, 328);
            Create_Brigade.Name = "Create_Brigade";
            Create_Brigade.Size = new Size(308, 63);
            Create_Brigade.TabIndex = 6;
            Create_Brigade.Text = "Додати";
            Create_Brigade.UseVisualStyleBackColor = false;
            Create_Brigade.Click += Create_Brigade_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(107, 119, 150);
            panel1.Controls.Add(BrigNameTbMain);
            panel1.Controls.Add(br_specl);
            panel1.Controls.Add(br_PCountL);
            panel1.Controls.Add(BrigadesSpecTbMain);
            panel1.Controls.Add(BrigadesPCountTbMain);
            panel1.Controls.Add(Br_NameL);
            panel1.Location = new Point(-5, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 244);
            panel1.TabIndex = 5;
            // 
            // BrigNameTbMain
            // 
            BrigNameTbMain.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BrigNameTbMain.Location = new Point(233, 32);
            BrigNameTbMain.Name = "BrigNameTbMain";
            BrigNameTbMain.Size = new Size(205, 33);
            BrigNameTbMain.TabIndex = 23;
            BrigNameTbMain.TextChanged += BrigNameTbMain_TextChanged;
            // 
            // br_specl
            // 
            br_specl.AutoSize = true;
            br_specl.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            br_specl.Location = new Point(30, 184);
            br_specl.Name = "br_specl";
            br_specl.Size = new Size(182, 32);
            br_specl.TabIndex = 22;
            br_specl.Text = "Спецiализацiя: ";
            // 
            // br_PCountL
            // 
            br_PCountL.AutoSize = true;
            br_PCountL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            br_PCountL.Location = new Point(17, 109);
            br_PCountL.Name = "br_PCountL";
            br_PCountL.Size = new Size(195, 32);
            br_PCountL.TabIndex = 21;
            br_PCountL.Text = "Кiлькiсть людей:";
            // 
            // BrigadesSpecTbMain
            // 
            BrigadesSpecTbMain.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BrigadesSpecTbMain.Location = new Point(233, 183);
            BrigadesSpecTbMain.Name = "BrigadesSpecTbMain";
            BrigadesSpecTbMain.Size = new Size(205, 33);
            BrigadesSpecTbMain.TabIndex = 20;
            BrigadesSpecTbMain.TextChanged += BrigadesSpecTbMain_TextChanged;
            BrigadesSpecTbMain.KeyPress += KeyPressForAllWhoString;
            // 
            // BrigadesPCountTbMain
            // 
            BrigadesPCountTbMain.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BrigadesPCountTbMain.Location = new Point(233, 112);
            BrigadesPCountTbMain.Name = "BrigadesPCountTbMain";
            BrigadesPCountTbMain.Size = new Size(205, 33);
            BrigadesPCountTbMain.TabIndex = 19;
            BrigadesPCountTbMain.Text = "0";
            BrigadesPCountTbMain.KeyPress += KeyPressForAllWhoInt;
            // 
            // Br_NameL
            // 
            Br_NameL.AutoSize = true;
            Br_NameL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            Br_NameL.Location = new Point(17, 29);
            Br_NameL.Name = "Br_NameL";
            Br_NameL.Size = new Size(181, 32);
            Br_NameL.TabIndex = 18;
            Br_NameL.Text = "Назва бригади:";
            // 
            // AddBrig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(107, 119, 120);
            ClientSize = new Size(507, 403);
            Controls.Add(Create_Brigade);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddBrig";
            Text = "Додати бригаду";
            Load += AddBrig_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Create_Brigade;
        private Panel panel1;
        private TextBox BrigNameTbMain;
        private Label br_specl;
        private Label br_PCountL;
        private TextBox BrigadesSpecTbMain;
        private TextBox BrigadesPCountTbMain;
        private Label Br_NameL;
    }
}