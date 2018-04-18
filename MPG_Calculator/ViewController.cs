using System;

using UIKit;

namespace MPG_Calculator
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            CalculateButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                ResignFirstResponder();
                try
                {
                    decimal mpg = MPG_Calculator.MPG(MilesText.Text, GallonsText.Text);
                    ResultLabel.Text = String.Format("MPG: {0:0.00}", mpg);
                }
                catch(ArgumentException ex)
                {
                    new UIAlertView("Error", ex.Message, null, "Ok", null).Show();
                }
            };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
