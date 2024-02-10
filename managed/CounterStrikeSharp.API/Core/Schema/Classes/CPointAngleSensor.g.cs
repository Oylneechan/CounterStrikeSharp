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
public partial class CPointAngleSensor : CPointEntity, ICPointAngleSensor
{
    public CPointAngleSensor (IntPtr pointer) : base(pointer) {}

	// m_bDisabled
	[SchemaMember("CPointAngleSensor", "m_bDisabled")]
	public ref bool Disabled => ref Schema.GetRef<bool>(this.Handle, "CPointAngleSensor", "m_bDisabled");

	// m_nLookAtName
	[SchemaMember("CPointAngleSensor", "m_nLookAtName")]
	public string LookAtName
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointAngleSensor", "m_nLookAtName"); }
		set { Schema.SetString(this.Handle, "CPointAngleSensor", "m_nLookAtName", value); }
	}

	// m_hTargetEntity
	[SchemaMember("CPointAngleSensor", "m_hTargetEntity")]
	public CHandle<CBaseEntity> TargetEntity => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CPointAngleSensor", "m_hTargetEntity");

	// m_hLookAtEntity
	[SchemaMember("CPointAngleSensor", "m_hLookAtEntity")]
	public CHandle<CBaseEntity> LookAtEntity => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CPointAngleSensor", "m_hLookAtEntity");

	// m_flDuration
	[SchemaMember("CPointAngleSensor", "m_flDuration")]
	public ref float Duration => ref Schema.GetRef<float>(this.Handle, "CPointAngleSensor", "m_flDuration");

	// m_flDotTolerance
	[SchemaMember("CPointAngleSensor", "m_flDotTolerance")]
	public ref float DotTolerance => ref Schema.GetRef<float>(this.Handle, "CPointAngleSensor", "m_flDotTolerance");

	// m_flFacingTime
	[SchemaMember("CPointAngleSensor", "m_flFacingTime")]
	public ref float FacingTime => ref Schema.GetRef<float>(this.Handle, "CPointAngleSensor", "m_flFacingTime");

	// m_bFired
	[SchemaMember("CPointAngleSensor", "m_bFired")]
	public ref bool Fired => ref Schema.GetRef<bool>(this.Handle, "CPointAngleSensor", "m_bFired");

	// m_OnFacingLookat
	[SchemaMember("CPointAngleSensor", "m_OnFacingLookat")]
	public CEntityIOOutput OnFacingLookat => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPointAngleSensor", "m_OnFacingLookat");

	// m_OnNotFacingLookat
	[SchemaMember("CPointAngleSensor", "m_OnNotFacingLookat")]
	public CEntityIOOutput OnNotFacingLookat => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPointAngleSensor", "m_OnNotFacingLookat");

}
