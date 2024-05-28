using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая.Интерфейсы.Целевые
{
    internal interface IChangeble
    {
        void Change(TextBox identitykey, ComboBox id, TextBox lnam, TextBox fnam, TextBox mnam, TextBox log, TextBox phon, TextBox emai, ComboBox gender, TextBox spec,
            DataGridView dgw, out bool result);
        void Change(TextBox identitykey, TextBox brname, TextBox count, TextBox spec,
            DataGridView dgw, out bool result);
        void Change(TextBox identitykey, TextBox mat_name, TextBox mat_price, TextBox mat_count, TextBox mat_company, TextBox mat_description, TextBox mat_features,
            DataGridView dgw, out bool result);
        void Change(TextBox identitykey, TextBox id_brigade, TextBox id_work, TextBox id_materials,TextBox matof_date_give, TextBox matof_count,
           DataGridView dgw, out bool result);
        void Change(TextBox identitykey, TextBox ob_name, TextBox ob_city_region, TextBox ob_street, TextBox ob_house_number, TextBox ob_type,TextBox ob_date_start, TextBox ob_date_end,
            DataGridView dgw, out bool result);
        void Change(TextBox identitykey, ComboBox brigadename, ComboBox objectname, TextBox work_date_start, TextBox work_date_end, TextBox work_count, ComboBox status,
            DataGridView dgw, out bool result); //works
    }
}
