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
public partial class CBaseDMStart : CPointEntity, ICBaseDMStart
{
    public CBaseDMStart (IntPtr pointer) : base(pointer) {}

	// m_Master
	[SchemaMember("CBaseDMStart", "m_Master")]
	public string Master
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseDMStart", "m_Master"); }
		set { Schema.SetString(this.Handle, "CBaseDMStart", "m_Master", value); }
	}

}
