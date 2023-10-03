

namespace PM02_Ejercicio_1._1
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnsuma_Clicked(object sender, EventArgs e)
        {
            // await DisplayAlert("Resultado", Convert.ToString(Convert.ToDecimal(num1.Text) + Convert.ToDecimal(num2.Text)), "OK");

            double numero1 = Convert.ToDouble( num1.Text);
            double numero2 = Convert.ToDouble( num2.Text);

            double resultado = numero1 + numero2;

            await Navigation.PushAsync(new Pagina2(resultado));

        }

        private async void btnresta_Clicked(object sender, EventArgs e)
        {
            //await DisplayAlert("Resultado", Convert.ToString(Convert.ToDecimal(num1.Text) - Convert.ToDecimal(num2.Text)), "OK");

            double numero1 = Convert.ToDouble(num1.Text);
            double numero2 = Convert.ToDouble(num2.Text);

            double resultado = numero1 - numero2;

            await Navigation.PushAsync(new Pagina2(resultado));
        }

        private async void btnmulti_Clicked(object sender, EventArgs e)
        {
            //await DisplayAlert("Resultado", Convert.ToString(Convert.ToDecimal(num1.Text) * Convert.ToDecimal(num2.Text)), "OK");

            double numero1 = Convert.ToDouble(num1.Text);
            double numero2 = Convert.ToDouble(num2.Text);

            double resultado = numero1 * numero2;

            await Navigation.PushAsync(new Pagina2(resultado));
        }

        private async void btnDivi_Clicked(object sender, EventArgs e)
        {
            //await DisplayAlert("Resultado", Convert.ToString(Convert.ToDecimal(num1.Text) / Convert.ToDecimal(num2.Text)), "OK");

            double numero1 = Convert.ToDouble(num1.Text);
            double numero2 = Convert.ToDouble(num2.Text);

            double resultado = numero1 / numero2;

            await Navigation.PushAsync(new Pagina2(resultado));

        }
    }
}