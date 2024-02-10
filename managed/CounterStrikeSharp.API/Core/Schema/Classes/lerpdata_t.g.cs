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
public partial class lerpdata_t : NativeObject, Ilerpdata_t
{
    public lerpdata_t (IntPtr pointer) : base(pointer) {}

	// m_hEnt
	[SchemaMember("lerpdata_t", "m_hEnt")]
	public CHandle<CBaseEntity> Ent => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "lerpdata_t", "m_hEnt");

	// m_MoveType
	[SchemaMember("lerpdata_t", "m_MoveType")]
	public ref MoveType_t MoveType => ref Schema.GetRef<MoveType_t>(this.Handle, "lerpdata_t", "m_MoveType");

	// m_flStartTime
	[SchemaMember("lerpdata_t", "m_flStartTime")]
	public ref float StartTime => ref Schema.GetRef<float>(this.Handle, "lerpdata_t", "m_flStartTime");

	// m_vecStartOrigin
	[SchemaMember("lerpdata_t", "m_vecStartOrigin")]
	public Vector StartOrigin => Schema.GetDeclaredClass<Vector>(this.Handle, "lerpdata_t", "m_vecStartOrigin");

	// m_qStartRot
	[SchemaMember("lerpdata_t", "m_qStartRot")]
	public Quaternion StartRot => Schema.GetDeclaredClass<Quaternion>(this.Handle, "lerpdata_t", "m_qStartRot");

	// m_nFXIndex
	[SchemaMember("lerpdata_t", "m_nFXIndex")]
	public ParticleIndex_t FXIndex => Schema.GetDeclaredClass<ParticleIndex_t>(this.Handle, "lerpdata_t", "m_nFXIndex");

}
