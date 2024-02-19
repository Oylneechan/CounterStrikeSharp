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
public partial class CSoundOpvarSetAutoRoomEntity : CSoundOpvarSetPointEntity, ICSoundOpvarSetAutoRoomEntity
{
    public CSoundOpvarSetAutoRoomEntity (IntPtr pointer) : base(pointer) {}

	// m_traceResults
	[SchemaMember("CSoundOpvarSetAutoRoomEntity", "m_traceResults")]
	public NetworkedVector<SoundOpvarTraceResult_t> TraceResults => Schema.GetDeclaredClass<NetworkedVector<SoundOpvarTraceResult_t>>(this.Handle, "CSoundOpvarSetAutoRoomEntity", "m_traceResults");

	// m_flSize
	[SchemaMember("CSoundOpvarSetAutoRoomEntity", "m_flSize")]
	public ref float Size => ref Schema.GetRef<float>(this.Handle, "CSoundOpvarSetAutoRoomEntity", "m_flSize");

	// m_flHeightTolerance
	[SchemaMember("CSoundOpvarSetAutoRoomEntity", "m_flHeightTolerance")]
	public ref float HeightTolerance => ref Schema.GetRef<float>(this.Handle, "CSoundOpvarSetAutoRoomEntity", "m_flHeightTolerance");

	// m_flSizeSqr
	[SchemaMember("CSoundOpvarSetAutoRoomEntity", "m_flSizeSqr")]
	public ref float SizeSqr => ref Schema.GetRef<float>(this.Handle, "CSoundOpvarSetAutoRoomEntity", "m_flSizeSqr");

}
