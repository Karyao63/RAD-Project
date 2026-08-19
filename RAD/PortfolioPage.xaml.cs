namespace RAD; 

public partial class PortfolioPage : ContentPage
{
    public PortfolioPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        Card1.TranslationX = 200;
        Card2.TranslationX = 300;
        Card3.TranslationX = 400;
        Card4.TranslationX = 400;

        var card1Fade = Card1.FadeTo(1, 500, Easing.CubicOut);
        var card1Slide = Card1.TranslateTo(0, 0, 500, Easing.CubicOut);
        await Task.Delay(150);
        var card2Fade = Card2.FadeTo(1, 500, Easing.CubicOut);
        var card2Slide = Card2.TranslateTo(0, 0, 500, Easing.CubicOut);
        await Task.Delay(150);
        var card3Fade = Card3.FadeTo(1, 500, Easing.CubicOut);
        var card3Slide = Card3.TranslateTo(0, 0, 500, Easing.CubicOut);
        await Task.Delay(150);
        var card4Fade = Card4.FadeTo(1, 500, Easing.CubicOut);
        var card4Slide = Card4.TranslateTo(0, 0, 500, Easing.CubicOut);


        await Task.WhenAll(card1Fade, card1Slide, card2Fade, card2Slide, card3Fade, card3Slide, card4Fade, card4Slide);
    }


    private void ShowPopup(string title, string description, string tech)
    {
        PopupTitle.Text = title;
        PopupDescription.Text = description;
        PopupTech.Text = $"Built with: {tech}";

        PopupOverlay.IsVisible = true;
        PopupBox.Scale = 0.7; 

        PopupOverlay.FadeTo(1, 250);
        PopupBox.ScaleTo(1, 300, Easing.SpringOut);
    }

    private async void OnCard1Tapped(object sender, TappedEventArgs e)
    {
        ShowPopup(
            "Claims Detective",
            "A mini-game designed to boost customer retention and education. Users analyze interactive scenarios to determine claim eligibility.",
            "C#, .NET MAUI, XAML"
        );
    }

    private async void OnCard2Tapped(object sender, TappedEventArgs e)
    {
        ShowPopup(
            "Data Scraper",
            "An automated script that crawls Malaysian tech retailer websites to compile a real-time database of PC component prices.",
            "Python, BeautifulSoup"
        );
    }

    private async void OnCard3Tapped(object sender, TappedEventArgs e)
    {
        ShowPopup(
            "Face Recognition System",
            "A system that takes photos of students and recognize them to automatically take attendance.",
            "Python, Opencv-Python, Numpy, Pandas and etc"
        );
    }

    private async void OnCard4Tapped(object sender, TappedEventArgs e)
    {
        ShowPopup(
            "Neural Collaborative filtering recommendation system",
            "A system that is trained a dataset to recommend videos to users on a higher level",
            "Python, Pytorch and etc"
        );
    }

    private async void OnClosePopupClicked(object sender, EventArgs e)
    {
        await Task.WhenAll(
            PopupOverlay.FadeTo(0, 200),
            PopupBox.ScaleTo(0.8, 200, Easing.CubicIn)
        );

        PopupOverlay.IsVisible = false;
    }
}