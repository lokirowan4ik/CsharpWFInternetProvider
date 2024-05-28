namespace Курсовая.Формы.Добавления_новых_значений_в_таблицы.Методы_для_создания
{
    public partial class AddMaterialOffered : Form
    {
        public AddMaterialOffered()
        {
            InitializeComponent();
        }

        private void Newmat_mat_ofBut_Click(object sender, EventArgs e)
        {
            MethodsForMaterialsOffered.AddMaterialsOffered.Add(br_name_Cb, Work_KeyComb, mat_name_Cb, mat_of_date_tb,
            mat_of_count_tb);
        }

        private void AddMaterialOffered_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            MethodsForMaterialsOffered.ComboboxesBrWorkMat.ComboboxBrigadeName(br_name_Cb);
            MethodsForMaterialsOffered.ComboboxesBrWorkMat.ComboboxMaterials(mat_name_Cb);
            MethodsForMaterialsOffered.ComboboxesBrWorkMat.ComboboxWorks(Work_KeyComb);
            MethodsForMaterialsOffered.ComboboxesBrWorkMat.ComboboxSelectedBrname(br_name_Cb, Work_KeyComb);
        }

        private void Change_mat_of_date_B_Click(object sender, EventArgs e)
        {
            CalendarForChangeMaterialsOffered.Color = Color.Green;
            MethodsForMaterialsOffered.ChangeCalendarMaterialsOffered.CalendarSavePrevious(mat_of_date_tb);
        }

        private void Restore_mat_of_date_B_Click(object sender, EventArgs e)
        {
            MethodsForMaterialsOffered.ChangeCalendarMaterialsOffered.CalendarSavePrevious(mat_of_date_tb);
        }

        private void KeyPressForAllWhoInt(object sender, KeyPressEventArgs e)
        {
            TextboxesScripts.FixTextboxInts(e);
        }

        private void KeyPressForAllWhoString(object sender, KeyPressEventArgs e)
        {
            TextboxesScripts.FixTextboxString(e);
        }

        private void KeyPressForAllWhoDouble(object sender, KeyPressEventArgs e)
        {
            TextboxesScripts.FixTextboxDouble(e);
        }

        private void br_name_Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            MethodsForMaterialsOffered.ComboboxesBrWorkMat.ComboboxSelectedBrname(br_name_Cb, Work_KeyComb);
        }

        private void mat_name_Cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            MethodsForMaterialsOffered.ComboboxesBrWorkMat.GetCountMaterialsToLabel(GetCountMatOffFromMatL, mat_name_Cb);
        }
    }
}
