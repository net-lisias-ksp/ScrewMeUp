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
namespace ScrewMeUp
{
	public class AAAModuleScrewer : PartModule
	{
		[KSPField(isPersistant = true, guiActive = true, guiActiveEditor = true, guiName = "Screwing Unity is")]
		[UI_Toggle(disabledText = "Inactive", enabledText = "Active", scene = UI_Scene.All)]
		public bool screwUnity = false;

		[KSPField(isPersistant = true, guiActive = true, guiActiveEditor = true, guiName = "Screwing KSP is")]
		[UI_Toggle(disabledText = "Inactive", enabledText = "Active", scene = UI_Scene.All)]
		public bool screwKSP = false;

		#region Unity Life Cycle

		private void OnEnable()		{ this.ScrewUnity(); }
		private void Reset()		{ this.ScrewUnity(); }
		private void Start()		{ this.ScrewUnity(); }
		private void FixedUpdate()	{ this.ScrewUnity(); }
		private void Update()		{ this.ScrewUnity(); }
		private void LastUpdate()	{ this.ScrewUnity(); }
		private void OnDisable()	{ this.ScrewUnity(); }
		private void OnDestroy()	{ this.ScrewUnity(); }

		#endregion

		#region KSP Life Cycle
		public override void OnInitialize()
		{
			base.OnInitialize();
			this.ScrewKSP();
		}

		public override void OnAwake()
		{
			base.OnAwake();
			this.ScrewKSP();
		}

		public override void OnActive()
		{
			base.OnActive();
			this.ScrewKSP();
		}

		public override void OnCopy(PartModule fromModule)
		{
			base.OnCopy(fromModule);
			this.ScrewKSP();
		}

		public override void OnLoad(ConfigNode node)
		{
			base.OnLoad(node);
			this.ScrewKSP();
		}

		public override void OnSave(ConfigNode node)
		{
			base.OnSave(node);
			this.ScrewKSP();
		}

		public override void OnUpdate()
		{
			base.OnUpdate();
			this.ScrewKSP();
		}

		public override void OnFixedUpdate()
		{
			base.OnFixedUpdate();
			this.ScrewKSP();
		}

		public override void OnInactive()
		{
			base.OnInactive();
			this.ScrewKSP();
		}

		#endregion

		private void ScrewUnity()
		{
			if (this.screwUnity) throw new NullReferenceException("Fake NRE from ScrewMeUp!");
		}

		private void ScrewKSP()
		{
			if (this.screwKSP) throw new NullReferenceException("Fake NRE from ScrewMeUp!");
		}
	}
}
