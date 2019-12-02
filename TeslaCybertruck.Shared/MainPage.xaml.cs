using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.Extensions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;

namespace TeslaCybertruck
{
	public sealed partial class MainPage : Page
	{
		private bool pressedSecondTime = False;

		public MainPage()
		{
			this.InitializeComponent();
			Windows.PointerPressed += new PointerEventHandler(Windows_PointerPressed);
		}

		public static bool False { get; private set; }

		private void Windows_PointerPressed(object sender, PointerRoutedEventArgs e)
		{
			if (pressedSecondTime == false)
			{
				Storyboard firstBrokenGlassOpacity = (Storyboard)this.Resources["FirstBrokenGlassOpacity"];
				firstBrokenGlassOpacity.Begin();
				pressedSecondTime = true;
			}
			else
			{
				Storyboard secondBrokenGlassOpacity = (Storyboard)this.Resources["SecondBrokenGlassOpacity"];
				secondBrokenGlassOpacity.Begin();
			}
		}
	}
}
