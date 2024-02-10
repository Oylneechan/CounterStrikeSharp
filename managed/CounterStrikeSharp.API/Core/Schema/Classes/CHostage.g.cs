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
public partial class CHostage : CHostageExpresserShim, ICHostage
{
    public CHostage (IntPtr pointer) : base(pointer) {}

	// m_OnHostageBeginGrab
	[SchemaMember("CHostage", "m_OnHostageBeginGrab")]
	public CEntityIOOutput OnHostageBeginGrab => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CHostage", "m_OnHostageBeginGrab");

	// m_OnFirstPickedUp
	[SchemaMember("CHostage", "m_OnFirstPickedUp")]
	public CEntityIOOutput OnFirstPickedUp => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CHostage", "m_OnFirstPickedUp");

	// m_OnDroppedNotRescued
	[SchemaMember("CHostage", "m_OnDroppedNotRescued")]
	public CEntityIOOutput OnDroppedNotRescued => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CHostage", "m_OnDroppedNotRescued");

	// m_OnRescued
	[SchemaMember("CHostage", "m_OnRescued")]
	public CEntityIOOutput OnRescued => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CHostage", "m_OnRescued");

	// m_entitySpottedState
	[SchemaMember("CHostage", "m_entitySpottedState")]
	public EntitySpottedState_t EntitySpottedState => Schema.GetDeclaredClass<EntitySpottedState_t>(this.Handle, "CHostage", "m_entitySpottedState");

	// m_nSpotRules
	[SchemaMember("CHostage", "m_nSpotRules")]
	public ref Int32 SpotRules => ref Schema.GetRef<Int32>(this.Handle, "CHostage", "m_nSpotRules");

	// m_uiHostageSpawnExclusionGroupMask
	[SchemaMember("CHostage", "m_uiHostageSpawnExclusionGroupMask")]
	public ref UInt32 UiHostageSpawnExclusionGroupMask => ref Schema.GetRef<UInt32>(this.Handle, "CHostage", "m_uiHostageSpawnExclusionGroupMask");

	// m_nHostageSpawnRandomFactor
	[SchemaMember("CHostage", "m_nHostageSpawnRandomFactor")]
	public ref UInt32 HostageSpawnRandomFactor => ref Schema.GetRef<UInt32>(this.Handle, "CHostage", "m_nHostageSpawnRandomFactor");

	// m_bRemove
	[SchemaMember("CHostage", "m_bRemove")]
	public ref bool RemoveProperty => ref Schema.GetRef<bool>(this.Handle, "CHostage", "m_bRemove");

	// m_vel
	[SchemaMember("CHostage", "m_vel")]
	public Vector Vel => Schema.GetDeclaredClass<Vector>(this.Handle, "CHostage", "m_vel");

	// m_isRescued
	[SchemaMember("CHostage", "m_isRescued")]
	public ref bool IsRescued => ref Schema.GetRef<bool>(this.Handle, "CHostage", "m_isRescued");

	// m_jumpedThisFrame
	[SchemaMember("CHostage", "m_jumpedThisFrame")]
	public ref bool JumpedThisFrame => ref Schema.GetRef<bool>(this.Handle, "CHostage", "m_jumpedThisFrame");

	// m_nHostageState
	[SchemaMember("CHostage", "m_nHostageState")]
	public ref Int32 HostageState => ref Schema.GetRef<Int32>(this.Handle, "CHostage", "m_nHostageState");

	// m_leader
	[SchemaMember("CHostage", "m_leader")]
	public CHandle<CBaseEntity> Leader => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CHostage", "m_leader");

	// m_lastLeader
	[SchemaMember("CHostage", "m_lastLeader")]
	public CHandle<CCSPlayerPawnBase> LastLeader => Schema.GetDeclaredClass<CHandle<CCSPlayerPawnBase>>(this.Handle, "CHostage", "m_lastLeader");

	// m_reuseTimer
	[SchemaMember("CHostage", "m_reuseTimer")]
	public CountdownTimer ReuseTimer => Schema.GetDeclaredClass<CountdownTimer>(this.Handle, "CHostage", "m_reuseTimer");

	// m_hasBeenUsed
	[SchemaMember("CHostage", "m_hasBeenUsed")]
	public ref bool HasBeenUsed => ref Schema.GetRef<bool>(this.Handle, "CHostage", "m_hasBeenUsed");

	// m_accel
	[SchemaMember("CHostage", "m_accel")]
	public Vector Accel => Schema.GetDeclaredClass<Vector>(this.Handle, "CHostage", "m_accel");

	// m_isRunning
	[SchemaMember("CHostage", "m_isRunning")]
	public ref bool IsRunning => ref Schema.GetRef<bool>(this.Handle, "CHostage", "m_isRunning");

	// m_isCrouching
	[SchemaMember("CHostage", "m_isCrouching")]
	public ref bool IsCrouching => ref Schema.GetRef<bool>(this.Handle, "CHostage", "m_isCrouching");

