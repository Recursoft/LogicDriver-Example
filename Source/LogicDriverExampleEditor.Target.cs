// Recursoft LLC

using UnrealBuildTool;
using System.Collections.Generic;

public class LogicDriverExampleEditorTarget : TargetRules
{
	public LogicDriverExampleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "LogicDriverExample" } );
	}
}
