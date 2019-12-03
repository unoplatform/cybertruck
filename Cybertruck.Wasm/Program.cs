using System;
using Uno.Foundation;
using Windows.UI.Xaml;

namespace CyberTruck.Wasm
{
	public class Program
	{
		private static App _app;

		static int Main(string[] args)
		{
			WebAssemblyRuntime.InvokeJS("Uno.UI.Demo.Analytics.reportPageView('main');");

			Windows.UI.Xaml.Application.Start(_ => _app = new App());

			return 0;
		}
	}
}
