using System.Data;

namespace Курсовая.Классы.Методы
{
    class MethodsLogReg
    {
        #region  Показ и скрытие '*' элемента в пароле
        /// <summary>
        ///  Метод показа и скрытия '*' элемента в пароле
        /// </summary>
        /// <param name="passwordbox"> Текстбокс Пароля</param>
        public void ShowPassword(TextBox passwordbox, PictureBox RedEye, PictureBox GrayEye)
        {
            if (passwordbox.PasswordChar == '*')
            {
                passwordbox.UseSystemPasswordChar = true;
                RedEye.Visible = false;
                GrayEye.Visible = true;

            }
            else
            {
                passwordbox.UseSystemPasswordChar = false;
                RedEye.Visible = true;
                GrayEye.Visible = false;
            }
        }
        #endregion

        #region Загрузка Формы
        /// <summary>
        ///  Метод загрузки формы   
        /// </summary>
        /// <param name="passwordbox"> Текстбокс Пароля</param>
        /// <param name="loginbox"> Текстбокс Логина</param>
        public void Preload(TextBox loginbox, TextBox passwordbox)
        {
            passwordbox.PasswordChar = '*';
            passwordbox.MaxLength = 50;
            loginbox.MaxLength = 50;
        }
        #endregion

        #region Проверка на подлинность
        /// <summary>
        ///  Метод проверки логина и пароля
        /// </summary>
        /// <param name="loginbox"> Текстбокс Логина</param>
        /// <param name="passwordbox"> Текстбокс Пароля</param>
        public bool Verification(TextBox loginbox, TextBox passwordbox) 
        {
           
            SqlDataAdapter adapter = new();
            DataTable table = new();

            string loginuser = loginbox.Text;
            string passworduser = passwordbox.Text;

            string querystring = $"SELECT * FROM registration WHERE login_user = '{loginuser}' and password_user = '{passworduser}'";

            SqlCommand command = new(querystring, DataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Вы ввели неккоректный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        //#region Регистрация аккаунта
        ///// <summary>
        /////  Метод проверки логина и пароля
        ///// </summary>
        ///// <param name="loginbox"> Текстбокс Логина</param>
        ///// <param name="passwordbox"> Текстбокс Пароля</param>
        //public bool Registration(TextBox loginbox, TextBox passwordbox)
        //{
        //    if (loginbox.Text == "" || passwordbox.Text == "")
        //    {
        //        MessageBox.Show("Значение не может быть пустым!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //    DataBase DataBase = new();
        //    SqlDataAdapter adapter = new();
        //    DataTable table = new();

        //    string loginuser = loginbox.Text;
        //    string passworduser = passwordbox.Text;

        //    string querystring = $"INSERT INTO registration VALUES( '{loginuser}', '{passworduser}')";

        //    SqlCommand command = new(querystring, DataBase.GetConnection());

        //    DataBase.OpenConnection();
            
        //    if (command.ExecuteNonQuery() == 1)
        //    {
        //        MessageBox.Show("Создание аккаунта завершено!", "Успешно!",MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        DataBase.CloseConnection();
        //        return true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Ошибка при создании аккаунта!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        DataBase.CloseConnection();
        //        return false;
        //    }
           
        //}
        //#endregion
    }
}
