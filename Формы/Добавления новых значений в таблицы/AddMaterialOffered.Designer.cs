namespace Курсовая.Формы.Добавления_новых_значений_в_таблицы.Методы_для_создания
{
    partial class AddMaterialOffered
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
            panel23 = new Panel();
            panel1 = new Panel();
            GetCountMatOffFromMatL = new Label();
            br_name_Cb = new ComboBox();
            Work_StatusL = new Label();
            mat_name_inworksL = new Label();
            Work_KeyComb = new ComboBox();
            br_name_L = new Label();
            mat_name_Cb = new ComboBox();
            Mat_of_countL = new Label();
            mat_of_count_tb = new TextBox();
            Newmat_mat_ofBut = new Button();
            panel9 = new Panel();
            Change_mat_of_date_B = new Button();
            Restore_mat_of_date_B = new Button();
            Mat_of_DateL = new Label();
            mat_of_date_tb = new TextBox();
            panel23.SuspendLayout();
            panel1.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel23
            // 
            panel23.BackColor = Color.FromArgb(107, 119, 120);
            panel23.Controls.Add(panel1);
            panel23.Controls.Add(Newmat_mat_ofBut);
            panel23.Location = new Point(0, 1);
            panel23.Name = "panel23";
            panel23.Size = new Size(682, 496);
            panel23.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(107, 119, 140);
            panel1.Controls.Add(GetCountMatOffFromMatL);
            panel1.Controls.Add(br_name_Cb);
            panel1.Controls.Add(Work_StatusL);
            panel1.Controls.Add(mat_name_inworksL);
            panel1.Controls.Add(Work_KeyComb);
            panel1.Controls.Add(br_name_L);
            panel1.Controls.Add(mat_name_Cb);
            panel1.Controls.Add(Mat_of_countL);
            panel1.Controls.Add(mat_of_count_tb);
            panel1.Location = new Point(-6, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(697, 313);
            panel1.TabIndex = 41;
            // 
            // GetCountMatOffFromMatL
            // 
            GetCountMatOffFromMatL.AutoSize = true;
            GetCountMatOffFromMatL.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            GetCountMatOffFromMatL.Location = new Point(447, 203);
            GetCountMatOffFromMatL.Name = "GetCountMatOffFromMatL";
            GetCountMatOffFromMatL.Size = new Size(0, 25);
            GetCountMatOffFromMatL.TabIndex = 41;
            // 
            // br_name_Cb
            // 
            br_name_Cb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            br_name_Cb.Location = new Point(223, 22);
            br_name_Cb.Name = "br_name_Cb";
            br_name_Cb.Size = new Size(205, 33);
            br_name_Cb.TabIndex = 37;
            br_name_Cb.SelectedIndexChanged += br_name_Cb_SelectedIndexChanged;
            // 
            // Work_StatusL
            // 
            Work_StatusL.AutoSize = true;
            Work_StatusL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            Work_StatusL.Location = new Point(62, 254);
            Work_StatusL.Name = "Work_StatusL";
            Work_StatusL.Size = new Size(147, 32);
            Work_StatusL.TabIndex = 36;
            Work_StatusL.Text = "Код роботи:";
            // 
            // mat_name_inworksL
            // 
            mat_name_inworksL.AutoSize = true;
            mat_name_inworksL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            mat_name_inworksL.Location = new Point(21, 67);
            mat_name_inworksL.Name = "mat_name_inworksL";
            mat_name_inworksL.Size = new Size(200, 32);
            mat_name_inworksL.TabIndex = 40;
            mat_name_inworksL.Text = "Назва матеріалу:";
            // 
            // Work_KeyComb
            // 
            Work_KeyComb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Work_KeyComb.Location = new Point(223, 257);
            Work_KeyComb.Name = "Work_KeyComb";
            Work_KeyComb.Size = new Size(205, 33);
            Work_KeyComb.TabIndex = 35;
            // 
            // br_name_L
            // 
            br_name_L.AutoSize = true;
            br_name_L.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            br_name_L.Location = new Point(28, 22);
            br_name_L.Name = "br_name_L";
            br_name_L.Size = new Size(181, 32);
            br_name_L.TabIndex = 38;
            br_name_L.Text = "Назва бригади:";
            // 
            // mat_name_Cb
            // 
            mat_name_Cb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            mat_name_Cb.Location = new Point(223, 66);
            mat_name_Cb.Name = "mat_name_Cb";
            mat_name_Cb.Size = new Size(205, 33);
            mat_name_Cb.TabIndex = 39;
            mat_name_Cb.SelectedIndexChanged += mat_name_Cb_SelectedIndexChanged;
            // 
            // Mat_of_countL
            // 
            Mat_of_countL.AutoSize = true;
            Mat_of_countL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            Mat_of_countL.Location = new Point(77, 200);
            Mat_of_countL.Name = "Mat_of_countL";
            Mat_of_countL.Size = new Size(115, 32);
            Mat_of_countL.TabIndex = 28;
            Mat_of_countL.Text = "Кiлькiсть:";
            // 
            // mat_of_count_tb
            // 
            mat_of_count_tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            mat_of_count_tb.Location = new Point(223, 200);
            mat_of_count_tb.Name = "mat_of_count_tb";
            mat_of_count_tb.Size = new Size(205, 33);
            mat_of_count_tb.TabIndex = 19;
            mat_of_count_tb.Text = "0";
            mat_of_count_tb.KeyPress += KeyPressForAllWhoInt;
            // 
            // Newmat_mat_ofBut
            // 
            Newmat_mat_ofBut.BackColor = Color.DarkSeaGreen;
            Newmat_mat_ofBut.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Newmat_mat_ofBut.Location = new Point(207, 378);
            Newmat_mat_ofBut.Name = "Newmat_mat_ofBut";
            Newmat_mat_ofBut.Size = new Size(215, 87);
            Newmat_mat_ofBut.TabIndex = 30;
            Newmat_mat_ofBut.Text = "Додати";
            Newmat_mat_ofBut.UseVisualStyleBackColor = false;
            Newmat_mat_ofBut.Click += Newmat_mat_ofBut_Click;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(107, 119, 145);
            panel9.Controls.Add(Change_mat_of_date_B);
            panel9.Controls.Add(Restore_mat_of_date_B);
            panel9.Controls.Add(Mat_of_DateL);
            panel9.Controls.Add(mat_of_date_tb);
            panel9.Location = new Point(-6, 164);
            panel9.Name = "panel9";
            panel9.Size = new Size(688, 53);
            panel9.TabIndex = 41;
            // 
            // Change_mat_of_date_B
            // 
            Change_mat_of_date_B.BackColor = Color.PaleTurquoise;
            Change_mat_of_date_B.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Change_mat_of_date_B.Location = new Point(431, 2);
            Change_mat_of_date_B.Name = "Change_mat_of_date_B";
            Change_mat_of_date_B.Size = new Size(118, 42);
            Change_mat_of_date_B.TabIndex = 37;
            Change_mat_of_date_B.Text = "Змiнити";
            Change_mat_of_date_B.UseVisualStyleBackColor = false;
            Change_mat_of_date_B.Click += Change_mat_of_date_B_Click;
            // 
            // Restore_mat_of_date_B
            // 
            Restore_mat_of_date_B.BackColor = Color.DarkSalmon;
            Restore_mat_of_date_B.Location = new Point(555, 10);
            Restore_mat_of_date_B.Name = "Restore_mat_of_date_B";
            Restore_mat_of_date_B.Size = new Size(130, 29);
            Restore_mat_of_date_B.TabIndex = 36;
            Restore_mat_of_date_B.Text = "Скинути зміни";
            Restore_mat_of_date_B.UseVisualStyleBackColor = false;
            Restore_mat_of_date_B.Click += Restore_mat_of_date_B_Click;
            // 
            // Mat_of_DateL
            // 
            Mat_of_DateL.AutoSize = true;
            Mat_of_DateL.Font = new Font("Segoe UI", 17.75F, FontStyle.Regular, GraphicsUnit.Point);
            Mat_of_DateL.Location = new Point(18, 10);
            Mat_of_DateL.Name = "Mat_of_DateL";
            Mat_of_DateL.Size = new Size(198, 32);
            Mat_of_DateL.TabIndex = 27;
            Mat_of_DateL.Text = "Дата отримання:";
            // 
            // mat_of_date_tb
            // 
            mat_of_date_tb.Enabled = false;
            mat_of_date_tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            mat_of_date_tb.Location = new Point(223, 10);
            mat_of_date_tb.Name = "mat_of_date_tb";
            mat_of_date_tb.ReadOnly = true;
            mat_of_date_tb.Size = new Size(205, 33);
            mat_of_date_tb.TabIndex = 20;
            // 
            // AddMaterialOffered
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 496);
            Controls.Add(panel9);
            Controls.Add(panel23);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddMaterialOffered";
            Text = "Додати замовлений матеріал";
            Load += AddMaterialOffered_Load;
            panel23.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel23;
        private Button Newmat_mat_ofBut;
        private Label Mat_of_countL;
        private TextBox mat_of_count_tb;
        private Label mat_name_inworksL;
        private ComboBox mat_name_Cb;
        private Label br_name_L;
        private ComboBox br_name_Cb;
        private Label Work_StatusL;
        private ComboBox Work_KeyComb;
        private Panel panel9;
        private Button Change_mat_of_date_B;
        private Button Restore_mat_of_date_B;
        private Label Mat_of_DateL;
        private TextBox mat_of_date_tb;
        private Panel panel1;
        private Label GetCountMatOffFromMatL;
    }
}