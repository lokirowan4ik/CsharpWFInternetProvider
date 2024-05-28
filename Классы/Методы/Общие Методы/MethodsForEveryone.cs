using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Курсовая.Классы.Методы.Общие_Методы
{
    public enum RowState
    {
        Existed,
        Added,
        Modified,
        ModifiedNew,
        Deleted
    };
    //нужна перегрузка метода

    #region Очитка полей текстбоксов
    static class ClearTextBoxes
    {
        public static void ClearText(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control.HasChildren)
                {
                    ClearText(control.Controls);
                }
            }
        }
    }
    #endregion

    public static class ExtensionMethods
    {
        public static void RestoreAll(this CheckedListBox checkbox)
        {
            while (checkbox.CheckedIndices.Count > 0)
            {
                checkbox.SetItemChecked(checkbox.CheckedIndices[0], false);
            }
        }
        public static void Count(this Label text, DataGridView dgv)
        {
            text.Text = $"Загальна кількість рядків: {dgv.RowCount}";
        }
        public static void GetSum(this Label lbl, DataGridView dgv, int columnIndex1, int columnIndex2)
        {
            decimal sum = 0;
            foreach (DataGridViewRow Row in dgv.Rows)
            {
                sum += Convert.ToDecimal(Row.Cells[columnIndex1].Value) * Convert.ToDecimal(Row.Cells[columnIndex2].Value);
            }

            lbl.Text = $"Сума всіх матеріалів: {sum}";
        }
        public static int CounterMaterialsCount(this ref int matCount, ComboBox id_materials)
        {
            DataBase.OpenConnection();
            string selectQuery = $"SELECT mat_count FROM materials WHERE id_materials = '{Comboboxid.GiveIdFromMaterials(id_materials)}'";
            SqlCommand command1 = new SqlCommand(selectQuery, DataBase.GetConnection());
            DataBase.OpenConnection();
            SqlDataReader reader = command1.ExecuteReader();
            if (reader.Read())
            {
                matCount = reader.GetInt32(0);
            }
            DataBase.CloseConnection();
            return matCount;
        }
        public static int CounterMaterialsCount(this ref int matCount, TextBox id_materials)
        {
            DataBase.OpenConnection();
            string selectQuery = $"SELECT mat_count FROM materials WHERE id_materials = '{id_materials.Text}'";
            SqlCommand command1 = new SqlCommand(selectQuery, DataBase.GetConnection());
            DataBase.OpenConnection();
            SqlDataReader reader = command1.ExecuteReader();
            if (reader.Read())
            {
                matCount = reader.GetInt32(0);
            }
            DataBase.CloseConnection();
            string selectQuery2 = $"SELECT matof_count FROM materials_offered";
            DataBase.OpenConnection();
            SqlCommand command2 = new SqlCommand(selectQuery2, DataBase.GetConnection());
            SqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                matCount += reader2.GetInt32(0);
            }
            DataBase.CloseConnection();
            return matCount;
        }
    }



    #region Передача из комбобокса айди  
    static class Comboboxid
    {
        public static int GiveIdFromBrigadeName(ComboBox Br_names)
        {
            if (Br_names.SelectedItem is DataRowView selectedRow)
            {
                return (int)selectedRow["id_brigade"];
            }
            else
            {
                // Обработка ситуации, когда ни один элемент не выбран
                return -1;
            }
        }
     
        public static int GiveIdFromObjectName(ComboBox Obj_name)
        {
            if (Obj_name.SelectedItem is DataRowView selectedRow)
            {
                return (int)selectedRow["id_object_building"];
            }
            else
            {
                // Обработка ситуации, когда ни один элемент не выбран
                return -1;
            }
        }
        public static int GiveIdFromMaterials(ComboBox Mat_name)
        {
            if (Mat_name.SelectedItem is DataRowView selectedRow)
            {
                return (int)selectedRow["id_materials"];
            }
            else
            {
                // Обработка ситуации, когда ни один элемент не выбран
                return -1;
            }
        }
    }
    #endregion

    #region Регион проверка комбобоксов
    class CheckComboboxes
    {
        /// <summary>
        /// Проверка пола
        /// </summary>
        /// <param name="gend">Комбобокс пола</param>
        /// <returns></returns>
        public static string GetStringFromIndexGender(ComboBox gend)
        {
            string gender;
            if (gend.SelectedIndex == 1) gender = "Жінка";
            else gender = "Чоловік";//изменять на текущее значение + 1
            return gender;
        }
        public static string GetStringFromIndexStatus(ComboBox stat)
        {
            string status = "";
            switch (stat.SelectedIndex)
            {
                case 0: status = "У процесі"; break;
                case 1: status = "Завершено"; break;
                case 2: status = "Не розпочато"; break;
            }
            return status;
        }
    }

    #endregion

    #region Чтение каждой строки

    #region Чтение каждой строки с таблицы работ 
    /// <summary>
    /// Чтение каждой строки с таблицы работ
    /// </summary>
    /// <param name="dat">Указание Datagridview</param>
    /// <param name="record">Интерфейс чтения</param>
    class ReadSingleRowFromWorks : RefreshableBase, IReadable
    {
        public override void ReadSingleRows(DataGridView dat, IDataRecord record)
        {
            dat.Rows.Add(record.GetInt32(0),
            record.GetInt32(1), record.GetInt32(2),
            record.GetDateTime(3).ToString("yyyy/MM/d"), record.GetDateTime(4).ToString("yyyy/MM/d"),
            record.GetInt32(5), record.GetString(6), record.GetString(7), record.GetString(8), RowState.ModifiedNew);
        }
    }
    #endregion

    #region Чтение каждой строки с таблицы бригад
    class ReadSingleRowFromBrigades : RefreshableBase, IReadable
    {
        /// <summary>
        /// Чтение каждой строки с таблицы рабочих
        /// </summary>
        /// <param name="dat">Указание Datagridview</param>
        /// <param name="record">Интерфейс чтения</param>
        public override void ReadSingleRows(DataGridView dat, IDataRecord record)
        {
            dat.Rows.Add(record.GetInt32(0),
            record.GetString(1), record.GetInt32(2),
            record.GetString(3), RowState.ModifiedNew);
        }
    }
    #endregion

    #region Чтение каждой строки с таблицы материалов
    /// <summary>
    /// Чтение каждой строки с таблицы материалов
    /// </summary>
    /// <param name="dat">Указание Datagridview</param>
    /// <param name="record">Интерфейс чтения</param>
    class ReadSingleRowFromMaterials : RefreshableBase, IReadable
    {
        public override void ReadSingleRows(DataGridView dat, IDataRecord record)
        {
            dat.Rows.Add(record.GetInt32(0),
            record.GetString(1), record.GetDecimal(2),
            record.GetInt32(3), record.GetString(4),
            record.GetString(5), record.GetString(6),
            RowState.ModifiedNew);
        }
    }
    #endregion


    #region Чтение каждой строки с таблицы Заказанных материалов
    class ReadSingleRowFromMaterialsOffered : RefreshableBase, IReadable
    {
        //готово
        /// <summary>
        /// Чтение каждой строки с таблицы заказанных материалов
        /// </summary>
        /// <param name="dat">Указание Datagridview</param>
        /// <param name="record">Интерфейс чтения</param>
        public override void ReadSingleRows(DataGridView dat, IDataRecord record)
        {
            dat.Rows.Add(record.GetInt32(0),
            record.GetInt32(1), record.GetInt32(2),
            record.GetInt32(3), record.GetDateTime(4).ToString("yyyy/MM/d"),
            record.GetInt32(5), record.GetString(6), record.GetString(7), record.GetString(8), RowState.ModifiedNew);
        }
    }
    #endregion

    #region Чтение каждой строки с таблицы объектов
    class ReadSingleRowFromObjectBuilding : RefreshableBase, IReadable
    {
        /// <summary>
        /// Чтение каждой строки с таблицы объектов
        /// </summary>
        /// <param name="dat">Указание Datagridview</param>
        /// <param name="record">Интерфейс чтения</param>
        public override void ReadSingleRows(DataGridView dat, IDataRecord record)
        {
            dat.Rows.Add(record.GetInt32(0),
            record.GetString(1), record.GetString(2),
            record.GetString(3), record.GetString(4),
            record.GetString(5), record.GetDateTime(6).ToString("yyyy/MM/d"),
            record.GetDateTime(7).ToString("yyyy/MM/d"), RowState.ModifiedNew);
        }
    }
    #endregion


    #region Чтение каждой строки с таблицы рабочих
    class ReadSingleRowFromBrigadeWorker : RefreshableBase, IReadable
    {
        /// <summary>
        /// Чтение каждой строки с таблицы рабочих
        /// </summary>
        /// <param name="dat">Указание Datagridview</param>
        /// <param name="record">Интерфейс чтения</param>
        public override void ReadSingleRows(DataGridView dat, IDataRecord record)
        {
            dat.Rows.Add(record.GetInt32(0),
            record.GetInt32(1), record.GetString(2),
            record.GetString(3), record.GetString(4),
            record.GetString(5), record.GetString(6),
            record.GetString(7), record.GetString(8), record.GetString(9), record.GetString(10), RowState.ModifiedNew);
        }
    }
    #endregion

    #endregion

    #region Работа с базой данных и датагридвью

    //добавлять новую колонку в датагридвью при добавлении нового значения в БД
    #region создание таблиц
    class CreateColumnsForWorkers : ICreateble
    {
        #region Создание таблицы с Бригадными рабочими
        /// <summary>
        /// Создание колонок для рабочих и занесение их в таблицу Datagridview
        /// </summary>
        /// <param name="dat">Указание Datagridview</param>

        public void Create(DataGridView data)
        {
            data.Columns.Add("id_brigade_worker", "Айдi робiтника"); //0
            data.Columns.Add("id_brigade", "Тип Бригади"); //1
            data.Columns.Add("brwr_lname", "Прiзвище"); //2
            data.Columns.Add("brwr_fname", "Iм'я"); //3
            data.Columns.Add("brwr_mname", "По-батькові"); //4
            data.Columns.Add("brwr_login", "Логiн"); //5
            data.Columns.Add("brwr_phone", "Номер телефону"); //6
            data.Columns.Add("brwr_email", "Почтова адреса"); //7 
            data.Columns.Add("brwr_gender", "Стать"); //8
            data.Columns.Add("brwr_speciality", "Спецiальнiсть"); //9
            data.Columns.Add("br_name", "Назва бригади"); //10

            data.Columns.Add("IsNew", string.Empty);
        }
        #endregion
    }
    class CreateColumnsForBrigades : ICreateble
    {
        #region Создание таблицы с Бригадами
        /// <summary>
        /// Создание колонок для рабочих и занесение их в таблицу Datagridview
        /// </summary>
        /// <param name="dat">Указание Datagridview</param>

        public void Create(DataGridView dat)
        {
            dat.Columns.Add("id_brigade", "Айдi бригади");
            dat.Columns.Add("br_name", "Назва бригади");
            dat.Columns.Add("br_people_count", "Кількість людей");
            dat.Columns.Add("br_specilaity", "Спецiальнiсть");

            dat.Columns.Add("IsNew", string.Empty);
        }
        #endregion
    }

    class CreateColumnsForObjects : ICreateble
    {
        #region Создание таблицы с Объектами
        /// <summary>
        /// Создание колонок для рабочих и занесение их в таблицу Datagridview
        /// </summary>
        /// <param name="dat">Указание Datagridview</param>
        public void Create(DataGridView dat)
        {
            dat.Columns.Add("id_object_building", "Айдi об'єкту");
            dat.Columns.Add("ob_name", "Назва об'єкту");
            dat.Columns.Add("ob_city_region", "Регiон ");
            dat.Columns.Add("ob_street", "Вулиця ");
            dat.Columns.Add("ob_house_number", "Номер будинку");
            dat.Columns.Add("ob_type", "Тип");
            dat.Columns.Add("ob_date_start", "Дата початку");
            dat.Columns.Add("ob_date_end", "Дата кiнця");

            dat.Columns.Add("IsNew", string.Empty);
        }
        #endregion
    }
    class CreateColumnsForWorks : ICreateble
    {
        #region Создание таблицы с Работами
        /// <summary> 						
        /// Создание колонок для рабочих и занесение их в таблицу Datagridview
        /// </summary>
        /// <param name="dat">Указание Datagridview</param>
        public void Create(DataGridView dat)
        {
            dat.Columns.Add("id_work", "Код роботи");
            dat.Columns.Add("id_brigade", "Айдi бригади");
            dat.Columns.Add("id_object_building", "Айдi об'єкту");
            dat.Columns.Add("work_date_start", "Дата початку ");
            dat.Columns.Add("work_date_end", "Дата виконання");
            dat.Columns.Add("work_count", "Кількість робiт");
            dat.Columns.Add("work_in_process", "Стан");
            dat.Columns.Add("ob_name", "Назва об'єкту");
            dat.Columns.Add("br_name", "Назва бригади ");
            dat.Columns.Add("IsNew", string.Empty);
        }
        #endregion
    }
    class CreateColumnsForMaterials : ICreateble
    {
        #region Создание таблицы с Материалами
        /// <summary>
        /// Создание колонок для рабочих и занесение их в таблицу Datagridview
        /// </summary>
        /// <param name="dat">Указание Datagridview</param>
        public void Create(DataGridView dat)
        {
            dat.Columns.Add("id_materials", "Айдi матерiалу");
            dat.Columns.Add("mat_name", "Назва");
            dat.Columns.Add("mat_price", "Цiна");
            dat.Columns.Add("mat_count", "Кiлькiсть");
            dat.Columns.Add("mat_company", "Фiрма");
            dat.Columns.Add("mat_description", "Опис");
            dat.Columns.Add("mat_features", "Особливостi");


            dat.Columns.Add("IsNew", string.Empty);
        }
        #endregion
    }
    class CreateColumnsForMaterialsOffered : ICreateble
    {
        #region Создание таблицы с Материалами, которых заказали
        /// <summary>
        /// Создание колонок для рабочих и занесение их в таблицу Datagridview
        /// </summary>
        /// <param name="dat">Указание Datagridview</param>
        public void Create(DataGridView dat)
        {
            dat.Columns.Add("id_materials_offered", "Айдi замовленого матеріалу");
            dat.Columns.Add("id_brigade", "Айдi бригади");
            dat.Columns.Add("id_work", "Код роботи");
            dat.Columns.Add("id_materials", "Айдi матерiалу");
            dat.Columns.Add("matof_date_give", "Дата отримання");
            dat.Columns.Add("matof_count", "Кiлькiсть");
            dat.Columns.Add("br_name", "Назва бригади");
            dat.Columns.Add("ob_name", "Назва об'єкту");
            dat.Columns.Add("mat_name", "Назва матерiалу");

            dat.Columns.Add("IsNew", string.Empty);
        }
        #endregion
    }
    #endregion

    #region Клик на ячейку и занесение инфы в текстбокс, тут находятся перегруженный метод
    //ок
    #region Рабочие
    class WorkersClick : ClickableBase
    {
        /// <summary>
        /// Занесение информации в текстбокс рабочих
        /// </summary>
        /// <param name="identitykey">Айди бригады</param>
        /// <param name="id">Айди бригады</param>
        /// <param name="log">логин</param>
        /// <param name="phon">номер телефона</param>
        /// <param name="emai">Емейл</param>
        /// <param name="lnam">Фамилия</param>
        /// <param name="fnam">Имя</param>
        /// <param name="mnam">Отчество</param>
        /// <param name="spec">Специальность</param>
        /// <param name="e">Уникальный индекс ячейки(по умолчанию e)</param>
        /// <param name="dgw">Таблица для которой нужно сделать</param>
        public override void Cellsclick(TextBox identitykey, ComboBox id, TextBox lnam, TextBox fnam, TextBox mnam, TextBox log, ComboBox citykodeph, TextBox phon,
                TextBox emai,  TextBox spec, ComboBox gender, DataGridViewCellEventArgs e, DataGridView dgw)
        {
            int selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                int index;
                DataGridViewRow row = dgw.Rows[selectedRow];
                string telephone = row.Cells[6].Value.ToString()?.Trim() ?? "";
                foreach (string citykode in citykodeph.Items)
                {
                    index = telephone.IndexOf(citykode);
                    if (index >= 0)
                    {
                        phon.Text = telephone.Remove(index, citykode.Length);
                        citykodeph.SelectedItem = citykode;
                        break;
                    }
                }
                identitykey.Text = row.Cells[0].Value.ToString();
                lnam.Text = row.Cells[2].Value.ToString()?.Trim();
                fnam.Text = row.Cells[3].Value.ToString()?.Trim();
                mnam.Text = row.Cells[4].Value.ToString()?.Trim(); //тут колонка с гендером ненужна
                log.Text = row.Cells[5].Value.ToString()?.Trim();
                emai.Text = row.Cells[7].Value.ToString()?.Trim();
                SelectedIndexComboboxes.SetSelectedIndex(gender, row.Cells[8].Value.ToString()?.Trim() ?? "");
                spec.Text = row.Cells[9].Value.ToString()?.Trim();
                SelectedIndexComboboxes.SetSelectedIndexBrRowView(id, row.Cells[10].Value.ToString() ?? "");
            }
        }
    }

    #endregion

    //ок
    #region Бригады
    class BrigadeClick : ClickableBase
    {
        /// <summary>
        /// Занесение информации в текстбокс бригады
        /// </summary>
        /// <param name="identitykey">Айди бригады</param>
        /// <param name="brname">Название бригады</param>
        /// <param name="count">Кол-во рабочих</param>
        /// <param name="spec">Специальность</param>
        /// <param name="e">Уникальный индекс ячейки(по умолчанию e)</param>
        /// <param name="dgw">Таблица для которой нужно сделать</param>
        public override void Cellsclick(TextBox identitykey, TextBox brname, TextBox count, TextBox spec, DataGridViewCellEventArgs e, DataGridView dgw)
        {
            int selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgw.Rows[selectedRow];
                identitykey.Text = row.Cells[0].Value.ToString()?.Trim();
                brname.Text = row.Cells[1].Value.ToString()?.Trim();
                count.Text = row.Cells[2].Value.ToString()?.Trim();
                spec.Text = row.Cells[3].Value.ToString()?.Trim();
            }
        }
    }

    #endregion

    //ок
    #region Объекты
    class ObjectsClick : ClickableBase
    {
        /// <summary>
        /// Занесение информации в текстбокс Объекта
        /// </summary>
        /// <param name="identitykey">Айди объекта</param>
        /// <param name="ob_name">Название объекта</param>
        /// <param name="ob_city_region">Регион</param>
        /// <param name="ob_street">Улица</param>
        /// <param name="ob_house_number">Номер дома</param>
        /// <param name="ob_type">Тип</param>
        /// <param name="ob_date_start">Начальная дата</param>
        /// <param name="ob_date_end">Конечная дата</param>
        /// <param name="e">Уникальный индекс ячейки(по умолчанию e)</param>
        /// <param name="dgw">Таблица для которой нужно сделать</param>
        public override void Cellsclick(TextBox identitykey, TextBox ob_name,
            TextBox ob_city_region, TextBox ob_street, TextBox ob_house_number, TextBox ob_type,
            TextBox ob_date_start, TextBox ob_date_end, DataGridViewCellEventArgs e, DataGridView dgw)
        {
            int selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgw.Rows[selectedRow];
                identitykey.Text = row.Cells[0].Value.ToString()?.Trim();
                ob_name.Text = row.Cells[1].Value.ToString()?.Trim();
                ob_city_region.Text = row.Cells[2].Value.ToString()?.Trim();
                ob_street.Text = row.Cells[3].Value.ToString()?.Trim();
                ob_house_number.Text = row.Cells[4].Value.ToString()?.Trim();
                ob_type.Text = row.Cells[5].Value.ToString()?.Trim();
                ob_date_start.Text = row.Cells[6].Value.ToString()?.Trim();
                ob_date_end.Text = row.Cells[7].Value.ToString()?.Trim();
            }
        }
    }

    #endregion

    //ок
    #region Работы
    class WorksClick : ClickableBase
    {
        /// <summary>
        /// Занесение информации в текстбокс Работы
        /// </summary>
        /// <param name="identitykey">Айди работы</param>
        /// <param name="id_brigade">Айди бригады</param>
        /// <param name="id_object_building">Айди объекта</param>
        /// <param name="work_date_start">Начало работы</param>
        /// <param name="work_date_end">Конец работы</param>
        /// <param name="work_count">Конец работы</param>
        /// <param name="e">Уникальный индекс ячейки(по умолчанию e)</param>
        /// <param name="dgw">Таблица для которой нужно сделать</param>

        public override void Cellsclick(TextBox identitykey, ComboBox id_brigade, ComboBox id_object_building,
            TextBox work_date_start, TextBox work_date_end, TextBox work_count, ComboBox workinprocess, DataGridViewCellEventArgs e, DataGridView dgw)
        {
            int selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgw.Rows[selectedRow];
                identitykey.Text = row.Cells[0].Value.ToString()?.Trim();
                work_date_start.Text = row.Cells[3].Value.ToString()?.Trim();
                work_date_end.Text = row.Cells[4].Value.ToString()?.Trim();
                work_count.Text = row.Cells[5].Value.ToString()?.Trim();
                SelectedIndexComboboxes.SetSelectedIndexObRowView(id_object_building, row.Cells[7].Value.ToString() ?? "");
                SelectedIndexComboboxes.SetSelectedIndexBrRowView(id_brigade, row.Cells[8].Value.ToString() ?? "");
                SelectedIndexComboboxes.SetSelectedIndex(workinprocess, row.Cells[6].Value.ToString()?.Trim() ?? "");
            }
        }
    }

    #endregion

    //ок
    #region Материалы
    class MaterialsClick : ClickableBase
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
        /// <param name="e">Уникальный индекс ячейки(по умолчанию e)</param>
        /// <param name="dgw">Таблица для которой нужно сделать</param>
        /// <param name="Materials">Определение для материалов(обязательный параметр, должен быть true, необходимый для перегрузки метода)</param>

        public override void Cellsclick(TextBox identitykey, TextBox mat_name, TextBox mat_price, TextBox mat_count, TextBox mat_company,
            TextBox mat_description, TextBox mat_features, DataGridViewCellEventArgs e, DataGridView dgw)
        {
            int selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgw.Rows[selectedRow];
                identitykey.Text = row.Cells[0].Value.ToString()?.Trim();
                mat_name.Text = row.Cells[1].Value.ToString()?.Trim();
                mat_price.Text = row.Cells[2].Value.ToString()?.Trim();
                mat_count.Text = row.Cells[3].Value.ToString()?.Trim();
                mat_company.Text = row.Cells[4].Value.ToString()?.Trim();
                mat_description.Text = row.Cells[5].Value.ToString()?.Trim();
                mat_features.Text = row.Cells[6].Value.ToString()?.Trim();
            }

        }
    }

    #endregion

    //ок
    #region Заказанные материалы
    class MaterialsOfferedClick : ClickableBase
    {
        /// <summary>
        /// Занесение информации в текстбокс Заказанных материалов
        /// </summary>
        /// <param name="identitykey">Айди работы</param>
        /// <param name="id_brigade">Айди бригады</param>
        /// <param name="id_work">Айди работы</param>
        /// <param name="id_materials">Айди материалов</param>
        /// <param name="matof_date_give">Дата получения</param>
        /// <param name="matof_count">количество</param>
        /// <param name="e">Уникальный индекс ячейки(по умолчанию e)</param>
        /// <param name="dgw">Таблица для которой нужно сделать</param>
        /// <param name="ne">Значение необходимое для перегрузки</param>
        public override void Cellsclick(TextBox identitykey, TextBox id_brigade, TextBox id_work, TextBox id_materials,
            TextBox matof_date_give, TextBox matof_count, DataGridViewCellEventArgs e, DataGridView dgw)
        {
            int selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgw.Rows[selectedRow];
                identitykey.Text = row.Cells[0].Value.ToString()?.Trim();
                id_brigade.Text = row.Cells[1].Value.ToString()?.Trim();
                id_work.Text = row.Cells[2].Value.ToString()?.Trim();
                id_materials.Text = row.Cells[3].Value.ToString()?.Trim();
                matof_date_give.Text = row.Cells[4].Value.ToString()?.Trim();
                matof_count.Text = row.Cells[5].Value.ToString()?.Trim();
            }
        }
    }

    #endregion

    #endregion

    #region Изменение значений

    #region Изменение значения рабочего в датагридвью
    class ChangeWorkers : ChangebleBase
    {
        /// <summary>
        /// Изменение таблицы рабочих
        /// </summary>
        /// <param name="identitykey">Айди бригады</param>
        /// <param name="id">Айди бригады</param>
        /// <param name="log">логин</param>
        /// <param name="phon">номер телефона</param>
        /// <param name="emai">Емейл</param>
        /// <param name="lnam">Фамилия</param>
        /// <param name="fnam">Имя</param>
        /// <param name="mnam">Отчество</param>
        /// <param name="spec">Специальность</param>
        public override void Change(TextBox identitykey, ComboBox id, TextBox lnam, TextBox fnam, TextBox mnam, TextBox log, TextBox phon, TextBox emai, ComboBox gender, TextBox spec
            , DataGridView dgw, out bool result)
        {
            if (identitykey.Text.Length > 0 && log.Text.Length > 0 && phon.Text.Length > 0 && emai.Text.Length > 0
                && lnam.Text.Length > 0 && fnam.Text.Length > 0 && mnam.Text.Length > 0 && spec.Text.Length > 0)
            {
                DialogResult dialog = MessageBox.Show("Вы действительно хотите переименовать эту строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    result = true;
                    int index = dgw.CurrentCell.RowIndex;
                    if (dgw.Rows[index].Cells[0].Value.ToString() != string.Empty)
                    {
                        dgw.Rows[index].SetValues(identitykey.Text, Comboboxid.GiveIdFromBrigadeName(id),  lnam.Text, fnam.Text, mnam.Text, log.Text, TextboxesScripts.CityKey + phon.Text, emai.Text,
                            CheckComboboxes.GetStringFromIndexGender(gender), spec.Text); // изменил GetStringFromIndexGender(status)
                        dgw.Rows[index].Cells[11].Value = RowState.Modified;//изменять на текущее значение + 1
                    }
                }
                else result = false;
            }
            else
            {
                MessageBox.Show("Заполните все текстовые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
        }
    }

    #endregion

    #region Изменение значение бригады в датагридвью
    class ChangeBrigade : ChangebleBase
    {
        /// <summary>
        /// Занесение информации в текстбокс бригады
        /// </summary>
        /// <param name="identitykey">Айди бригады</param>
        /// <param name="brname">Название бригады</param>
        /// <param name="count">Кол-во рабочих</param>
        /// <param name="spec">Специальность</param>
        /// <param name="dgw">Таблица для которой нужно сделать</param>
        public override void Change(TextBox identitykey, TextBox brname, TextBox count, TextBox spec, DataGridView dgw, out bool result)
        {
            if (identitykey.Text.Length > 0 && brname.Text.Length > 0 && count.Text.Length > 0 && spec.Text.Length > 0)
            {
                DialogResult dialog = MessageBox.Show("Вы действительно хотите переименовать эту строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    result = true;
                    int index = dgw.CurrentCell.RowIndex;
                    if (dgw.Rows[index].Cells[0].Value.ToString() != string.Empty)
                    {
                        dgw.Rows[index].SetValues(identitykey.Text, brname.Text, count.Text, spec.Text);
                        dgw.Rows[index].Cells[4].Value = RowState.Modified;//изменять на текущее значение + 1
                    }
                }
                else result = false;
            }
            else
            {
                MessageBox.Show("Заполните все текстовые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
        }
    }
    #endregion

    #region Изменение значения материалов в датагридвью
    class ChangeMaterials : ChangebleBase
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
        /// <param name="dgw">Таблица для которой нужно сделать</param>
        /// <param name="result">Определение условия</param>
        public override void Change(TextBox identitykey, TextBox mat_name, TextBox mat_price, TextBox mat_count, TextBox mat_company,
            TextBox mat_description, TextBox mat_features, DataGridView dgw, out bool result)
        {
            if (identitykey.Text.Length > 0 && mat_name.Text.Length > 0 && mat_price.Text.Length > 0 && mat_count.Text.Length > 0
              && mat_company.Text.Length > 0 && mat_description.Text.Length > 0 && mat_features.Text.Length > 0)
            {
                DialogResult dialog = MessageBox.Show("Вы действительно хотите переименовать эту строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    result = true;
                    int index = dgw.CurrentCell.RowIndex;
                    if (dgw.Rows[index].Cells[0].Value.ToString() != string.Empty)
                    {
                        dgw.Rows[index].SetValues(identitykey.Text, mat_name.Text, mat_price.Text, mat_count.Text, mat_company.Text, mat_description.Text,
                            mat_features.Text);
                        dgw.Rows[index].Cells[7].Value = RowState.Modified;//изменять на текущее значение + 1
                    }
                }
                else result = false;
            }
            else
            {
                MessageBox.Show("Заполните все текстовые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
        }
    }

    #endregion

    #region Изменение значения заказанных материалов в датагридвью
    class ChangeMaterialsOffered : ChangebleBase
    {
        /// <summary>
        /// Занесение информации в текстбокс заказанных материалов
        /// </summary>
        /// <param name="identitykey">Айди работы</param>
        /// <param name="id_brigade">Айди бригады</param>
        /// <param name="id_work">Айди работы</param>
        /// <param name="id_materials">Айди материалов</param>
        /// <param name="matof_date_give">Дата получения</param>
        /// <param name="matof_count">количество</param>
        /// <param name="dgw">Таблица для которой нужно сделать</param>
        public override void Change(TextBox identitykey, TextBox id_brigade, TextBox id_work, TextBox id_materials,
            TextBox matof_date_give, TextBox matof_count, DataGridView dgw, out bool result)
        {
            if (identitykey.Text.Length > 0 && id_brigade.Text.Length > 0 && id_work.Text.Length > 0 && id_materials.Text.Length > 0
               && matof_date_give.Text.Length > 0 && matof_count.Text.Length > 0)
            {
                DialogResult dialog = MessageBox.Show("Вы действительно хотите переименовать эту строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    int matCount = 0;
                    matCount.CounterMaterialsCount(id_materials);
                    
                    if (int.Parse(matof_count.Text) <= matCount)
                    {
                       
                        result = true;
                        int index = dgw.CurrentCell.RowIndex;
                        if (dgw.Rows[index].Cells[0].Value.ToString() != string.Empty)
                        {
                            dgw.Rows[index].SetValues(identitykey.Text, id_brigade.Text, id_work.Text, id_materials.Text, matof_date_give.Text, matof_count.Text);
                            dgw.Rows[index].Cells[9].Value = RowState.Modified;//изменять на текущее значение + 1
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невозможно добавить больше к заказанному чем есть на складе!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        result = false;
                    }
                }
                else result = false;
            }
            else
            {
                MessageBox.Show("Заполните все текстовые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
        }
    }

    #endregion

    #region Изменение значения объектов в датагридвью
    class ChangeObjects : ChangebleBase
    {
        /// <summary>
        /// Занесение информации в текстбокс Объекта
        /// </summary>
        /// <param name="identitykey">Айди объекта</param>
        /// <param name="ob_name">Название объекта</param>
        /// <param name="ob_city_region">Регион</param>
        /// <param name="ob_street">Улица</param>
        /// <param name="ob_house_number">Номер дома</param>
        /// <param name="ob_type">Тип</param>
        /// <param name="ob_date_start">Начальная дата</param>
        /// <param name="ob_date_end">Конечная дата</param>
        /// <param name="e">Уникальный индекс ячейки(по умолчанию e)</param>
        /// <param name="dgw">Таблица для которой нужно сделать</param>
        public override void Change(TextBox identitykey, TextBox ob_name,
            TextBox ob_city_region, TextBox ob_street, TextBox ob_house_number, TextBox ob_type,
            TextBox ob_date_start, TextBox ob_date_end, DataGridView dgw, out bool result)
        {
            if (identitykey.Text.Length > 0 && ob_name.Text.Length > 0 && ob_city_region.Text.Length > 0 && ob_street.Text.Length > 0
                && ob_house_number.Text.Length > 0 && ob_type.Text.Length > 0 && ob_date_start.Text.Length > 0 && ob_date_end.Text.Length > 0)
            {
                DialogResult dialog = MessageBox.Show("Вы действительно хотите переименовать эту строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    result = true;
                    int index = dgw.CurrentCell.RowIndex;
                    if (dgw.Rows[index].Cells[0].Value.ToString() != string.Empty)
                    {
                        dgw.Rows[index].SetValues(identitykey.Text, ob_name.Text, ob_city_region.Text, ob_street.Text, ob_house_number.Text, ob_type.Text,
                            ob_date_start.Text, ob_date_end.Text);
                        dgw.Rows[index].Cells[8].Value = RowState.Modified;//изменять на текущее значение + 1
                    }

                }
                else result = false;

            }
            else
            {
                MessageBox.Show("Заполните все текстовые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
        }
    }

    #endregion

    #region Изменение значения работ в датагридвью
    class ChangeWorks : ChangebleBase
    {
        /// <summary>
        /// Изменение таблицы рабочих
        /// </summary>
        /// <param name="identitykey">Айди бригады</param>
        /// <param name="brigadename">Название бригады</param>
        /// <param name="objectname">название обьекта</param>
        /// <param name="work_date_start">конец работы</param>
        /// <param name="work_date_end">начало работы</param>
        /// <param name="work_count">кол-во работ</param>
        /// <param name="status">статус</param>
        /// <param name="dgw">дгв</param>
        /// <param name="result">для модального окна</param>
        public override void Change(TextBox identitykey, ComboBox brigadename, ComboBox objectname, TextBox work_date_start, TextBox work_date_end, TextBox work_count, ComboBox status, DataGridView dgw, out bool result)
        {
            if (identitykey.Text.Length > 0 && work_date_start.Text.Length > 0 && work_date_end.Text.Length > 0 && work_count.Text.Length > 0)
            {
                DialogResult dialog = MessageBox.Show("Вы действительно хотите переименовать эту строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    result = true;
                    int index = dgw.CurrentCell.RowIndex;
                    if (dgw.Rows[index].Cells[0].Value.ToString() != string.Empty)
                    {
                        dgw.Rows[index].SetValues(identitykey.Text, Comboboxid.GiveIdFromBrigadeName(brigadename), Comboboxid.GiveIdFromObjectName(objectname), work_date_start.Text, work_date_end.Text, work_count.Text, CheckComboboxes.GetStringFromIndexStatus(status));
                        dgw.Rows[index].Cells[9].Value = RowState.Modified;
                    }
                }
                else result = false;
            }
            else
            {
                MessageBox.Show("Заполните все текстовые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                result = false;
            }
        }
    }


    #endregion

    #endregion

    #region Обновление базы данных
    //добавлять новое свойство в UpdateWorkers в If (rowState.Modified) и Insert там же при добавлении колонки в Бд

    #region Обновление базы данных по редактированию ячеек(удаление или изменение) для рабочего
    /// <summary>
    /// Обновление строки с рабочим и базы данных 
    /// </summary>
    /// <param name="dgw">Указание Datagridview</param>
    class UpdateWorkers : IUpdatable
    {
        public void Update(DataGridView dgw)
        {
            DataBase.OpenConnection();

            for (int index = 0; index < dgw.Rows.Count; index++)
            {
                var rowState = (RowState)dgw.Rows[index].Cells[11].Value; //Обновлять на +1 при обновлении на +1 предыдущих значений

                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    int identitykey = (int)dgw.Rows[index].Cells[0].Value;
                    string deletequery = "DELETE FROM brigade_worker WHERE id_brigade_worker = @identitykey";

                    SqlCommand command = new(deletequery, DataBase.GetConnection());
                    command.Parameters.AddWithValue("@identitykey", identitykey);
                    command.ExecuteNonQuery();
                    return;
                }
                if (rowState == RowState.Modified)
                {
                    var identitykey = dgw.Rows[index].Cells[0].Value.ToString();
                    
                    string? lnam = dgw.Rows[index].Cells[2].Value.ToString();
                    string? fnam = dgw.Rows[index].Cells[3].Value.ToString();
                    string? mnam = dgw.Rows[index].Cells[4].Value.ToString();
                    string? log = dgw.Rows[index].Cells[5].Value.ToString();
                    string? phon = dgw.Rows[index].Cells[6].Value.ToString();
                    string? emai = dgw.Rows[index].Cells[7].Value.ToString();
                    string? gender = dgw.Rows[index].Cells[8].Value.ToString(); //Добавление проверки и занесение пола в поле string
                    string? spec = dgw.Rows[index].Cells[9].Value.ToString();

                    string ChangeQuery = "UPDATE brigade_worker" +
                    " SET brwr_login = @log, brwr_phone = @phon, brwr_email = @emai, brwr_lname = @lnam, brwr_fname = @fnam, brwr_mname = @mnam, brwr_gender = @gender, brwr_speciality = @spec" +
                    " WHERE id_brigade_worker = @identitykey";
                    SqlCommand command = new(ChangeQuery, DataBase.GetConnection());
                    command.Parameters.AddWithValue("@log", log);
                    command.Parameters.AddWithValue("@phon", phon);
                    command.Parameters.AddWithValue("@emai", emai);
                    command.Parameters.AddWithValue("@lnam", lnam);
                    command.Parameters.AddWithValue("@fnam", fnam);
                    command.Parameters.AddWithValue("@mnam", mnam);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@spec", spec);
                    command.Parameters.AddWithValue("@identitykey", identitykey);
                    command.ExecuteNonQuery();
                }
            }
            DataBase.CloseConnection();
        }
    }
    #endregion

    #region Обновление базы данных по редактированию ячеек(удаление или изменение) для бригады
    /// <summary>
    /// Обновление строки с бригадами и базы данных 
    /// </summary>
    /// <param name="dgw">Указание Datagridview</param>
    class UpdateBrigade : IUpdatable
    {
        public void Update(DataGridView dgw)
        {
            DataBase.OpenConnection();

            for (int index = 0; index < dgw.Rows.Count; index++)
            {
                var rowState = (RowState)dgw.Rows[index].Cells[4].Value; //Обновлять на +1 при обновлении на +1 предыдущих значений

                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    int identitykey = (int)dgw.Rows[index].Cells[0].Value;
                    string deletequery = "DELETE FROM brigade WHERE id_brigade = @identitykey";

                    SqlCommand command = new(deletequery, DataBase.GetConnection());
                    command.Parameters.AddWithValue("@identitykey", identitykey);
                    command.ExecuteNonQuery();
                    return;
                }
                if (rowState == RowState.Modified)
                {
                    //(TextBox , TextBox , TextBox , TextBox ,
                    string? identitykey = dgw.Rows[index].Cells[0].Value.ToString();
                    string? brname = dgw.Rows[index].Cells[1].Value.ToString();
                    string? count = dgw.Rows[index].Cells[2].Value.ToString();
                    string? spec = dgw.Rows[index].Cells[3].Value.ToString();
                    string ChangeQuery = $"UPDATE brigade" +
                        $" SET br_name=@brname,br_people_count=@count,br_specilaity=@spec" +
                        $" WHERE id_brigade= @identitykey";
                    SqlCommand command = new(ChangeQuery, DataBase.GetConnection());
                    command.Parameters.AddWithValue("@brname", brname);
                    command.Parameters.AddWithValue("@count", count);
                    command.Parameters.AddWithValue("@spec", spec);
                    command.Parameters.AddWithValue("@identitykey", identitykey);

                    command.ExecuteNonQuery();
                }
            }
            DataBase.CloseConnection();
        }
    }
    #endregion

    #region Обновление базы данных по редактированию ячеек(удаление или изменение) для материалов
    /// <summary>
    /// Обновление строки с материалами и базы данных 
    /// </summary>
    /// <param name="dgw">Указание Datagridview</param>
    class UpdateMaterials : IUpdatable
    {
        public void Update(DataGridView dgw)
        {
            DataBase.OpenConnection();

            for (int index = 0; index < dgw.Rows.Count; index++)
            {
                var rowState = (RowState)dgw.Rows[index].Cells[7].Value; //Обновлять на +1 при обновлении на +1 предыдущих значений

                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    int identitykey = (int)dgw.Rows[index].Cells[0].Value;
                    string deletequery = "DELETE FROM materials WHERE id_materials = @identitykey";

                    SqlCommand command = new(deletequery, DataBase.GetConnection());
                    command.Parameters.AddWithValue("@identitykey", identitykey);
                    command.ExecuteNonQuery();
                    return;
                }
                if (rowState == RowState.Modified)
                {
                    //TextBox identitykey, TextBox , TextBox , TextBox , TextBox ,
                    //TextBox , TextBox ,
                    var identitykey = dgw.Rows[index].Cells[0].Value.ToString();
                    string? mat_name = dgw.Rows[index].Cells[1].Value.ToString();
                    string? mat_price = dgw.Rows[index].Cells[2].Value.ToString();
                    string? mat_count = dgw.Rows[index].Cells[3].Value.ToString();
                    string? mat_company = dgw.Rows[index].Cells[4].Value.ToString();
                    string? mat_description = dgw.Rows[index].Cells[5].Value.ToString();
                    string? mat_features = dgw.Rows[index].Cells[6].Value.ToString();

                    string ChangeQuery = "UPDATE materials" +
                    " SET mat_name = @mat_name, mat_price = @mat_price, mat_count = @mat_count, mat_company = @mat_company, mat_description = @mat_description, mat_features = @mat_features" +
                    " WHERE id_materials = @identitykey";
                    SqlCommand command = new(ChangeQuery, DataBase.GetConnection());
                    command.Parameters.AddWithValue("@mat_name", mat_name);
                    command.Parameters.AddWithValue("@mat_price", Convert.ToDecimal(mat_price));
                    command.Parameters.AddWithValue("@mat_count", Convert.ToInt32(mat_count));
                    command.Parameters.AddWithValue("@mat_company", mat_company);
                    command.Parameters.AddWithValue("@mat_description", mat_description);
                    command.Parameters.AddWithValue("@mat_features", mat_features);
                    command.Parameters.AddWithValue("@identitykey", identitykey);
                    command.ExecuteNonQuery();
                }
            }
            DataBase.CloseConnection();
        }
    }
    #endregion

    #region Обновление базы данных по редактированию ячеек(удаление или изменение) для заказанных материалов
    /// <summary>
    /// Обновление строки с заказанными материалами и базы данных 
    /// </summary>
    /// <param name="dgw">Указание Datagridview</param>
    class UpdateMaterialsOffered : IUpdatable
    {
        public void Update(DataGridView dgw)
        {
            DataBase.OpenConnection();

            for (int index = 0; index < dgw.Rows.Count; index++)
            {
                var rowState = (RowState)dgw.Rows[index].Cells[9].Value; //Обновлять на +1 при обновлении на +1 предыдущих значений

                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    int identitykey = (int)dgw.Rows[index].Cells[0].Value;
                    string deletequery = "DELETE FROM materials_offered WHERE id_materials_offered = @identitykey";

                    SqlCommand command = new(deletequery, DataBase.GetConnection());
                    command.Parameters.AddWithValue("@identitykey", identitykey);
                    command.ExecuteNonQuery();
                    return;
                }
                if (rowState == RowState.Modified)
                {
                    string? identitykey = dgw.Rows[index].Cells[0].Value.ToString();
                    string? id_brigade = dgw.Rows[index].Cells[1].Value.ToString();
                    string? id_work = dgw.Rows[index].Cells[2].Value.ToString();
                    string? id_materials = dgw.Rows[index].Cells[3].Value.ToString();
                    string? matof_date_give = dgw.Rows[index].Cells[4].Value.ToString();
                    string? matof_count = dgw.Rows[index].Cells[5].Value.ToString();

                    string ChangeQuery = $"UPDATE materials_offered" +
                      $" SET id_brigade=@id_brigade, id_work=@id_work, id_materials=@id_materials, matof_date_give=@matof_date_give," +
                      $" matof_count=@matof_count WHERE id_materials_offered=@identitykey";
                    SqlCommand command = new(ChangeQuery, DataBase.GetConnection());

                    command.Parameters.AddWithValue("@id_brigade", id_brigade);
                    command.Parameters.AddWithValue("@id_work", id_work);
                    command.Parameters.AddWithValue("@id_materials", id_materials);
                    command.Parameters.AddWithValue("@matof_date_give", matof_date_give);
                    command.Parameters.AddWithValue("@matof_count", matof_count);
                    command.Parameters.AddWithValue("@identitykey", identitykey);

                    command.ExecuteNonQuery();
                }
            }
            DataBase.CloseConnection();
            //TODO: тут должен быть метод очистки
        }
    }
    #endregion

    #region Обновление базы данных по редактированию ячеек(удаление или изменение) для объектов
    /// <summary>
    /// Обновление строки с материалами и базы данных 
    /// </summary>
    /// <param name = "dgw" > Указание Datagridview</param>
    class UpdateObjects : IUpdatable
    {
        public void Update(DataGridView dgw)
        {
            DataBase.OpenConnection();

            for (int index = 0; index < dgw.Rows.Count; index++)
            {
                var rowState = (RowState)dgw.Rows[index].Cells[8].Value; //Обновлять на +1 при обновлении на +1 предыдущих значений

                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    int identitykey = (int)dgw.Rows[index].Cells[0].Value;
                    string deletequery = "DELETE FROM object_building WHERE id_object_building = @identitykey";
                    SqlCommand command = new(deletequery, DataBase.GetConnection());

                    command.Parameters.AddWithValue("@identitykey", identitykey);
                    command.ExecuteNonQuery();
                    return;
                }
                if (rowState == RowState.Modified)
                {
                    var identitykey = dgw.Rows[index].Cells[0].Value.ToString();
                    string? ob_name = dgw.Rows[index].Cells[1].Value.ToString();
                    string? ob_city_region = dgw.Rows[index].Cells[2].Value.ToString();
                    string? ob_street = dgw.Rows[index].Cells[3].Value.ToString();
                    string? ob_house_number = dgw.Rows[index].Cells[4].Value.ToString();
                    string? ob_type = dgw.Rows[index].Cells[5].Value.ToString();
                    string? ob_date_start = dgw.Rows[index].Cells[6].Value.ToString();
                    string? ob_date_end = dgw.Rows[index].Cells[7].Value.ToString();

                    string ChangeQuery = "UPDATE object_building " +
                      "SET ob_name = @ob_name, ob_city_region = @ob_city_region, ob_street = @ob_street, ob_house_number = @ob_house_number, " +
                      "ob_type = @ob_type, ob_date_start = @ob_date_start, ob_date_end = @ob_date_end " +
                     "WHERE id_object_building = @identitykey";
                    SqlCommand command = new(ChangeQuery, DataBase.GetConnection());
                    command.Parameters.AddWithValue("@ob_name", ob_name);
                    command.Parameters.AddWithValue("@ob_city_region", ob_city_region);
                    command.Parameters.AddWithValue("@ob_street", ob_street);
                    command.Parameters.AddWithValue("@ob_house_number", ob_house_number);
                    command.Parameters.AddWithValue("@ob_type", ob_type);
                    command.Parameters.AddWithValue("@ob_date_start", ob_date_start);
                    command.Parameters.AddWithValue("@ob_date_end", ob_date_end);
                    command.Parameters.AddWithValue("@identitykey", identitykey);
                    command.ExecuteNonQuery();
                }
            }
            DataBase.CloseConnection();
        }

    }
    #endregion

    #region Обновление базы данных по редактированию ячеек(удаление или изменение) для работы
    /// <summary>
    /// Обновление строки с материалами и базы данных 
    /// </summary>
    /// <param name = "dgw" > Указание Datagridview</param>
    class UpdateWorks : IUpdatable
    {
        public void Update(DataGridView dgw)
        {
            DataBase.OpenConnection();

            for (int index = 0; index < dgw.Rows.Count; index++)
            {
                var rowState = (RowState)dgw.Rows[index].Cells[9].Value; //Обновлять на +1 при обновлении на +1 предыдущих значений

                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    int identitykey = (int)dgw.Rows[index].Cells[0].Value;
                    string deletequery = "DELETE FROM Works WHERE id_work  = @identitykey";
                    SqlCommand command = new(deletequery, DataBase.GetConnection());

                    command.Parameters.AddWithValue("@identitykey", identitykey);
                    command.ExecuteNonQuery();
                    return;
                }
                if (rowState == RowState.Modified)
                {


                    var identitykey = dgw.Rows[index].Cells[0].Value.ToString();
                    string? id_brigade = dgw.Rows[index].Cells[1].Value.ToString();
                    string? id_object_building = dgw.Rows[index].Cells[2].Value.ToString();
                    string? work_date_start = dgw.Rows[index].Cells[3].Value.ToString();
                    string? work_date_end = dgw.Rows[index].Cells[4].Value.ToString();
                    string? work_count = dgw.Rows[index].Cells[5].Value.ToString();
                    string? work_in_process = dgw.Rows[index].Cells[6].Value.ToString();

                    string ChangeQuery = "UPDATE Works " +
                                         "SET id_brigade = @id_brigade, id_object_building = @id_object_building, " +
                                         "work_date_start = @work_date_start, work_date_end = @work_date_end, " +
                                         "work_count = @work_count, work_in_process = @work_in_process " +
                                         "WHERE id_work = @identitykey";
                    SqlCommand command = new(ChangeQuery, DataBase.GetConnection());
                    command.Parameters.AddWithValue("@id_brigade", id_brigade);
                    command.Parameters.AddWithValue("@id_object_building", id_object_building);
                    command.Parameters.AddWithValue("@work_date_start", work_date_start);
                    command.Parameters.AddWithValue("@work_date_end", work_date_end);
                    command.Parameters.AddWithValue("@work_count", work_count);
                    command.Parameters.AddWithValue("@work_in_process", work_in_process);
                    command.Parameters.AddWithValue("@identitykey", identitykey);
                    command.ExecuteNonQuery();
                }
            }
            DataBase.CloseConnection();
        }

    }
    #endregion

    #endregion
    //добавлять новый параметр в ChangeWorkers и новое значение в If при добавлении колонки в Бд

    #region Удаление значения в таблице
    //так-же подлежит редактированию при добавлении новой колонки в бд



    #region Удаление Заказанного материала
    /// <summary>
    /// Удаление строки с Заказанного материала
    /// </summary>
    /// <param name="data">Указание Datagridview</param>
    class DeleteMaterialsOffered : IDeletable
    {
        public void Delete(DataGridView data, out bool result)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите удалить эту строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                int index = data.CurrentCell.RowIndex;
                result = true;
                data.Rows[index].Visible = false;
                if (data.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    data.Rows[index].Cells[9].Value = RowState.Deleted; //изменять на текущее значение значение +1, когда добавляется новая колонка
                    return;
                }
                data.Rows[index].Cells[9].Value = RowState.Deleted; //изменять на текущее значение значение +1, когда добавляется новая колонка
            }
            else result = false;
        }

    }
    #endregion

    #region Удаление Работы
    /// <summary>
    /// Удаление строки с Работ
    /// </summary>
    /// <param name="data">Указание Datagridview</param>
    class DeleteWorks : IDeletable
    {
        public void Delete(DataGridView data, out bool result)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите удалить эту строку?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                int index = data.CurrentCell.RowIndex;
                result = true;
                data.Rows[index].Visible = false;
                if (data.Rows[index].Cells[0].Value.ToString() == string.Empty)
                {
                    data.Rows[index].Cells[9].Value = RowState.Deleted; //изменять на текущее значение значение +1, когда добавляется новая колонка
                    return;
                }
                data.Rows[index].Cells[9].Value = RowState.Deleted; //изменять на текущее значение значение +1, когда добавляется новая колонка
            }
            else result = false;
        }

    }
    #endregion

    #endregion

    #endregion

    #region Методы для комбобоксов
    static class SelectedIndexComboboxes
    {
        //передача элемента в индекс комбобокса
        public static void SetSelectedIndex(ComboBox comboBox, string value)
        {
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                if (comboBox.Items[i].ToString() == value)
                {
                    comboBox.SelectedIndex = i;
                }
            }
        }
        public static void SetSelectedIndexBrRowView(ComboBox comboBox, string value)
        {
            foreach (DataRowView row in comboBox.Items)
            {
                if (row.Row.Field<string>("br_name") == value)
                {
                    comboBox.SelectedItem = row;
                    return;
                }
            }
        }
        public static void SetSelectedIndexObRowView(ComboBox comboBox, string value)
        {
            foreach (DataRowView row in comboBox.Items)
            {
                if (row.Row.Field<string>("ob_name") == value)
                {
                    comboBox.SelectedItem = row;
                    return;
                }
            }
        }
    }
    class Comboboxes : IComboboxable
    {
        public void ComboboxBrigadeName(ComboBox box)
        {
            string SelectQuery = $"SELECT id_brigade, br_name FROM brigade ORDER BY id_brigade";
            SqlDataAdapter adapter = new(SelectQuery, DataBase.GetConnection());
            DataBase.OpenConnection();
            DataSet dataset = new();
            adapter.Fill(dataset, "br_name");
            box.DisplayMember = "br_name";
            box.ValueMember = "id_brigade";
            box.DataSource = dataset.Tables["br_name"];
            box.DropDownStyle = ComboBoxStyle.DropDownList; // запрет на редактирование и добавление элементов комбобокса 
            DataBase.CloseConnection();
        }
        public void GetCountMaterialsToLabel(Label lab, ComboBox box)
        {
            
            int matCount = 0;
            DataBase.OpenConnection();
            string selectQuery = $"SELECT mat_count FROM materials WHERE id_materials = '{Comboboxid.GiveIdFromMaterials(box)}'";
            SqlCommand command1 = new SqlCommand(selectQuery, DataBase.GetConnection());
            DataBase.OpenConnection();
            SqlDataReader reader = command1.ExecuteReader();
            if (reader.Read())
            {
                matCount = reader.GetInt32(0);
            }
            DataBase.CloseConnection();
            lab.Text = $"Всего этих материалов: {matCount}";
        }
        public void ComboboxObjName(ComboBox box)
        {
            string SelectQuery = $"SELECT id_object_building, ob_name FROM object_building ORDER BY id_object_building";
            SqlDataAdapter adapter = new(SelectQuery, DataBase.GetConnection());
            DataBase.OpenConnection();
            DataSet dataset = new();
            adapter.Fill(dataset, "ob_name");
            box.DisplayMember = "ob_name";
            box.ValueMember = "id_object_building";
            box.DataSource = dataset.Tables["ob_name"];
            box.DropDownStyle = ComboBoxStyle.DropDownList; // запрет на редактирование и добавление элементов комбобокса 
            DataBase.CloseConnection();
        }
        public void ComboboxWorks(ComboBox box)
        {
            string SelectQuery = $"SELECT id_work FROM works ORDER BY id_work";
            SqlDataAdapter adapter = new(SelectQuery, DataBase.GetConnection());
            DataBase.OpenConnection();
            DataSet dataset = new();
            adapter.Fill(dataset, "id_work");
            box.DisplayMember = "id_work";
            box.ValueMember = "id_work";
            box.DataSource = dataset.Tables["id_work"];
            box.DropDownStyle = ComboBoxStyle.DropDownList; // запрет на редактирование и добавление элементов комбобокса 
            DataBase.CloseConnection();
        }
        public void ComboboxSelectedBrname(ComboBox brname, ComboBox box)
        {
            string SelectQuery = $"SELECT id_work FROM works as w JOIN brigade as br on br.id_brigade=w.id_brigade " +
                $"WHERE br.id_brigade = '{Comboboxid.GiveIdFromBrigadeName(brname)}' Order by id_work";
            SqlDataAdapter adapter = new(SelectQuery, DataBase.GetConnection());
            DataBase.OpenConnection();
            DataSet dataset = new();
            adapter.Fill(dataset, "id_work");
            box.DisplayMember = "id_work";
            box.ValueMember = "id_work";
            box.DataSource = dataset.Tables["id_work"];
            box.DropDownStyle = ComboBoxStyle.DropDownList; // запрет на редактирование и добавление элементов комбобокса 
            DataBase.CloseConnection();
        }
        public void ComboboxMaterials(ComboBox box)
        {
            string SelectQuery = $"SELECT id_materials, mat_name FROM materials  WHERE mat_count > 0 ORDER BY id_materials";
            SqlDataAdapter adapter = new(SelectQuery, DataBase.GetConnection());
            DataBase.OpenConnection();
            DataSet dataset = new();
            adapter.Fill(dataset, "mat_name");
            box.DisplayMember = "mat_name";
            box.ValueMember = "id_materials";
            box.DataSource = dataset.Tables["mat_name"];
            /* box.DropDownStyle = ComboBoxStyle.DropDownList; */// запрет на редактирование и добавление элементов комбобокса 
            DataBase.CloseConnection();
            box.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void ComboboxCityKey(ComboBox city)
        {
            city.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #region Заполнение комбобокса гендера
        public void ComboboxGender(ComboBox gender)
        {
            gender.Items.Add("Чоловік");
            gender.Items.Add("Жінка");
            gender.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion

        #region Передача названия статуса работы в комбобокс
        /// <summary>
        /// Добавление в комбо бокс статуса
        /// </summary>
        /// <param name="box">Комбобокс с названиями статусов</param>
        public void ComboboxStatus(ComboBox status)
        {
            status.Items.Add("У процесі");
            status.Items.Add("Завершено");
            status.Items.Add("Не розпочато");
            status.DropDownStyle = ComboBoxStyle.DropDownList; // запрет на редактирование и добавление элементов комбобокса 
        }
        #endregion

    }
    #endregion

    #region Перемещаемые методы
    //TODO:  Перемещаемые методы
    #region Методы для работ
    internal static class MethodsForWorks
    {
        //TODO:  Класс работ
        public static ICreateble CreateWorks = new CreateColumnsForWorks();
        public static IDeletable DeleteWorks = new DeleteWorks();
        public static IClickable ClickWorks = new WorksClick();
        public static IUpdatable UpdateWorks = new UpdateWorks();
        public static IChangeble ChangeWorks = new ChangeWorks();
        public static IComboboxable ComboboxBrigObjStatus = new Comboboxes();
        public static ISearchable SearchWorks = new SearchFromDatagridWorks();
        public static IRefreshable RefreshWorks = new RefreshDataGridWorks();
        public static ICheckboxable CheckboxWorks = new CheckboxesWorks();
        public static IAddable AddWorks = new AddingWorks();
        public static ICalendarTwo ChangeCalendarWorks = new CalendarForChangeWorks();
        public static ICalendarTwo AddingCalendarWorks = new CalendarForAddingWorks();
        public static ICalendarTwo FilterCalendarWorks = new CalendarForFilterWorks();

    }
    #endregion

    #region Методы для бригад
    internal static class MethodsForBrigades
    {
        //TODO: Класс бригад
        public static ICreateble CreateBrigades = new CreateColumnsForBrigades();
        public static IClickable ClickBrigades = new BrigadeClick();
        public static IUpdatable UpdateBrigade = new UpdateBrigade();
        public static IChangeble ChangeBrigades = new ChangeBrigade();
        public static ISearchable SearchBrigades = new SearchFromDatagridBrigades();
        public static IRefreshable RefreshBrigades = new RefreshDataGridBrigades();
        public static ICheckboxable CheckboxBrigades = new CheckboxesBrigades();
        public static IAddable AddBrigades = new AddingBrigades();
    }
    #endregion

    #region Методы для материалов
    internal static class MethodsForMaterials
    {
        public static ICreateble CreateMaterials = new CreateColumnsForMaterials();
        public static IClickable ClickMaterials = new MaterialsClick();
        public static IUpdatable UpdateMaterials = new UpdateMaterials();
        public static IChangeble ChangeMaterials = new ChangeMaterials();
        public static ISearchable SearchMaterials = new SearchFromDatagridMaterials();
        public static IRefreshable RefreshMaterials = new RefreshDataGridMaterials();
        public static ICheckboxable CheckboxMaterials = new CheckboxesMaterials();
        public static IAddable AddMaterials = new AddingMaterials();
        //TODO: Класс материалов
    }
    #endregion

    #region Методы для заказанных материалов
    internal static class MethodsForMaterialsOffered
    {
        public static ICreateble CreateMaterialsOffered = new CreateColumnsForMaterialsOffered();
        public static IDeletable DeleteMaterialsOffered = new DeleteMaterialsOffered();
        public static IClickable ClickMaterialsOffered = new MaterialsOfferedClick();
        public static IUpdatable UpdateMaterialsOffered = new UpdateMaterialsOffered();
        public static IChangeble ChangeMaterialsOffered = new ChangeMaterialsOffered();
        public static ISearchable SearchMaterialsOffered = new SearchFromDatagridMaterialsOffered();
        public static IRefreshable RefreshMaterialsOffered = new RefreshDataGridMaterialsOffered();
        public static ICheckboxable CheckboxMaterialsOffered = new CheckboxesMaterialsOffered();
        public static IAddable AddMaterialsOffered = new AddingMaterialsOff();
        public static ICalendarOne ChangeCalendarMaterialsOffered = new CalendarForChangeMaterialsOffered();
        public static ICalendarOne AddingCalendarMaterialsOffered = new CalendarForAddingMaterialsOffered();
        public static ICalendarOne FilterCalendarMaterialsOffered = new CalendarForFilterMaterialsOffered();
        public static IComboboxable ComboboxesBrWorkMat = new Comboboxes();
    }
    #endregion

    #region Методы для объектов
    internal static class MethodsForObject
    {
        public static ICreateble CreateObject = new CreateColumnsForObjects();
        public static IClickable ClickObject = new ObjectsClick();
        public static IChangeble ChangeObjects = new ChangeObjects();
        public static IUpdatable UpdateObjects = new UpdateObjects();
        public static ISearchable SearchObject = new SearchFromDatagridObject();
        public static IRefreshable RefreshObject = new RefreshDataGridObjectBuilding();
        public static ICheckboxable CheckboxObject = new CheckboxesObjects();
        public static IAddable AddObjects = new AddingObjects();
        public static ICalendarTwo ChangeCalendarObjects = new CalendarForChangeObjects();
        public static ICalendarTwo AddingCalendarObjects = new CalendarForAddingObjects();
        public static ICalendarTwo FilterCalendarObjects = new CalendarForFilterObjects();

        //TODO: Класс объектов
    }
    #endregion

    #region Методы для рабочих
    internal static class MethodsForWorkers
    {

        public static ICreateble CreateWorker = new CreateColumnsForWorkers();
        public static IClickable ClickWorker = new WorkersClick();
        public static IUpdatable UpdateWorker = new UpdateWorkers();
        public static IChangeble ChangeWorker = new ChangeWorkers();
        public static IComboboxable Comboboxes = new Comboboxes();
        public static ISearchable SearchWorkers = new SearchFromDatagridWorkers();
        public static IRefreshable RefreshWorkers = new RefreshDataGridWorkers();
        public static ICheckboxable CheckboxWorkers = new CheckboxesWorkers();
        public static IAddable AddWorker = new AddingWorkers();



    }
    #endregion

    #endregion

    #region Поиск значений в датагридвью

    #region Поиск рабочих в датагридвью
    class SearchFromDatagridWorkers : ReadSingleRowFromBrigadeWorker, ISearchable
    {
        /// <summary>
        /// Создание колонок для рабочих и занесение их в таблицу Datagridview
        /// </summary>
        /// <param name="data">Указание Datagridview</param>
        /// <param name="search">Указание текстбокса для поиска</param>
        public override void Search(DataGridView data, CheckedListBox listitem1, Label lbl, Control.ControlCollection collection, TextBox search)
        {
            string query = $"SELECT w.*, br.br_name FROM brigade_worker AS w JOIN brigade AS br ON w.id_brigade = br.id_brigade ";
            string listquery1 = listitem1.CheckedItems.Count != 0 ? $"WHERE br.br_name IN ({string.Join(",", listitem1.CheckedItems.Cast<string>().Select(item => $"'{item}'"))}) AND " : "WHERE ";
            string searchquery = $"CONCAT(id_brigade_worker, w.id_brigade, brwr_login, brwr_phone, brwr_email, " +
                "brwr_lname, brwr_fname, brwr_mname, brwr_speciality, br.br_name) LIKE '%" + search.Text + "%' ";

            CheckboxesIfnormal(data, lbl, collection, query, listquery1, searchquery);
        }
    }
    #endregion

    #region Поиск бригад в датагридвью
    class SearchFromDatagridBrigades : ReadSingleRowFromBrigades, ISearchable
    {
        /// <summary>
        /// Создание колонок для рабочих и занесение их в таблицу Datagridview
        /// </summary>
        /// <param name="data">Указание Datagridview</param>
        /// <param name="search">Указание текстбокса для поиска</param>
        public override void Search(DataGridView data, CheckedListBox listitem1, Label lbl, Control.ControlCollection collection, TextBox search)
        {
            string query = $"SELECT * FROM brigade ";
            string listquery1 = listitem1.CheckedItems.Count > 0 ? $"WHERE br_name IN ({string.Join(",", listitem1.CheckedItems.Cast<string>()
                                         .Select(item => $"'{item}'"))}) AND " : "WHERE ";
            string searchquery = $"CONCAT(id_brigade,  br_name, br_people_count,  br_specilaity) LIKE '%" + search.Text + "%'";
            CheckboxesIfnormal(data, lbl, collection, query, listquery1, searchquery);
        }
    }
    #endregion

    #region Поиск работ в датагридвью
    class SearchFromDatagridWorks : ReadSingleRowFromWorks, ISearchable
    {
        /// <summary>
        /// Создание колонок для рабочих и занесение их в таблицу Datagridview
        /// </summary>
        /// <param name="data">Указание Datagridview</param>
        /// <param name="search">Указание текстбокса для поиска</param>
        public override void Search(DataGridView data, CheckedListBox listitem1, CheckedListBox listitem2, Label lbl, Control.ControlCollection collection, TextBox search, TextBox dat1, TextBox dat2)
        {
            string query = $"SELECT w.*, ob_name, br_name from Works AS w JOIN object_building as ob" +
                                          $" ON w.id_object_building = ob.id_object_building JOIN brigade as br ON w.id_brigade = br.id_brigade ";
            string listquery1 = listitem1.CheckedItems.Count > 0 ? $"AND work_in_process IN ({string.Join(",", listitem1.CheckedItems.Cast<string>()
                                         .Select(item => $"'{item}'"))}) " : "";
            string listquery2 = listitem2.CheckedItems.Count > 0 ? $"AND br.br_name IN({string.Join(",", listitem2.CheckedItems.Cast<string>()
                                         .Select(item => $"'{item}'"))}) " : "";
            string searchquery = $"AND CONCAT(w.id_work, w.id_brigade, w.id_object_building, work_date_start, work_date_end," +
                "work_count, work_in_process, ob.ob_name, br.br_name ) LIKE '%" + search.Text + "%'"; //tODO : searchworks
            string datequery1 = dat1.Text.Length > 0 ? $"AND work_date_start >= '{dat1.Text}'" : "";
            string datequery2 = dat2.Text.Length > 0 ? $"AND work_date_end <= '{dat2.Text}'" : "";

            CheckboxesIfnormal(data,  lbl, collection,  query, searchquery, listquery1, listquery2, datequery1, datequery2);
        }
    }
    #endregion

    #region Поиск материалов в датагридвью
    class SearchFromDatagridMaterials : ReadSingleRowFromMaterials, ISearchable
    {
        /// <summary>
        /// Создание колонок для материалов и занесение их в таблицу Datagridview
        /// </summary>
        /// <param name="data">Указание Datagridview</param>
        /// <param name="search">Указание текстбокса для поиска</param>
        public override void Search(DataGridView data, CheckedListBox listitem1, Label lbl, Control.ControlCollection collection, TextBox search)
        {
            string query = $"SELECT * FROM materials ";
            string listquery1 = listitem1.CheckedItems.Count > 0 ? $"WHERE mat_name IN ({string.Join(",", listitem1.CheckedItems.Cast<string>()
                                         .Select(item => $"'{item}'"))}) AND " : "WHERE ";
            string searchquery = $"CONCAT(id_materials, mat_name, mat_price, mat_count, mat_company," +
                "mat_description, mat_features) LIKE '%" + search.Text + "%'";
            CheckboxesIfnormal(data, lbl, collection, query, listquery1, searchquery);
        }
    }
    #endregion

    #region Поиск заказанных материалов в датагридвью
    class SearchFromDatagridMaterialsOffered : ReadSingleRowFromMaterialsOffered, ISearchable
    {
        /// <summary>
        /// Создание колонок для заказанных материалов и занесение их в таблицу Datagridview
        /// </summary>
        /// <param name="data">Указание Datagridview</param>
        /// <param name="search">Указание текстбокса для поиска</param>
        public override void Search(DataGridView data, CheckedListBox listitem1, CheckedListBox listitem2, Label lbl, Control.ControlCollection collection, TextBox search, TextBox dat1)
        {
            string query = $"SELECT matof.*, br.br_name, obj.ob_name, mat.mat_name FROM materials_offered AS matof " +
                                         $"JOIN brigade AS br ON matof.id_brigade = br.id_brigade " +
                                         $"JOIN Works AS w ON matof.id_work = w.id_work " +
                                         $"JOIN object_building AS obj ON w.id_object_building = obj.id_object_building " +
                                         $"JOIN materials AS mat ON matof.id_materials = mat.id_materials ";

            string listquery1 = listitem1.CheckedItems.Count > 0 ? $"AND mat.mat_name IN ({string.Join(",", listitem1.CheckedItems.Cast<string>()
                                         .Select(item => $"'{item}'"))}) " : "";
            string listquery2 = listitem2.CheckedItems.Count > 0 ? $"AND obj.ob_name IN({string.Join(",", listitem2.CheckedItems.Cast<string>()
                                         .Select(item => $"'{item}'"))}) " : "";
            string searchquery = $"AND CONCAT(matof.id_materials_offered, matof.id_brigade, br.br_name, obj.ob_name, matof.id_work,  mat.mat_name, matof.id_materials, matof.matof_date_give, " +
                $"matof.matof_count) LIKE '%{search.Text}%'";
            string datequery1 = dat1.Text.Length > 0 ? $"AND matof_date_give >= '{dat1.Text}'" : "";

            CheckboxesIfnormal(data, lbl, collection, query, listquery1, listquery2, searchquery, datequery1);
        }
    }
    #endregion

    #region Поиск объектов в датагридвью
    class SearchFromDatagridObject : ReadSingleRowFromObjectBuilding, ISearchable
    {
        /// <summary>
        /// Создание колонок для объектов и занесение их в таблицу Datagridview
        /// </summary>
        /// <param name="data">Указание Datagridview</param>
        /// <param name="search">Указание текстбокса для поиска</param>
        public override void Search(DataGridView data, CheckedListBox listitem1, Label lbl, Control.ControlCollection collection, TextBox search, TextBox dat1,TextBox dat2)
        {
            string query = $"SELECT * FROM object_building ";
            string listquery1 = listitem1.CheckedItems.Count > 0 ? $"AND ob_name IN({string.Join(",", listitem1.CheckedItems.Cast<string>()
                                         .Select(item => $"'{item}'"))}) " : "";
            string listquery2 = "";
            string searchquery = $"AND CONCAT(id_object_building,  ob_name, ob_city_region,  ob_street," +
                "ob_house_number, ob_type, ob_date_start, ob_date_end ) LIKE '%" + search.Text + "%' ";
            string datequery1 = dat1.Text.Length > 0 ? $"AND ob_date_start >= '{dat1.Text}' " : "";
            string datequery2 = dat2.Text.Length > 0 ? $"AND ob_date_end <= '{dat2.Text}' " : "";

            CheckboxesIfnormal(data,  lbl, collection, query, listquery1, listquery2, searchquery, datequery1, datequery2);
        }
    }
    #endregion

    #endregion

    #region Перезагрузка значений в датагридвью

    #region Перезагрузка рабочих
    class RefreshDataGridWorkers : ReadSingleRowFromBrigadeWorker, IRefreshable
    {
        public override void Refresh(DataGridView dat, Label lbl, Control.ControlCollection controls)
        {

            MethodsForWorkers.UpdateWorker.Update(dat);
            dat.Rows.Clear();
            dat.Columns[0].Visible = false;
            dat.Columns[1].Visible = false;
            dat.Columns[11].Visible = false; // также изменять на +1 в зависимости добавлении данных
            string query = $"SELECT worker.*, br_name FROM brigade_worker AS worker JOIN brigade as br ON worker.id_brigade = br.id_brigade";

            SqlCommand command = new(query, DataBase.GetConnection());

            ReaderAndCountAllRows(dat, lbl, command);
            ClearTextBoxes.ClearText(controls);
        }
    }
    #endregion

    #region Перезагрузка объектов
    class RefreshDataGridObjectBuilding : ReadSingleRowFromObjectBuilding, IRefreshable
    {
        public override void Refresh(DataGridView dat, Label lbl, Control.ControlCollection controls)
        {
            MethodsForObject.UpdateObjects.Update(dat);
            dat.Rows.Clear();
            dat.Columns[8].Visible = false; // также изменять на +1 в зависимости добавлении данных
            string query = $"SELECT * FROM object_building";

            SqlCommand command = new(query, DataBase.GetConnection());

            ReaderAndCountAllRows(dat, lbl, command);
            ClearTextBoxes.ClearText(controls);

        }
    }
    #endregion

    #region Перезагрузка заказанных материалов
    class RefreshDataGridMaterialsOffered : ReadSingleRowFromMaterialsOffered, IRefreshable
    {
        public override void Refresh(DataGridView dat, Label lbl, Control.ControlCollection controls)
        {
            MethodsForMaterialsOffered.UpdateMaterialsOffered.Update(dat);
            dat.Rows.Clear();
            dat.Columns[0].Visible = false;
            dat.Columns[1].Visible = false;
            dat.Columns[3].Visible = false;
            dat.Columns[9].Visible = false; // также изменять на +1 в зависимости добавлении данных
            string query = $"SELECT matof.*, br.br_name, obj.ob_name, mat.mat_name FROM materials_offered AS matof " +
                $"JOIN brigade AS br ON matof.id_brigade = br.id_brigade " +
                $"JOIN Works AS w ON matof.id_work = w.id_work " +
                $"JOIN object_building AS obj ON w.id_object_building = obj.id_object_building " +
                $"JOIN materials AS mat ON matof.id_materials = mat.id_materials";

            SqlCommand command = new(query, DataBase.GetConnection());

            ReaderAndCountAllRows(dat, lbl, command);
            ClearTextBoxes.ClearText(controls);

        }
    }
    #endregion

    #region Перезагрузка материалов
    class RefreshDataGridMaterials : ReadSingleRowFromMaterials, IRefreshable
    {
        public override void Refresh(DataGridView dat, Label lbl, Label summat, Control.ControlCollection controls)
        {
            MethodsForMaterials.UpdateMaterials.Update(dat);
            dat.Rows.Clear();
            dat.Columns[7].Visible = false; // также изменять на +1 в зависимости добавлении данных
            string query = $"SELECT * FROM materials";

            SqlCommand command = new(query, DataBase.GetConnection());

            ReaderAndCountAllRows(dat, lbl, command);
            summat.GetSum(dat, 2,3);
            //TODO так же очистка
            ClearTextBoxes.ClearText(controls);
        }
    }
    #endregion

    #region Перезагрузка бригад
    class RefreshDataGridBrigades : ReadSingleRowFromBrigades, IRefreshable
    {
        public override void Refresh(DataGridView dat, Label lbl, Control.ControlCollection controls)
        {
            MethodsForBrigades.UpdateBrigade.Update(dat);
            dat.Rows.Clear();
            dat.Columns[4].Visible = false; // также изменять на +1 в зависимости добавлении данных
            string query = $"SELECT * FROM brigade";

            SqlCommand command = new(query, DataBase.GetConnection());

            ReaderAndCountAllRows(dat, lbl, command);
            ClearTextBoxes.ClearText(controls);

        }
    }
    #endregion

    #region Перезагрузка работ
    class RefreshDataGridWorks : ReadSingleRowFromWorks, IRefreshable
    {
        public override void Refresh(DataGridView dat, Label lbl, Control.ControlCollection controls)
        {

            MethodsForWorks.UpdateWorks.Update(dat);
            dat.Rows.Clear();
            dat.Columns[9].Visible = false; // также изменять на +1 в зависимости добавлении данных
            dat.Columns[1].Visible = false;
            dat.Columns[2].Visible = false;
            //этот запрос просто адски хорош

            SqlCommand command = new($"SELECT w.*, ob_name, br_name from Works AS w JOIN object_building as ob ON w.id_object_building = ob.id_object_building JOIN brigade as br ON w.id_brigade = br.id_brigade", DataBase.GetConnection());

            ReaderAndCountAllRows(dat, lbl, command);
            ClearTextBoxes.ClearText(controls);
        }
    }
    #endregion

    #endregion

    #region Работа с чекбоксами

    #region Чекбоксы для рабочих
    class CheckboxesWorkers : RefreshDataGridWorkers, ICheckboxable
    {
        #region Занесение названия бригады в чекбокс из базы данных
        /// <summary>
        /// Вывод названия бригады в чекбокс из базы данных
        /// </summary>
        /// <param name="listitem">Название листа чекбоксов</param>

        public override void Checkboxes(CheckedListBox listitem)
        {
            listitem.Items.Clear();
            DataBase.OpenConnection();
            SqlCommand command = new($"SELECT br_name FROM brigade ORDER BY id_brigade", DataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listitem.Items.Add(reader[0]);
            }
            DataBase.CloseConnection();
        }
        #endregion
    }
    #endregion

    #region Чекбоксы для объектов
    class CheckboxesObjects : RefreshDataGridObjectBuilding, ICheckboxable
    {
        #region Занесение названия бригады в чекбокс из базы данных
        /// <summary>
        /// Вывод названия бригады в чекбокс из базы данных
        /// </summary>
        /// <param name="listitem">Название листа чекбоксов</param>
        readonly string query = $"SELECT ob_name FROM object_building ORDER BY id_object_building";
        public override void Checkboxes(CheckedListBox listitem)
        {
            listitem.Items.Clear();
            DataBase.OpenConnection();
            SqlCommand command = new(query, DataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listitem.Items.Add(reader[0]);
            }
            DataBase.CloseConnection();
        }
        #endregion
    }
    #endregion

    #region Чекбоксы для заказанных материалов
    class CheckboxesMaterialsOffered : RefreshDataGridMaterialsOffered, ICheckboxable
    {
        #region Фильтрация значений по имени бригады в датагридвью через чекбокс
        public override void Checkboxes(CheckedListBox listitem)
        {
            listitem.Items.Clear();
            DataBase.OpenConnection();
            SqlCommand command = new($"SELECT mat_name FROM materials ORDER BY id_materials", DataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listitem.Items.Add(reader[0]);
            }
            DataBase.CloseConnection();
        }
        #endregion
    }
    #endregion

    #region Чекбоксы для материалов
    class CheckboxesMaterials : RefreshDataGridMaterials, ICheckboxable
    {
        #region Фильтрация значений по имени бригады в датагридвью через чекбокс
        readonly string query = $"SELECT mat_name FROM materials ORDER BY id_materials ";
        public override void Checkboxes(CheckedListBox listitem)
        {
            listitem.Items.Clear();
            DataBase.OpenConnection();
            SqlCommand command = new(query, DataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listitem.Items.Add(reader[0]);
            }
            DataBase.CloseConnection();
        }
        #endregion
    }
    #endregion

    #region Чекбоксы для бригад
    class CheckboxesBrigades : RefreshDataGridBrigades, ICheckboxable
    {
        #region Фильтрация значений по имени бригады в датагридвью через чекбокс
        readonly string query = $"SELECT br_name FROM brigade ORDER BY id_brigade";
        public override void Checkboxes(CheckedListBox listitem)
        {
            listitem.Items.Clear();
            DataBase.OpenConnection();
            SqlCommand command = new(query, DataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listitem.Items.Add(reader[0]);
            }
            DataBase.CloseConnection();
        }
        #endregion
    }
    #endregion

    #region Чекбоксы для работ
    class CheckboxesWorks : RefreshDataGridWorks, ICheckboxable
    {
        #region Фильтрация значений по имени бригады в датагридвью через чеклист

        public override void Checkboxes(CheckedListBox listitem)
        {
            listitem.Items.Clear();
            DataBase.OpenConnection();
            SqlCommand command = new($"SELECT DISTINCT work_in_process FROM Works", DataBase.GetConnection());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listitem.Items.Add(reader[0]);
            }
            DataBase.CloseConnection();
        }
        #endregion
    }
    #endregion

    #endregion

}