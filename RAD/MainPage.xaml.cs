namespace RAD; 

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        MainContent.Opacity = 0;

        await MainContent.FadeTo(1, 1200, Easing.CubicOut);
    }

    private async void OnViewWorkClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;

        await button.ScaleTo(0.9, 100);

        await button.ScaleTo(1.0, 100, Easing.BounceOut);

        await Task.Delay(150);

        await Shell.Current.GoToAsync("//PortfolioPage");
    }
}