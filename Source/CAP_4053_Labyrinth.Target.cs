// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class CAP_4053_LabyrinthTarget : TargetRules
{
	public CAP_4053_LabyrinthTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("CAP_4053_Labyrinth");
	}
}
