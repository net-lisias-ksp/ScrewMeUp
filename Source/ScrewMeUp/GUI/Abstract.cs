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

namespace KSPe.Common.Dialogs
{
	public class AbstractDialog
	{

		private static Texture2D windowTex = null;
		protected static void SetWindowBackground(GUIStyle style)
		{
			if (null == windowTex)
			{
				windowTex = new Texture2D(1, 1);
				windowTex.SetPixel(0, 0, new Color(0f, 0f, 0f, 0.45f));
				windowTex.Apply();
				style.active.background =
					style.focused.background =
					style.normal.background = windowTex;
			}
		}

		private static Texture2D textTex = null;
		protected static void SetTextBackground(GUIStyle style)
		{
			if (null == textTex)
			{
				textTex = new Texture2D(1, 1);
				textTex.SetPixel(0, 0, new Color(0f, 0f, 0f, 0.45f));
				textTex.Apply();
			}
				style.active.background =
					style.focused.background =
					style.normal.background = textTex;
		}

	}
}
