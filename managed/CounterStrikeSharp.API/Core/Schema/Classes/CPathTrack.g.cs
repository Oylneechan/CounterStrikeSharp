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

public partial class CPathTrack : CPointEntity
{
    public CPathTrack (IntPtr pointer) : base(pointer) {}

	// m_pnext
	[SchemaMember("CPathTrack", "m_pnext")]
	public CPathTrack? Pnext => Schema.GetPointer<CPathTrack>(this.Handle, "CPathTrack", "m_pnext");

	// m_pprevious
	[SchemaMember("CPathTrack", "m_pprevious")]
	public CPathTrack? Pprevious => Schema.GetPointer<CPathTrack>(this.Handle, "CPathTrack", "m_pprevious");

	// m_paltpath
	[SchemaMember("CPathTrack", "m_paltpath")]
	public CPathTrack? Paltpath => Schema.GetPointer<CPathTrack>(this.Handle, "CPathTrack", "m_paltpath");

	// m_flRadius
	[SchemaMember("CPathTrack", "m_flRadius")]
	public ref float Radius => ref Schema.GetRef<float>(this.Handle, "CPathTrack", "m_flRadius");

	// m_length
	[SchemaMember("CPathTrack", "m_length")]
	public ref float Length => ref Schema.GetRef<float>(this.Handle, "CPathTrack", "m_length");

	// m_altName
	[SchemaMember("CPathTrack", "m_altName")]
	public string AltName
	{
		get { return Schema.GetUtf8String(this.Handle, "CPathTrack", "m_altName"); }
		set { Schema.SetString(this.Handle, "CPathTrack", "m_altName", value); }
	}

	// m_nIterVal
	[SchemaMember("CPathTrack", "m_nIterVal")]
	public ref Int32 IterVal => ref Schema.GetRef<Int32>(this.Handle, "CPathTrack", "m_nIterVal");

	// m_eOrientationType
	[SchemaMember("CPathTrack", "m_eOrientationType")]
	public ref TrackOrientationType_t OrientationType => ref Schema.GetRef<TrackOrientationType_t>(this.Handle, "CPathTrack", "m_eOrientationType");

	// m_OnPass
	[SchemaMember("CPathTrack", "m_OnPass")]
	public CEntityIOOutput OnPass => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPathTrack", "m_OnPass");

}
