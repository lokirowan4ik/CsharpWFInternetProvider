using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая.Интерфейсы.Абстрактные_классы
{
    abstract class AddNewBase : IAddable
    {
        public virtual void Add(ComboBox id, TextBox lnam, TextBox fnam, TextBox mnam, TextBox log, TextBox phon, TextBox emai, ComboBox gender, TextBox spec)
        {
            throw new NotImplementedException();
        }

        public virtual void Add(TextBox brname, TextBox count, TextBox spec)
        {
            throw new NotImplementedException();
        }

        public virtual void Add(TextBox mat_name, TextBox mat_price, TextBox mat_count, TextBox mat_company, TextBox mat_description, TextBox mat_features)
        {
            throw new NotImplementedException();
        }

        public virtual void Add(ComboBox id_brigade, ComboBox id_work, ComboBox id_materials, TextBox matof_date_give, TextBox matof_count)
        {
            throw new NotImplementedException();
        } // matof

        public virtual void Add(TextBox ob_name, TextBox ob_city_region, TextBox ob_street, TextBox ob_house_number, TextBox ob_type, TextBox ob_date_start, TextBox ob_date_end)
        {
            throw new NotImplementedException();
        }

        public virtual void Add(ComboBox brigadename, ComboBox objectname, TextBox work_date_start, TextBox work_date_end, TextBox work_count, ComboBox status)
        {
            throw new NotImplementedException();
        }
    }
}
