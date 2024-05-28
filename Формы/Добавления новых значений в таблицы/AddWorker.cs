namespace Курсовая.Формы.Создание_рабочих
{
    public partial class AddWorker : Form
    {

        public AddWorker()
        {
            InitializeComponent();
        }

        private void AddWorker_Load(object sender, EventArgs e)
        {
            MethodsForWorkers.Comboboxes.ComboboxBrigadeName(Name_brigade_combobox);
            MethodsForWorkers.Comboboxes.ComboboxCityKey(CountrySpecForTelephoneCb);
            StartPosition = FormStartPosition.CenterScreen;
            MethodsForWorkers.Comboboxes.ComboboxGender(Gender_combobox);
        }

        private void Create_Worker_Click(object sender, EventArgs e)
        {
            MethodsForWorkers.AddWorker.Add(Name_brigade_combobox, textBox_brwr_lname, textBox_brwr_fname, textBox_brwr_mname, textBox_brwr_login, textBox_brwr_phone, textBox_brwr_email, Gender_combobox, textBox_brwr_speciality);
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

        private void textBox_brwr_phone_TextChanged(object sender, EventArgs e)
        {
            TextboxesScripts.WorkerTelephone(textBox_brwr_phone, WorkerPbCorrectPhon);
        }

        private void textBox_brwr_email_TextChanged(object sender, EventArgs e)
        {
            TextboxesScripts.WorkerEmail(textBox_brwr_email, WorkerPbCorrectEmai);
        }
        private void CountrySpecForTelephoneCb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            TextboxesScripts.Proverka(textBox_brwr_phone, CountrySpecForTelephoneCb);
        }

        private void textBox_brwr_fname_TextChanged(object sender, EventArgs e)
        {
            textBox_brwr_fname.RemoveAllOver30();
        }

        private void textBox_brwr_lname_TextChanged(object sender, EventArgs e)
        {
            textBox_brwr_lname.RemoveAllOver30();
        }

        private void textBox_brwr_mname_TextChanged(object sender, EventArgs e)
        {
            textBox_brwr_mname.RemoveAllOver30();
        }

        private void textBox_brwr_login_TextChanged(object sender, EventArgs e)
        {
            textBox_brwr_login.RemoveAllOver30();
        }

        private void textBox_brwr_speciality_TextChanged(object sender, EventArgs e)
        {
            textBox_brwr_speciality.RemoveAllOver70();
        }
    }
}
