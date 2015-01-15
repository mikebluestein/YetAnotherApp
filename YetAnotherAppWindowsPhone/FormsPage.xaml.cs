using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using YetAnotherAppShared;
using Xamarin.Forms;

namespace YetAnotherAppWindowsPhone
{
  public partial class FormsPage : PhoneApplicationPage
  {
    public FormsPage()
    {
      InitializeComponent();
      Forms.Init();
    }

    protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
    {
      base.OnNavigatedTo(e);
      var img = string.Empty;

      if (NavigationContext.QueryString.TryGetValue("img", out img))
      {
        Content = new DetailPage(img).ConvertPageToUIElement(this);
      }
    
    }
  }
}