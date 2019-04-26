using Orm.MvvmFrame.Auxiliary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Orm.Config.Service.DBClientService.GetAllList<Orm.Model.BsHospital>();
        }

        private string _test;
        /// <summary>
        /// 是否在打印状态，即新增或修改状态
        /// </summary>
        public string Test { get { return _test; } set { this.SetProperty(ref _test, value); } }

        public ICommand TestCommand { get; private set; }
    }
}
