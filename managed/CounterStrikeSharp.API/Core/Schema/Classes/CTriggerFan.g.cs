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
public partial class CTriggerFan : CBaseTrigger, ICTriggerFan
{
    public CTriggerFan (IntPtr pointer) : base(pointer) {}

	// m_vFanOrigin
	[SchemaMember("CTriggerFan", "m_vFanOrigin")]
	public Vector FanOrigin => Schema.GetDeclaredClass<Vector>(this.Handle, "CTriggerFan", "m_vFanOrigin");

	// m_vFanEnd
	[SchemaMember("CTriggerFan", "m_vFanEnd")]
	public Vector FanEnd => Schema.GetDeclaredClass<Vector>(this.Handle, "CTriggerFan", "m_vFanEnd");

	// m_vNoise
	[SchemaMember("CTriggerFan", "m_vNoise")]
	public Vector Noise => Schema.GetDeclaredClass<Vector>(this.Handle, "CTriggerFan", "m_vNoise");

	// m_flForce
	[SchemaMember("CTriggerFan", "m_flForce")]
	public ref float Force => ref Schema.GetRef<float>(this.Handle, "CTriggerFan", "m_flForce");

	// m_flPlayerForce
	[SchemaMember("CTriggerFan", "m_flPlayerForce")]
	public ref float PlayerForce => ref Schema.GetRef<float>(this.Handle, "CTriggerFan", "m_flPlayerForce");

	// m_flRampTime
	[SchemaMember("CTriggerFan", "m_flRampTime")]
	public ref float RampTime => ref Schema.GetRef<float>(this.Handle, "CTriggerFan", "m_flRampTime");

	// m_bFalloff
	[SchemaMember("CTriggerFan", "m_bFalloff")]
	public ref bool Falloff => ref Schema.GetRef<bool>(this.Handle, "CTriggerFan", "m_bFalloff");

	// m_bPushPlayer
	[SchemaMember("CTriggerFan", "m_bPushPlayer")]
	public ref bool PushPlayer => ref Schema.GetRef<bool>(this.Handle, "CTriggerFan", "m_bPushPlayer");

	// m_bRampDown
	[SchemaMember("CTriggerFan", "m_bRampDown")]
	public ref bool RampDown => ref Schema.GetRef<bool>(this.Handle, "CTriggerFan", "m_bRampDown");

	// m_bAddNoise
	[SchemaMember("CTriggerFan", "m_bAddNoise")]
	public ref bool AddNoise => ref Schema.GetRef<bool>(this.Handle, "CTriggerFan", "m_bAddNoise");

	// m_RampTimer
	[SchemaMember("CTriggerFan", "m_RampTimer")]
	public CountdownTimer RampTimer => Schema.GetDeclaredClass<CountdownTimer>(this.Handle, "CTriggerFan", "m_RampTimer");

}
