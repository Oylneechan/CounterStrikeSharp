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
public partial class CSoundOpvarSetEntity : CBaseEntity, ICSoundOpvarSetEntity
{
    public CSoundOpvarSetEntity (IntPtr pointer) : base(pointer) {}

	// m_iszStackName
	[SchemaMember("CSoundOpvarSetEntity", "m_iszStackName")]
	public string StackName
	{
		get { return Schema.GetUtf8String(this.Handle, "CSoundOpvarSetEntity", "m_iszStackName"); }
		set { Schema.SetString(this.Handle, "CSoundOpvarSetEntity", "m_iszStackName", value); }
	}

	// m_iszOperatorName
	[SchemaMember("CSoundOpvarSetEntity", "m_iszOperatorName")]
	public string OperatorName
	{
		get { return Schema.GetUtf8String(this.Handle, "CSoundOpvarSetEntity", "m_iszOperatorName"); }
		set { Schema.SetString(this.Handle, "CSoundOpvarSetEntity", "m_iszOperatorName", value); }
	}

	// m_iszOpvarName
	[SchemaMember("CSoundOpvarSetEntity", "m_iszOpvarName")]
	public string OpvarName
	{
		get { return Schema.GetUtf8String(this.Handle, "CSoundOpvarSetEntity", "m_iszOpvarName"); }
		set { Schema.SetString(this.Handle, "CSoundOpvarSetEntity", "m_iszOpvarName", value); }
	}

	// m_nOpvarType
	[SchemaMember("CSoundOpvarSetEntity", "m_nOpvarType")]
	public ref Int32 OpvarType => ref Schema.GetRef<Int32>(this.Handle, "CSoundOpvarSetEntity", "m_nOpvarType");

	// m_nOpvarIndex
	[SchemaMember("CSoundOpvarSetEntity", "m_nOpvarIndex")]
	public ref Int32 OpvarIndex => ref Schema.GetRef<Int32>(this.Handle, "CSoundOpvarSetEntity", "m_nOpvarIndex");

	// m_flOpvarValue
	[SchemaMember("CSoundOpvarSetEntity", "m_flOpvarValue")]
	public ref float OpvarValue => ref Schema.GetRef<float>(this.Handle, "CSoundOpvarSetEntity", "m_flOpvarValue");

	// m_OpvarValueString
	[SchemaMember("CSoundOpvarSetEntity", "m_OpvarValueString")]
	public string OpvarValueString
	{
		get { return Schema.GetUtf8String(this.Handle, "CSoundOpvarSetEntity", "m_OpvarValueString"); }
		set { Schema.SetString(this.Handle, "CSoundOpvarSetEntity", "m_OpvarValueString", value); }
	}

	// m_bSetOnSpawn
	[SchemaMember("CSoundOpvarSetEntity", "m_bSetOnSpawn")]
	public ref bool SetOnSpawn => ref Schema.GetRef<bool>(this.Handle, "CSoundOpvarSetEntity", "m_bSetOnSpawn");

}
