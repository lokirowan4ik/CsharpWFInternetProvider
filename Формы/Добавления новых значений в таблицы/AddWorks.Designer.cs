namespace Курсовая.Формы.Добавления_новых_значений_в_таблицы
{
    partial class AddWorks
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
            panel15 = new Panel();
            panel7 = new Panel();
            RevokeDatEnd_WorksB = new Button();
            ChangeDatEnd_WorksB = new Button();
            Work_DEndL = new Label();
            Work_DEndTb = new TextBox();
            panel5 = new Panel();
            RevokeDatSt_WorksB = new Button();
            Work_DStartTb = new TextBox();
            Work_DStartL = new Label();
            ChangeDatSt_WorksB = new Button();
            ob_name_inworksL = new Label();
            ob_name_inworksCb = new ComboBox();
            br_name_inworksL = new Label();
            br_name_in_worksCb = new ComboBox();
            Work_CountL = new Label();
            Work_StatusL = new Label();
            Work_StatusComb = new ComboBox();
            Work_CountTb = new TextBox();
            Work_newButton = new Button();
            panel15.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(107, 119, 140);
            panel15.Controls.Add(panel7);
            panel15.Controls.Add(panel5);
            panel15.Controls.Add(ob_name_inworksL);
            panel15.Controls.Add(ob_name_inworksCb);
            panel15.Controls.Add(br_name_inworksL);
            panel15.Controls.Add(br_name_in_worksCb);
            panel15.Controls.Add(Work_CountL);
            panel15.Controls.Add(Work_StatusL);
            panel15.Controls.Add(Work_StatusComb);
            panel15.Controls.Add(Work_CountTb);
            panel15.Location = new Point(-1, 44);
            panel15.Name = "panel15";
            panel15.Size = new Size(761, 361);
            panel15.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(107, 119, 145);
            panel7.Controls.Add(RevokeDatEnd_WorksB);
            panel7.Controls.Add(ChangeDatEnd_WorksB);
            panel7.Controls.Add(Work_DEndL);
            panel7.Controls.Add(Work_DEndTb);
            panel7.Location = new Point(-5, 183);
            panel7.Name = "panel7";
            panel7.Size = new Size(767, 53);
            panel7.TabIndex = 47;
            // 
            // RevokeDatEnd_WorksB
            // 
            RevokeDatEnd_WorksB.BackColor = Color.DarkSalmon;
            RevokeDatEnd_WorksB.Location = new Point(625, 13);
            RevokeDatEnd_WorksB.Name = "RevokeDatEnd_WorksB";
            RevokeDatEnd_WorksB.Size = new Size(130, 29);
            RevokeDatEnd_WorksB.TabIndex = 37;
            RevokeDatEnd_WorksB.Text = "Скинути зміни";
            RevokeDatEnd_WorksB.UseVisualStyleBackColor = false;
            RevokeDatEnd_WorksB.Click += RevokeDatEnd_WorksB_Click;
            // 
            // ChangeDatEnd_WorksB
            // 
            ChangeDatEnd_WorksB.BackColor = Color.PaleTurquoise;
            ChangeDatEnd_WorksB.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ChangeDatEnd_WorksB.Location = new Point(485, 5);
            ChangeDatEnd_WorksB.Name = "ChangeDatEnd_WorksB";
            ChangeDatEnd_WorksB.Size = new Size(134, 42);
            ChangeDatEnd_WorksB.TabIndex = 36;
            ChangeDatEnd_WorksB.Text = "Змiнити";
            ChangeDatEnd_WorksB.UseVisualStyleBackColor = false;
            ChangeDatEnd_WorksB.Click += ChangeDatSt_WorksB_Click;
            // 
            // Work_DEndL
            // 
            Work_DEndL.AutoSize = true;
            Work_DEndL.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            Work_DEndL.Location = new Point(15, 11);
            Work_DEndL.Name = "Work_DEndL";
            Work_DEndL.Size = new Size(186, 31);
            Work_DEndL.TabIndex = 20;
            Work_DEndL.Text = "Дата виконання:";
            // 
            // Work_DEndTb
            // 
            Work_DEndTb.Enabled = false;
            Work_DEndTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Work_DEndTb.Location = new Point(256, 9);
            Work_DEndTb.Multiline = true;
            Work_DEndTb.Name = "Work_DEndTb";
            Work_DEndTb.ReadOnly = true;
            Work_DEndTb.Size = new Size(205, 33);
            Work_DEndTb.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(107, 119, 145);
            panel5.Controls.Add(RevokeDatSt_WorksB);
            panel5.Controls.Add(Work_DStartTb);
            panel5.Controls.Add(Work_DStartL);
            panel5.Controls.Add(ChangeDatSt_WorksB);
            panel5.Location = new Point(-5, 126);
            panel5.Name = "panel5";
            panel5.Size = new Size(767, 51);
            panel5.TabIndex = 46;
            // 
            // RevokeDatSt_WorksB
            // 
            RevokeDatSt_WorksB.BackColor = Color.DarkSalmon;
            RevokeDatSt_WorksB.Location = new Point(625, 8);
            RevokeDatSt_WorksB.Name = "RevokeDatSt_WorksB";
            RevokeDatSt_WorksB.Size = new Size(130, 29);
            RevokeDatSt_WorksB.TabIndex = 35;
            RevokeDatSt_WorksB.Text = "Скинути зміни";
            RevokeDatSt_WorksB.UseVisualStyleBackColor = false;
            RevokeDatSt_WorksB.Click += RevokeDatSt_WorksB_Click;
            // 
            // Work_DStartTb
            // 
            Work_DStartTb.Enabled = false;
            Work_DStartTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Work_DStartTb.Location = new Point(256, 12);
            Work_DStartTb.Multiline = true;
            Work_DStartTb.Name = "Work_DStartTb";
            Work_DStartTb.ReadOnly = true;
            Work_DStartTb.Size = new Size(205, 33);
            Work_DStartTb.TabIndex = 3;
            // 
            // Work_DStartL
            // 
            Work_DStartL.AutoSize = true;
            Work_DStartL.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            Work_DStartL.Location = new Point(20, 10);
            Work_DStartL.Name = "Work_DStartL";
            Work_DStartL.Size = new Size(156, 31);
            Work_DStartL.TabIndex = 10;
            Work_DStartL.Text = "Дата початку:";
            // 
            // ChangeDatSt_WorksB
            // 
            ChangeDatSt_WorksB.BackColor = Color.PaleTurquoise;
            ChangeDatSt_WorksB.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ChangeDatSt_WorksB.Location = new Point(485, 3);
            ChangeDatSt_WorksB.Name = "ChangeDatSt_WorksB";
            ChangeDatSt_WorksB.Size = new Size(134, 42);
            ChangeDatSt_WorksB.TabIndex = 34;
            ChangeDatSt_WorksB.Text = "Змiнити";
            ChangeDatSt_WorksB.UseVisualStyleBackColor = false;
            ChangeDatSt_WorksB.Click += ChangeDatSt_WorksB_Click;
            // 
            // ob_name_inworksL
            // 
            ob_name_inworksL.AutoSize = true;
            ob_name_inworksL.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            ob_name_inworksL.Location = new Point(23, 92);
            ob_name_inworksL.Name = "ob_name_inworksL";
            ob_name_inworksL.Size = new Size(160, 31);
            ob_name_inworksL.TabIndex = 45;
            ob_name_inworksL.Text = "Назва об'єкту:";
            // 
            // ob_name_inworksCb
            // 
            ob_name_inworksCb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ob_name_inworksCb.Location = new Point(251, 94);
            ob_name_inworksCb.Name = "ob_name_inworksCb";
            ob_name_inworksCb.Size = new Size(385, 33);
            ob_name_inworksCb.TabIndex = 44;
            // 
            // br_name_inworksL
            // 
            br_name_inworksL.AutoSize = true;
            br_name_inworksL.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            br_name_inworksL.Location = new Point(23, 47);
            br_name_inworksL.Name = "br_name_inworksL";
            br_name_inworksL.Size = new Size(174, 31);
            br_name_inworksL.TabIndex = 43;
            br_name_inworksL.Text = "Назва бригади:";
            // 
            // br_name_in_worksCb
            // 
            br_name_in_worksCb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            br_name_in_worksCb.Location = new Point(251, 48);
            br_name_in_worksCb.Name = "br_name_in_worksCb";
            br_name_in_worksCb.Size = new Size(385, 33);
            br_name_in_worksCb.TabIndex = 42;
            // 
            // Work_CountL
            // 
            Work_CountL.AutoSize = true;
            Work_CountL.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            Work_CountL.Location = new Point(23, 245);
            Work_CountL.Name = "Work_CountL";
            Work_CountL.Size = new Size(172, 31);
            Work_CountL.TabIndex = 41;
            Work_CountL.Text = "Кiлькiсть робiт:";
            // 
            // Work_StatusL
            // 
            Work_StatusL.AutoSize = true;
            Work_StatusL.Font = new Font("Segoe UI", 17.25F, FontStyle.Regular, GraphicsUnit.Point);
            Work_StatusL.Location = new Point(27, 281);
            Work_StatusL.Name = "Work_StatusL";
            Work_StatusL.Size = new Size(67, 31);
            Work_StatusL.TabIndex = 40;
            Work_StatusL.Text = "Стан:";
            // 
            // Work_StatusComb
            // 
            Work_StatusComb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Work_StatusComb.Location = new Point(251, 283);
            Work_StatusComb.Name = "Work_StatusComb";
            Work_StatusComb.Size = new Size(205, 33);
            Work_StatusComb.TabIndex = 39;
            // 
            // Work_CountTb
            // 
            Work_CountTb.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Work_CountTb.Location = new Point(251, 245);
            Work_CountTb.Name = "Work_CountTb";
            Work_CountTb.Size = new Size(205, 33);
            Work_CountTb.TabIndex = 38;
            Work_CountTb.Text = "0";
            Work_CountTb.KeyPress += KeyPressForAllWhoInt;
            // 
            // Work_newButton
            // 
            Work_newButton.BackColor = Color.DarkSeaGreen;
            Work_newButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Work_newButton.Location = new Point(259, 411);
            Work_newButton.Name = "Work_newButton";
            Work_newButton.Size = new Size(196, 61);
            Work_newButton.TabIndex = 21;
            Work_newButton.Text = "Додати";
            Work_newButton.UseVisualStyleBackColor = false;
            Work_newButton.Click += Work_newButton_Click;
            // 
            // AddWorks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(107, 119, 120);
            ClientSize = new Size(760, 506);
            Controls.Add(panel15);
            Controls.Add(Work_newButton);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddWorks";
            Text = "Додати роботи";
            Load += AddWorks_Load;
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel15;
        private Button Work_newButton;
        private Panel panel7;
        private Button RevokeDatEnd_WorksB;
        private Button ChangeDatEnd_WorksB;
        private Label Work_DEndL;
        private TextBox Work_DEndTb;
        private Panel panel5;
        private Button RevokeDatSt_WorksB;
        private TextBox Work_DStartTb;
        private Label Work_DStartL;
        private Button ChangeDatSt_WorksB;
        private Label ob_name_inworksL;
        private ComboBox ob_name_inworksCb;
        private Label br_name_inworksL;
        private ComboBox br_name_in_worksCb;
        private Label Work_CountL;
        private Label Work_StatusL;
        private ComboBox Work_StatusComb;
        private TextBox Work_CountTb;
    }
}