// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ShooterRemasteredEditorTarget : TargetRules
{
    public ShooterRemasteredEditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V4;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_3;
        ExtraModuleNames.Add("ShooterRemastered");
        ExtraModuleNames.Add("CharacterMovementModule");
    }
}
