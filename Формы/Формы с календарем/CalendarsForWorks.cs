namespace Курсовая.Формы.Формы_с_календарем
{
    public partial class CalendarsForWorks : Form
    {
        public CalendarsForWorks()
        {
            InitializeComponent();
        }
        public static Color Color { get; set; }
        private void CalendarsForWorks_Load(object sender, EventArgs e)
        {
            Confirmable.BackColor = CalendarForChangeWorks.Color;
            if (Confirmable.BackColor == Color.Red || Confirmable.BackColor == Color.Green)
                MethodsForWorks.ChangeCalendarWorks.ActivateCalendar(CalendarForWorksStart, CalendarForWorksEnd);
        }
        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalendarForWorksStart_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (Confirmable.BackColor == Color.Red)
            {
                MethodsForWorks.ChangeCalendarWorks.GetDateStart(CalendarForWorksStart);
                DateStart_Test_Tb.Text = CalendarForChangeWorks.DateStart;
                CalendarForWorksEnd.MinDate = CalendarForWorksStart.SelectionStart.AddDays(1);
                MethodsForWorks.ChangeCalendarWorks.GetDateEnd(CalendarForWorksEnd);
                DateEnd_Test_Tb.Text = CalendarForChangeWorks.DateEnd;
            }
            else if (Confirmable.BackColor == Color.Green)
            {
                MethodsForWorks.AddingCalendarWorks.GetDateStart(CalendarForWorksStart);
                DateStart_Test_Tb.Text = CalendarForAddingWorks.DateStart;
                CalendarForWorksEnd.MinDate = CalendarForWorksStart.SelectionStart.AddDays(1);
                MethodsForWorks.AddingCalendarWorks.GetDateEnd(CalendarForWorksEnd);
                DateEnd_Test_Tb.Text = CalendarForAddingWorks.DateEnd;
            }
            else if (Confirmable.BackColor == Color.Orange)
            {
                MethodsForWorks.FilterCalendarWorks.GetDateStart(CalendarForWorksStart);
                DateStart_Test_Tb.Text = CalendarForFilterWorks.DateStart;
                CalendarForWorksEnd.MinDate = CalendarForWorksStart.SelectionStart.AddDays(1);
                MethodsForWorks.FilterCalendarWorks.GetDateEnd(CalendarForWorksEnd);
                DateEnd_Test_Tb.Text = CalendarForFilterWorks.DateEnd;
            }
        }

        private void CalendarForWorksEnd_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (Confirmable.BackColor == Color.Red)
            {
                MethodsForWorks.ChangeCalendarWorks.GetDateEnd(CalendarForWorksEnd);
                DateEnd_Test_Tb.Text = CalendarForChangeWorks.DateEnd;
            }
            else if (Confirmable.BackColor == Color.Green)
            {
                MethodsForWorks.AddingCalendarWorks.GetDateEnd(CalendarForWorksEnd);
                DateEnd_Test_Tb.Text = CalendarForAddingWorks.DateEnd;
            }
            else if (Confirmable.BackColor == Color.Orange)
            {
                MethodsForWorks.FilterCalendarWorks.GetDateEnd(CalendarForWorksEnd);
                DateEnd_Test_Tb.Text = CalendarForFilterWorks.DateEnd;
            }
        }
    }
}
