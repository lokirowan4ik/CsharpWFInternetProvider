namespace Курсовая.Интерфейсы.Целевые
{
    internal interface IComboboxable
    {
        public void ComboboxObjName(ComboBox box);
        public void ComboboxBrigadeName(ComboBox box);
        public void ComboboxMaterials(ComboBox box);
        public void ComboboxWorks(ComboBox box);
        public void ComboboxCityKey(ComboBox city);
        public void ComboboxStatus(ComboBox status);
        public void ComboboxGender(ComboBox gender);
        public void ComboboxSelectedBrname(ComboBox brname, ComboBox box);
        void GetCountMaterialsToLabel(Label lab, ComboBox box);
    }
}
