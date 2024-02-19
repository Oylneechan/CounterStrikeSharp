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
public partial class CEntityInstance : NativeEntity, ICEntityInstance
{
	// m_iszPrivateVScripts
	[SchemaMember("CEntityInstance", "m_iszPrivateVScripts")]
	public string PrivateVScripts
	{
		get { return Schema.GetUtf8String(this.Handle, "CEntityInstance", "m_iszPrivateVScripts"); }
		set { Schema.SetString(this.Handle, "CEntityInstance", "m_iszPrivateVScripts", value); }
	}

	// m_pEntity
	[SchemaMember("CEntityInstance", "m_pEntity")]
	public CEntityIdentity? Entity => Schema.GetPointer<CEntityIdentity>(this.Handle, "CEntityInstance", "m_pEntity");

	// m_CScriptComponent
	[SchemaMember("CEntityInstance", "m_CScriptComponent")]
	public CScriptComponent? CScriptComponent => Schema.GetPointer<CScriptComponent>(this.Handle, "CEntityInstance", "m_CScriptComponent");

	// m_bVisibleinPVS
	[SchemaMember("CEntityInstance", "m_bVisibleinPVS")]
	public ref bool VisibleinPVS => ref Schema.GetRef<bool>(this.Handle, "CEntityInstance", "m_bVisibleinPVS");

}
