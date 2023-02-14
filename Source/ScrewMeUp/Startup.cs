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

namespace ScrewMeUp
{
	[KSPAddon(KSPAddon.Startup.Instantly, true)]
	internal class Startup : MonoBehaviour
	{
		private void Start() {
			Log.force("Version {0}. Are you sure you know what you are doing??", Version.Text);
			GUI.ShowStopperAlertBox.Show("You have `ScrewMeUp` installed!");
		}
	}
}
