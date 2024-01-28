using UnrealBuildTool;

public class VR_GGJClientTarget : TargetRules
{
	public VR_GGJClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("VR_GGJ");
	}
}
