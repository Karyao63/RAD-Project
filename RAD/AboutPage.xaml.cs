namespace RAD; 

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        Skill1.Scale = 0.5;
        Skill2.Scale = 0.5;
        Skill3.Scale = 0.5;

        var s1Fade = Skill1.FadeTo(1, 400, Easing.SpringOut);
        var s1Scale = Skill1.ScaleTo(1, 400, Easing.SpringOut);

        await Task.Delay(100); 

        var s2Fade = Skill2.FadeTo(1, 400, Easing.SpringOut);
        var s2Scale = Skill2.ScaleTo(1, 400, Easing.SpringOut);

        await Task.Delay(100); 

        var s3Fade = Skill3.FadeTo(1, 400, Easing.SpringOut);
        var s3Scale = Skill3.ScaleTo(1, 400, Easing.SpringOut);

        await Task.WhenAll(s1Fade, s1Scale, s2Fade, s2Scale, s3Fade, s3Scale);
    }
}