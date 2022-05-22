using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ODINVisionV2
{	
	public partial class SequenceView : ContentPage
	{
		public string FullUrl = "";
		public SequenceView (string url, string stationID)
		{
			InitializeComponent ();
			//FullUrl = 
			pageviewer.Source = $"{url}/?stationid={stationID}";
		}
	}
}

