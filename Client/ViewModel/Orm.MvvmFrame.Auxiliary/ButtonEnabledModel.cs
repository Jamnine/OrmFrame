using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Orm.MvvmFrame.Auxiliary
{
    public class ButtonEnabledModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool _previous = true;
        private bool _next = true;
        private bool _search = true;
        private bool _add = true;
        private bool _modify = true;
        private bool _delete = true;
        private bool _save = true;
        private bool _cancel = true;
        private bool _audit = true;
        private bool _refresh = true;
        private bool _print = true;
        private bool _export = true;
        private bool _end = true;
        private bool _cancelAudit = true;
        public bool Previous
        {
            get { return _previous; }
            set
            {
                this.SetProperty(ref _previous, value);
            }
        }
        public bool Next
        {
            get { return _next; }
            set
            {
                this.SetProperty(ref _next, value);
            }
        }
        public bool Search
        {
            get { return _search; }
            set
            {
                this.SetProperty(ref _search, value);
            }
        }
        public bool Add
        {
            get { return _add; }
            set
            {
                this.SetProperty(ref _add, value);
            }
        }
        public bool Modify
        {
            get { return _modify; }
            set
            {
                this.SetProperty(ref _modify, value);
            }
        }
        public bool Delete
        {
            get { return _delete; }
            set
            {
                this.SetProperty(ref _delete, value);
            }
        }
        public bool Save
        {
            get { return _save; }
            set
            {
                this.SetProperty(ref _save, value);
            }
        }
        public bool Cancel
        {
            get { return _cancel; }
            set
            {
                this.SetProperty(ref _cancel, value);
            }
        }
        public bool Audit
        {
            get { return _audit; }
            set
            {
                this.SetProperty(ref _audit, value);
            }
        }
        public bool CancelAudit
        {
            get { return _cancelAudit; }
            set
            {
                this.SetProperty(ref _cancelAudit, value);
            }
        }
        public bool Refresh
        {
            get { return _refresh; }
            set
            {
                this.SetProperty(ref _refresh, value);
            }
        }
        public bool Print
        {
            get { return _print; }
            set
            {
                this.SetProperty(ref _print, value);
            }
        }
        public bool Export
        {
            get { return _export; }
            set
            {
                this.SetProperty(ref _export, value);
            }
        }
        public bool End
        {
            get { return _end; }
            set
            {
                this.SetProperty(ref _end, value);
            }
        }
        protected bool SetProperty<T>(ref T storage, T value, bool isCheckEquals = true, [CallerMemberName] string propertyName = null)
        {
            if (isCheckEquals)
                if (object.Equals(storage, value)) { return false; }
            storage = value;
            this.OnPropertyChanged(propertyName);
            return true;
        }
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var eventHandler = this.PropertyChanged;
            if (eventHandler != null)
            {
                eventHandler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
