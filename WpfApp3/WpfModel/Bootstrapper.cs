using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfModel.ViewModels;

namespace WpfModel
{
    public class Bootstrapper: BootstrapperBase
    {

        private readonly SimpleContainer _container = new SimpleContainer();

        public Bootstrapper()
        {
            Initialize();
        }
         

        protected override object GetInstance(Type serviceType, string key)
        {
            return _container.GetInstance(serviceType, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return _container.GetAllInstances(serviceType);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        protected override void Configure()
        {

            base.Configure();  

            _container.Singleton<IWindowManager, WindowManager>();
            _container.Singleton<IEventAggregator, EventAggregator>();
            _container.Singleton<DataGridViewModel>();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            try
            {
                base.OnStartup(sender, e);
                DisplayRootViewFor<DataGridViewModel>();
                //DisplayRootViewFor<ComboBoxTestViewModel>();
            }
            catch (Exception ex)
            {
            }
        }

        //protected override IEnumerable<Assembly> SelectAssemblies()
        //{
        //    var assemblies = base.SelectAssemblies().ToList();
        //    assemblies.Add(typeof(ShellViewModel).Assembly);
        //    return assemblies;
        //}
    }
}
