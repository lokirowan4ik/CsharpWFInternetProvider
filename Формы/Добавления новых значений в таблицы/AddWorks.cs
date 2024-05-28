namespace Курсовая.Формы.Добавления_новых_значений_в_таблицы
{
    public partial class AddWorks : Form
    {
        public AddWorks()
        {
            InitializeComponent();
        }

        private void AddWorks_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            MethodsForWorks.ComboboxBrigObjStatus.ComboboxObjName(ob_name_inworksCb);
            MethodsForWorks.ComboboxBrigObjStatus.ComboboxBrigadeName(br_name_in_worksCb);
            MethodsForWorks.ComboboxBrigObjStatus.ComboboxStatus(Work_StatusComb);

        }

        private void Work_newButton_Click(object sender, EventArgs e)
        {
            MethodsForWorks.AddWorks.Add(br_name_in_worksCb, ob_name_inworksCb, Work_DStartTb, Work_DEndTb,
               Work_CountTb, Work_StatusComb);
        }

        private void ChangeDatSt_WorksB_Click(object sender, EventArgs e)
        {
            CalendarForChangeWorks.Color = Color.Red;
            MethodsForWorks.ChangeCalendarWorks.CalendarSavePrevious(Work_DStartTb, Work_DEndTb);
        }

        private void RevokeDatSt_WorksB_Click(object sender, EventArgs e)
        {
            Work_DStartTb.Text = CalendarForChangeWorks.DateStartSave;
        }

        private void RevokeDatEnd_WorksB_Click(object sender, EventArgs e)
        {
            Work_DEndTb.Text = CalendarForChangeWorks.DateEndSave;
        }

        private void KeyPressForAllWhoInt(object sender, KeyPressEventArgs e)
        {
            TextboxesScripts.FixTextboxInts(e);
        }
    }
}
