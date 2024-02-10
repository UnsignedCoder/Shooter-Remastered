// Fill out your copyright notice in the Description page of Project Settings.


#include "CharacterMovement.h"

// Sets default values
ACharacterMovement::ACharacterMovement()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

void ACharacterMovement::CharacterMovementTest()
{
	GEngine->AddOnScreenDebugMessage(0, 15.0f, FColor::Blue, TEXT("Hello, world!"));
}

void ACharacterMovement::PrintHelloWorld()
{
    UE_LOG(LogTemp, Warning, TEXT("I'm working"));
}

// Called when the game starts or when spawned
void ACharacterMovement::BeginPlay()
{
	Super::BeginPlay();
}

// Called every frame
void ACharacterMovement::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

