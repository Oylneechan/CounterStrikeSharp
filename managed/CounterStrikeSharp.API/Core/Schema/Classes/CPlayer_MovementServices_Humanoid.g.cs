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

public partial class CPlayer_MovementServices_Humanoid : CPlayer_MovementServices
{
    public CPlayer_MovementServices_Humanoid (IntPtr pointer) : base(pointer) {}

	// m_flStepSoundTime
	[SchemaMember("CPlayer_MovementServices_Humanoid", "m_flStepSoundTime")]
	public ref float StepSoundTime => ref Schema.GetRef<float>(this.Handle, "CPlayer_MovementServices_Humanoid", "m_flStepSoundTime");

	// m_flFallVelocity
	[SchemaMember("CPlayer_MovementServices_Humanoid", "m_flFallVelocity")]
	public ref float FallVelocity => ref Schema.GetRef<float>(this.Handle, "CPlayer_MovementServices_Humanoid", "m_flFallVelocity");

	// m_bInCrouch
	[SchemaMember("CPlayer_MovementServices_Humanoid", "m_bInCrouch")]
	public ref bool InCrouch => ref Schema.GetRef<bool>(this.Handle, "CPlayer_MovementServices_Humanoid", "m_bInCrouch");

	// m_nCrouchState
	[SchemaMember("CPlayer_MovementServices_Humanoid", "m_nCrouchState")]
	public ref UInt32 CrouchState => ref Schema.GetRef<UInt32>(this.Handle, "CPlayer_MovementServices_Humanoid", "m_nCrouchState");

	// m_flCrouchTransitionStartTime
	[SchemaMember("CPlayer_MovementServices_Humanoid", "m_flCrouchTransitionStartTime")]
	public ref float CrouchTransitionStartTime => ref Schema.GetRef<float>(this.Handle, "CPlayer_MovementServices_Humanoid", "m_flCrouchTransitionStartTime");

	// m_bDucked
	[SchemaMember("CPlayer_MovementServices_Humanoid", "m_bDucked")]
	public ref bool Ducked => ref Schema.GetRef<bool>(this.Handle, "CPlayer_MovementServices_Humanoid", "m_bDucked");

	// m_bDucking
	[SchemaMember("CPlayer_MovementServices_Humanoid", "m_bDucking")]
	public ref bool Ducking => ref Schema.GetRef<bool>(this.Handle, "CPlayer_MovementServices_Humanoid", "m_bDucking");

	// m_bInDuckJump
	[SchemaMember("CPlayer_MovementServices_Humanoid", "m_bInDuckJump")]
	public ref bool InDuckJump => ref Schema.GetRef<bool>(this.Handle, "CPlayer_MovementServices_Humanoid", "m_bInDuckJump");

	// m_groundNormal
	[SchemaMember("CPlayer_MovementServices_Humanoid", "m_groundNormal")]
	public Vector GroundNormal => Schema.GetDeclaredClass<Vector>(this.Handle, "CPlayer_MovementServices_Humanoid", "m_groundNormal");

	// m_flSurfaceFriction
	[SchemaMember("CPlayer_MovementServices_Humanoid", "m_flSurfaceFriction")]
	public ref float SurfaceFriction => ref Schema.GetRef<float>(this.Handle, "CPlayer_MovementServices_Humanoid", "m_flSurfaceFriction");

	// m_surfaceProps
	[SchemaMember("CPlayer_MovementServices_Humanoid", "m_surfaceProps")]
	public CUtlStringToken SurfaceProps => Schema.GetDeclaredClass<CUtlStringToken>(this.Handle, "CPlayer_MovementServices_Humanoid", "m_surfaceProps");

	// m_nStepside
	[SchemaMember("CPlayer_MovementServices_Humanoid", "m_nStepside")]
	public ref Int32 Stepside => ref Schema.GetRef<Int32>(this.Handle, "CPlayer_MovementServices_Humanoid", "m_nStepside");

	// m_iTargetVolume
	[SchemaMember("CPlayer_MovementServices_Humanoid", "m_iTargetVolume")]
	public ref Int32 TargetVolume => ref Schema.GetRef<Int32>(this.Handle, "CPlayer_MovementServices_Humanoid", "m_iTargetVolume");

	// m_vecSmoothedVelocity
	[SchemaMember("CPlayer_MovementServices_Humanoid", "m_vecSmoothedVelocity")]
	public Vector SmoothedVelocity => Schema.GetDeclaredClass<Vector>(this.Handle, "CPlayer_MovementServices_Humanoid", "m_vecSmoothedVelocity");

}
