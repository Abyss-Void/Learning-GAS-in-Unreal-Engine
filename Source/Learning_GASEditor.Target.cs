// Learning Project for GAS in Unreal Engine by Satyam Deo

using UnrealBuildTool;
using System.Collections.Generic;

public class Learning_GASEditorTarget : TargetRules
{
	public Learning_GASEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "Learning_GAS" } );
	}
}
