namespace Курсовая.Формы.Формы_с_календарем
{
    partial class CalendarForDateGivenMatOf
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
            CalendarForMaterialsOff = new MonthCalendar();
            Confirm_Button = new Button();
            Date_Test_Tb = new TextBox();
            Date_TestLabel = new Label();
            Confirmable = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Confirmable).BeginInit();
            SuspendLayout();
            // 
            // CalendarForMaterialsOff
            // 
            CalendarForMaterialsOff.BackColor = Color.FromArgb(107, 119, 120);
            CalendarForMaterialsOff.CalendarDimensions = new Size(3, 3);
            CalendarForMaterialsOff.Location = new Point(40, 18);
            CalendarForMaterialsOff.Name = "CalendarForMaterialsOff";
            CalendarForMaterialsOff.TabIndex = 0;
            CalendarForMaterialsOff.DateChanged += CalendarForMaterialsOff_DateChanged;
            // 
            // Confirm_Button
            // 
            Confirm_Button.BackColor = Color.ForestGreen;
            Confirm_Button.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Confirm_Button.Location = new Point(634, 275);
            Confirm_Button.Name = "Confirm_Button";
            Confirm_Button.Size = new Size(190, 53);
            Confirm_Button.TabIndex = 1;
            Confirm_Button.Text = "Применить";
            Confirm_Button.UseVisualStyleBackColor = false;
            Confirm_Button.Click += Confirm_Button_Click;
            // 
            // Date_Test_Tb
            // 
            Date_Test_Tb.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Date_Test_Tb.Location = new Point(575, 230);
            Date_Test_Tb.Multiline = true;
            Date_Test_Tb.Name = "Date_Test_Tb";
            Date_Test_Tb.ReadOnly = true;
            Date_Test_Tb.Size = new Size(297, 39);
            Date_Test_Tb.TabIndex = 2;
            // 
            // Date_TestLabel
            // 
            Date_TestLabel.AutoSize = true;
            Date_TestLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Date_TestLabel.Location = new Point(574, 202);
            Date_TestLabel.Name = "Date_TestLabel";
            Date_TestLabel.Size = new Size(298, 25);
            Date_TestLabel.TabIndex = 3;
            Date_TestLabel.Text = "Представление вводимой даты:";
            // 
            // Confirmable
            // 
            Confirmable.BackColor = Color.Red;
            Confirmable.Location = new Point(880, 485);
            Confirmable.Name = "Confirmable";
            Confirmable.Size = new Size(31, 25);
            Confirmable.TabIndex = 4;
            Confirmable.TabStop = false;
            Confirmable.Visible = false;
            // 
            // CalendarForDateGivenMatOf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(107, 119, 120);
            ClientSize = new Size(923, 522);
            Controls.Add(Confirmable);
            Controls.Add(Date_TestLabel);
            Controls.Add(Date_Test_Tb);
            Controls.Add(Confirm_Button);
            Controls.Add(CalendarForMaterialsOff);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CalendarForDateGivenMatOf";
            Text = "Изменение даты:";
            Load += CalendarForDateGivenMatOf_Load;
            ((System.ComponentModel.ISupportInitialize)Confirmable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar CalendarForMaterialsOff;
        private Button Confirm_Button;
        private TextBox Date_Test_Tb;
        private Label Date_TestLabel;
        private PictureBox Confirmable;
    }
}