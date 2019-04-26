using Orm.MvvmFrame.Auxiliary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Orm.Config;

namespace OrmFrameClientViewModel
{
    public class OrmFrameClientViewModel : ViewModelBase
    {
        public OrmFrameClientViewModel()
        {
            Init();
        }

        private void Init()
        {
            this.TestCommand = new ViewModelCommand((object parameter) =>
            {
                this.TestCommandExecute(parameter);
            });
        }

        private void TestCommandExecute(object parameter)
        {
            var bsHospital = Orm.Config.Service.DBClientService.GetAllList<Orm.Model.BsHospital>();
        }

        private string _test;
        
        public string Test { get { return _test; } set { this.SetProperty(ref _test, value); } }

        public ICommand TestCommand { get; private set; }
    }
}
