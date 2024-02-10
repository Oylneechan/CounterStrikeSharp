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
public partial class CTriggerHurt : CBaseTrigger, ICTriggerHurt
{
    public CTriggerHurt (IntPtr pointer) : base(pointer) {}

	// m_flOriginalDamage
	[SchemaMember("CTriggerHurt", "m_flOriginalDamage")]
	public ref float OriginalDamage => ref Schema.GetRef<float>(this.Handle, "CTriggerHurt", "m_flOriginalDamage");

	// m_flDamage
	[SchemaMember("CTriggerHurt", "m_flDamage")]
	public ref float Damage => ref Schema.GetRef<float>(this.Handle, "CTriggerHurt", "m_flDamage");

	// m_flDamageCap
	[SchemaMember("CTriggerHurt", "m_flDamageCap")]
	public ref float DamageCap => ref Schema.GetRef<float>(this.Handle, "CTriggerHurt", "m_flDamageCap");

	// m_flLastDmgTime
	[SchemaMember("CTriggerHurt", "m_flLastDmgTime")]
	public ref float LastDmgTime => ref Schema.GetRef<float>(this.Handle, "CTriggerHurt", "m_flLastDmgTime");

	// m_flForgivenessDelay
	[SchemaMember("CTriggerHurt", "m_flForgivenessDelay")]
	public ref float ForgivenessDelay => ref Schema.GetRef<float>(this.Handle, "CTriggerHurt", "m_flForgivenessDelay");

	// m_bitsDamageInflict
	[SchemaMember("CTriggerHurt", "m_bitsDamageInflict")]
	public ref Int32 BitsDamageInflict => ref Schema.GetRef<Int32>(this.Handle, "CTriggerHurt", "m_bitsDamageInflict");

	// m_damageModel
	[SchemaMember("CTriggerHurt", "m_damageModel")]
	public ref Int32 DamageModel => ref Schema.GetRef<Int32>(this.Handle, "CTriggerHurt", "m_damageModel");

	// m_bNoDmgForce
	[SchemaMember("CTriggerHurt", "m_bNoDmgForce")]
	public ref bool NoDmgForce => ref Schema.GetRef<bool>(this.Handle, "CTriggerHurt", "m_bNoDmgForce");

	// m_vDamageForce
	[SchemaMember("CTriggerHurt", "m_vDamageForce")]
	public Vector DamageForce => Schema.GetDeclaredClass<Vector>(this.Handle, "CTriggerHurt", "m_vDamageForce");

	// m_thinkAlways
	[SchemaMember("CTriggerHurt", "m_thinkAlways")]
	public ref bool ThinkAlways => ref Schema.GetRef<bool>(this.Handle, "CTriggerHurt", "m_thinkAlways");

	// m_hurtThinkPeriod
	[SchemaMember("CTriggerHurt", "m_hurtThinkPeriod")]
	public ref float HurtThinkPeriod => ref Schema.GetRef<float>(this.Handle, "CTriggerHurt", "m_hurtThinkPeriod");

	// m_OnHurt
	[SchemaMember("CTriggerHurt", "m_OnHurt")]
	public CEntityIOOutput OnHurt => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CTriggerHurt", "m_OnHurt");

	// m_OnHurtPlayer
	[SchemaMember("CTriggerHurt", "m_OnHurtPlayer")]
	public CEntityIOOutput OnHurtPlayer => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CTriggerHurt", "m_OnHurtPlayer");

	// m_hurtEntities
	[SchemaMember("CTriggerHurt", "m_hurtEntities")]
	public NetworkedVector<CHandle<CBaseEntity>> HurtEntities => Schema.GetDeclaredClass<NetworkedVector<CHandle<CBaseEntity>>>(this.Handle, "CTriggerHurt", "m_hurtEntities");

}
