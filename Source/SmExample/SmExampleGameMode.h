// Copyright 1998-2018 Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/GameModeBase.h"
#include "SmExampleGameMode.generated.h"

UENUM(BlueprintType)
enum class ESMTestType : uint8
{
	ServerReplication,
	ServerOnly,
	ClientOnly
};

UCLASS(minimalapi)
class ASmExampleGameMode : public AGameModeBase
{
	GENERATED_BODY()

public:
	ASmExampleGameMode();
};



