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
public partial class CCSPlace : CServerOnlyModelEntity, ICCSPlace
{
    public CCSPlace (IntPtr pointer) : base(pointer) {}

	// m_name
	[SchemaMember("CCSPlace", "m_name")]
	public string Name
	{
		get { return Schema.GetUtf8String(this.Handle, "CCSPlace", "m_name"); }
		set { Schema.SetString(this.Handle, "CCSPlace", "m_name", value); }
	}

}
