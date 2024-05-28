namespace Курсовая.Классы.Методы.Общие_Методы
{
    static class TextboxesScripts
    {
        public static string? CityKey { get; set; }
        public static void WorkerEmail(TextBox text, PictureBox pb)
        {
            if (text.Text.Length > 95)
            {
                text.Text = text.Text.Remove(text.Text.Length - 1);
                text.SelectionStart = text.TextLength;
            }
            if (Regex.IsMatch(text.Text, @"^[\w\d]{3,20}@(gmail|Gmail)[\.]com$"))
            {
                pb.BackColor = Color.DarkGreen;
            }
            else
            {
                pb.BackColor = Color.DarkRed;
            }
        }
        public static void WorkerTelephone(TextBox text, PictureBox pb)
        {
            if (text.Text.Length > 10 && Regex.IsMatch(text.Text, @"\d"))
            {
                text.Text = text.Text.Remove(text.Text.Length - 1);
                text.SelectionStart = text.TextLength;
            }
            if (text.Text.Length == 10)
            {
                pb.BackColor = Color.DarkGreen;
            }
            else
            {
                pb.BackColor = Color.DarkRed;
            }
        }
        public static void RemoveAllOver30(this TextBox text)
        {
            if (text.Text.Length > 30)
            {
                text.Text = text.Text.Remove(text.Text.Length - 1);
                text.SelectionStart = text.TextLength;
            }
        }        
        public static void RemoveAllOver50(this TextBox text)
        {
            if (text.Text.Length > 50)
            {
                text.Text = text.Text.Remove(text.Text.Length - 1);
                text.SelectionStart = text.TextLength;
            }
        }   
        public static void RemoveAllOver70(this TextBox text)
        {
            if (text.Text.Length > 70)
            {
                text.Text = text.Text.Remove(text.Text.Length - 1);
                text.SelectionStart = text.TextLength;
            }
        }
        public static bool CheckColor(PictureBox pb)
        {
            if (pb.BackColor == Color.DarkGreen)
            {
                return true;
            }
            else return false;
        }
        public static void FixTextboxInts(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 || e.KeyChar == 32) // 8 - это код клавиши Backspace
            {
                e.Handled = true; // отменяем ввод символа
            }
        }
        public static void FixTextboxDouble(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46 || e.KeyChar == 32) // 8 - это код клавиши Backspace, 46 - Точка
            {
                e.Handled = true; // отменяем ввод символа
            }
        }
        public static void FixTextboxString(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32) // 8 - это код клавиши Backspace
            {
                e.Handled = true; // отменяем ввод символа
            }
        }
        public static void Proverka(TextBox phonetextbox, ComboBox CountryCb)
        {
            phonetextbox.Enabled = true;
            CityKey = CountryCb.SelectedItem.ToString()?.Trim();
        }
    }
}
