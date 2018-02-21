// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

#include "CAP_4053_LabyrinthGameMode.h"
#include "CAP_4053_LabyrinthCharacter.h"
#include "UObject/ConstructorHelpers.h"

ACAP_4053_LabyrinthGameMode::ACAP_4053_LabyrinthGameMode()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnBPClass(TEXT("/Game/ThirdPersonCPP/Blueprints/ThirdPersonCharacter"));
	if (PlayerPawnBPClass.Class != NULL)
	{
		DefaultPawnClass = PlayerPawnBPClass.Class;
	}
}
