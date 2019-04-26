using System;
using System.ComponentModel;

namespace Orm.Toolkit
{
    public class Day : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private DateTime date;
        private string notes;
        private bool enabled;
        private bool isTargetMonth;
        private bool isToday;

        private System.Windows.FrameworkElement visual;
        //    new System.Windows.Controls.TextBox {
        //    Background = null, 
        //    AcceptsReturn=true,
        //    TextWrapping= System.Windows.TextWrapping.Wrap,
        //    BorderThickness=new System.Windows.Thickness(0),
        //    VerticalScrollBarVisibility= System.Windows.Controls.ScrollBarVisibility.Auto,
        //    Foreground=new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.White),
        //};
        
        public bool IsToday
        {
            get { return isToday; }
            set
            {
                isToday = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IsToday"));
            }
        }

        public bool IsTargetMonth
        {
            get { return isTargetMonth; }
            set
            {
                isTargetMonth = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IsTargetMonth"));
            }
        }

        public bool Enabled
        {
            get { return enabled; }
            set
            {
                enabled = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Enabled"));
            }
        }

        public string Notes
        {
            get { return notes; }
            set
            {
                notes = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Notes"));
            }
        }

        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Date"));
            }
        }

        public System.Windows.FrameworkElement Visual
        {
            get{ return visual;}
            set{
               
                visual=value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Visual"));
            }
        }

    }
}