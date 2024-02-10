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
public partial class CPointClientUIDialog : CBaseClientUIEntity, ICPointClientUIDialog
{
    public CPointClientUIDialog (IntPtr pointer) : base(pointer) {}

	// m_hActivator
	[SchemaMember("CPointClientUIDialog", "m_hActivator")]
	public CHandle<CBaseEntity> Activator => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CPointClientUIDialog", "m_hActivator");

	// m_bStartEnabled
	[SchemaMember("CPointClientUIDialog", "m_bStartEnabled")]
	public ref bool StartEnabled => ref Schema.GetRef<bool>(this.Handle, "CPointClientUIDialog", "m_bStartEnabled");

}
