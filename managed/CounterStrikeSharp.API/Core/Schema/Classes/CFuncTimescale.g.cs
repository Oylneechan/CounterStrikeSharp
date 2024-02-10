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
public partial class CFuncTimescale : CBaseEntity, ICFuncTimescale
{
    public CFuncTimescale (IntPtr pointer) : base(pointer) {}

	// m_flDesiredTimescale
	[SchemaMember("CFuncTimescale", "m_flDesiredTimescale")]
	public ref float DesiredTimescale => ref Schema.GetRef<float>(this.Handle, "CFuncTimescale", "m_flDesiredTimescale");

	// m_flAcceleration
	[SchemaMember("CFuncTimescale", "m_flAcceleration")]
	public ref float Acceleration => ref Schema.GetRef<float>(this.Handle, "CFuncTimescale", "m_flAcceleration");

	// m_flMinBlendRate
	[SchemaMember("CFuncTimescale", "m_flMinBlendRate")]
	public ref float MinBlendRate => ref Schema.GetRef<float>(this.Handle, "CFuncTimescale", "m_flMinBlendRate");

	// m_flBlendDeltaMultiplier
	[SchemaMember("CFuncTimescale", "m_flBlendDeltaMultiplier")]
	public ref float BlendDeltaMultiplier => ref Schema.GetRef<float>(this.Handle, "CFuncTimescale", "m_flBlendDeltaMultiplier");

	// m_isStarted
	[SchemaMember("CFuncTimescale", "m_isStarted")]
	public ref bool IsStarted => ref Schema.GetRef<bool>(this.Handle, "CFuncTimescale", "m_isStarted");

}
