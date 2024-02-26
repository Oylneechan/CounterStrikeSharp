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

public partial class CLogicCompare : CLogicalEntity
{
    public CLogicCompare (IntPtr pointer) : base(pointer) {}

	// m_flInValue
	[SchemaMember("CLogicCompare", "m_flInValue")]
	public ref float InValue => ref Schema.GetRef<float>(this.Handle, "CLogicCompare", "m_flInValue");

	// m_flCompareValue
	[SchemaMember("CLogicCompare", "m_flCompareValue")]
	public ref float CompareValue => ref Schema.GetRef<float>(this.Handle, "CLogicCompare", "m_flCompareValue");

}
