// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class CharacterMovementModule : ModuleRules
{
    public CharacterMovementModule(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[]
            {
                "Core",
                "CoreUObject",
                "Engine"
            });

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {

            });

        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {

            });
    }
}
