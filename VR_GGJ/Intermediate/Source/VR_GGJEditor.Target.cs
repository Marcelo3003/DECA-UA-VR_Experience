using UnrealBuildTool;

public class VR_GGJEditorTarget : TargetRules
{
	public VR_GGJEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("VR_GGJ");
	}
}
