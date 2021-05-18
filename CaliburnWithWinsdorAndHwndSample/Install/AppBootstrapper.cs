using CaliburnWithWinsdorAndHwndSample.ViewModels;
using System;
using Caliburn.Micro;
using System.Windows;
using Castle.Windsor;
using Castle.MicroKernel.Registration;
using CaliburnWithWinsdorAndHwndSample.Views;

namespace CaliburnWithWinsdorAndHwndSample.Install
{
    public class AppBootstrapper : BootstrapperBase
    {
        private IWindsorContainer _container;

        public AppBootstrapper()
        {
            Initialize();
        }

        protected override void Configure()
        {
            _container = new WindsorContainer();

            _container.Register(Component.For<IWindowManager>().ImplementedBy<WindowManager>().LifestyleSingleton());
            _container.Register(Component.For<IEventAggregator>().ImplementedBy<EventAggregator>().LifestyleSingleton());

            _container.Register(Component.For<ShellView>().ImplementedBy<ShellView>().LifestyleSingleton());
            _container.Register(Component.For<ShellViewModel>().ImplementedBy<ShellViewModel>().LifestyleSingleton());

            _container.Register(Component.For<ConfirmationBoxView>().ImplementedBy<ConfirmationBoxView>().LifestyleSingleton());
            _container.Register(Component.For<ConfirmationBoxViewModel>().ImplementedBy<ConfirmationBoxViewModel>().LifestyleSingleton());


        }

        protected override object GetInstance(Type service, string key)
        {
            var instance = _container.Resolve(service);
            if (instance != null)
                return instance;

            throw new InvalidOperationException("Could not locate any instances.");
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}