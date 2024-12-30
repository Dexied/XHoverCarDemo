/**
* Copyright (C) 2019-2020 | Created by DEXIED || DEXIED GAMES
* All rights reserved!
* My Discord Server: https://discord.gg/mqV52Qf
*/

using UnrealBuildTool;
using System.Collections.Generic;

public class XHoverCarDemoEditorTarget : TargetRules
{
	public XHoverCarDemoEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
		ExtraModuleNames.AddRange( new string[] { "XHoverCarDemo" } );
	}
}
