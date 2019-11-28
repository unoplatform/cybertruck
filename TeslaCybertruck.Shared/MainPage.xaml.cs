using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TeslaCybertruck
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			this.InitializeComponent();
			Storyboard groundAnimation = (Storyboard)this.Resources["GroundAnimation"];
			groundAnimation.Begin();
			Storyboard spinTeslaLeftWheel = (Storyboard)this.Resources["SpinTeslaLeftWheel"];
			spinTeslaLeftWheel.Begin();
			Storyboard spinTeslaRightWheel = (Storyboard)this.Resources["SpinTeslaRightWheel"];
			spinTeslaRightWheel.Begin();
			Storyboard frontLightOpacity = (Storyboard)this.Resources["FrontLightOpacity"];
			frontLightOpacity.Begin();
			Storyboard rotateFrontLight = (Storyboard)this.Resources["RotateFrontLight"];
			rotateFrontLight.Begin();
			Storyboard backLightOpacity = (Storyboard)this.Resources["BackLightOpacity"];
			backLightOpacity.Begin();
			Storyboard rotateBackLight = (Storyboard)this.Resources["RotateBackLight"];
			rotateBackLight.Begin();
			Storyboard rotateTeslaBody = (Storyboard)this.Resources["RotateTeslaBody"];
			rotateTeslaBody.Begin();
		}
	}
}
