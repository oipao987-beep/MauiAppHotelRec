namespace MauiAppHotelRec.Views;

public partial class ContrataçãoHospedagem : ContentPage
{
    public ContrataçãoHospedagem()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        {
            try
            {
               await Navigation.PushAsync(new Sobre1());

            }catch (Exception ex)

            {
               await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}