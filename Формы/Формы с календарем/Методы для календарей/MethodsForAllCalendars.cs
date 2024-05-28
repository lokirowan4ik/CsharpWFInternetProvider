namespace Курсовая.Формы.Формы_с_календарем
{
    //TODO: Календарные методы
    class CalendarForChangeWorks : ICalendarTwo
    {
        public static string? DateStart { get; set; }
        public static string? DateEnd { get; set; }
        public static string? DateStartSave { get; private set; }
        public static string? DateEndSave { get; private set; }
        public static Color Color { get; set; }
        public virtual void ActivateCalendar<T>(T Calendar1, T Calendar2) where T : MonthCalendar
        {
            DateTime Today = DateTime.Now;
            Calendar1.MinDate = Today;
            Calendar2.MinDate = Today.AddDays(1);
        }

        public void CalendarSavePrevious<T>(T DstartTb, T DendTb) where T : TextBox
        {
            DateStartSave = DstartTb.Text;
            DateEndSave = DendTb.Text;
            CalendarsForWorks date = new();
            date.ShowDialog();
            DstartTb.Text = DateStart;
            DendTb.Text = DateEnd;
        }

        public void GetDateStart<T>(T Calendar1) where T : MonthCalendar
        {
            DateStart = Calendar1.SelectionStart.ToString("yyyy/MM/d");
        }
        public void GetDateEnd<T>(T Calendar2) where T : MonthCalendar
        {
            DateEnd = Calendar2.SelectionStart.ToString("yyyy/MM/d");
        }
    }
    class CalendarForChangeObjects : ICalendarTwo
    {
        public static string? DateStart { get; set; }
        public static string? DateEnd { get; set; }
        public static string? DateStartSave { get; private set; }
        public static string? DateEndSave { get; private set; }
        public static Color Color { get; set; }
        public void ActivateCalendar<T>(T Calendar1, T Calendar2) where T : MonthCalendar
        {
            DateTime Today = DateTime.Now;
            Calendar1.MinDate = Today;
            Calendar2.MinDate = Today.AddDays(1);
        }

        public void CalendarSavePrevious<T>(T DstartTb, T DendTb) where T : TextBox
        {
            DateStartSave = DstartTb.Text;
            DateEndSave = DendTb.Text;
            CalendarsForObjects date = new();
            date.ShowDialog();
            DstartTb.Text = DateStart;
            DendTb.Text = DateEnd;
        }
        public void GetDateStart<T>(T Calendar1) where T : MonthCalendar
        {
            DateStart = Calendar1.SelectionStart.ToString("yyyy/MM/d");
        }
        public void GetDateEnd<T>(T Calendar2) where T : MonthCalendar
        {
            DateEnd = Calendar2.SelectionStart.ToString("yyyy/MM/d");
        }

    }
    class CalendarForChangeMaterialsOffered : ICalendarOne
    {
        public static string? Date { get; set; }
        public static string? DateSave { get; private set; }
        public static Color Color { get; set; }
        public void ActivateCalendar<T>(T Calendar) where T : MonthCalendar
        {
            Calendar.MinDate = DateTime.Now;
        }

        public void CalendarSavePrevious<T>(T Matoftextbox) where T : TextBox
        {
            DateSave = Matoftextbox.Text;
            CalendarForDateGivenMatOf date = new();
            date.ShowDialog();
            Matoftextbox.Text = Date;
        }

        public void GetDate<T>(T Calendar1) where T : MonthCalendar
        {
                Date = Calendar1.SelectionStart.ToString("yyyy/MM/d");
        }
    }

    class CalendarForAddingWorks : CalendarForChangeWorks { }
    class CalendarForAddingObjects : CalendarForChangeObjects { }
    class CalendarForAddingMaterialsOffered : CalendarForChangeMaterialsOffered { }
    class CalendarForFilterWorks : CalendarForChangeWorks { }
    class CalendarForFilterObjects : CalendarForChangeObjects { }
    class CalendarForFilterMaterialsOffered : CalendarForChangeMaterialsOffered { }
}
