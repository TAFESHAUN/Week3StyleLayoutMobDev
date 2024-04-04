namespace Week4;

public partial class OtherPage : ContentPage
{
	public OtherPage()
	{
		InitializeComponent();

        if (entry.Text == null)
        {
            btn.IsEnabled = false;
        }

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        string input;
        input = entry.Text.ToString();
        changer.Text = input;
    }

    private void entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (entry.Text != null)
        {
            btn.IsEnabled = true;
        }
        else { btn.IsEnabled = false; }
    }
}