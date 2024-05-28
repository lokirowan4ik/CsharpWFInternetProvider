using Microsoft.VisualBasic.Logging;

namespace Курсовая.Формы.Создание_рабочих.Методы_для_создания
{
    //TODO: добавление новых объектов
    #region Добавление рабочего
    class AddingWorkers : AddNewBase
    {

        /// <summary>
        /// Добавление рабочих
        /// </summary>
        /// <param name="id">Айди бригады</param>
        /// <param name="log">логин</param>
        /// <param name="phon">номер телефона</param>
        /// <param name="emai">Емейл</param>
        /// <param name="lnam">Фамилия</param>
        /// <param name="fnam">Имя</param>
        /// <param name="mnam">Отчество</param>
        /// <param name="spec">Специальность</param>
        public override void Add(ComboBox id, TextBox lnam, TextBox fnam, TextBox mnam, TextBox log, TextBox phon, TextBox emai,  ComboBox gender, TextBox spec)
        {
            if (id.SelectedIndex.ToString().Length > 0 && log.TextLength > 0 && phon.TextLength > 0 && emai.TextLength > 0
                && lnam.TextLength > 0 && fnam.TextLength > 0 && mnam.TextLength > 0 && spec.TextLength > 0)
            {
                DataBase.OpenConnection();
                string AddQuery = $"INSERT INTO brigade_worker VALUES ('{Comboboxid.GiveIdFromBrigadeName(id)}','{lnam.Text.Replace("'", "''")}','{fnam.Text.Replace("'", "''")}'," +
                    $"'{mnam.Text}','{log.Text.Replace("'", "''")}'," +
                    $"'{TextboxesScripts.CityKey + phon.Text.Replace("'", "''")}','{emai.Text.Replace("'", "''")}'," +
                    $"'{CheckComboboxes.GetStringFromIndexGender(gender)}','{spec.Text.Replace("'", "''")}')"; //Добавил GetStringFromIndexGender(gender)
                SqlCommand command = new(AddQuery, DataBase.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Успешно Добавлено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBase.CloseConnection();
            }
            else MessageBox.Show("Не вся иформация заполнена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #endregion

    #region Добавление новой бригады
    class AddingBrigades : AddNewBase
    {
        /// <summary>
        /// Занесение информации в текстбокс бригады
        /// </summary>
        /// <param name="identitykey">Айди бригады</param>
        /// <param name="brname">Название бригады</param>
        /// <param name="count">Кол-во рабочих</param>
        /// <param name="spec">Специальность</param>
        public override void Add(TextBox brname, TextBox count, TextBox spec)
        {
            if (brname.TextLength > 0 && count.TextLength > 0 && spec.TextLength > 0)
            {
                DataBase.OpenConnection();
                string AddQuery = $"INSERT INTO brigade VALUES ('{brname.Text.Replace("'", "''")}','{count.Text.Replace("'", "''")}'," +
                    $"'{spec.Text.Replace("'", "''")}')";
                SqlCommand command = new(AddQuery, DataBase.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Успешно Добавлено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBase.CloseConnection();
            }
            else MessageBox.Show("Не вся иформация заполнена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #endregion

    #region Добавление материалов

    class AddingMaterials : AddNewBase
    {
        /// <summary>
        /// Занесение информации в текстбокс Материалов
        /// </summary>
        /// <param name="identitykey">Айди материалов</param>
        /// <param name="mat_name">Название материалов</param>
        /// <param name="mat_price">Цена</param>
        /// <param name="mat_count">Количество</param>
        /// <param name="mat_company">Фирма</param>
        /// <param name="mat_description">Описание</param>
        /// <param name="mat_features">Особенности</param>

        public override void Add(TextBox mat_name, TextBox mat_price, TextBox mat_count, TextBox mat_company,
        TextBox mat_description, TextBox mat_features)
        {
            if (mat_name.TextLength > 0 && mat_price.TextLength > 0 && mat_count.TextLength > 0
                && mat_company.TextLength > 0 && mat_description.TextLength > 0 && mat_features.TextLength > 0)
            {
                DataBase.OpenConnection();
                string AddQuery = $"INSERT INTO materials VALUES ('{mat_name.Text.Replace("'", "''")}'," +
                    $"'{mat_price.Text.Replace("'", "''")}','{mat_count.Text.Replace("'", "''")}','{mat_company.Text.Replace("'", "''")}','{mat_description.Text.Replace("'", "''")}','{mat_features.Text.Replace("'", "''")}')";
                SqlCommand command = new(AddQuery, DataBase.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Успешно Добавлено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBase.CloseConnection();
            }
            else MessageBox.Show("Не вся иформация заполнена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #endregion

    #region Добавление заказанных материалов
    class AddingMaterialsOff : AddNewBase
    {
        /// <summary>
        /// Занесение информации в текстбокс заказанных материалов
        /// </summary>
        /// <param name="id_brigade">Айди бригады</param>
        /// <param name="id_work">Айди работы</param>
        /// <param name="id_materials">Айди материалов</param>
        /// <param name="matof_date_give">Дата получения</param>
        /// <param name="matof_count">количество</param>
        /// <param name="dgw">Таблица для которой нужно сделать</param>
        public override void Add(ComboBox id_brigade, ComboBox id_work, ComboBox id_materials,
            TextBox matof_date_give, TextBox matof_count)
        {
            if (id_brigade.SelectedIndex.ToString().Length > 0 && id_work.Items.Count > 0
                && id_materials.SelectedIndex.ToString().Length > 0 && matof_date_give.TextLength > 0 && matof_count.TextLength > 0)
            {
                int matCount = 0;
                matCount.CounterMaterialsCount(id_materials);
                int selectedWorkId = int.Parse(((DataRowView)id_work.SelectedItem)["id_work"].ToString() ?? "");
                if (int.Parse(matof_count.Text) <= matCount)
                {
                    DataBase.OpenConnection();
                    string AddQuery = $"INSERT INTO materials_offered VALUES ('{Comboboxid.GiveIdFromBrigadeName(id_brigade)}'," +
                        $"'{selectedWorkId}','{Comboboxid.GiveIdFromMaterials(id_materials)}','{matof_date_give.Text}','{matof_count.Text}')";

                    SqlCommand command2 = new(AddQuery, DataBase.GetConnection());
                    command2.ExecuteNonQuery();

                    MessageBox.Show("Успешно Добавлено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataBase.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Невозможно заказать больше чем есть на складе!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Не вся иформация заполнена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }

    #endregion

    #region Добавление объектов 

    class AddingObjects : AddNewBase
    {
        /// <summary>
        /// Занесение информации в текстбокс Объекта
        /// </summary>
        /// <param name="ob_name">Название объекта</param>
        /// <param name="ob_city_region">Регион</param>
        /// <param name="ob_street">Улица</param>
        /// <param name="ob_house_number">Номер дома</param>
        /// <param name="ob_type">Тип</param>
        /// <param name="ob_date_start">Начальная дата</param>
        /// <param name="ob_date_end">Конечная дата</param>
        public override void Add(TextBox ob_name,
            TextBox ob_city_region, TextBox ob_street, TextBox ob_house_number, TextBox ob_type,
            TextBox ob_date_start, TextBox ob_date_end)
        {
            if (ob_name.TextLength > 0 && ob_city_region.TextLength > 0 && ob_street.TextLength > 0
                 && ob_house_number.TextLength > 0 && ob_type.TextLength > 0 && ob_date_start.TextLength > 0 && ob_date_end.TextLength > 0)
            {
                DataBase.OpenConnection();
                string AddQuery = $"INSERT INTO object_building VALUES ('{ob_name.Text.Replace("'", "''")}'," +
                    $"'{ob_city_region.Text.Replace("'", "''")}','{ob_street.Text.Replace("'", "''")}'," +
                    $"'{ob_house_number.Text.Replace("'", "''")}','{ob_type.Text.Replace("'", "''")}','{ob_date_start.Text.Replace("'", "''")}'," +
                    $"'{ob_date_end.Text.Replace("'", "''")}')";
                SqlCommand command = new(AddQuery, DataBase.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Успешно Добавлено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBase.CloseConnection();
            }
            else MessageBox.Show("Не вся иформация заполнена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #endregion

    #region Добавление работ 

    class AddingWorks : AddNewBase
    {
        /// <summary>
        /// Добавление работ
        /// </summary>
        /// <param name="brigadename">айди бриг</param>
        /// <param name="objectname">айди обьекта</param>
        /// <param name="work_date_start">начало работы</param>
        /// <param name="work_date_end">конец работы</param>
        /// <param name="work_count">кол-во работ</param>
        /// <param name="status">статус</param>
        public override void Add(ComboBox brigadename, ComboBox objectname, TextBox work_date_start, TextBox work_date_end, TextBox work_count, ComboBox status)
        {
            if (brigadename.SelectedIndex.ToString().Length > 0 && objectname.SelectedIndex.ToString().Length > 0 && work_date_start.TextLength > 0
                 && work_date_end.TextLength > 0 && work_count.TextLength > 0)
            {
                DataBase.OpenConnection();
                string AddQuery = $"INSERT INTO works VALUES ('{Comboboxid.GiveIdFromBrigadeName(brigadename)}'," +
                    $"'{Comboboxid.GiveIdFromObjectName(objectname)}'," +
                    $"'{work_date_start.Text.Replace("'", "''")}','{work_date_end.Text.Replace("'", "''")}','{work_count.Text.Replace("'", "''")}'," +
                    $"'{CheckComboboxes.GetStringFromIndexStatus(status).Replace("'", "''")}')";
                SqlCommand command = new(AddQuery, DataBase.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Успешно Добавлено!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataBase.CloseConnection();
            }
            else MessageBox.Show("Не вся иформация заполнена!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    #endregion

}
