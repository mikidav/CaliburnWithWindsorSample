using Caliburn.Micro;

namespace CaliburnWithWinsdorAndHwndSample.ViewModels
{
    internal class ConfirmationBoxViewModel : Screen
    {
        private string text = "AAA";

        public ConfirmationBoxViewModel()
        {

        }

        public string Text
        {
            get => text; set
            {
                text = value;
                NotifyOfPropertyChange(() => Text);
                NotifyOfPropertyChange(() => CanOk);
            }
        }

        public bool CanOk
        {
            get { return !string.IsNullOrWhiteSpace(Text); }
        }

        public async void Ok()
        {
            await TryCloseAsync(true);
        }

        public async void Cancel()
        {
            await TryCloseAsync(false);
        }


    }
}