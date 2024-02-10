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
public partial class CBombTarget : CBaseTrigger, ICBombTarget
{
    public CBombTarget (IntPtr pointer) : base(pointer) {}

	// m_OnBombExplode
	[SchemaMember("CBombTarget", "m_OnBombExplode")]
	public CEntityIOOutput OnBombExplode => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBombTarget", "m_OnBombExplode");

	// m_OnBombPlanted
	[SchemaMember("CBombTarget", "m_OnBombPlanted")]
	public CEntityIOOutput OnBombPlanted => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBombTarget", "m_OnBombPlanted");

	// m_OnBombDefused
	[SchemaMember("CBombTarget", "m_OnBombDefused")]
	public CEntityIOOutput OnBombDefused => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBombTarget", "m_OnBombDefused");

	// m_bIsBombSiteB
	[SchemaMember("CBombTarget", "m_bIsBombSiteB")]
	public ref bool IsBombSiteB => ref Schema.GetRef<bool>(this.Handle, "CBombTarget", "m_bIsBombSiteB");

	// m_bIsHeistBombTarget
	[SchemaMember("CBombTarget", "m_bIsHeistBombTarget")]
	public ref bool IsHeistBombTarget => ref Schema.GetRef<bool>(this.Handle, "CBombTarget", "m_bIsHeistBombTarget");

	// m_bBombPlantedHere
	[SchemaMember("CBombTarget", "m_bBombPlantedHere")]
	public ref bool BombPlantedHere => ref Schema.GetRef<bool>(this.Handle, "CBombTarget", "m_bBombPlantedHere");

	// m_szMountTarget
	[SchemaMember("CBombTarget", "m_szMountTarget")]
	public string MountTarget
	{
		get { return Schema.GetUtf8String(this.Handle, "CBombTarget", "m_szMountTarget"); }
		set { Schema.SetString(this.Handle, "CBombTarget", "m_szMountTarget", value); }
	}

	// m_hInstructorHint
	[SchemaMember("CBombTarget", "m_hInstructorHint")]
	public CHandle<CBaseEntity> InstructorHint => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CBombTarget", "m_hInstructorHint");

	// m_nBombSiteDesignation
	[SchemaMember("CBombTarget", "m_nBombSiteDesignation")]
	public ref Int32 BombSiteDesignation => ref Schema.GetRef<Int32>(this.Handle, "CBombTarget", "m_nBombSiteDesignation");

}
