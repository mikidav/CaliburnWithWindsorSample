using Caliburn.Micro;


namespace CaliburnWithWinsdorSample.ViewModels
{
    public class ShellViewModel : Conductor<IScreen>.Collection.AllActive
    {

        public ShellViewModel(IWindowManager windowManager)
        {
            WindowManager = windowManager;
        }
        private string m_name;

        public string Name
        {
            get { return m_name; }
            set
            {
                m_name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public bool CanSayHello
        {
            get { return !string.IsNullOrWhiteSpace(Name); }
        }

        public IWindowManager WindowManager { get; private set; }

        public async void SayHello()
        {

            var box = new ConfirmationBoxViewModel();
            var result =await  WindowManager.ShowDialogAsync(box);
            if (result == true)
            {
                // OK was clicked
            }
            //  MessageBox.Show(string.Format("Hello {0}!", Name)); //Don't do this in real life :)
        }
    }
}
