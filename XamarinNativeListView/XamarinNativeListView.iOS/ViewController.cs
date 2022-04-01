using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace XamarinNativeListView.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var cities = new List<City>();
            cities.Add(new City("Jakarta", "Indonesia"));
            cities.Add(new City("Jakarta", "Indonesia"));
            cities.Add(new City("Jakarta", "Indonesia"));
            TableView.Source = new Source(cities);
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
