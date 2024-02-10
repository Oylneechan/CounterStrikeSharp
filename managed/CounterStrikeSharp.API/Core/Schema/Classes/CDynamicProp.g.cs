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
public partial class CDynamicProp : CBreakableProp, ICDynamicProp
{
    public CDynamicProp (IntPtr pointer) : base(pointer) {}

	// m_bCreateNavObstacle
	[SchemaMember("CDynamicProp", "m_bCreateNavObstacle")]
	public ref bool CreateNavObstacle => ref Schema.GetRef<bool>(this.Handle, "CDynamicProp", "m_bCreateNavObstacle");

	// m_bUseHitboxesForRenderBox
	[SchemaMember("CDynamicProp", "m_bUseHitboxesForRenderBox")]
	public ref bool UseHitboxesForRenderBox => ref Schema.GetRef<bool>(this.Handle, "CDynamicProp", "m_bUseHitboxesForRenderBox");

	// m_bUseAnimGraph
	[SchemaMember("CDynamicProp", "m_bUseAnimGraph")]
	public ref bool UseAnimGraph => ref Schema.GetRef<bool>(this.Handle, "CDynamicProp", "m_bUseAnimGraph");

	// m_pOutputAnimBegun
	[SchemaMember("CDynamicProp", "m_pOutputAnimBegun")]
	public CEntityIOOutput OutputAnimBegun => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CDynamicProp", "m_pOutputAnimBegun");

	// m_pOutputAnimOver
	[SchemaMember("CDynamicProp", "m_pOutputAnimOver")]
	public CEntityIOOutput OutputAnimOver => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CDynamicProp", "m_pOutputAnimOver");

	// m_pOutputAnimLoopCycleOver
	[SchemaMember("CDynamicProp", "m_pOutputAnimLoopCycleOver")]
	public CEntityIOOutput OutputAnimLoopCycleOver => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CDynamicProp", "m_pOutputAnimLoopCycleOver");

	// m_OnAnimReachedStart
	[SchemaMember("CDynamicProp", "m_OnAnimReachedStart")]
	public CEntityIOOutput OnAnimReachedStart => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CDynamicProp", "m_OnAnimReachedStart");

	// m_OnAnimReachedEnd
	[SchemaMember("CDynamicProp", "m_OnAnimReachedEnd")]
	public CEntityIOOutput OnAnimReachedEnd => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CDynamicProp", "m_OnAnimReachedEnd");

	// m_iszDefaultAnim
	[SchemaMember("CDynamicProp", "m_iszDefaultAnim")]
	public string DefaultAnim
	{
		get { return Schema.GetUtf8String(this.Handle, "CDynamicProp", "m_iszDefaultAnim"); }
		set { Schema.SetString(this.Handle, "CDynamicProp", "m_iszDefaultAnim", value); }
	}

	// m_nDefaultAnimLoopMode
	[SchemaMember("CDynamicProp", "m_nDefaultAnimLoopMode")]
	public ref AnimLoopMode_t DefaultAnimLoopMode => ref Schema.GetRef<AnimLoopMode_t>(this.Handle, "CDynamicProp", "m_nDefaultAnimLoopMode");

	// m_bAnimateOnServer
	[SchemaMember("CDynamicProp", "m_bAnimateOnServer")]
	public ref bool AnimateOnServer => ref Schema.GetRef<bool>(this.Handle, "CDynamicProp", "m_bAnimateOnServer");

	// m_bRandomizeCycle
	[SchemaMember("CDynamicProp", "m_bRandomizeCycle")]
	public ref bool RandomizeCycle => ref Schema.GetRef<bool>(this.Handle, "CDynamicProp", "m_bRandomizeCycle");

	// m_bStartDisabled
	[SchemaMember("CDynamicProp", "m_bStartDisabled")]
	public ref bool StartDisabled => ref Schema.GetRef<bool>(this.Handle, "CDynamicProp", "m_bStartDisabled");

	// m_bScriptedMovement
	[SchemaMember("CDynamicProp", "m_bScriptedMovement")]
	public ref bool ScriptedMovement => ref Schema.GetRef<bool>(this.Handle, "CDynamicProp", "m_bScriptedMovement");

	// m_bFiredStartEndOutput
	[SchemaMember("CDynamicProp", "m_bFiredStartEndOutput")]
	public ref bool FiredStartEndOutput => ref Schema.GetRef<bool>(this.Handle, "CDynamicProp", "m_bFiredStartEndOutput");

	// m_bForceNpcExclude
	[SchemaMember("CDynamicProp", "m_bForceNpcExclude")]
	public ref bool ForceNpcExclude => ref Schema.GetRef<bool>(this.Handle, "CDynamicProp", "m_bForceNpcExclude");

	// m_bCreateNonSolid
	[SchemaMember("CDynamicProp", "m_bCreateNonSolid")]
	public ref bool CreateNonSolid => ref Schema.GetRef<bool>(this.Handle, "CDynamicProp", "m_bCreateNonSolid");

	// m_bIsOverrideProp
	[SchemaMember("CDynamicProp", "m_bIsOverrideProp")]
	public ref bool IsOverrideProp => ref Schema.GetRef<bool>(this.Handle, "CDynamicProp", "m_bIsOverrideProp");

	// m_iInitialGlowState
	[SchemaMember("CDynamicProp", "m_iInitialGlowState")]
	public ref Int32 InitialGlowState => ref Schema.GetRef<Int32>(this.Handle, "CDynamicProp", "m_iInitialGlowState");

	// m_nGlowRange
	[SchemaMember("CDynamicProp", "m_nGlowRange")]
	public ref Int32 GlowRange => ref Schema.GetRef<Int32>(this.Handle, "CDynamicProp", "m_nGlowRange");

	// m_nGlowRangeMin
	[SchemaMember("CDynamicProp", "m_nGlowRangeMin")]
	public ref Int32 GlowRangeMin => ref Schema.GetRef<Int32>(this.Handle, "CDynamicProp", "m_nGlowRangeMin");

	// m_glowColor
	[SchemaMember("CDynamicProp", "m_glowColor")]
	public Color GlowColor
	{
		get { return Schema.GetCustomMarshalledType<Color>(this.Handle, "CDynamicProp", "m_glowColor"); }
		set { Schema.SetCustomMarshalledType<Color>(this.Handle, "CDynamicProp", "m_glowColor", value); }
	}

	// m_nGlowTeam
	[SchemaMember("CDynamicProp", "m_nGlowTeam")]
	public ref Int32 GlowTeam => ref Schema.GetRef<Int32>(this.Handle, "CDynamicProp", "m_nGlowTeam");

}
