namespace Курсовая
{
    public partial class LoginPage : Form
    {
        readonly MethodsLogReg Metod = new();
        public LoginPage()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {
            Metod.Preload(LoginTextbox, PasswordTextbox);
        }
        private void ResultButton_Click(object sender, EventArgs e)
        {
            if (Metod.Verification(LoginTextbox, PasswordTextbox) == true)
            {
                Mainform Main = new();
                Hide();
                Main.ShowDialog();
                Close();
            }
        }
        private void EyeOpen_Click(object sender, EventArgs e)
        {
            Metod.ShowPassword(PasswordTextbox, EyeOpen, EyeClose);
        }

        private void EyeClose_Click(object sender, EventArgs e)
        {
            Metod.ShowPassword(PasswordTextbox, EyeOpen, EyeClose);
        }

        private void LoginTextbox_TextChanged(object sender, EventArgs e)
        {
            LoginTextbox.RemoveAllOver50();
        }

        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextbox.RemoveAllOver50();
        }
    }
}