using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.views.popup
{
    interface IMTGridPopup
    {
        event Action RowClicked;
        event Action PopupClosed;
        event Action<string> ChangeSortKey;
        event Action<string> ChangeFirstChar;

        string SelectedKey { get; }

        void ShowPopup(System.Windows.Forms.Form owner);

        void ClearGrid();
        void AddGridRow(string code, string kamoku);
        void ClearFirstCharList();
        void AddFirstCharListItem(string key);

        void ChangeSortKeySelection(string key);
    }
}
