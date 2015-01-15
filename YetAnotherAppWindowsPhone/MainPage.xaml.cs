using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using YetAnotherAppWindowsPhone.Resources;
using System.Collections.ObjectModel;

namespace YetAnotherAppWindowsPhone
{


  public partial class MainPage : PhoneApplicationPage
  {
    ObservableCollection<string> Monkeys = new ObservableCollection<string>();
    // Constructor
    public MainPage()
    {
      InitializeComponent();

      Monkeys.Add("/Assets/a.jpg");
      Monkeys.Add("/Assets/b.jpg");
      Monkeys.Add("/Assets/c.jpg");
      Monkeys.Add("/Assets/d.jpg");
      Monkeys.Add("/Assets/e.jpg");
      Monkeys.Add("/Assets/f.jpg");
      Monkeys.Add("/Assets/g.jpg");
      Monkeys.Add("/Assets/h.jpg");
      Monkeys.Add("/Assets/i.jpg");
      Monkeys.Add("/Assets/j.jpg");
      Monkeys.Add("/Assets/k.jpg");
      Monkeys.Add("/Assets/l.jpg");
      Monkeys.Add("/Assets/m.jpg");
      Monkeys.Add("/Assets/n.jpg");
      Monkeys.Add("/Assets/o.jpg");
      Monkeys.Add("/Assets/p.jpg");
      Monkeys.Add("/Assets/q.jpg");
      Monkeys.Add("/Assets/r.jpg");
      Monkeys.Add("/Assets/s.jpg");
      Monkeys.Add("/Assets/t.jpg");
      Monkeys.Add("/Assets/u.jpg");
      DataContext = Monkeys;

      LongList.SelectionChanged += LongList_SelectionChanged;
      // Sample code to localize the ApplicationBar
      //BuildLocalizedApplicationBar();
    }

    void LongList_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      var img = LongList.SelectedItem.ToString();
      NavigationService.Navigate(new Uri("/FormsPage.xaml?img=" + img, UriKind.Relative));
       
    }

    // Sample code for building a localized ApplicationBar
    //private void BuildLocalizedApplicationBar()
    //{
    //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
    //    ApplicationBar = new ApplicationBar();

    //    // Create a new button and set the text value to the localized string from AppResources.
    //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
    //    appBarButton.Text = AppResources.AppBarButtonText;
    //    ApplicationBar.Buttons.Add(appBarButton);

    //    // Create a new menu item with the localized string from AppResources.
    //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
    //    ApplicationBar.MenuItems.Add(appBarMenuItem);
    //}
  }
}