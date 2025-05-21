using XmlnsSimple.Models;
using XmlnsSimple.PageModels;

namespace XmlnsSimple.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}