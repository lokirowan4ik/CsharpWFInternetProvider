namespace Курсовая.Интерфейсы.Общие
{
    internal interface ICalendarTwo
    {
        #region Строки для записи значений

        static string? DateStart { get; set; }
        static string? DateEnd { get; set; }

        # endregion
        #region Строки для сохранения значений
        static string? DateStartSave { get; set; }
        static string? DateEndSave { get; set; }

        #endregion
        void GetDateStart<T>(T a) where T : MonthCalendar;
        void GetDateEnd<T>(T a) where T : MonthCalendar;
        void ActivateCalendar<T>(T a, T b) where T : MonthCalendar;
        void CalendarSavePrevious<T>(T a, T b) where T : TextBox;
    }
    interface ICalendarOne
    {
        static string? Date { get; set; } //Запись
        static string? DateSave { get; set; } //Сохранение
        void GetDate<T>(T a) where T : MonthCalendar;
        void ActivateCalendar<T>(T a) where T : MonthCalendar;
        void CalendarSavePrevious<T>(T a) where T : TextBox;
    }
}
