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
public partial class CBaseCombatCharacter : CBaseFlex, ICBaseCombatCharacter
{
    public CBaseCombatCharacter (IntPtr pointer) : base(pointer) {}

	// m_bForceServerRagdoll
	[SchemaMember("CBaseCombatCharacter", "m_bForceServerRagdoll")]
	public ref bool ForceServerRagdoll => ref Schema.GetRef<bool>(this.Handle, "CBaseCombatCharacter", "m_bForceServerRagdoll");

	// m_hMyWearables
	[SchemaMember("CBaseCombatCharacter", "m_hMyWearables")]
	public NetworkedVector<CHandle<CEconWearable>> MyWearables => Schema.GetDeclaredClass<NetworkedVector<CHandle<CEconWearable>>>(this.Handle, "CBaseCombatCharacter", "m_hMyWearables");

	// m_flFieldOfView
	[SchemaMember("CBaseCombatCharacter", "m_flFieldOfView")]
	public ref float FieldOfView => ref Schema.GetRef<float>(this.Handle, "CBaseCombatCharacter", "m_flFieldOfView");

	// m_impactEnergyScale
	[SchemaMember("CBaseCombatCharacter", "m_impactEnergyScale")]
	public ref float ImpactEnergyScale => ref Schema.GetRef<float>(this.Handle, "CBaseCombatCharacter", "m_impactEnergyScale");

	// m_LastHitGroup
	[SchemaMember("CBaseCombatCharacter", "m_LastHitGroup")]
	public ref HitGroup_t LastHitGroup => ref Schema.GetRef<HitGroup_t>(this.Handle, "CBaseCombatCharacter", "m_LastHitGroup");

	// m_bApplyStressDamage
	[SchemaMember("CBaseCombatCharacter", "m_bApplyStressDamage")]
	public ref bool ApplyStressDamage => ref Schema.GetRef<bool>(this.Handle, "CBaseCombatCharacter", "m_bApplyStressDamage");

	// m_bloodColor
	[SchemaMember("CBaseCombatCharacter", "m_bloodColor")]
	public ref Int32 BloodColor => ref Schema.GetRef<Int32>(this.Handle, "CBaseCombatCharacter", "m_bloodColor");

	// m_iDamageCount
	[SchemaMember("CBaseCombatCharacter", "m_iDamageCount")]
	public ref Int32 DamageCount => ref Schema.GetRef<Int32>(this.Handle, "CBaseCombatCharacter", "m_iDamageCount");

	// m_strRelationships
	[SchemaMember("CBaseCombatCharacter", "m_strRelationships")]
	public string StrRelationships
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseCombatCharacter", "m_strRelationships"); }
		set { Schema.SetString(this.Handle, "CBaseCombatCharacter", "m_strRelationships", value); }
	}

	// m_eHull
	[SchemaMember("CBaseCombatCharacter", "m_eHull")]
	public ref Hull_t Hull => ref Schema.GetRef<Hull_t>(this.Handle, "CBaseCombatCharacter", "m_eHull");

	// m_nNavHullIdx
	[SchemaMember("CBaseCombatCharacter", "m_nNavHullIdx")]
	public ref UInt32 NavHullIdx => ref Schema.GetRef<UInt32>(this.Handle, "CBaseCombatCharacter", "m_nNavHullIdx");

}
