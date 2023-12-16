// Copyright 2023 KNxDev.

using UnrealBuildTool;
using System.Collections.Generic;

public class RobotEditorTarget : TargetRules
{
	public RobotEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.Add("Robot");
	}
}
