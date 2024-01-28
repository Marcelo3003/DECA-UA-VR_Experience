using UnrealBuildTool;

public class VR_GGJServerTarget : TargetRules
{
	public VR_GGJServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("VR_GGJ");
	}
}
