using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;

namespace Orm.Toolkit
{
    public class DownloadsControl : Control
    {
        static DownloadsControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DownloadsControl), new FrameworkPropertyMetadata(typeof(DownloadsControl)));
        }

        public IEnumerable<DownloadItem> Source
        {
            get { return (IEnumerable<DownloadItem>)this.GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source",
            typeof(IEnumerable<DownloadItem>), typeof(DownloadsControl),
            new FrameworkPropertyMetadata(null, SourceChanged));

        private static void SourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DownloadsControl owner = (DownloadsControl)d;
            IEnumerable<DownloadItem> oldValue = (IEnumerable<DownloadItem>)e.OldValue;
            IEnumerable<DownloadItem> value = (IEnumerable<DownloadItem>)e.NewValue;

            if (oldValue != null)
                foreach (DownloadItem de in oldValue)
                    de.Dispose();
        }
    }
}
