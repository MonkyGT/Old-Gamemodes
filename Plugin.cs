using System;
using BepInEx;
using UnityEngine;
using Utilla;
using Utilla.Attributes;
using Utilla.Models;

namespace OldGamemodes
{
	[ModdedGamemode("MODDED_Hunt", "MODDED HUNT", BaseGamemode.Hunt)]
	[ModdedGamemode("MODDED_Paintbrawl", "MODDED BRAWL", BaseGamemode.Paintbrawl)]
	[ModdedGamemode("MODDED_Ambush", "MODDED AMBUSH")]
	[ModdedGamemode("MODDED_Ghost", "MODDED GHOST")]
	[BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
	public class Plugin : BaseUnityPlugin { }
}
