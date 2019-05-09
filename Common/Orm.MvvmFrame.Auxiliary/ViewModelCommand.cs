using System;
using System.Diagnostics;

namespace Orm.MvvmFrame.Auxiliary
{
    public class ViewModelCommand : System.Windows.Input.ICommand
    {
        private Action<Object> action;

        public Action<Object> ViewModelAction
        {
            get { return action; }
            set { action = value; }
        }

        private Func<Object, bool> canAction;
        private Action getDataPagerPageChangedExecute1;

        public Func<Object, bool> CanAction
        {
            get { return canAction; }
            set { canAction = value; }
        }


        public ViewModelCommand(Action<Object> act)
        {
            action = act;
        }

        public ViewModelCommand(Action<Object> act, Func<Object, bool> canAct)
        {
            if (act == null)
                throw new ArgumentNullException("");

            action = act;
            canAction = canAct;
        }

        public ViewModelCommand(Action getDataPagerPageChangedExecute1)
        {
            this.getDataPagerPageChangedExecute1 = getDataPagerPageChangedExecute1;
        }

        [DebuggerStepThrough]
        public bool CanExecute(Object parameter)
        {
            return canAction == null ? true : canAction(parameter);
        }

        public void Execute(Object parameter)
        {

            this.ViewModelAction(parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add
            {
                if (canAction != null)
                    System.Windows.Input.CommandManager.RequerySuggested += value;
            }
            remove
            {
                if (canAction != null)
                    System.Windows.Input.CommandManager.RequerySuggested -= value;
            }
        }
    }
}
