namespace Курсовая.Формы.Формы_с_календарем
{
    public partial class CalendarForDateGivenMatOf : Form
    {
        public CalendarForDateGivenMatOf()
        {
            InitializeComponent();
        }

        private void CalendarForDateGivenMatOf_Load(object sender, EventArgs e)
        {
            Confirmable.BackColor = CalendarForChangeMaterialsOffered.Color;
            if (Confirmable.BackColor == Color.Red || Confirmable.BackColor == Color.Green)
                MethodsForMaterialsOffered.ChangeCalendarMaterialsOffered.ActivateCalendar(CalendarForMaterialsOff);
        }
        private void CalendarForMaterialsOff_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (Confirmable.BackColor == Color.Red)
            {
                MethodsForMaterialsOffered.ChangeCalendarMaterialsOffered.GetDate(CalendarForMaterialsOff);
                Date_Test_Tb.Text = CalendarForChangeMaterialsOffered.Date;
            }
            else if (Confirmable.BackColor == Color.Green)
            {
                MethodsForMaterialsOffered.AddingCalendarMaterialsOffered.GetDate(CalendarForMaterialsOff);
                Date_Test_Tb.Text = CalendarForAddingMaterialsOffered.Date;
            }
            else if (Confirmable.BackColor == Color.Orange)
            {
                MethodsForMaterialsOffered.FilterCalendarMaterialsOffered.GetDate(CalendarForMaterialsOff);
                Date_Test_Tb.Text = CalendarForFilterMaterialsOffered.Date;
            }
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
