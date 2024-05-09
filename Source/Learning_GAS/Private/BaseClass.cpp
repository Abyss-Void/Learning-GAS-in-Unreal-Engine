// Learning Project for GAS in Unreal Engine by Satyam Deo


#include "BaseClass.h"

// Sets default values
ABaseClass::ABaseClass()
{
 	// Set this character to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void ABaseClass::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void ABaseClass::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

// Called to bind functionality to input
void ABaseClass::SetupPlayerInputComponent(UInputComponent* PlayerInputComponent)
{
	Super::SetupPlayerInputComponent(PlayerInputComponent);

}