	// m_jumpTimer
	[SchemaMember("CHostage", "m_jumpTimer")]
	public CountdownTimer JumpTimer => Schema.GetDeclaredClass<CountdownTimer>(this.Handle, "CHostage", "m_jumpTimer");

	// m_isWaitingForLeader
	[SchemaMember("CHostage", "m_isWaitingForLeader")]
	public ref bool IsWaitingForLeader => ref Schema.GetRef<bool>(this.Handle, "CHostage", "m_isWaitingForLeader");

	// m_repathTimer
	[SchemaMember("CHostage", "m_repathTimer")]
	public CountdownTimer RepathTimer => Schema.GetDeclaredClass<CountdownTimer>(this.Handle, "CHostage", "m_repathTimer");

	// m_inhibitDoorTimer
	[SchemaMember("CHostage", "m_inhibitDoorTimer")]
	public CountdownTimer InhibitDoorTimer => Schema.GetDeclaredClass<CountdownTimer>(this.Handle, "CHostage", "m_inhibitDoorTimer");

	// m_inhibitObstacleAvoidanceTimer
	[SchemaMember("CHostage", "m_inhibitObstacleAvoidanceTimer")]
	public CountdownTimer InhibitObstacleAvoidanceTimer => Schema.GetDeclaredClass<CountdownTimer>(this.Handle, "CHostage", "m_inhibitObstacleAvoidanceTimer");

	// m_wiggleTimer
	[SchemaMember("CHostage", "m_wiggleTimer")]
	public CountdownTimer WiggleTimer => Schema.GetDeclaredClass<CountdownTimer>(this.Handle, "CHostage", "m_wiggleTimer");

	// m_isAdjusted
	[SchemaMember("CHostage", "m_isAdjusted")]
	public ref bool IsAdjusted => ref Schema.GetRef<bool>(this.Handle, "CHostage", "m_isAdjusted");

	// m_bHandsHaveBeenCut
	[SchemaMember("CHostage", "m_bHandsHaveBeenCut")]
	public ref bool HandsHaveBeenCut => ref Schema.GetRef<bool>(this.Handle, "CHostage", "m_bHandsHaveBeenCut");

	// m_hHostageGrabber
	[SchemaMember("CHostage", "m_hHostageGrabber")]
	public CHandle<CCSPlayerPawn> HostageGrabber => Schema.GetDeclaredClass<CHandle<CCSPlayerPawn>>(this.Handle, "CHostage", "m_hHostageGrabber");

	// m_fLastGrabTime
	[SchemaMember("CHostage", "m_fLastGrabTime")]
	public ref float LastGrabTime => ref Schema.GetRef<float>(this.Handle, "CHostage", "m_fLastGrabTime");

	// m_vecPositionWhenStartedDroppingToGround
	[SchemaMember("CHostage", "m_vecPositionWhenStartedDroppingToGround")]
	public Vector PositionWhenStartedDroppingToGround => Schema.GetDeclaredClass<Vector>(this.Handle, "CHostage", "m_vecPositionWhenStartedDroppingToGround");

	// m_vecGrabbedPos
	[SchemaMember("CHostage", "m_vecGrabbedPos")]
	public Vector GrabbedPos => Schema.GetDeclaredClass<Vector>(this.Handle, "CHostage", "m_vecGrabbedPos");

	// m_flRescueStartTime
	[SchemaMember("CHostage", "m_flRescueStartTime")]
	public ref float RescueStartTime => ref Schema.GetRef<float>(this.Handle, "CHostage", "m_flRescueStartTime");

	// m_flGrabSuccessTime
	[SchemaMember("CHostage", "m_flGrabSuccessTime")]
	public ref float GrabSuccessTime => ref Schema.GetRef<float>(this.Handle, "CHostage", "m_flGrabSuccessTime");

	// m_flDropStartTime
	[SchemaMember("CHostage", "m_flDropStartTime")]
	public ref float DropStartTime => ref Schema.GetRef<float>(this.Handle, "CHostage", "m_flDropStartTime");

	// m_nApproachRewardPayouts
	[SchemaMember("CHostage", "m_nApproachRewardPayouts")]
	public ref Int32 ApproachRewardPayouts => ref Schema.GetRef<Int32>(this.Handle, "CHostage", "m_nApproachRewardPayouts");

	// m_nPickupEventCount
	[SchemaMember("CHostage", "m_nPickupEventCount")]
	public ref Int32 PickupEventCount => ref Schema.GetRef<Int32>(this.Handle, "CHostage", "m_nPickupEventCount");

	// m_vecSpawnGroundPos
	[SchemaMember("CHostage", "m_vecSpawnGroundPos")]
	public Vector SpawnGroundPos => Schema.GetDeclaredClass<Vector>(this.Handle, "CHostage", "m_vecSpawnGroundPos");

	// m_vecHostageResetPosition
	[SchemaMember("CHostage", "m_vecHostageResetPosition")]
	public Vector HostageResetPosition => Schema.GetDeclaredClass<Vector>(this.Handle, "CHostage", "m_vecHostageResetPosition");

}
