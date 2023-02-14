/*
	This file is part of ScrewMeUp
		©2023 Lisias T : http://lisias.net <support@lisias.net>

	ScrewMeUp is licensed as follows:
		* ALL RIGHTS RESERVED

	ScrewMeUp is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	HELL, this thing is going to screw your game! :)

*/
using UnityEngine;

namespace ScrewMeUp.GUI
{
	internal static class ShowStopperAlertBox
	{
		private static readonly string AMSG = @"close KSP, and remove this `ScrewMeUp` crap from your GameData";

		internal static void Show(string msg)
		{
			KSPe.Common.Dialogs.ShowStopperAlertBox.Show(
				msg,
				AMSG,
				() => { Application.Quit(); }
			);
			Log.force("\"Houston, we have a problem!\" was displayed about : {0}", msg);
		}
	}
}
