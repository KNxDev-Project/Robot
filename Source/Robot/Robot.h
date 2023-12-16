// Copyright 2023 KNxDev.

#pragma once

#include "CoreMinimal.h"

DECLARE_LOG_CATEGORY_EXTERN(LogRobot, Log, All);

//Example of use: ROBOT_LOG(Error, *FString::Printf(TEXT("%i/%i = %i"), 10, 5, 10/5));
#define ROBOT_LOG(Verbosity, Message) \
{ \
    UE_LOG(LogRobot, Verbosity, TEXT("%s::%i - %s"), *FString(__FUNCTION__), __LINE__, Message); \
}