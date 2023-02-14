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
using System.Diagnostics;

namespace ScrewMeUp
{
	public static class Log
	{
		internal static void force(string msg, params object[] @params)
		{
			UnityEngine.Debug.LogFormat("[ScrewMeUp] " + msg, @params);
		}

		internal static void info(string msg, params object[] @params)
		{
			UnityEngine.Debug.LogFormat("[ScrewMeUp] INFO: " + msg, @params);
		}

		internal static void detail(string msg, params object[] @params)
		{
			UnityEngine.Debug.LogFormat("[ScrewMeUp] DETAIL: " + msg, @params);
		}

		internal static void error(string msg, params object[] @params)
		{
			UnityEngine.Debug.LogErrorFormat("[ScrewMeUp] ERROR: " + msg, @params);
		}

		[ConditionalAttribute("DEBUG")]
		internal static void dbg(string msg, params object[] @params)
		{
			UnityEngine.Debug.LogFormat("[ScrewMeUp] DEBUG: " + msg, @params);
		}
	}
}
