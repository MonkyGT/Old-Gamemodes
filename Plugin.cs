using System;
using BepInEx;
using UnityEngine;
using TillaHook;
using TillaHook.Models;

namespace GorillaTagModTemplateProject
{
	/// <summary>
	/// This is your mod's main class.
	/// </summary>

	/* This attribute tells Utilla to look for [ModdedGameJoin] and [ModdedGameLeave] */

	[BepInDependency("dev.tillahook")]
	[BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
	public class Plugin : BaseUnityPlugin
	{
		bool inRoom;

		void Start()
		{
				TillaHook.TillaHook.Hook.AddGameMode(new GameModeWrapper[1] {
					new GameModeWrapper()
					{
						DisplayName = "HUNT",
						ID = "MODDED_HUNT",
						GameModeType = "Hunt"
					}
				}, OnJoin, OnLeave);
				TillaHook.TillaHook.Hook.AddGameMode(new GameModeWrapper[1] {
					new GameModeWrapper()
					{
						DisplayName = "PAINTBRAWL",
						ID = "MODDED_PAINTBRAWL",
						GameModeType = "Paintbrawl"
						
					}
				}, OnJoin, OnLeave);
		}

		void OnEnable()
		{
			HarmonyPatches.ApplyHarmonyPatches();
		}

		void OnDisable()
		{
			HarmonyPatches.RemoveHarmonyPatches();
		}

		void OnGameInitialized(object sender, EventArgs e)
		{

		}

		void Update()
		{ 
			
		}



		public void OnJoin(string gamemode)
		{
			inRoom = true;
		}


		public void OnLeave(string gamemode)
		{
			inRoom = false;
		}
	}
}
