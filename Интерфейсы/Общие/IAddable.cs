namespace Курсовая.Интерфейсы.Общие
{
    internal interface IAddable
    {
        void Add(ComboBox id, TextBox lnam, TextBox fnam, TextBox mnam, TextBox log, TextBox phon, TextBox emai, ComboBox gender, TextBox spec);
        void Add( TextBox brname, TextBox count, TextBox spec);
        void Add(TextBox mat_name, TextBox mat_price, TextBox mat_count, TextBox mat_company, TextBox mat_description, TextBox mat_features);
        void Add(ComboBox id_brigade, ComboBox id_work, ComboBox id_materials, TextBox matof_date_give, TextBox matof_count); //matof
        void Add(TextBox ob_name, TextBox ob_city_region, TextBox ob_street, TextBox ob_house_number, TextBox ob_type, TextBox ob_date_start, TextBox ob_date_end);
        void Add(ComboBox brigadename, ComboBox objectname, TextBox work_date_start, TextBox work_date_end, TextBox work_count, ComboBox status);

    }
}
