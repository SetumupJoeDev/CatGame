using UnrealBuildTool;

public class HelpMeowtTarget : TargetRules
{
	public HelpMeowtTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("HelpMeowt");
	}
}
