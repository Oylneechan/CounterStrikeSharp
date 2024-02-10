// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;
using System.Diagnostics;
using System.Drawing;
using CounterStrikeSharp;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core.Attributes;

namespace CounterStrikeSharp.API.Core;

[GenerateAutomaticInterface]
public partial class CChangeLevel : CBaseTrigger, ICChangeLevel
{
    public CChangeLevel (IntPtr pointer) : base(pointer) {}

	// m_sMapName
	[SchemaMember("CChangeLevel", "m_sMapName")]
	public string MapName
	{
		get { return Schema.GetUtf8String(this.Handle, "CChangeLevel", "m_sMapName"); }
		set { Schema.SetString(this.Handle, "CChangeLevel", "m_sMapName", value); }
	}

	// m_sLandmarkName
	[SchemaMember("CChangeLevel", "m_sLandmarkName")]
	public string LandmarkName
	{
		get { return Schema.GetUtf8String(this.Handle, "CChangeLevel", "m_sLandmarkName"); }
		set { Schema.SetString(this.Handle, "CChangeLevel", "m_sLandmarkName", value); }
	}

	// m_OnChangeLevel
	[SchemaMember("CChangeLevel", "m_OnChangeLevel")]
	public CEntityIOOutput OnChangeLevel => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CChangeLevel", "m_OnChangeLevel");

	// m_bTouched
	[SchemaMember("CChangeLevel", "m_bTouched")]
	public ref bool Touched => ref Schema.GetRef<bool>(this.Handle, "CChangeLevel", "m_bTouched");

	// m_bNoTouch
	[SchemaMember("CChangeLevel", "m_bNoTouch")]
	public ref bool NoTouch => ref Schema.GetRef<bool>(this.Handle, "CChangeLevel", "m_bNoTouch");

	// m_bNewChapter
	[SchemaMember("CChangeLevel", "m_bNewChapter")]
	public ref bool NewChapter => ref Schema.GetRef<bool>(this.Handle, "CChangeLevel", "m_bNewChapter");

	// m_bOnChangeLevelFired
	[SchemaMember("CChangeLevel", "m_bOnChangeLevelFired")]
	public ref bool OnChangeLevelFired => ref Schema.GetRef<bool>(this.Handle, "CChangeLevel", "m_bOnChangeLevelFired");

}
