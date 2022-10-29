using AndroidBookAPI.Services;

namespace AndroidBookAPI;

public partial class App : Application
{

    const int WindowWidth = 500;
    const int WindowHeight = 600;
    public App()
	{
		InitializeComponent();
        DependencyService.Register<BooksDataStoreAPI>();
        DependencyService.Register<WebClientServices>();

        


        MainPage = new AppShell();
	}
}

