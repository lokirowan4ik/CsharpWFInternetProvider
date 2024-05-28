namespace Курсовая.Формы.Формы_с_календарем
{
    partial class CalendarsForWorks
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
            Date_TestLabel = new Label();
            DateEnd_Test_Tb = new TextBox();
            Confirm_Button = new Button();
            CalendarForWorksStart = new MonthCalendar();
            DateStart_Test_Tb = new TextBox();
            CalendarForWorksEnd = new MonthCalendar();
            Confirmable = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Confirmable).BeginInit();
            SuspendLayout();
            // 
            // Date_TestLabel
            // 
            Date_TestLabel.AutoSize = true;
            Date_TestLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Date_TestLabel.Location = new Point(713, 284);
            Date_TestLabel.Name = "Date_TestLabel";
            Date_TestLabel.Size = new Size(298, 25);
            Date_TestLabel.TabIndex = 7;
            Date_TestLabel.Text = "Представление вводимой даты:";
            // 
            // DateEnd_Test_Tb
            // 
            DateEnd_Test_Tb.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            DateEnd_Test_Tb.Location = new Point(714, 362);
            DateEnd_Test_Tb.Multiline = true;
            DateEnd_Test_Tb.Name = "DateEnd_Test_Tb";
            DateEnd_Test_Tb.ReadOnly = true;
            DateEnd_Test_Tb.Size = new Size(297, 39);
            DateEnd_Test_Tb.TabIndex = 6;
            // 
            // Confirm_Button
            // 
            Confirm_Button.BackColor = Color.OliveDrab;
            Confirm_Button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Confirm_Button.Location = new Point(773, 407);
            Confirm_Button.Name = "Confirm_Button";
            Confirm_Button.Size = new Size(190, 53);
            Confirm_Button.TabIndex = 5;
            Confirm_Button.Text = "Применить";
            Confirm_Button.UseVisualStyleBackColor = false;
            Confirm_Button.Click += Confirm_Button_Click;
            // 
            // CalendarForWorksStart
            // 
            CalendarForWorksStart.BackColor = Color.Snow;
            CalendarForWorksStart.CalendarDimensions = new Size(4, 2);
            CalendarForWorksStart.Location = new Point(18, 18);
            CalendarForWorksStart.Name = "CalendarForWorksStart";
            CalendarForWorksStart.TabIndex = 4;
            CalendarForWorksStart.DateChanged += CalendarForWorksStart_DateChanged;
            // 
            // DateStart_Test_Tb
            // 
            DateStart_Test_Tb.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            DateStart_Test_Tb.Location = new Point(713, 317);
            DateStart_Test_Tb.Multiline = true;
            DateStart_Test_Tb.Name = "DateStart_Test_Tb";
            DateStart_Test_Tb.ReadOnly = true;
            DateStart_Test_Tb.Size = new Size(297, 39);
            DateStart_Test_Tb.TabIndex = 8;
            // 
            // CalendarForWorksEnd
            // 
            CalendarForWorksEnd.CalendarDimensions = new Size(4, 2);
            CalendarForWorksEnd.Location = new Point(18, 329);
            CalendarForWorksEnd.Name = "CalendarForWorksEnd";
            CalendarForWorksEnd.TabIndex = 9;
            CalendarForWorksEnd.DateChanged += CalendarForWorksEnd_DateChanged;
            // 
            // Confirmable
            // 
            Confirmable.BackColor = Color.Red;
            Confirmable.Location = new Point(993, 613);
            Confirmable.Name = "Confirmable";
            Confirmable.Size = new Size(31, 25);
            Confirmable.TabIndex = 10;
            Confirmable.TabStop = false;
            Confirmable.Visible = false;
            // 
            // CalendarsForWorks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(107, 119, 120);
            ClientSize = new Size(1028, 657);
            Controls.Add(Confirmable);
            Controls.Add(CalendarForWorksEnd);
            Controls.Add(DateStart_Test_Tb);
            Controls.Add(Date_TestLabel);
            Controls.Add(DateEnd_Test_Tb);
            Controls.Add(Confirm_Button);
            Controls.Add(CalendarForWorksStart);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "CalendarsForWorks";
            Text = "WorksForDateCalendars";
            Load += CalendarsForWorks_Load;
            ((System.ComponentModel.ISupportInitialize)Confirmable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Date_TestLabel;
        private TextBox DateEnd_Test_Tb;
        private Button Confirm_Button;
        private MonthCalendar CalendarForWorksStart;
        private TextBox DateStart_Test_Tb;
        private MonthCalendar CalendarForWorksEnd;
        private PictureBox Confirmable;
    }
}