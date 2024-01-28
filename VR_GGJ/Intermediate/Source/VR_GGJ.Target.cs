using UnrealBuildTool;

public class VR_GGJTarget : TargetRules
{
	public VR_GGJTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("VR_GGJ");
	}
}
