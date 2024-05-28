namespace Курсовая.Формы.Добавления_новых_значений_в_таблицы
{
    partial class AddObject
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
            panel20 = new Panel();
            Obj_NewObjB = new Button();
            panel6 = new Panel();
            ResetObjDComplB = new Button();
            ChangeObjDComplB = new Button();
            Obj_DendL = new Label();
            Obj_DEndTb = new TextBox();
            panel1 = new Panel();
            panel11 = new Panel();
            ResetObjDStartB = new Button();
            ChangeObjDStartB = new Button();
            Obj_DStartL = new Label();
            Obj_DstartTb = new TextBox();
            Obj_StreetTb = new TextBox();
            Obj_NameL = new Label();
            Obj_TypeOfObjL = new Label();
            Obj_name_Tb = new TextBox();
            Obj_HouseL = new Label();
            Obj_TypeOfObjTb = new TextBox();
            Obj_RayonTb = new TextBox();
            Obj_HouseNTb = new TextBox();
            Obj_AreaL = new Label();
            Obj_StreetL = new Label();
            panel20.SuspendLayout();
            panel6.SuspendLayout();
            panel1.SuspendLayout();
            panel11.SuspendLayout();
            SuspendLayout();
            // 
            // panel20
            // 
            panel20.BackColor = Color.FromArgb(107, 119, 120);
            panel20.Controls.Add(Obj_NewObjB);
            panel20.Controls.Add(panel6);
            panel20.Controls.Add(panel1);
            panel20.Location = new Point(-6, 0);
            panel20.Name = "panel20";
            panel20.Size = new Size(774, 511);
            panel20.TabIndex = 3;
            // 
            // Obj_NewObjB
            // 
            Obj_NewObjB.BackColor = Color.DarkSeaGreen;
            Obj_NewObjB.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Obj_NewObjB.Location = new Point(264, 415);
            Obj_NewObjB.Name = "Obj_NewObjB";
            Obj_NewObjB.Size = new Size(189, 52);
            Obj_NewObjB.TabIndex = 0;
            Obj_NewObjB.Text = "Додати";
            Obj_NewObjB.UseVisualStyleBackColor = false;
            Obj_NewObjB.Click += Obj_NewObjB_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(107, 119, 140);
            panel6.Controls.Add(ResetObjDComplB);
            panel6.Controls.Add(ChangeObjDComplB);
            panel6.Controls.Add(Obj_DendL);
            panel6.Controls.Add(Obj_DEndTb);
            panel6.Location = new Point(7, 209);
            panel6.Name = "panel6";
            panel6.Size = new Size(763, 51);
            panel6.TabIndex = 51;
            // 
            // ResetObjDComplB
            // 
            ResetObjDComplB.BackColor = Color.DarkSalmon;
            ResetObjDComplB.Location = new Point(608, 10);
            ResetObjDComplB.Name = "ResetObjDComplB";
            ResetObjDComplB.Size = new Size(130, 29);
            ResetObjDComplB.TabIndex = 37;
            ResetObjDComplB.Text = "Скинути зміни";
            ResetObjDComplB.UseVisualStyleBackColor = false;
            ResetObjDComplB.Click += ResetObjDComplB_Click;
            // 
            // ChangeObjDComplB
            // 
            ChangeObjDComplB.BackColor = Color.PaleTurquoise;
            ChangeObjDComplB.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ChangeObjDComplB.Location = new Point(468, 0);
            ChangeObjDComplB.Name = "ChangeObjDComplB";
            ChangeObjDComplB.Size = new Size(134, 42);
            ChangeObjDComplB.TabIndex = 36;
            ChangeObjDComplB.Text = "Змiнити";
            ChangeObjDComplB.UseVisualStyleBackColor = false;
            ChangeObjDComplB.Click += ChangeObjDStartB_Click;
            // 
            // Obj_DendL
            // 
            Obj_DendL.AutoSize = true;
            Obj_DendL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            Obj_DendL.Location = new Point(15, 7);
            Obj_DendL.Name = "Obj_DendL";
            Obj_DendL.Size = new Size(196, 32);
            Obj_DendL.TabIndex = 10;
            Obj_DendL.Text = "Дата виконання:";
            // 
            // Obj_DEndTb
            // 
            Obj_DEndTb.Enabled = false;
            Obj_DEndTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Obj_DEndTb.Location = new Point(250, 10);
            Obj_DEndTb.Name = "Obj_DEndTb";
            Obj_DEndTb.Size = new Size(205, 33);
            Obj_DEndTb.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(107, 119, 140);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(Obj_StreetTb);
            panel1.Controls.Add(Obj_NameL);
            panel1.Controls.Add(Obj_TypeOfObjL);
            panel1.Controls.Add(Obj_name_Tb);
            panel1.Controls.Add(Obj_HouseL);
            panel1.Controls.Add(Obj_TypeOfObjTb);
            panel1.Controls.Add(Obj_RayonTb);
            panel1.Controls.Add(Obj_HouseNTb);
            panel1.Controls.Add(Obj_AreaL);
            panel1.Controls.Add(Obj_StreetL);
            panel1.Location = new Point(7, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(753, 350);
            panel1.TabIndex = 52;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(107, 119, 140);
            panel11.Controls.Add(ResetObjDStartB);
            panel11.Controls.Add(ChangeObjDStartB);
            panel11.Controls.Add(Obj_DStartL);
            panel11.Controls.Add(Obj_DstartTb);
            panel11.Location = new Point(0, 108);
            panel11.Name = "panel11";
            panel11.Size = new Size(753, 51);
            panel11.TabIndex = 50;
            // 
            // ResetObjDStartB
            // 
            ResetObjDStartB.BackColor = Color.DarkSalmon;
            ResetObjDStartB.Location = new Point(608, 13);
            ResetObjDStartB.Name = "ResetObjDStartB";
            ResetObjDStartB.Size = new Size(130, 29);
            ResetObjDStartB.TabIndex = 35;
            ResetObjDStartB.Text = "Скинути зміни";
            ResetObjDStartB.UseVisualStyleBackColor = false;
            ResetObjDStartB.Click += ResetObjDStartB_Click;
            // 
            // ChangeObjDStartB
            // 
            ChangeObjDStartB.BackColor = Color.PaleTurquoise;
            ChangeObjDStartB.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ChangeObjDStartB.Location = new Point(468, 6);
            ChangeObjDStartB.Name = "ChangeObjDStartB";
            ChangeObjDStartB.Size = new Size(134, 42);
            ChangeObjDStartB.TabIndex = 34;
            ChangeObjDStartB.Text = "Змiнити";
            ChangeObjDStartB.UseVisualStyleBackColor = false;
            ChangeObjDStartB.Click += ChangeObjDStartB_Click;
            // 
            // Obj_DStartL
            // 
            Obj_DStartL.AutoSize = true;
            Obj_DStartL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            Obj_DStartL.Location = new Point(20, 10);
            Obj_DStartL.Name = "Obj_DStartL";
            Obj_DStartL.Size = new Size(165, 32);
            Obj_DStartL.TabIndex = 9;
            Obj_DStartL.Text = "Дата початку:";
            // 
            // Obj_DstartTb
            // 
            Obj_DstartTb.Enabled = false;
            Obj_DstartTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Obj_DstartTb.Location = new Point(250, 9);
            Obj_DstartTb.Name = "Obj_DstartTb";
            Obj_DstartTb.Size = new Size(205, 33);
            Obj_DstartTb.TabIndex = 2;
            // 
            // Obj_StreetTb
            // 
            Obj_StreetTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Obj_StreetTb.Location = new Point(490, 52);
            Obj_StreetTb.Name = "Obj_StreetTb";
            Obj_StreetTb.Size = new Size(205, 33);
            Obj_StreetTb.TabIndex = 43;
            Obj_StreetTb.TextChanged += Obj_StreetTb_TextChanged;
            // 
            // Obj_NameL
            // 
            Obj_NameL.AutoSize = true;
            Obj_NameL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            Obj_NameL.Location = new Point(21, 31);
            Obj_NameL.Name = "Obj_NameL";
            Obj_NameL.Size = new Size(170, 32);
            Obj_NameL.TabIndex = 40;
            Obj_NameL.Text = "Назва об'єкту:";
            // 
            // Obj_TypeOfObjL
            // 
            Obj_TypeOfObjL.AutoSize = true;
            Obj_TypeOfObjL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            Obj_TypeOfObjL.Location = new Point(32, 259);
            Obj_TypeOfObjL.Name = "Obj_TypeOfObjL";
            Obj_TypeOfObjL.Size = new Size(146, 32);
            Obj_TypeOfObjL.TabIndex = 49;
            Obj_TypeOfObjL.Text = "Тип об'єкту:";
            // 
            // Obj_name_Tb
            // 
            Obj_name_Tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Obj_name_Tb.Location = new Point(250, 30);
            Obj_name_Tb.Name = "Obj_name_Tb";
            Obj_name_Tb.Size = new Size(205, 33);
            Obj_name_Tb.TabIndex = 41;
            Obj_name_Tb.TextChanged += Obj_name_Tb_TextChanged;
            Obj_name_Tb.KeyPress += KeyPressForAllWhoString;
            // 
            // Obj_HouseL
            // 
            Obj_HouseL.AutoSize = true;
            Obj_HouseL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            Obj_HouseL.Location = new Point(34, 221);
            Obj_HouseL.Name = "Obj_HouseL";
            Obj_HouseL.Size = new Size(157, 32);
            Obj_HouseL.TabIndex = 48;
            Obj_HouseL.Text = "Номер дому:";
            // 
            // Obj_TypeOfObjTb
            // 
            Obj_TypeOfObjTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Obj_TypeOfObjTb.Location = new Point(250, 259);
            Obj_TypeOfObjTb.Name = "Obj_TypeOfObjTb";
            Obj_TypeOfObjTb.Size = new Size(205, 33);
            Obj_TypeOfObjTb.TabIndex = 45;
            Obj_TypeOfObjTb.TextChanged += Obj_TypeOfObjTb_TextChanged;
            Obj_TypeOfObjTb.KeyPress += KeyPressForAllWhoString;
            // 
            // Obj_RayonTb
            // 
            Obj_RayonTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Obj_RayonTb.Location = new Point(250, 69);
            Obj_RayonTb.Name = "Obj_RayonTb";
            Obj_RayonTb.Size = new Size(205, 33);
            Obj_RayonTb.TabIndex = 42;
            Obj_RayonTb.TextChanged += Obj_RayonTb_TextChanged;
            Obj_RayonTb.KeyPress += KeyPressForAllWhoString;
            // 
            // Obj_HouseNTb
            // 
            Obj_HouseNTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Obj_HouseNTb.Location = new Point(250, 220);
            Obj_HouseNTb.Name = "Obj_HouseNTb";
            Obj_HouseNTb.Size = new Size(205, 33);
            Obj_HouseNTb.TabIndex = 44;
            Obj_HouseNTb.TextChanged += Obj_HouseNTb_TextChanged;
            Obj_HouseNTb.KeyPress += KeyPressForAllWhoInt;
            // 
            // Obj_AreaL
            // 
            Obj_AreaL.AutoSize = true;
            Obj_AreaL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            Obj_AreaL.Location = new Point(29, 69);
            Obj_AreaL.Name = "Obj_AreaL";
            Obj_AreaL.Size = new Size(149, 32);
            Obj_AreaL.TabIndex = 46;
            Obj_AreaL.Text = "Район мiста:";
            // 
            // Obj_StreetL
            // 
            Obj_StreetL.AutoSize = true;
            Obj_StreetL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            Obj_StreetL.Location = new Point(488, 17);
            Obj_StreetL.Name = "Obj_StreetL";
            Obj_StreetL.Size = new Size(98, 32);
            Obj_StreetL.TabIndex = 47;
            Obj_StreetL.Text = "Вулиця:";
            // 
            // AddObject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 498);
            Controls.Add(panel20);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddObject";
            Text = "Додати об'єкт";
            Load += AddObject_Load;
            panel20.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel20;
        private Button Obj_NewObjB;
        private Panel panel11;
        private Button ResetObjDStartB;
        private Button ChangeObjDStartB;
        private Label Obj_DStartL;
        private TextBox Obj_DstartTb;
        private Panel panel6;
        private Button ResetObjDComplB;
        private Button ChangeObjDComplB;
        private Label Obj_DendL;
        private TextBox Obj_DEndTb;
        private Label Obj_TypeOfObjL;
        private Label Obj_HouseL;
        private Label Obj_StreetL;
        private Label Obj_AreaL;
        private TextBox Obj_TypeOfObjTb;
        private TextBox Obj_HouseNTb;
        private TextBox Obj_StreetTb;
        private TextBox Obj_RayonTb;
        private TextBox Obj_name_Tb;
        private Label Obj_NameL;
        private Panel panel1;
    }
}