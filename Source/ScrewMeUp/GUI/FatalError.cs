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
using System;
using UnityEngine;
using KSPe.UI;

namespace KSPe.Common.Dialogs
{
	public class ShowStopperAlertBox : AbstractDialog
	{
		private static readonly string aMSG = "close KSP, and remove this `ScrewMeUp` crap from your `GameData`";

		private static readonly string MSG = @"{0}

This thing <b>intentionally</b> screws things up as Research & Development, and should not be used by end users!!

You should consider carefully if you really want to proceed with the tests on this current KSP installation. <b>**DO NOT**</b> use any valuable savegames on this stunt!

Click ""Cancel"" if you really want to proceeed.
";

		public static void Show(string errorMessage)
		{
			Show(errorMessage, aMSG, Application.Quit);
		}

		public static void Show(string errorMessage, string actionMessage, Action lambda)
		{
			GameObject go = new GameObject("KSPe.Common.Diallgs.ShowStopperAlertBox");
			MessageBox dlg = go.AddComponent<MessageBox>();

			//GUIStyle win = new GUIStyle(HighLogic.Skin.window)
			GUIStyle win = new GUIStyle("Window")
			{
				fontSize = 26,
				fontStyle = FontStyle.Bold,
				alignment = TextAnchor.UpperCenter,
				wordWrap = false
			};
			win.normal.textColor = Color.red;
			win.border.top = 0;
			win.padding.top = -5;
			SetWindowBackground(win);
			win.active.background =	win.focused.background = win.normal.background;

			GUIStyle text = new GUIStyle("Label")
			{
				fontSize = 18,
				fontStyle = FontStyle.Normal,
				alignment = TextAnchor.MiddleLeft,
				wordWrap = true
			};
			text.normal.textColor = Color.white;
			text.padding.top = 8;
			text.padding.bottom = text.padding.top;
			text.padding.left = text.padding.top;
			text.padding.right = text.padding.top;
			SetTextBackground(text);

			dlg.Show(
				"Houston, we have a problem!",
				String.Format(MSG, errorMessage, actionMessage),
				lambda,
				win, text
			);
		}
	}
}
