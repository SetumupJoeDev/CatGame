using UnrealBuildTool;

public class HerdingCatsTarget : TargetRules
{
	public HerdingCatsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("HerdingCats");
	}
}
