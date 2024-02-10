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
public partial class CMultiSource : CLogicalEntity, ICMultiSource
{
    public CMultiSource (IntPtr pointer) : base(pointer) {}

	// m_rgEntities
	[SchemaMember("CMultiSource", "m_rgEntities")]
	public Span<CHandle<CBaseEntity>> RgEntities => Schema.GetFixedArray<CHandle<CBaseEntity>>(this.Handle, "CMultiSource", "m_rgEntities", 32);

	// m_rgTriggered
	[SchemaMember("CMultiSource", "m_rgTriggered")]
	public Span<Int32> RgTriggered => Schema.GetFixedArray<Int32>(this.Handle, "CMultiSource", "m_rgTriggered", 32);

	// m_OnTrigger
	[SchemaMember("CMultiSource", "m_OnTrigger")]
	public CEntityIOOutput OnTrigger => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CMultiSource", "m_OnTrigger");

	// m_iTotal
	[SchemaMember("CMultiSource", "m_iTotal")]
	public ref Int32 Total => ref Schema.GetRef<Int32>(this.Handle, "CMultiSource", "m_iTotal");

	// m_globalstate
	[SchemaMember("CMultiSource", "m_globalstate")]
	public string Globalstate
	{
		get { return Schema.GetUtf8String(this.Handle, "CMultiSource", "m_globalstate"); }
		set { Schema.SetString(this.Handle, "CMultiSource", "m_globalstate", value); }
	}

}
