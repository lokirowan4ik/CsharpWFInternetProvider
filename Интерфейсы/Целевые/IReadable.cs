using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая.Интерфейсы.Целевые
{
    internal interface IReadable
    {
        void ReaderAndCountAllRows(DataGridView data, Label lbl, SqlCommand command);
        void ReadSingleRows(DataGridView dat, IDataRecord record);
        void CheckboxesIfnormal(DataGridView data,  Label lbl, Control.ControlCollection collection, string query, string searchquery, string dat1, string listquery1, string listquery2);
        void CheckboxesIfnormal(DataGridView data,  Label lbl, Control.ControlCollection collection, string query, string searchquery, string dat1, string dat2, string listquery1, string listquery2);
        void CheckboxesIfnormal(DataGridView data,  Label lbl, Control.ControlCollection collection, string query, string searchquery, string listquery1);
    }
}
