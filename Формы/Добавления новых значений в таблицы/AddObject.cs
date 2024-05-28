using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая.Формы.Добавления_новых_значений_в_таблицы
{
    public partial class AddObject : Form
    {
        public AddObject()
        {
            InitializeComponent();
        }

        private void AddObject_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Obj_NewObjB_Click(object sender, EventArgs e)
        {
            MethodsForObject.AddObjects.Add(Obj_name_Tb, Obj_RayonTb, Obj_StreetTb, Obj_HouseNTb,
            Obj_TypeOfObjTb, Obj_DstartTb, Obj_DEndTb);
        }

        private void ChangeObjDStartB_Click(object sender, EventArgs e)
        {
            CalendarForChangeObjects.Color = Color.Green;
            MethodsForObject.ChangeCalendarObjects.CalendarSavePrevious(Obj_DstartTb, Obj_DEndTb);
        }

        private void ResetObjDStartB_Click(object sender, EventArgs e)
        {
            Obj_DstartTb.Text = CalendarForChangeObjects.DateStartSave;
        }

        private void ResetObjDComplB_Click(object sender, EventArgs e)
        {
            Obj_DEndTb.Text = CalendarForChangeObjects.DateEndSave;
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

        private void Obj_name_Tb_TextChanged(object sender, EventArgs e)
        {
            Obj_name_Tb.RemoveAllOver70();
        }

        private void Obj_RayonTb_TextChanged(object sender, EventArgs e)
        {
            Obj_RayonTb.RemoveAllOver70();
        }

        private void Obj_StreetTb_TextChanged(object sender, EventArgs e)
        {
            Obj_StreetTb.RemoveAllOver70();
        }

        private void Obj_HouseNTb_TextChanged(object sender, EventArgs e)
        {
            Obj_HouseNTb.RemoveAllOver30();
        }

        private void Obj_TypeOfObjTb_TextChanged(object sender, EventArgs e)
        {
            Obj_TypeOfObjTb.RemoveAllOver30();
        }
    }
}
