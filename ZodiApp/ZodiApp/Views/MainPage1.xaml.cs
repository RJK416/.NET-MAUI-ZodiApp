namespace ZodiApp.Views;

public partial class MainPage1 : ContentPage
{
    public MainPage1()
    {
        InitializeComponent();
    }

    private async void OnNavigateToDetailsPageClicked(object sender, EventArgs e)
    {
        // Use Shell navigation if applicable
        await Navigation.PushAsync(new DetailsPage());
        // If using Shell, use the following line instead:
        // await Shell.Current.GoToAsync("//DetailsPage");
    }
}