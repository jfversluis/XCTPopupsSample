using System;
using System.Collections.Generic;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace XCTPopupsSample
{
    public partial class MyPopup : Popup
    {
        public MyPopup()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Dismiss(null);
        }
    }
}
