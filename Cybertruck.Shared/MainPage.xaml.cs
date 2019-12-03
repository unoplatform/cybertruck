using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace CyberTruck
{
	public sealed partial class MainPage : Page
	{
		public MainPage()
		{
			this.InitializeComponent();
			DoorWindows.PointerPressed += new PointerEventHandler(Windows_PointerPressed);
		}


		public bool FirstGlassBroken
		{
			get => (bool)GetValue(FirstGlassBrokenProperty);
			set => SetValue(FirstGlassBrokenProperty, value);
		}

		public static readonly DependencyProperty FirstGlassBrokenProperty =
			DependencyProperty.Register("FirstGlassBroken", typeof(bool), typeof(MainPage), new PropertyMetadata(false));

		public bool SecondGlassBroken
		{
			get => (bool)GetValue(SecondGlassBrokenProperty);
			set => SetValue(SecondGlassBrokenProperty, value);
		}

		public static readonly DependencyProperty SecondGlassBrokenProperty =
			DependencyProperty.Register("SecondGlassBroken", typeof(bool), typeof(MainPage), new PropertyMetadata(false));

		private void Windows_PointerPressed(object sender, PointerRoutedEventArgs e)
		{
			if (!FirstGlassBroken)
			{
				FirstGlassBroken = true;
			}
			else
			{
				SecondGlassBroken = true;
			}
		}

		private async void CustomizeIt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await Windows.System.Launcher.LaunchUriAsync(new Uri("https://playground.platform.uno/#cybertruck"));
            }
            catch
            {
                // Oops
            }
            
        }
	}
}

