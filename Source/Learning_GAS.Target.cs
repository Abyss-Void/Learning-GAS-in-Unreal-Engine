// Learning Project for GAS in Unreal Engine by Satyam Deo

using UnrealBuildTool;
using System.Collections.Generic;

public class Learning_GASTarget : TargetRules
{
	public Learning_GASTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "Learning_GAS" } );
	}
}
