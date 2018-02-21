// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class CAP_4053_LabyrinthEditorTarget : TargetRules
{
	public CAP_4053_LabyrinthEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("CAP_4053_Labyrinth");
	}
}
