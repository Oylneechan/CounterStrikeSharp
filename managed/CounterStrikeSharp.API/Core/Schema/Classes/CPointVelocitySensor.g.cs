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
public partial class CPointVelocitySensor : CPointEntity, ICPointVelocitySensor
{
    public CPointVelocitySensor (IntPtr pointer) : base(pointer) {}

	// m_hTargetEntity
	[SchemaMember("CPointVelocitySensor", "m_hTargetEntity")]
	public CHandle<CBaseEntity> TargetEntity => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CPointVelocitySensor", "m_hTargetEntity");

	// m_vecAxis
	[SchemaMember("CPointVelocitySensor", "m_vecAxis")]
	public Vector Axis => Schema.GetDeclaredClass<Vector>(this.Handle, "CPointVelocitySensor", "m_vecAxis");

	// m_bEnabled
	[SchemaMember("CPointVelocitySensor", "m_bEnabled")]
	public ref bool Enabled => ref Schema.GetRef<bool>(this.Handle, "CPointVelocitySensor", "m_bEnabled");

	// m_fPrevVelocity
	[SchemaMember("CPointVelocitySensor", "m_fPrevVelocity")]
	public ref float PrevVelocity => ref Schema.GetRef<float>(this.Handle, "CPointVelocitySensor", "m_fPrevVelocity");

	// m_flAvgInterval
	[SchemaMember("CPointVelocitySensor", "m_flAvgInterval")]
	public ref float AvgInterval => ref Schema.GetRef<float>(this.Handle, "CPointVelocitySensor", "m_flAvgInterval");

}
