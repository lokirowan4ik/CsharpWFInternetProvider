namespace Курсовая.Интерфейсы.Целевые
{
    internal interface IClickable
    {
        void Cellsclick(TextBox identitykey, ComboBox id, TextBox lnam, TextBox fnam, TextBox mnam, TextBox log, ComboBox citykodeph, TextBox phon, TextBox emai, TextBox spec, ComboBox gender, 
            DataGridViewCellEventArgs e, DataGridView dgw); //10 worker
        void Cellsclick(TextBox identitykey, TextBox brname, TextBox count, TextBox spec,
            DataGridViewCellEventArgs e, DataGridView dgw); //4 brig
        void Cellsclick(TextBox identitykey, TextBox ob_name, TextBox ob_city_region, TextBox ob_street, TextBox ob_house_number, TextBox ob_type, TextBox ob_date_start, TextBox ob_date_end,
            DataGridViewCellEventArgs e, DataGridView dgw); //8 obj
        void Cellsclick(TextBox identitykey, ComboBox id_brigade, ComboBox id_object_building, TextBox work_date_start, TextBox work_date_end, TextBox work_count, ComboBox work_in_process,
            DataGridViewCellEventArgs e, DataGridView dgw); //6 work
        void Cellsclick(TextBox identitykey, TextBox mat_name, TextBox mat_price, TextBox mat_count, TextBox mat_company, TextBox mat_description, TextBox mat_features, 
            DataGridViewCellEventArgs e, DataGridView dgw); //7 materials
        void Cellsclick(TextBox identitykey, TextBox id_brigade, TextBox id_work, TextBox id_materials, TextBox matof_date_give, TextBox matof_count, 
            DataGridViewCellEventArgs e, DataGridView dgw); //6+1 matof
    }
}
