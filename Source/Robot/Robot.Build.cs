// Copyright 2023 KNxDev.

using UnrealBuildTool;

public class Robot : ModuleRules
{
	public Robot(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });

        PublicIncludePaths.AddRange(
        new string[]
        {
                "Robot"
        });
    }
}
