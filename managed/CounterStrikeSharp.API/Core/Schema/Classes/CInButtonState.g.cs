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
public partial class CInButtonState : NativeObject, ICInButtonState
{
    public CInButtonState (IntPtr pointer) : base(pointer) {}

	// m_pButtonStates
	[SchemaMember("CInButtonState", "m_pButtonStates")]
	public Span<UInt64> ButtonStates => Schema.GetFixedArray<UInt64>(this.Handle, "CInButtonState", "m_pButtonStates", 3);

}
