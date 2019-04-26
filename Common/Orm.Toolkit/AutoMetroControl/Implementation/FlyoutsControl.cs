using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Orm.Toolkit.Metro;

namespace Orm.Toolkit
{
    [StyleTypedProperty(Property = "ItemContainerStyle", StyleTargetType = typeof(Flyout))]
    public class FlyoutsControl : ItemsControl
    {
        static FlyoutsControl()
        {
            FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(FlyoutsControl), new FrameworkPropertyMetadata(typeof(FlyoutsControl)));
        }

        private void AttachHandlers(Flyout item)
        {
            DependencyPropertyDescriptor descriptor = DependencyPropertyDescriptor.FromProperty(Flyout.IsOpenProperty, typeof(Flyout));
            DependencyPropertyDescriptor descriptor2 = DependencyPropertyDescriptor.FromProperty(Flyout.ThemeProperty, typeof(Flyout));
            descriptor.AddValueChanged(item, new EventHandler(this.FlyoutStatusChanged));
            descriptor2.AddValueChanged(item, new EventHandler(this.FlyoutStatusChanged));
        }

        private void AttachHandlers(IEnumerable<Flyout> items)
        {
            foreach (Flyout flyout in items)
            {
                this.AttachHandlers(flyout);
            }
        }

        private void DetachHandlers(Flyout item)
        {
            DependencyPropertyDescriptor descriptor = DependencyPropertyDescriptor.FromProperty(Flyout.IsOpenProperty, typeof(Flyout));
            DependencyPropertyDescriptor descriptor2 = DependencyPropertyDescriptor.FromProperty(Flyout.ThemeProperty, typeof(Flyout));
            descriptor.RemoveValueChanged(item, new EventHandler(this.FlyoutStatusChanged));
            descriptor2.RemoveValueChanged(item, new EventHandler(this.FlyoutStatusChanged));
        }

        private void DetachHandlers(IEnumerable<Flyout> items)
        {
            foreach (Flyout flyout in items)
            {
                this.DetachHandlers(flyout);
            }
        }

        private void FlyoutStatusChanged(object sender, EventArgs e)
        {
            Flyout lastChanged = this.GetFlyout(sender);
            this.ReorderZIndices(lastChanged);
            MetroControl window = this.TryFindParent<MetroControl>();
            if (window != null)
            {
                IOrderedEnumerable<Flyout> visibleFlyouts = (from i in this.GetFlyouts(base.Items)
                                                             where i.IsOpen
                                                             select i).OrderBy<Flyout, int>(new Func<Flyout, int>(Panel.GetZIndex));
                window.HandleFlyoutStatusChange(lastChanged, visibleFlyouts);
            }
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new Flyout();
        }

        private Flyout GetFlyout(object item)
        {
            Flyout flyout = item as Flyout;
            if (flyout != null)
            {
                return flyout;
            }
            return (Flyout)base.ItemContainerGenerator.ContainerFromItem(item);
        }

        internal IEnumerable<Flyout> GetFlyouts()
        {
            return this.GetFlyouts(base.Items);
        }

        private IEnumerable<Flyout> GetFlyouts(IEnumerable items)
        {
            return (from item in items.Cast<object>() select this.GetFlyout(item));
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return (item is Flyout);
        }

        protected override void OnItemsChanged(NotifyCollectionChangedEventArgs e)
        {
            base.OnItemsChanged(e);
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    this.AttachHandlers(this.GetFlyouts(e.NewItems));
                    return;

                case NotifyCollectionChangedAction.Remove:
                    this.DetachHandlers(this.GetFlyouts(e.OldItems));
                    return;

                case NotifyCollectionChangedAction.Replace:
                    this.AttachHandlers(this.GetFlyouts(e.NewItems));
                    this.DetachHandlers(this.GetFlyouts(e.OldItems));
                    return;

                case NotifyCollectionChangedAction.Move:
                    break;

                case NotifyCollectionChangedAction.Reset:
                    {
                        List<Flyout> items = this.GetFlyouts(base.Items).ToList<Flyout>();
                        this.DetachHandlers(items);
                        this.AttachHandlers(items);
                        break;
                    }
                default:
                    return;
            }
        }

        private void ReorderZIndices(Flyout lastChanged)
        {
            IOrderedEnumerable<Flyout> enumerable = (from i in this.GetFlyouts(base.Items)
                                                     where i.IsOpen && (i != lastChanged)
                                                     select i).OrderBy<Flyout, int>(new Func<Flyout, int>(Panel.GetZIndex));
            int num = 0;
            foreach (Flyout flyout in enumerable)
            {
                Panel.SetZIndex(flyout, num);
                num++;
            }
            if (lastChanged.IsOpen)
            {
                Panel.SetZIndex(lastChanged, num);
            }
        }
    }
}
