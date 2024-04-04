namespace Week4;

public partial class NewPage : ContentPage
{
	public NewPage()
	{
		InitializeComponent();
	}

    async private void Button_Clicked(object sender, EventArgs e)
    {
        ShowTheMsg();
        await Shell.Current.GoToAsync("//MainPage");
    }

    async private void ShowTheMsg()
    {
        await DisplayAlert("Back Home", "You are on your way home", "Bye");
        //Update this to show what they picked before we nav back
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        //var list = picker.ItemsSource as List<string>;

        var pick = picker.SelectedItem as string;

        ti.Text = pick;
    }
}