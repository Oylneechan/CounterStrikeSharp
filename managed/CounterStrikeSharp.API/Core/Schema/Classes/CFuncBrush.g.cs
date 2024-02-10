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
public partial class CFuncBrush : CBaseModelEntity, ICFuncBrush
{
    public CFuncBrush (IntPtr pointer) : base(pointer) {}

	// m_iSolidity
	[SchemaMember("CFuncBrush", "m_iSolidity")]
	public ref BrushSolidities_e Solidity => ref Schema.GetRef<BrushSolidities_e>(this.Handle, "CFuncBrush", "m_iSolidity");

	// m_iDisabled
	[SchemaMember("CFuncBrush", "m_iDisabled")]
	public ref Int32 Disabled => ref Schema.GetRef<Int32>(this.Handle, "CFuncBrush", "m_iDisabled");

	// m_bSolidBsp
	[SchemaMember("CFuncBrush", "m_bSolidBsp")]
	public ref bool SolidBsp => ref Schema.GetRef<bool>(this.Handle, "CFuncBrush", "m_bSolidBsp");

	// m_iszExcludedClass
	[SchemaMember("CFuncBrush", "m_iszExcludedClass")]
	public string ExcludedClass
	{
		get { return Schema.GetUtf8String(this.Handle, "CFuncBrush", "m_iszExcludedClass"); }
		set { Schema.SetString(this.Handle, "CFuncBrush", "m_iszExcludedClass", value); }
	}

	// m_bInvertExclusion
	[SchemaMember("CFuncBrush", "m_bInvertExclusion")]
	public ref bool InvertExclusion => ref Schema.GetRef<bool>(this.Handle, "CFuncBrush", "m_bInvertExclusion");

	// m_bScriptedMovement
	[SchemaMember("CFuncBrush", "m_bScriptedMovement")]
	public ref bool ScriptedMovement => ref Schema.GetRef<bool>(this.Handle, "CFuncBrush", "m_bScriptedMovement");

}
