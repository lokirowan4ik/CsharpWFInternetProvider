using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая.Формы.Создание_рабочих.Методы_для_создания;

namespace Курсовая.Формы.Добавления_новых_значений_в_таблицы
{
    public partial class AddBrig : Form
    {
        public AddBrig()
        {
            InitializeComponent();
        }

        private void AddBrig_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Create_Brigade_Click(object sender, EventArgs e)
        {
            MethodsForBrigades.AddBrigades.Add(BrigNameTbMain, BrigadesPCountTbMain, BrigadesSpecTbMain);
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

        private void BrigadesSpecTbMain_TextChanged(object sender, EventArgs e)
        {
            BrigadesSpecTbMain.RemoveAllOver50();
        }

        private void BrigNameTbMain_TextChanged(object sender, EventArgs e)
        {
            BrigNameTbMain.RemoveAllOver30();
        }
    }
}
