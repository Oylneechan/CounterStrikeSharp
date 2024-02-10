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
public partial class VelocitySampler : NativeObject, IVelocitySampler
{
    public VelocitySampler (IntPtr pointer) : base(pointer) {}

	// m_prevSample
	[SchemaMember("VelocitySampler", "m_prevSample")]
	public Vector PrevSample => Schema.GetDeclaredClass<Vector>(this.Handle, "VelocitySampler", "m_prevSample");

	// m_fPrevSampleTime
	[SchemaMember("VelocitySampler", "m_fPrevSampleTime")]
	public ref float PrevSampleTime => ref Schema.GetRef<float>(this.Handle, "VelocitySampler", "m_fPrevSampleTime");

	// m_fIdealSampleRate
	[SchemaMember("VelocitySampler", "m_fIdealSampleRate")]
	public ref float IdealSampleRate => ref Schema.GetRef<float>(this.Handle, "VelocitySampler", "m_fIdealSampleRate");

}
