namespace Курсовая.Интерфейсы.Целевые
{
    internal interface ISearchable
    {
        void Search(DataGridView data, CheckedListBox listitem1, Label lbl, Control.ControlCollection collection, TextBox search);
        void Search(DataGridView data, CheckedListBox listitem1, Label lbl, Control.ControlCollection collection, TextBox search, TextBox dat1, TextBox dat2);
        void Search(DataGridView data, CheckedListBox listitem1, CheckedListBox listitem2, Label lbl, Control.ControlCollection collection, TextBox search, TextBox datasearch);
        void Search(DataGridView data, CheckedListBox listitem1, CheckedListBox listitem2, Label lbl, Control.ControlCollection collection, TextBox search, TextBox datasearch1,TextBox datasearch2);
    }
    internal interface IRefreshable
    {
        void Refresh(DataGridView dat, Label lbl, Control.ControlCollection controls);
        void Refresh(DataGridView dat, Label lbl, Label sum, Control.ControlCollection controls);
    }
    internal interface ICheckboxable
    {
        void Checkboxes(CheckedListBox listitem);
    }

}
