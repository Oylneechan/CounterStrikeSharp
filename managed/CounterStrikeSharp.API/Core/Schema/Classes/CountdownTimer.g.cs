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
public partial class CountdownTimer : NativeObject, ICountdownTimer
{
    public CountdownTimer (IntPtr pointer) : base(pointer) {}

	// m_duration
	[SchemaMember("CountdownTimer", "m_duration")]
	public ref float Duration => ref Schema.GetRef<float>(this.Handle, "CountdownTimer", "m_duration");

	// m_timestamp
	[SchemaMember("CountdownTimer", "m_timestamp")]
	public ref float Timestamp => ref Schema.GetRef<float>(this.Handle, "CountdownTimer", "m_timestamp");

	// m_timescale
	[SchemaMember("CountdownTimer", "m_timescale")]
	public ref float Timescale => ref Schema.GetRef<float>(this.Handle, "CountdownTimer", "m_timescale");

	// m_nWorldGroupId
	[SchemaMember("CountdownTimer", "m_nWorldGroupId")]
	public WorldGroupId_t WorldGroupId => Schema.GetDeclaredClass<WorldGroupId_t>(this.Handle, "CountdownTimer", "m_nWorldGroupId");

}
