using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaikeiSystemBody.controllers.popup
{
    abstract class AbstractMTPopupController
    {
        private views.popup.IMTGridPopup popup;
        private string sortKey;
        private string firstChar;


        public models.Context Context {
            get;
            set;
        }


        public event Action<string> RowClicked;


        public AbstractMTPopupController() {
        }


        protected abstract views.popup.IMTGridPopup CreatePopup();
        protected abstract string GetInitialSortKey();
        protected abstract void SetGridRows(string sortKey, string firstChar);
        protected abstract void SetFirstCharList();

        public void ShowPopup(System.Windows.Forms.Form owner) {
            if (popup != null) {
                return;
            }

            popup = CreatePopup();
            popup.ChangeSortKey += ChangeSortKey;
            popup.ChangeFirstChar += ChangeFirstChar;
            popup.RowClicked += OnRowClicked;
            popup.PopupClosed += Closed;


            sortKey = "";
            firstChar = null;

            ChangeSortKey(GetInitialSortKey());
            SetGridRows(sortKey, firstChar);
            SetFirstCharList();
            popup.ShowPopup(owner);
        }


        public void ClosePopup() {
            if (popup != null) {
                (popup as System.Windows.Forms.Form).Close();
            }
        }


        // events

        private void ChangeSortKey(string newKey) {
            if (sortKey == newKey) {
                return;
            }

            sortKey = newKey;
            SetGridRows(sortKey, null);
            popup.ChangeSortKeySelection(sortKey);
        }


        private void ChangeFirstChar(string newFirstChar) {
            if (firstChar == newFirstChar) {
                return;
            }

            if (newFirstChar == null || newFirstChar.Length == 0) {
                firstChar = null;
            }
            else {
                firstChar = newFirstChar;
            }

            SetGridRows(sortKey, firstChar);
        }

        private void OnRowClicked() {
            if (RowClicked != null) {
                RowClicked(popup.SelectedKey);
            }
        }


        private void Closed() {
            popup = null;
        }
    }
}
