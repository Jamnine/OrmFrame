using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace Orm.MvvmFrame.Auxiliary
{

    public class MapEventToCommand : MapEventToCommandBase<EventArgs>
    {
    }

    public class MapRoutedEventToCommand : MapEventToCommandBase<RoutedEventArgs>
    {
    }

    public abstract class MapEventToCommandBase<TEventArgsType> : TriggerAction<DependencyObject> where TEventArgsType : EventArgs
    {
        private readonly static Type _selfType = typeof(MapEventToCommandBase<TEventArgsType>);

        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register("Command", typeof(ICommand), _selfType, null);

        public static readonly DependencyProperty CommandParameterProperty = DependencyProperty.Register("CommandParameter", typeof(object), typeof(MapEventToCommandBase<TEventArgsType>), null);

        private string _commandName;

        public string CommandName
        {
            get { base.ReadPreamble(); return this._commandName; }
            set { if (this._commandName != value) { base.WritePreamble(); this._commandName = value; base.WritePostscript(); } }
        }

        public ICommand Command
        {
            get { return (ICommand)base.GetValue(CommandProperty); }
            set
            {
                base.SetValue(CommandProperty, value);
            }
        }

        public object CommandParameter
        {
            get { return base.GetValue(CommandParameterProperty); }
            set { base.SetValue(CommandParameterProperty, value); }
        }

        protected override void Invoke(object parameter)
        {
            if (base.AssociatedObject != null)
            {
                ICommand command = this.ResolveCommand();
                EventInformation<TEventArgsType> eventInfo = new EventInformation<TEventArgsType>
                {
                    EventArgs = parameter as TEventArgsType,
                    Sender = base.AssociatedObject,
                    CommandArgument = GetValue(CommandParameterProperty)
                };

                if (command != null && command.CanExecute(eventInfo))
                {
                    command.Execute(eventInfo);
                }
            }
        }

        private ICommand ResolveCommand()
        {

            ICommand command = null;
            if (this.Command != null)
            {
                command = this.Command;
            }
            else
            {
                if (base.AssociatedObject != null)
                {
                    Type type = base.AssociatedObject.GetType();
                    PropertyInfo[] propertyArray = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
                    for (int i = 0; i < propertyArray.Length; i++)
                    {
                        PropertyInfo propertyInfo = propertyArray[i];
                        if (typeof(ICommand).IsAssignableFrom(propertyInfo.PropertyType) && string.Equals(propertyInfo.Name, this.CommandName, StringComparison.Ordinal))
                        {
                            command = (ICommand)propertyInfo.GetValue(base.AssociatedObject, null);
                        }
                    }
                }

            }

            return command;
        }

    }

}
