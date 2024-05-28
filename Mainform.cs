namespace Курсовая
{
    public partial class Mainform : Form
    {

        public Mainform()
        {
            InitializeComponent();
        }
        //TODO: Главная форма
        private void Mainform_Load(object sender, EventArgs e)
        {
            #region Подключение базы данных к dgv
            Parallel.Invoke(() =>
            {
                MethodsForWorkers.CreateWorker.Create(WorkersDataGridView); //бригадные рабочие
                MethodsForBrigades.CreateBrigades.Create(BrigadesDataGridView); //бригады
                MethodsForObject.CreateObject.Create(ObjectsDataGridView); //объекты
                MethodsForMaterials.CreateMaterials.Create(MaterialsDataGridView); //материалы
                MethodsForMaterialsOffered.CreateMaterialsOffered.Create(MaterialsOfferedDataGridView); //заказанные материалы
                MethodsForWorks.CreateWorks.Create(WorksDataGridView);
            }); //работы
            #endregion

            #region Активация рабочих:
            Parallel.Invoke(() =>
            {
                MethodsForWorkers.RefreshWorkers.Refresh(WorkersDataGridView, CounterWorkerL, Controls);
                MethodsForWorkers.CheckboxWorkers.Checkboxes(ListOfFiltrationBrigadeName);
                MethodsForWorkers.Comboboxes.ComboboxBrigadeName(Name_brigade_combobox);
                MethodsForWorkers.Comboboxes.ComboboxCityKey(CountrySpecForTelephoneCb);
                MethodsForWorkers.Comboboxes.ComboboxGender(Gender_combobox);
            });
            #endregion

            #region Активация работ:
            Parallel.Invoke(() =>
            {
                MethodsForWorks.RefreshWorks.Refresh(WorksDataGridView, CounterWorkL, Controls);
                MethodsForWorks.CheckboxWorks.Checkboxes(ListOfFiltrationWorks);
                MethodsForWorks.ComboboxBrigObjStatus.ComboboxBrigadeName(br_name_in_worksCb);
                MethodsForWorks.ComboboxBrigObjStatus.ComboboxObjName(ob_name_inworksCb);
                MethodsForWorks.ComboboxBrigObjStatus.ComboboxStatus(Work_StatusComb);
                MethodsForBrigades.CheckboxBrigades.Checkboxes(ListOfFiltrBrigInWorks);
            });
            #endregion

            #region Активация бригад:
            Parallel.Invoke(() =>
            {
                MethodsForBrigades.RefreshBrigades.Refresh(BrigadesDataGridView, CounterBrigL, Controls);
                MethodsForBrigades.CheckboxBrigades.Checkboxes(ListOfFiltrationBrigades);
            });
            #endregion

            #region Активация объектов: 
            Parallel.Invoke(() =>
            {
                MethodsForObject.RefreshObject.Refresh(ObjectsDataGridView, CounterObjectL, Controls);
                MethodsForObject.CheckboxObject.Checkboxes(ListOfFiltrationObjects);
            });
            #endregion

            #region Активация материалов:
            Parallel.Invoke(() =>
            {
                MethodsForMaterials.RefreshMaterials.Refresh(MaterialsDataGridView, CounterMaterialsL, SumOfMaterials, Controls);
                MethodsForMaterials.CheckboxMaterials.Checkboxes(ListOfFiltrationMaterials);
            });

            #endregion

            #region Активация материлов, которых заказали:
            Parallel.Invoke(() =>
            {
                MethodsForMaterialsOffered.RefreshMaterialsOffered.Refresh(MaterialsOfferedDataGridView, CounterMaterialsOffL, Controls);
                MethodsForMaterialsOffered.CheckboxMaterialsOffered.Checkboxes(ListOfFiltrationMaterialsOffered);
                MethodsForObject.CheckboxObject.Checkboxes(ListOfFiltrObjInMaterialsOffered);
            });
            #endregion

        }
        #region CellClicks методы занесения значений в текстбоксы по клику на ячейку
        private void Workers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MethodsForWorkers.ClickWorker.Cellsclick(TextboxWorker, Name_brigade_combobox,
            textBox_brwr_lname, textBox_brwr_fname, textBox_brwr_mname, textBox_brwr_login, CountrySpecForTelephoneCb, textBox_brwr_phone, textBox_brwr_email, textBox_brwr_speciality, Gender_combobox, e, WorkersDataGridView); //подлежит редактированию при занесении новых значений 
        }
        private void BrigadesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MethodsForBrigades.ClickBrigades.Cellsclick(BrigadesIdTbMAIN, BrigNameTbMain, BrigadesPCountTbMain, BrigadesSpecTbMain, e, BrigadesDataGridView);
        }

        private void MaterialsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MethodsForMaterials.ClickMaterials.Cellsclick(Mat_IdTb, Mat_Name_Tb, Mat_PriceTb, Mat_CountTb, Mat_CompanyTb,
            Mat_DescrTb, Mat_FeaturesTb, e, MaterialsDataGridView);
        }

        private void MaterialsOfferedDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MethodsForMaterialsOffered.ClickMaterialsOffered.Cellsclick(Mat_of_IdTb, Mat_of_IdBrTb, Mat_of_WorkIdTb, Mat_of_MatIdTb, mat_of_date_tb,
            mat_of_count_tb, e, MaterialsOfferedDataGridView);
        }

        private void WorksDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MethodsForWorks.ClickWorks.Cellsclick(Id_worktb, br_name_in_worksCb, ob_name_inworksCb, Work_DStartTb, Work_DEndTb,
            Work_CountTb, Work_StatusComb, e, WorksDataGridView);
        }

        private void ObjectsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MethodsForObject.ClickObject.Cellsclick(Obj_id_Tb, Obj_name_Tb, Obj_RayonTb, Obj_StreetTb, Obj_HouseNTb,
            Obj_TypeOfObjTb, Obj_DstartTb, Obj_DEndTb, e, ObjectsDataGridView);
        }
        #endregion

        #region ChangeButtons методы для изменения значений в таблице 
        private void ChangeWorkerButton_Click(object sender, EventArgs e)
        {
            if (TextboxesScripts.CheckColor(WorkerPbCorrectPhon) && TextboxesScripts.CheckColor(WorkerPbCorrectEmai))
            {
                MethodsForWorkers.ChangeWorker.Change(TextboxWorker, Name_brigade_combobox,
                    textBox_brwr_lname, textBox_brwr_fname, textBox_brwr_mname, textBox_brwr_login, textBox_brwr_phone, textBox_brwr_email, Gender_combobox, textBox_brwr_speciality, WorkersDataGridView, out bool condition); //подлежит редактированию при занесении новых значений 
                if (condition)
                    MethodsForWorkers.RefreshWorkers.Refresh(WorkersDataGridView, CounterWorkerL, Controls);
                //M_Workers.ClearAllFields(this);
                //TODO: Очистка текстбокса в главной форме нужно доделать!!!!
            }
            else
            {
                MessageBox.Show("Вы ввели неверный телефон или Email!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ChBrigBut_Click(object sender, EventArgs e)
        {
            MethodsForBrigades.ChangeBrigades.Change(BrigadesIdTbMAIN, BrigNameTbMain, BrigadesPCountTbMain, BrigadesSpecTbMain, BrigadesDataGridView, out bool condition); //подлежит редактированию при занесении новых значений 
            if (condition)
                MethodsForBrigades.RefreshBrigades.Refresh(BrigadesDataGridView, CounterBrigL, Controls);
            //MethodsForBrigades.UpdateBrigade.Update(BrigadesDataGridView);
            //MethodsForEveryone.ClearAllFields(this);
        }

        private void Mat_ChangBut_Click(object sender, EventArgs e)
        {
            MethodsForMaterials.ChangeMaterials.Change(Mat_IdTb, Mat_Name_Tb, Mat_PriceTb, Mat_CountTb, Mat_CompanyTb,
            Mat_DescrTb, Mat_FeaturesTb, MaterialsDataGridView, out bool condition); //подлежит редактированию при занесении новых значений 
            if (condition)
                MethodsForMaterials.RefreshMaterials.Refresh(MaterialsDataGridView, CounterMaterialsL, SumOfMaterials, Controls);
            //MethodsForEveryone.ClearAllFields(this);
        }

        private void Chagemat_mat_ofBut_Click(object sender, EventArgs e)
        {
            MethodsForMaterialsOffered.ChangeMaterialsOffered.Change(Mat_of_IdTb, Mat_of_IdBrTb, Mat_of_WorkIdTb, Mat_of_MatIdTb, mat_of_date_tb,
            mat_of_count_tb, MaterialsOfferedDataGridView, out bool condition); //подлежит редактированию при занесении новых значений 
            if (condition)
                MethodsForMaterialsOffered.RefreshMaterialsOffered.Refresh(MaterialsOfferedDataGridView, CounterMaterialsOffL, Controls);
            //MethodsForEveryone.ClearAllFields(this);
        }

        private void Work_changeBut_Click(object sender, EventArgs e)
        {
            MethodsForWorks.ChangeWorks.Change(Id_worktb, br_name_in_worksCb, ob_name_inworksCb, Work_DStartTb, Work_DEndTb,
               Work_CountTb, Work_StatusComb, WorksDataGridView, out bool condition); //подлежит редактированию при занесении новых значений 
            if (condition)
                MethodsForWorks.RefreshWorks.Refresh(WorksDataGridView, CounterWorkL, Controls);
            //MethodsForEveryone.ClearAllFields(this);
        }

        private void Obj_ChangeB_Click(object sender, EventArgs e)
        {
            MethodsForObject.ChangeObjects.Change(Obj_id_Tb, Obj_name_Tb, Obj_RayonTb, Obj_StreetTb, Obj_HouseNTb,
            Obj_TypeOfObjTb, Obj_DstartTb, Obj_DEndTb, ObjectsDataGridView, out bool condition); //подлежит редактированию при занесении новых значений 
            if (condition)
                MethodsForObject.RefreshObject.Refresh(ObjectsDataGridView, CounterObjectL, Controls);
            //MethodsForEveryone.ClearAllFields(this);
        }
        #endregion

        #region RefreshPB методы для обновления значений в таблице
        private void Refresh_picture_Click(object sender, EventArgs e)
        {
            MethodsForWorkers.RefreshWorkers.Refresh(WorkersDataGridView, CounterWorkerL, Controls);
            ClearTextBoxes.ClearText(Controls);
            MethodsForWorkers.CheckboxWorkers.Checkboxes(ListOfFiltrationBrigadeName);
            MethodsForWorkers.Comboboxes.ComboboxBrigadeName(Name_brigade_combobox);
            //TODO: дополнение к очистке!!
        }
        private void Refresh_br_pb_Click(object sender, EventArgs e)
        {
            MethodsForBrigades.RefreshBrigades.Refresh(BrigadesDataGridView, CounterBrigL, Controls);
            MethodsForBrigades.CheckboxBrigades.Checkboxes(ListOfFiltrationBrigades);
            //MethodsForEveryone.ClearAllFields();
        }

        private void Refresh_Mat_pb_Click(object sender, EventArgs e)
        {
            MethodsForMaterials.RefreshMaterials.Refresh(MaterialsDataGridView, CounterMaterialsL, SumOfMaterials, Controls);
            MethodsForMaterials.CheckboxMaterials.Checkboxes(ListOfFiltrationMaterials);
            //MethodsForEveryone.ClearAllFields();
        }

        private void Refresh_mat_ofP_Click(object sender, EventArgs e)
        {
            MethodsForMaterialsOffered.RefreshMaterialsOffered.Refresh(MaterialsOfferedDataGridView, CounterMaterialsOffL, Controls);
            MethodsForMaterialsOffered.CheckboxMaterialsOffered.Checkboxes(ListOfFiltrationMaterialsOffered);
            MethodsForObject.CheckboxObject.Checkboxes(ListOfFiltrObjInMaterialsOffered);
            //MethodsForEveryone.ClearAllFields();
        }

        private void Refresh_Work_pb_Click(object sender, EventArgs e)
        {
            MethodsForWorks.RefreshWorks.Refresh(WorksDataGridView, CounterWorkL, Controls);
            MethodsForWorks.CheckboxWorks.Checkboxes(ListOfFiltrationWorks);
            MethodsForWorks.ComboboxBrigObjStatus.ComboboxBrigadeName(br_name_in_worksCb);
            MethodsForWorks.ComboboxBrigObjStatus.ComboboxObjName(ob_name_inworksCb);
            MethodsForBrigades.CheckboxBrigades.Checkboxes(ListOfFiltrBrigInWorks);
            //MethodsForEveryone.ClearAllFields();
        }

        private void Refresh_Obj_Pb_Click(object sender, EventArgs e)
        {
            MethodsForObject.RefreshObject.Refresh(ObjectsDataGridView, CounterObjectL, Controls);
            MethodsForObject.CheckboxObject.Checkboxes(ListOfFiltrationObjects);
            //MethodsForEveryone.ClearAllFields();
        }
        #endregion

        #region NewButtons методы добавления новых значений в таблицы
        private void NewWorkerButton_Click(object sender, EventArgs e)
        {
            AddWorker addWorker = new();
            addWorker.ShowDialog();
            MethodsForWorkers.RefreshWorkers.Refresh(WorkersDataGridView, CounterWorkerL, Controls);
            MethodsForWorkers.CheckboxWorkers.Checkboxes(ListOfFiltrationBrigadeName);
            MethodsForWorkers.Comboboxes.ComboboxBrigadeName(Name_brigade_combobox);
        }

        private void AddBrigBut_Click(object sender, EventArgs e)
        {
            AddBrig AddBrig = new();
            AddBrig.ShowDialog();
            MethodsForBrigades.RefreshBrigades.Refresh(BrigadesDataGridView, CounterBrigL, Controls);
            MethodsForBrigades.CheckboxBrigades.Checkboxes(ListOfFiltrationBrigades);
        }

        private void Mat_addBut_Click(object sender, EventArgs e)
        {
            AddMaterial AddMat = new();
            AddMat.ShowDialog();
            MethodsForMaterials.RefreshMaterials.Refresh(MaterialsDataGridView, CounterMaterialsL, SumOfMaterials, Controls);
            MethodsForMaterials.CheckboxMaterials.Checkboxes(ListOfFiltrationMaterials);
        }

        private void Newmat_mat_ofBut_Click(object sender, EventArgs e)
        {
            AddMaterialOffered AddMatOf = new();
            AddMatOf.ShowDialog();
            MethodsForMaterialsOffered.RefreshMaterialsOffered.Refresh(MaterialsOfferedDataGridView, CounterMaterialsOffL, Controls);
            MethodsForMaterialsOffered.CheckboxMaterialsOffered.Checkboxes(ListOfFiltrationMaterialsOffered);
            MethodsForObject.CheckboxObject.Checkboxes(ListOfFiltrObjInMaterialsOffered);
        }

        private void Work_newButton_Click(object sender, EventArgs e)
        {
            AddWorks AddWork = new();
            AddWork.ShowDialog();
            MethodsForWorks.RefreshWorks.Refresh(WorksDataGridView, CounterWorkL, Controls);
            MethodsForWorks.CheckboxWorks.Checkboxes(ListOfFiltrationWorks);
            MethodsForWorks.ComboboxBrigObjStatus.ComboboxBrigadeName(br_name_in_worksCb);
            MethodsForWorks.ComboboxBrigObjStatus.ComboboxObjName(ob_name_inworksCb);
            MethodsForBrigades.CheckboxBrigades.Checkboxes(ListOfFiltrBrigInWorks);
        }
        private void Obj_NewObjB_Click(object sender, EventArgs e)
        {
            AddObject AddObj = new();
            AddObj.ShowDialog();
            MethodsForObject.RefreshObject.Refresh(ObjectsDataGridView, CounterObjectL, Controls);
            MethodsForObject.CheckboxObject.Checkboxes(ListOfFiltrationObjects);
        }
        #endregion

        #region Textboxes методы поиска значений
        private void TextBox_Search_TextChanged(object sender, EventArgs e)
        {
            MethodsForWorkers.SearchWorkers.Search(WorkersDataGridView, ListOfFiltrationBrigadeName, CounterWorkerL, Controls, SearchTextboxWorkers);
        }
        private void Search_brTb_TextChanged(object sender, EventArgs e)
        {
            MethodsForBrigades.SearchBrigades.Search(BrigadesDataGridView, ListOfFiltrationBrigades, CounterBrigL, Controls, SearchTextboxBrigades);
        }

        private void Search_Mat_tb_TextChanged(object sender, EventArgs e)
        {
            MethodsForMaterials.SearchMaterials.Search(MaterialsDataGridView, ListOfFiltrationMaterials, CounterMaterialsL, Controls, SearchTextboxMaterials);
        }

        private void Search_mat_ofTb_TextChanged(object sender, EventArgs e)
        {
            MethodsForMaterialsOffered.SearchMaterialsOffered.Search(MaterialsOfferedDataGridView, ListOfFiltrationMaterialsOffered,
               ListOfFiltrObjInMaterialsOffered, CounterMaterialsOffL, Controls, SearchTextboxMaterialsOffered, FiltrMatOfDatGTb);
        }

        private void Search_Work_Tb_TextChanged(object sender, EventArgs e)
        {
            MethodsForWorks.SearchWorks.Search(WorksDataGridView, ListOfFiltrationWorks, ListOfFiltrBrigInWorks, CounterWorkL, Controls, SearchTextboxWorks, FiltrDatStWorksTb, FiltrDatEndWorksTb);
        }

        private void Search_Object_Tb_TextChanged(object sender, EventArgs e)
        {
            MethodsForObject.SearchObject.Search(ObjectsDataGridView, ListOfFiltrationObjects, CounterObjectL, Controls, SearchTextboxObject, FiltrDatStObTb, FiltrDatEndObTb);
        }
        #endregion

        #region DeleteButtons методы удаления строк таблицы

        private void DeeteMat_mat_ofBut_Click(object sender, EventArgs e)
        {
            MethodsForMaterialsOffered.DeleteMaterialsOffered.Delete(MaterialsOfferedDataGridView, out bool condition);
            if (condition)
                MethodsForMaterialsOffered.RefreshMaterialsOffered.Refresh(MaterialsOfferedDataGridView, CounterMaterialsOffL, Controls);
        }

        private void Work_DeleteButton_Click(object sender, EventArgs e)
        {
            MethodsForWorks.DeleteWorks.Delete(WorksDataGridView, out bool condition);
            if (condition)
                MethodsForWorks.RefreshWorks.Refresh(WorksDataGridView, CounterWorkL, Controls);

        }
        #endregion

        //готово
        #region CheckLists методы 
        private void RestoreFilt_MatOf_Click(object sender, EventArgs e)
        {
            ListOfFiltrationMaterialsOffered.RestoreAll();
            ListOfFiltrObjInMaterialsOffered.RestoreAll();
            ListOfFiltrationBrigadeName.RestoreAll();
            ListOfFiltrationBrigades.RestoreAll();
            ListOfFiltrationMaterials.RestoreAll();
            ListOfFiltrationObjects.RestoreAll();
            ListOfFiltrationWorks.RestoreAll();
            ListOfFiltrBrigInWorks.RestoreAll();
            FiltrMatOfDatGTb.Text = FiltrDatStWorksTb.Text = FiltrDatStWorksTb.Text = FiltrDatEndWorksTb.Text = FiltrDatStObTb.Text = FiltrDatEndObTb.Text = "";
        }
        #endregion

        #region Календари

        private void Change_mat_of_date_B_Click(object sender, EventArgs e)
        {
            CalendarForChangeMaterialsOffered.Color = Color.Red;
            MethodsForMaterialsOffered.ChangeCalendarMaterialsOffered.CalendarSavePrevious(mat_of_date_tb);
        }

        private void ChangeDatSt_WorksB_Click(object sender, EventArgs e)
        {
            CalendarForChangeWorks.Color = Color.Red;
            MethodsForWorks.ChangeCalendarWorks.CalendarSavePrevious(Work_DStartTb, Work_DEndTb);
        }

        private void ChangeDatSt_ObjB_Click(object sender, EventArgs e)
        {
            CalendarForChangeObjects.Color = Color.Red;
            MethodsForObject.ChangeCalendarObjects.CalendarSavePrevious(Obj_DstartTb, Obj_DEndTb);
        }

        private void FiltrationDateBut_Click(object sender, EventArgs e)
        {
            CalendarForChangeMaterialsOffered.Color = Color.Orange;
            MethodsForMaterialsOffered.FilterCalendarMaterialsOffered.CalendarSavePrevious(FiltrMatOfDatGTb);
        }

        private void FiltrDatStWorksB_Click(object sender, EventArgs e)
        {
            CalendarForChangeWorks.Color = Color.Orange;
            MethodsForWorks.FilterCalendarWorks.CalendarSavePrevious(FiltrDatStWorksTb, FiltrDatEndWorksTb);
        }

        private void FiltrDatStObB_Click(object sender, EventArgs e)
        {
            CalendarForChangeObjects.Color = Color.Orange;
            MethodsForObject.FilterCalendarObjects.CalendarSavePrevious(FiltrDatStObTb, FiltrDatEndObTb);
        }


        private void RevokeDatSt_WorksB_Click(object sender, EventArgs e)
        {
            Work_DStartTb.Text = CalendarForChangeWorks.DateStartSave;
        }

        private void RevokeDatEnd_WorksB_Click(object sender, EventArgs e)
        {
            Work_DEndTb.Text = CalendarForChangeWorks.DateEndSave;
        }
        private void Restore_mat_of_date_B_Click(object sender, EventArgs e)
        {
            mat_of_date_tb.Text = CalendarForChangeMaterialsOffered.DateSave;
        }

        private void RevokeDatSt_ObjB_Click(object sender, EventArgs e)
        {
            Obj_DstartTb.Text = CalendarForChangeObjects.DateStartSave;
        }

        private void RevokeDatEnd_ObjB_Click(object sender, EventArgs e)
        {
            Obj_DEndTb.Text = CalendarForChangeObjects.DateEndSave;
        }

        #endregion

        #region Проверка текстбоксов на правильные значения
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
        #endregion

        #region Проверка комбобокса на телефон
        private void CountrySpecForTelephoneCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextboxesScripts.Proverka(textBox_brwr_phone, CountrySpecForTelephoneCb);
        }
        #endregion

        #region Проверка текстбоксов телефона и емайла на правильный текст
        private void TextBox_brwr_phone_TextChanged(object sender, EventArgs e)
        {
            TextboxesScripts.WorkerTelephone(textBox_brwr_phone, WorkerPbCorrectPhon);
        }

        private void TextBox_brwr_email_TextChanged(object sender, EventArgs e)
        {
            TextboxesScripts.WorkerEmail(textBox_brwr_email, WorkerPbCorrectEmai);
        }
        #endregion

        #region Фильтрация
        private void FiltrInWorkerBut_Click(object sender, EventArgs e)
        {
            MethodsForWorkers.SearchWorkers.Search(WorkersDataGridView, ListOfFiltrationBrigadeName, CounterWorkerL, Controls, SearchTextboxWorkers);
        }

        private void FiltrInBrigBut_Click(object sender, EventArgs e)
        {
            MethodsForBrigades.SearchBrigades.Search(BrigadesDataGridView, ListOfFiltrationBrigades, CounterBrigL, Controls, SearchTextboxBrigades);
        }

        private void FiltrInMatBut_Click(object sender, EventArgs e)
        {
            MethodsForMaterials.SearchMaterials.Search(MaterialsDataGridView, ListOfFiltrationMaterials, CounterMaterialsL, Controls, SearchTextboxMaterials);
        }

        private void FiltrInObjBut_Click(object sender, EventArgs e)
        {
            MethodsForObject.SearchObject.Search(ObjectsDataGridView, ListOfFiltrationObjects, CounterObjectL, Controls, SearchTextboxObject, FiltrDatStObTb, FiltrDatEndObTb);
        }

        private void FiltrInWorksBut_Click(object sender, EventArgs e)
        {
            MethodsForWorks.SearchWorks.Search(WorksDataGridView, ListOfFiltrationWorks, ListOfFiltrBrigInWorks, CounterWorkL, Controls, SearchTextboxWorks, FiltrDatStWorksTb, FiltrDatEndWorksTb);
        }

        private void Filtr_MatOf_B_Click(object sender, EventArgs e)
        {
            MethodsForMaterialsOffered.SearchMaterialsOffered.Search(MaterialsOfferedDataGridView, ListOfFiltrationMaterialsOffered,
              ListOfFiltrObjInMaterialsOffered, CounterMaterialsOffL, Controls, SearchTextboxMaterialsOffered, FiltrMatOfDatGTb);
        }

        #endregion

    }
}
