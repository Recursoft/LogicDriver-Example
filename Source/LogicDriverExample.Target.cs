// Recursoft LLC

using UnrealBuildTool;
using System.Collections.Generic;

public class LogicDriverExampleTarget : TargetRules
{
	public LogicDriverExampleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "LogicDriverExample" } );
	}
}
