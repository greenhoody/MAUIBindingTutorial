using MAUIBindingTutorial.Models;

namespace MAUIBindingTutorial;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
    {
        var toad = new Animal()
        {
            Name = "Toad",
            Info = "Just toad"
        };
        /*
        //Creates the binding
        Binding animalBinding = new Binding();
        //Defines data source
        animalBinding.Source = toad;
        //Defines the name of the property that is shared
        //between the source and control
        animalBinding.Path = "Name";

        labelName.SetBinding(Label.TextProperty, animalBinding);
        */

        BindingContext = toad;
    }
}

