using Курсовая;

abstract class RefreshableBase : IRefreshable, ICheckboxable, IReadable, ISearchable
{
    public virtual void Checkboxes(CheckedListBox listitem)
    {
        throw new NotImplementedException();
    }

    public virtual void CheckboxesIfnormal(DataGridView data, Label lbl, Control.ControlCollection controls, string query, string listquery1, string listquery2, string searchquery, string datquery)
    {
        if (listquery1.Length > 0 || listquery2.Length > 0 || searchquery.Length > 0 || datquery.Length > 0)
        {
            string fullQuery = query + $"WHERE 1=1 " + listquery1 + listquery2 + searchquery + datquery;
            data.Rows.Clear();
            SqlCommand command = new(fullQuery, DataBase.GetConnection());
            ReaderAndCountAllRows(data, lbl, command);
        }
        else
        {
            Refresh(data, lbl, controls);
        }
    } 
    public virtual void CheckboxesIfnormal(DataGridView data, Label lbl, Control.ControlCollection controls, string query, string listquery1, string listquery2, string searchquery, string dat1, string dat2)
    {
        if (listquery1.Length > 0 || listquery2.Length > 0 || searchquery.Length > 0 || dat1.Length >0 || dat2.Length >0)
        {
            string fullQuery = query + $"WHERE 1=1 " + listquery1 + listquery2 + searchquery + dat1 + dat2;
            data.Rows.Clear();
            SqlCommand command = new(fullQuery, DataBase.GetConnection());
            ReaderAndCountAllRows(data, lbl, command);
        }
        else
        {
            Refresh(data, lbl, controls);
        }
    }

    public virtual void CheckboxesIfnormal(DataGridView data, Label lbl, Control.ControlCollection controls, string selectlist, string querylist, string searchquery)
    {
        if (querylist.Length > 0 || searchquery.Length > 0)
        {
            string fullQuery = selectlist + querylist + searchquery;
            data.Rows.Clear();
            SqlCommand command = new(fullQuery, DataBase.GetConnection());
            ReaderAndCountAllRows(data, lbl, command);
        }
        else
        {
            Refresh(data, lbl, controls);
        }
    } 

    public virtual void ReadSingleRows(DataGridView dat, IDataRecord record)
    {
        throw new NotImplementedException();
    }

    public virtual void ReaderAndCountAllRows(DataGridView data, Label lbl, SqlCommand command)
    {
        DataBase.OpenConnection();
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            ReadSingleRows(data, reader);
        }
        reader.Close();
        DataBase.CloseConnection();
        lbl.Count(data);
    }

    public virtual void Refresh(DataGridView dat, Label lbl, Control.ControlCollection controls)
    {
        throw new NotImplementedException();
    }

    public virtual void Refresh(DataGridView dat, Label lbl, Label sum, Control.ControlCollection controls)
    {
        throw new NotImplementedException();
    }

    public virtual void Search(DataGridView data, CheckedListBox listitem1, Label lbl, Control.ControlCollection collection, TextBox search)
    {
        throw new NotImplementedException();
    }
    public virtual void Search(DataGridView data, CheckedListBox listitem1, Label lbl, Control.ControlCollection collection, TextBox search, TextBox dat1, TextBox dat2)
    {
        throw new NotImplementedException();
    }

    public virtual void Search(DataGridView data, CheckedListBox listitem1, CheckedListBox listitem2, Label lbl, Control.ControlCollection collection, TextBox search, TextBox dat1)
    {
        throw new NotImplementedException();
    } 
    public virtual void Search(DataGridView data, CheckedListBox listitem1, CheckedListBox listitem2, Label lbl, Control.ControlCollection collection, TextBox search, TextBox dat1, TextBox dat2)
    {
        throw new NotImplementedException();
    }
}

