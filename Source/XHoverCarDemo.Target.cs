/**
* Copyright (C) 2019-2020 | Created by DEXIED || DEXIED GAMES
* All rights reserved!
* My Discord Server: https://discord.gg/mqV52Qf
*/

using UnrealBuildTool;
using System.Collections.Generic;

public class XHoverCarDemoTarget : TargetRules
{
	public XHoverCarDemoTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "XHoverCarDemo" } );
	}
}
