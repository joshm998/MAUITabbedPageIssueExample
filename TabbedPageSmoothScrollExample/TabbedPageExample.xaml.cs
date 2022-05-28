using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using TabbedPage = Microsoft.Maui.Controls.TabbedPage;

namespace TabbedPageSmoothScrollExample;

public partial class TabbedPageExample : TabbedPage
{
	public TabbedPageExample()
	{
        On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsSmoothScrollEnabled(false);
        On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetIsSwipePagingEnabled(false);
        NavigationPage dashboardNav = new NavigationPage(new MainPage());
        dashboardNav.Title = "Page 1";
        dashboardNav.IconImageSource = "dotnet_bot.svg";

        NavigationPage discoverNav = new NavigationPage(new MainPage());
        discoverNav.Title = "Page 2";
        discoverNav.IconImageSource = "dotnet_bot.svg";

        NavigationPage myDecksNav = new NavigationPage(new MainPage());
        myDecksNav.Title = "Page 3";
        myDecksNav.IconImageSource = "dotnet_bot.svg";

        NavigationPage settingsNav = new NavigationPage(new MainPage());
        settingsNav.Title = "Page 4";
        settingsNav.IconImageSource = "dotnet_bot.svg";

        Children.Add(dashboardNav);
        Children.Add(discoverNav);
        Children.Add(myDecksNav);
        Children.Add(settingsNav);
        InitializeComponent();
	}
}