// Copyright 2023 KNxDev.

using UnrealBuildTool;
using System.Collections.Generic;

public class RobotTarget : TargetRules
{
	public RobotTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.Add("Robot");
	}
}
