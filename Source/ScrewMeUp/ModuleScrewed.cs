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
	public class zzzModuleScrewed : PartModule
	{
		#region Unity Life Cycle

		private void OnEnable()		{ Log.info("Unity OnEnable is fine."); }
		private void Reset()		{ Log.info("Unity Reset is fine."); }
		private void Start()		{ Log.info("Unity Start is fine."); }
		private void FixedUpdate()	{ Log.info("Unity FixedUpdate is fine."); }
		private void Update()		{ Log.info("Unity Update is fine."); }
		private void LastUpdate()	{ Log.info("Unity LastUpdate is fine."); }
		private void OnDisable()	{ Log.info("Unity OnDisable is fine."); }
		private void OnDestroy()	{ Log.info("Unity OnDestroy is fine."); }

		#endregion

		#region KSP Life Cycle
		public override void OnInitialize()
		{
			base.OnInitialize();
			Log.info("PartModule OnInitialize is fine.");
		}

		public override void OnAwake()
		{
			base.OnAwake();
			Log.info("PartModule OnAwake is fine.");
		}

		public override void OnActive()
		{
			base.OnActive();
			Log.info("PartModule OnActive is fine.");
		}

		public override void OnCopy(PartModule fromModule)
		{
			base.OnCopy(fromModule);
			Log.info("PartModule OnCopy is fine.");
		}

		public override void OnLoad(ConfigNode node)
		{
			base.OnLoad(node);
			Log.info("PartModule OnLoad is fine.");
		}

		public override void OnSave(ConfigNode node)
		{
			base.OnSave(node);
			Log.info("PartModule OnSave is fine.");
		}

		public override void OnUpdate()
		{
			base.OnUpdate();
			Log.info("PartModule OnUpdate is fine.");
		}

		public override void OnFixedUpdate()
		{
			base.OnFixedUpdate();
			Log.info("PartModule OnFixedUpdate is fine.");
		}

		public override void OnInactive()
		{
			base.OnInactive();
			Log.info("PartModule OnInactive is fine.");
		}

		#endregion
	}
}
