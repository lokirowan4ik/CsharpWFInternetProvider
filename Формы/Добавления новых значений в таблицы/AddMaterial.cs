namespace Курсовая.Формы.Добавления_новых_значений_в_таблицы
{
    public partial class AddMaterial : Form
    {
        public AddMaterial()
        {
            InitializeComponent();
        }

        private void AddMaterial_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Mat_addBut_Click(object sender, EventArgs e)
        {
            MethodsForMaterials.AddMaterials.Add(Mat_Name_Tb, Mat_PriceTb, Mat_CountTb, Mat_CompanyTb, Mat_DescrTb, Mat_FeaturesTb);
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

        private void Mat_Name_Tb_TextChanged(object sender, EventArgs e)
        {
            Mat_Name_Tb.RemoveAllOver70();
        }

        private void Mat_CompanyTb_TextChanged(object sender, EventArgs e)
        {
            Mat_CompanyTb.RemoveAllOver30();
        }

        private void Mat_DescrTb_TextChanged(object sender, EventArgs e)
        {
            Mat_DescrTb.RemoveAllOver30();
        }

        private void Mat_FeaturesTb_TextChanged(object sender, EventArgs e)
        {
            Mat_FeaturesTb.RemoveAllOver30();
        }
    }
}
