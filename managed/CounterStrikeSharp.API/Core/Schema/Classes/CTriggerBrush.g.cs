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
public partial class CTriggerBrush : CBaseModelEntity, ICTriggerBrush
{
    public CTriggerBrush (IntPtr pointer) : base(pointer) {}

	// m_OnStartTouch
	[SchemaMember("CTriggerBrush", "m_OnStartTouch")]
	public CEntityIOOutput OnStartTouch => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CTriggerBrush", "m_OnStartTouch");

	// m_OnEndTouch
	[SchemaMember("CTriggerBrush", "m_OnEndTouch")]
	public CEntityIOOutput OnEndTouch => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CTriggerBrush", "m_OnEndTouch");

	// m_OnUse
	[SchemaMember("CTriggerBrush", "m_OnUse")]
	public CEntityIOOutput OnUse => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CTriggerBrush", "m_OnUse");

	// m_iInputFilter
	[SchemaMember("CTriggerBrush", "m_iInputFilter")]
	public ref Int32 InputFilter => ref Schema.GetRef<Int32>(this.Handle, "CTriggerBrush", "m_iInputFilter");

	// m_iDontMessageParent
	[SchemaMember("CTriggerBrush", "m_iDontMessageParent")]
	public ref Int32 DontMessageParent => ref Schema.GetRef<Int32>(this.Handle, "CTriggerBrush", "m_iDontMessageParent");

}
