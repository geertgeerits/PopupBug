using CommunityToolkit.Maui.Extensions;

namespace PopupBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object? sender, EventArgs e)
        {
            // Show a modal popup to fill in the details for the selected payload type before generating the payload and setting it in the editor
            Page? currentPage = Application.Current?.Windows.Count > 0 ? Application.Current.Windows[0]?.Page : null;
            if (currentPage != null)
            {
                _ = await currentPage.ShowPopupAsync(new PopupTest());
            }
        }
    }
}
