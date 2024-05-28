namespace Курсовая.Формы.Формы_с_календарем
{
    public partial class CalendarsForObjects : Form
    {

        public CalendarsForObjects()
        {
            InitializeComponent();
        }
        public static Color Color { get; set; }
        private void CalendarsForObj_Load(object sender, EventArgs e)
        {
            Confirmable.BackColor = CalendarForChangeObjects.Color;
            if (Confirmable.BackColor == Color.Red || Confirmable.BackColor == Color.Green)
                MethodsForObject.ChangeCalendarObjects.ActivateCalendar(CalendarForObjStart, CalendarForObjComp);
        }
        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CalendarForObjStart_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (Confirmable.BackColor == Color.Red)
            {
                MethodsForObject.ChangeCalendarObjects.GetDateStart(CalendarForObjStart);
                DateStart_Test_Tb.Text = CalendarForChangeObjects.DateStart;
                CalendarForObjComp.MinDate = CalendarForObjStart.SelectionStart.AddDays(1);
                MethodsForObject.ChangeCalendarObjects.GetDateEnd(CalendarForObjComp);
                DateComp_Test_Tb.Text = CalendarForChangeObjects.DateEnd;
            }
            else if (Confirmable.BackColor == Color.Green)
            {
                MethodsForObject.AddingCalendarObjects.GetDateStart(CalendarForObjStart);
                DateStart_Test_Tb.Text = CalendarForAddingObjects.DateStart;
                CalendarForObjComp.MinDate = CalendarForObjStart.SelectionStart.AddDays(1);
                MethodsForObject.AddingCalendarObjects.GetDateEnd(CalendarForObjComp);
                DateComp_Test_Tb.Text = CalendarForAddingObjects.DateEnd;
            }
            else if (Confirmable.BackColor == Color.Orange)
            {
                MethodsForObject.FilterCalendarObjects.GetDateStart(CalendarForObjStart);
                DateStart_Test_Tb.Text = CalendarForFilterObjects.DateStart;
                CalendarForObjComp.MinDate = CalendarForObjStart.SelectionStart.AddDays(1);
                MethodsForObject.FilterCalendarObjects.GetDateEnd(CalendarForObjComp);
                DateComp_Test_Tb.Text = CalendarForFilterObjects.DateEnd;
            }
        }

        private void CalendarForObjComp_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (Confirmable.BackColor == Color.Red)
            {
                MethodsForObject.ChangeCalendarObjects.GetDateEnd(CalendarForObjComp);
                DateComp_Test_Tb.Text = CalendarForChangeObjects.DateEnd;
            }
            else if (Confirmable.BackColor == Color.Green)
            {
                MethodsForObject.AddingCalendarObjects.GetDateEnd(CalendarForObjComp);
                DateComp_Test_Tb.Text = CalendarForAddingObjects.DateEnd;
            }
            else if (Confirmable.BackColor == Color.Orange)
            {
                MethodsForObject.FilterCalendarObjects.GetDateEnd(CalendarForObjComp);
                DateComp_Test_Tb.Text = CalendarForFilterObjects.DateEnd;
            }
        }
    }
}
