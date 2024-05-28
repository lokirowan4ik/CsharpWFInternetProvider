namespace Курсовая.Формы.Добавления_новых_значений_в_таблицы
{
    partial class AddMaterial
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
            panel10 = new Panel();
            panel1 = new Panel();
            Mat_CountTb = new TextBox();
            Mat_CompanyTb = new TextBox();
            MatCountL = new Label();
            MatCharactL = new Label();
            Mat_FeaturesTb = new TextBox();
            MatDescrL = new Label();
            Mat_DescrTb = new TextBox();
            MatFirmL = new Label();
            Mat_Name_Tb = new TextBox();
            MatNameL = new Label();
            Mat_PriceTb = new TextBox();
            MatPriceL = new Label();
            Mat_addBut = new Button();
            panel10.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(107, 119, 120);
            panel10.Controls.Add(panel1);
            panel10.Controls.Add(Mat_addBut);
            panel10.Location = new Point(2, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(582, 398);
            panel10.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(107, 119, 140);
            panel1.Controls.Add(Mat_CountTb);
            panel1.Controls.Add(Mat_CompanyTb);
            panel1.Controls.Add(MatCountL);
            panel1.Controls.Add(MatCharactL);
            panel1.Controls.Add(Mat_FeaturesTb);
            panel1.Controls.Add(MatDescrL);
            panel1.Controls.Add(Mat_DescrTb);
            panel1.Controls.Add(MatFirmL);
            panel1.Controls.Add(Mat_Name_Tb);
            panel1.Controls.Add(MatNameL);
            panel1.Controls.Add(Mat_PriceTb);
            panel1.Controls.Add(MatPriceL);
            panel1.Location = new Point(0, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 264);
            panel1.TabIndex = 43;
            // 
            // Mat_CountTb
            // 
            Mat_CountTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Mat_CountTb.Location = new Point(224, 30);
            Mat_CountTb.Name = "Mat_CountTb";
            Mat_CountTb.Size = new Size(205, 33);
            Mat_CountTb.TabIndex = 31;
            Mat_CountTb.Text = "0";
            Mat_CountTb.KeyPress += KeyPressForAllWhoInt;
            // 
            // Mat_CompanyTb
            // 
            Mat_CompanyTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Mat_CompanyTb.Location = new Point(224, 138);
            Mat_CompanyTb.Name = "Mat_CompanyTb";
            Mat_CompanyTb.Size = new Size(205, 33);
            Mat_CompanyTb.TabIndex = 42;
            Mat_CompanyTb.TextChanged += Mat_CompanyTb_TextChanged;
            // 
            // MatCountL
            // 
            MatCountL.AutoSize = true;
            MatCountL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            MatCountL.Location = new Point(96, 30);
            MatCountL.Name = "MatCountL";
            MatCountL.Size = new Size(115, 32);
            MatCountL.TabIndex = 32;
            MatCountL.Text = "Кiлькiсть:";
            // 
            // MatCharactL
            // 
            MatCharactL.AutoSize = true;
            MatCharactL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            MatCharactL.Location = new Point(16, 207);
            MatCharactL.Name = "MatCharactL";
            MatCharactL.Size = new Size(195, 32);
            MatCharactL.TabIndex = 41;
            MatCharactL.Text = "Характеристики:";
            // 
            // Mat_FeaturesTb
            // 
            Mat_FeaturesTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Mat_FeaturesTb.Location = new Point(224, 208);
            Mat_FeaturesTb.Name = "Mat_FeaturesTb";
            Mat_FeaturesTb.Size = new Size(205, 33);
            Mat_FeaturesTb.TabIndex = 33;
            Mat_FeaturesTb.TextChanged += Mat_FeaturesTb_TextChanged;
            Mat_FeaturesTb.KeyPress += KeyPressForAllWhoString;
            // 
            // MatDescrL
            // 
            MatDescrL.AutoSize = true;
            MatDescrL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            MatDescrL.Location = new Point(124, 173);
            MatDescrL.Name = "MatDescrL";
            MatDescrL.Size = new Size(76, 32);
            MatDescrL.TabIndex = 40;
            MatDescrL.Text = "Опис:";
            // 
            // Mat_DescrTb
            // 
            Mat_DescrTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Mat_DescrTb.Location = new Point(224, 173);
            Mat_DescrTb.Name = "Mat_DescrTb";
            Mat_DescrTb.Size = new Size(205, 33);
            Mat_DescrTb.TabIndex = 34;
            Mat_DescrTb.TextChanged += Mat_DescrTb_TextChanged;
            Mat_DescrTb.KeyPress += KeyPressForAllWhoString;
            // 
            // MatFirmL
            // 
            MatFirmL.AutoSize = true;
            MatFirmL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            MatFirmL.Location = new Point(124, 135);
            MatFirmL.Name = "MatFirmL";
            MatFirmL.Size = new Size(85, 32);
            MatFirmL.TabIndex = 39;
            MatFirmL.Text = "Фiрма:";
            // 
            // Mat_Name_Tb
            // 
            Mat_Name_Tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Mat_Name_Tb.Location = new Point(224, 100);
            Mat_Name_Tb.Name = "Mat_Name_Tb";
            Mat_Name_Tb.Size = new Size(205, 33);
            Mat_Name_Tb.TabIndex = 35;
            Mat_Name_Tb.TextChanged += Mat_Name_Tb_TextChanged;
            Mat_Name_Tb.KeyPress += KeyPressForAllWhoString;
            // 
            // MatNameL
            // 
            MatNameL.AutoSize = true;
            MatNameL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            MatNameL.Location = new Point(124, 97);
            MatNameL.Name = "MatNameL";
            MatNameL.Size = new Size(84, 32);
            MatNameL.TabIndex = 38;
            MatNameL.Text = "Назва:";
            // 
            // Mat_PriceTb
            // 
            Mat_PriceTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Mat_PriceTb.Location = new Point(224, 64);
            Mat_PriceTb.Name = "Mat_PriceTb";
            Mat_PriceTb.Size = new Size(205, 33);
            Mat_PriceTb.TabIndex = 36;
            Mat_PriceTb.Text = "0";
            Mat_PriceTb.KeyPress += KeyPressForAllWhoDouble;
            // 
            // MatPriceL
            // 
            MatPriceL.AutoSize = true;
            MatPriceL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            MatPriceL.Location = new Point(143, 61);
            MatPriceL.Name = "MatPriceL";
            MatPriceL.Size = new Size(69, 32);
            MatPriceL.TabIndex = 37;
            MatPriceL.Text = "Цiна:";
            // 
            // Mat_addBut
            // 
            Mat_addBut.BackColor = Color.DarkSeaGreen;
            Mat_addBut.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Mat_addBut.Location = new Point(175, 318);
            Mat_addBut.Name = "Mat_addBut";
            Mat_addBut.Size = new Size(237, 57);
            Mat_addBut.TabIndex = 30;
            Mat_addBut.Text = "Додати";
            Mat_addBut.UseVisualStyleBackColor = false;
            Mat_addBut.Click += Mat_addBut_Click;
            // 
            // AddMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 390);
            Controls.Add(panel10);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddMaterial";
            Text = "Додати матерiал";
            Load += AddMaterial_Load;
            panel10.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel10;
        private Button Mat_addBut;
        private TextBox Mat_CompanyTb;
        private Label MatCharactL;
        private Label MatDescrL;
        private Label MatFirmL;
        private Label MatNameL;
        private Label MatPriceL;
        private TextBox Mat_PriceTb;
        private TextBox Mat_Name_Tb;
        private TextBox Mat_DescrTb;
        private TextBox Mat_FeaturesTb;
        private Label MatCountL;
        private TextBox Mat_CountTb;
        private Panel panel1;
    }
}