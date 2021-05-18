using Caliburn.Micro;

namespace CaliburnWithWinsdorSample.ViewModels
{
    internal class ConfirmationBoxViewModel : Screen
    {
        public ConfirmationBoxViewModel()
        {

        }

        public string Text { get; set; } = "AAA";
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