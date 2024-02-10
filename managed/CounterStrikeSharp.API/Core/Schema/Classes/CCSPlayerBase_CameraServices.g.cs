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
public partial class CCSPlayerBase_CameraServices : CPlayer_CameraServices, ICCSPlayerBase_CameraServices
{
    public CCSPlayerBase_CameraServices (IntPtr pointer) : base(pointer) {}

	// m_iFOV
	[SchemaMember("CCSPlayerBase_CameraServices", "m_iFOV")]
	public ref UInt32 FOV => ref Schema.GetRef<UInt32>(this.Handle, "CCSPlayerBase_CameraServices", "m_iFOV");

	// m_iFOVStart
	[SchemaMember("CCSPlayerBase_CameraServices", "m_iFOVStart")]
	public ref UInt32 FOVStart => ref Schema.GetRef<UInt32>(this.Handle, "CCSPlayerBase_CameraServices", "m_iFOVStart");

	// m_flFOVTime
	[SchemaMember("CCSPlayerBase_CameraServices", "m_flFOVTime")]
	public ref float FOVTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerBase_CameraServices", "m_flFOVTime");

	// m_flFOVRate
	[SchemaMember("CCSPlayerBase_CameraServices", "m_flFOVRate")]
	public ref float FOVRate => ref Schema.GetRef<float>(this.Handle, "CCSPlayerBase_CameraServices", "m_flFOVRate");

	// m_hZoomOwner
	[SchemaMember("CCSPlayerBase_CameraServices", "m_hZoomOwner")]
	public CHandle<CBaseEntity> ZoomOwner => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CCSPlayerBase_CameraServices", "m_hZoomOwner");

	// m_hTriggerFogList
	[SchemaMember("CCSPlayerBase_CameraServices", "m_hTriggerFogList")]
	public NetworkedVector<CHandle<CBaseEntity>> TriggerFogList => Schema.GetDeclaredClass<NetworkedVector<CHandle<CBaseEntity>>>(this.Handle, "CCSPlayerBase_CameraServices", "m_hTriggerFogList");

	// m_hLastFogTrigger
	[SchemaMember("CCSPlayerBase_CameraServices", "m_hLastFogTrigger")]
	public CHandle<CBaseEntity> LastFogTrigger => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CCSPlayerBase_CameraServices", "m_hLastFogTrigger");

}
