using Orm.Config;
using Orm.Model;
using Orm.MvvmFrame.Auxiliary;
using System.Collections.Generic;
using System.Windows.Input;

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
            //本地模式
            //List<BsHospital> debugBsHospital = Orm.Config.Service.DBClientService.GetAllList<BsHospital>();
            //本地模式服务端
            //List<BsHospital> debugServiceBsHospital = Service.TestDemoServices.GetLocHouseRoomName();
            //代理服务端
            List<BsHospital> proxyServiceBsHospital = Service.TestDemoServices.GetLocHouseRoomName();
        }

        private string _test;

        public string Test { get { return _test; } set { this.SetProperty(ref _test, value); } }

        public ICommand TestCommand { get; private set; }
    }
}
