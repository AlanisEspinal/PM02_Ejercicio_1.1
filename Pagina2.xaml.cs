namespace PM02_Ejercicio_1._1;

public partial class Pagina2 : ContentPage
{
	public Pagina2(double resultado)
	{
		InitializeComponent();

		Label resultadoLabel = new Label{
			Text = $"El resultado es: {resultado}"
		};

        Content = new StackLayout
        {
            Children = { resultadoLabel }
        };
    }
}