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

public partial class CCSPlayerPawnBase : CBasePlayerPawn
{
    public CCSPlayerPawnBase (IntPtr pointer) : base(pointer) {}

	// m_CTouchExpansionComponent
	[SchemaMember("CCSPlayerPawnBase", "m_CTouchExpansionComponent")]
	public CTouchExpansionComponent CTouchExpansionComponent => Schema.GetDeclaredClass<CTouchExpansionComponent>(this.Handle, "CCSPlayerPawnBase", "m_CTouchExpansionComponent");

	// m_pPingServices
	[SchemaMember("CCSPlayerPawnBase", "m_pPingServices")]
	public CCSPlayer_PingServices? PingServices => Schema.GetPointer<CCSPlayer_PingServices>(this.Handle, "CCSPlayerPawnBase", "m_pPingServices");

	// m_pViewModelServices
	[SchemaMember("CCSPlayerPawnBase", "m_pViewModelServices")]
	public CPlayer_ViewModelServices? ViewModelServices => Schema.GetPointer<CPlayer_ViewModelServices>(this.Handle, "CCSPlayerPawnBase", "m_pViewModelServices");

	// m_iDisplayHistoryBits
	[SchemaMember("CCSPlayerPawnBase", "m_iDisplayHistoryBits")]
	public ref UInt32 DisplayHistoryBits => ref Schema.GetRef<UInt32>(this.Handle, "CCSPlayerPawnBase", "m_iDisplayHistoryBits");

	// m_flLastAttackedTeammate
	[SchemaMember("CCSPlayerPawnBase", "m_flLastAttackedTeammate")]
	public ref float LastAttackedTeammate => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flLastAttackedTeammate");

	// m_hOriginalController
	[SchemaMember("CCSPlayerPawnBase", "m_hOriginalController")]
	public CHandle<CCSPlayerController> OriginalController => Schema.GetDeclaredClass<CHandle<CCSPlayerController>>(this.Handle, "CCSPlayerPawnBase", "m_hOriginalController");

	// m_blindUntilTime
	[SchemaMember("CCSPlayerPawnBase", "m_blindUntilTime")]
	public ref float BlindUntilTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_blindUntilTime");

	// m_blindStartTime
	[SchemaMember("CCSPlayerPawnBase", "m_blindStartTime")]
	public ref float BlindStartTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_blindStartTime");

	// m_allowAutoFollowTime
	[SchemaMember("CCSPlayerPawnBase", "m_allowAutoFollowTime")]
	public ref float AllowAutoFollowTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_allowAutoFollowTime");

	// m_entitySpottedState
	[SchemaMember("CCSPlayerPawnBase", "m_entitySpottedState")]
	public EntitySpottedState_t EntitySpottedState => Schema.GetDeclaredClass<EntitySpottedState_t>(this.Handle, "CCSPlayerPawnBase", "m_entitySpottedState");

	// m_nSpotRules
	[SchemaMember("CCSPlayerPawnBase", "m_nSpotRules")]
	public ref Int32 SpotRules => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_nSpotRules");

	// m_iPlayerState
	[SchemaMember("CCSPlayerPawnBase", "m_iPlayerState")]
	public ref CSPlayerState PlayerState => ref Schema.GetRef<CSPlayerState>(this.Handle, "CCSPlayerPawnBase", "m_iPlayerState");

	// m_chickenIdleSoundTimer
	[SchemaMember("CCSPlayerPawnBase", "m_chickenIdleSoundTimer")]
	public CountdownTimer ChickenIdleSoundTimer => Schema.GetDeclaredClass<CountdownTimer>(this.Handle, "CCSPlayerPawnBase", "m_chickenIdleSoundTimer");

	// m_chickenJumpSoundTimer
	[SchemaMember("CCSPlayerPawnBase", "m_chickenJumpSoundTimer")]
	public CountdownTimer ChickenJumpSoundTimer => Schema.GetDeclaredClass<CountdownTimer>(this.Handle, "CCSPlayerPawnBase", "m_chickenJumpSoundTimer");

	// m_vecLastBookmarkedPosition
	[SchemaMember("CCSPlayerPawnBase", "m_vecLastBookmarkedPosition")]
	public Vector LastBookmarkedPosition => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawnBase", "m_vecLastBookmarkedPosition");

	// m_flLastDistanceTraveledNotice
	[SchemaMember("CCSPlayerPawnBase", "m_flLastDistanceTraveledNotice")]
	public ref float LastDistanceTraveledNotice => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flLastDistanceTraveledNotice");

	// m_flAccumulatedDistanceTraveled
	[SchemaMember("CCSPlayerPawnBase", "m_flAccumulatedDistanceTraveled")]
	public ref float AccumulatedDistanceTraveled => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flAccumulatedDistanceTraveled");

	// m_flLastFriendlyFireDamageReductionRatio
	[SchemaMember("CCSPlayerPawnBase", "m_flLastFriendlyFireDamageReductionRatio")]
	public ref float LastFriendlyFireDamageReductionRatio => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flLastFriendlyFireDamageReductionRatio");

	// m_bRespawning
	[SchemaMember("CCSPlayerPawnBase", "m_bRespawning")]
	public ref bool Respawning => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bRespawning");

	// m_nLastPickupPriority
	[SchemaMember("CCSPlayerPawnBase", "m_nLastPickupPriority")]
	public ref Int32 LastPickupPriority => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_nLastPickupPriority");

	// m_flLastPickupPriorityTime
	[SchemaMember("CCSPlayerPawnBase", "m_flLastPickupPriorityTime")]
	public ref float LastPickupPriorityTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flLastPickupPriorityTime");

	// m_bIsScoped
	[SchemaMember("CCSPlayerPawnBase", "m_bIsScoped")]
	public ref bool IsScoped => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bIsScoped");

	// m_bIsWalking
	[SchemaMember("CCSPlayerPawnBase", "m_bIsWalking")]
	public ref bool IsWalking => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bIsWalking");

	// m_bResumeZoom
	[SchemaMember("CCSPlayerPawnBase", "m_bResumeZoom")]
	public ref bool ResumeZoom => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bResumeZoom");

	// m_bIsDefusing
	[SchemaMember("CCSPlayerPawnBase", "m_bIsDefusing")]
	public ref bool IsDefusing => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bIsDefusing");

	// m_bIsGrabbingHostage
	[SchemaMember("CCSPlayerPawnBase", "m_bIsGrabbingHostage")]
	public ref bool IsGrabbingHostage => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bIsGrabbingHostage");

	// m_iBlockingUseActionInProgress
	[SchemaMember("CCSPlayerPawnBase", "m_iBlockingUseActionInProgress")]
	public ref CSPlayerBlockingUseAction_t BlockingUseActionInProgress => ref Schema.GetRef<CSPlayerBlockingUseAction_t>(this.Handle, "CCSPlayerPawnBase", "m_iBlockingUseActionInProgress");

	// m_fImmuneToGunGameDamageTime
	[SchemaMember("CCSPlayerPawnBase", "m_fImmuneToGunGameDamageTime")]
	public ref float ImmuneToGunGameDamageTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_fImmuneToGunGameDamageTime");

	// m_bGunGameImmunity
	[SchemaMember("CCSPlayerPawnBase", "m_bGunGameImmunity")]
	public ref bool GunGameImmunity => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bGunGameImmunity");

	// m_GunGameImmunityColor
	[SchemaMember("CCSPlayerPawnBase", "m_GunGameImmunityColor")]
	public Color GunGameImmunityColor
	{
		get { return Schema.GetCustomMarshalledType<Color>(this.Handle, "CCSPlayerPawnBase", "m_GunGameImmunityColor"); }
		set { Schema.SetCustomMarshalledType<Color>(this.Handle, "CCSPlayerPawnBase", "m_GunGameImmunityColor", value); }
	}

	// m_fMolotovDamageTime
	[SchemaMember("CCSPlayerPawnBase", "m_fMolotovDamageTime")]
	public ref float MolotovDamageTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_fMolotovDamageTime");

	// m_bHasMovedSinceSpawn
	[SchemaMember("CCSPlayerPawnBase", "m_bHasMovedSinceSpawn")]
	public ref bool HasMovedSinceSpawn => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bHasMovedSinceSpawn");

	// m_bCanMoveDuringFreezePeriod
	[SchemaMember("CCSPlayerPawnBase", "m_bCanMoveDuringFreezePeriod")]
	public ref bool CanMoveDuringFreezePeriod => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bCanMoveDuringFreezePeriod");

	// m_flGuardianTooFarDistFrac
	[SchemaMember("CCSPlayerPawnBase", "m_flGuardianTooFarDistFrac")]
	public ref float GuardianTooFarDistFrac => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flGuardianTooFarDistFrac");

	// m_flNextGuardianTooFarHurtTime
	[SchemaMember("CCSPlayerPawnBase", "m_flNextGuardianTooFarHurtTime")]
	public ref float NextGuardianTooFarHurtTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flNextGuardianTooFarHurtTime");

	// m_flDetectedByEnemySensorTime
	[SchemaMember("CCSPlayerPawnBase", "m_flDetectedByEnemySensorTime")]
	public ref float DetectedByEnemySensorTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flDetectedByEnemySensorTime");

	// m_flDealtDamageToEnemyMostRecentTimestamp
	[SchemaMember("CCSPlayerPawnBase", "m_flDealtDamageToEnemyMostRecentTimestamp")]
	public ref float DealtDamageToEnemyMostRecentTimestamp => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flDealtDamageToEnemyMostRecentTimestamp");

	// m_flLastEquippedHelmetTime
	[SchemaMember("CCSPlayerPawnBase", "m_flLastEquippedHelmetTime")]
	public ref float LastEquippedHelmetTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flLastEquippedHelmetTime");

	// m_flLastEquippedArmorTime
	[SchemaMember("CCSPlayerPawnBase", "m_flLastEquippedArmorTime")]
	public ref float LastEquippedArmorTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flLastEquippedArmorTime");

	// m_nHeavyAssaultSuitCooldownRemaining
	[SchemaMember("CCSPlayerPawnBase", "m_nHeavyAssaultSuitCooldownRemaining")]
	public ref Int32 HeavyAssaultSuitCooldownRemaining => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_nHeavyAssaultSuitCooldownRemaining");

	// m_bResetArmorNextSpawn
	[SchemaMember("CCSPlayerPawnBase", "m_bResetArmorNextSpawn")]
	public ref bool ResetArmorNextSpawn => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bResetArmorNextSpawn");

	// m_flLastBumpMineBumpTime
	[SchemaMember("CCSPlayerPawnBase", "m_flLastBumpMineBumpTime")]
	public ref float LastBumpMineBumpTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flLastBumpMineBumpTime");

	// m_flEmitSoundTime
	[SchemaMember("CCSPlayerPawnBase", "m_flEmitSoundTime")]
	public ref float EmitSoundTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flEmitSoundTime");

	// m_iNumSpawns
	[SchemaMember("CCSPlayerPawnBase", "m_iNumSpawns")]
	public ref Int32 NumSpawns => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_iNumSpawns");

	// m_iShouldHaveCash
	[SchemaMember("CCSPlayerPawnBase", "m_iShouldHaveCash")]
	public ref Int32 ShouldHaveCash => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_iShouldHaveCash");

	// m_flIdleTimeSinceLastAction
	[SchemaMember("CCSPlayerPawnBase", "m_flIdleTimeSinceLastAction")]
	public ref float IdleTimeSinceLastAction => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flIdleTimeSinceLastAction");

	// m_flNameChangeHistory
	[SchemaMember("CCSPlayerPawnBase", "m_flNameChangeHistory")]
	public Span<float> NameChangeHistory => Schema.GetFixedArray<float>(this.Handle, "CCSPlayerPawnBase", "m_flNameChangeHistory", 5);

	// m_fLastGivenDefuserTime
	[SchemaMember("CCSPlayerPawnBase", "m_fLastGivenDefuserTime")]
	public ref float LastGivenDefuserTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_fLastGivenDefuserTime");

	// m_fLastGivenBombTime
	[SchemaMember("CCSPlayerPawnBase", "m_fLastGivenBombTime")]
	public ref float LastGivenBombTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_fLastGivenBombTime");

	// m_bHasNightVision
	[SchemaMember("CCSPlayerPawnBase", "m_bHasNightVision")]
	public ref bool HasNightVision => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bHasNightVision");

	// m_bNightVisionOn
	[SchemaMember("CCSPlayerPawnBase", "m_bNightVisionOn")]
	public ref bool NightVisionOn => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bNightVisionOn");

	// m_fNextRadarUpdateTime
	[SchemaMember("CCSPlayerPawnBase", "m_fNextRadarUpdateTime")]
	public ref float NextRadarUpdateTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_fNextRadarUpdateTime");

	// m_flLastMoneyUpdateTime
	[SchemaMember("CCSPlayerPawnBase", "m_flLastMoneyUpdateTime")]
	public ref float LastMoneyUpdateTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flLastMoneyUpdateTime");

	// m_MenuStringBuffer
	[SchemaMember("CCSPlayerPawnBase", "m_MenuStringBuffer")]
	public string MenuStringBuffer
	{
		get { return Schema.GetString(this.Handle, "CCSPlayerPawnBase", "m_MenuStringBuffer"); }
		set { Schema.SetStringBytes(this.Handle, "CCSPlayerPawnBase", "m_MenuStringBuffer", value, 1024); }
	}

	// m_fIntroCamTime
	[SchemaMember("CCSPlayerPawnBase", "m_fIntroCamTime")]
	public ref float IntroCamTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_fIntroCamTime");

	// m_nMyCollisionGroup
	[SchemaMember("CCSPlayerPawnBase", "m_nMyCollisionGroup")]
	public ref Int32 MyCollisionGroup => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_nMyCollisionGroup");

	// m_bInNoDefuseArea
	[SchemaMember("CCSPlayerPawnBase", "m_bInNoDefuseArea")]
	public ref bool InNoDefuseArea => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bInNoDefuseArea");

	// m_bKilledByTaser
	[SchemaMember("CCSPlayerPawnBase", "m_bKilledByTaser")]
	public ref bool KilledByTaser => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bKilledByTaser");

	// m_iMoveState
	[SchemaMember("CCSPlayerPawnBase", "m_iMoveState")]
	public ref Int32 MoveState => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_iMoveState");

	// m_grenadeParameterStashTime
	[SchemaMember("CCSPlayerPawnBase", "m_grenadeParameterStashTime")]
	public ref float GrenadeParameterStashTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_grenadeParameterStashTime");

	// m_bGrenadeParametersStashed
	[SchemaMember("CCSPlayerPawnBase", "m_bGrenadeParametersStashed")]
	public ref bool GrenadeParametersStashed => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bGrenadeParametersStashed");

	// m_angStashedShootAngles
	[SchemaMember("CCSPlayerPawnBase", "m_angStashedShootAngles")]
	public QAngle StashedShootAngles => Schema.GetDeclaredClass<QAngle>(this.Handle, "CCSPlayerPawnBase", "m_angStashedShootAngles");

	// m_vecStashedGrenadeThrowPosition
	[SchemaMember("CCSPlayerPawnBase", "m_vecStashedGrenadeThrowPosition")]
	public Vector StashedGrenadeThrowPosition => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawnBase", "m_vecStashedGrenadeThrowPosition");

	// m_vecStashedVelocity
	[SchemaMember("CCSPlayerPawnBase", "m_vecStashedVelocity")]
	public Vector StashedVelocity => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawnBase", "m_vecStashedVelocity");

	// m_angShootAngleHistory
	[SchemaMember("CCSPlayerPawnBase", "m_angShootAngleHistory")]
	public Span<QAngle> ShootAngleHistory => Schema.GetFixedArray<QAngle>(this.Handle, "CCSPlayerPawnBase", "m_angShootAngleHistory", 2);

	// m_vecThrowPositionHistory
	[SchemaMember("CCSPlayerPawnBase", "m_vecThrowPositionHistory")]
	public Span<Vector> ThrowPositionHistory => Schema.GetFixedArray<Vector>(this.Handle, "CCSPlayerPawnBase", "m_vecThrowPositionHistory", 2);

	// m_vecVelocityHistory
	[SchemaMember("CCSPlayerPawnBase", "m_vecVelocityHistory")]
	public Span<Vector> VelocityHistory => Schema.GetFixedArray<Vector>(this.Handle, "CCSPlayerPawnBase", "m_vecVelocityHistory", 2);

	// m_bDiedAirborne
	[SchemaMember("CCSPlayerPawnBase", "m_bDiedAirborne")]
	public ref bool DiedAirborne => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bDiedAirborne");

	// m_iBombSiteIndex
	[SchemaMember("CCSPlayerPawnBase", "m_iBombSiteIndex")]
	public CEntityIndex BombSiteIndex => Schema.GetDeclaredClass<CEntityIndex>(this.Handle, "CCSPlayerPawnBase", "m_iBombSiteIndex");

	// m_nWhichBombZone
	[SchemaMember("CCSPlayerPawnBase", "m_nWhichBombZone")]
	public ref Int32 WhichBombZone => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_nWhichBombZone");

	// m_bInBombZoneTrigger
	[SchemaMember("CCSPlayerPawnBase", "m_bInBombZoneTrigger")]
	public ref bool InBombZoneTrigger => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bInBombZoneTrigger");

	// m_bWasInBombZoneTrigger
	[SchemaMember("CCSPlayerPawnBase", "m_bWasInBombZoneTrigger")]
	public ref bool WasInBombZoneTrigger => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bWasInBombZoneTrigger");

	// m_iDirection
	[SchemaMember("CCSPlayerPawnBase", "m_iDirection")]
	public ref Int32 Direction => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_iDirection");

	// m_iShotsFired
	[SchemaMember("CCSPlayerPawnBase", "m_iShotsFired")]
	public ref Int32 ShotsFired => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_iShotsFired");

	// m_ArmorValue
	[SchemaMember("CCSPlayerPawnBase", "m_ArmorValue")]
	public ref Int32 ArmorValue => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_ArmorValue");

	// m_flFlinchStack
	[SchemaMember("CCSPlayerPawnBase", "m_flFlinchStack")]
	public ref float FlinchStack => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flFlinchStack");

	// m_flVelocityModifier
	[SchemaMember("CCSPlayerPawnBase", "m_flVelocityModifier")]
	public ref float VelocityModifier => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flVelocityModifier");

	// m_flHitHeading
	[SchemaMember("CCSPlayerPawnBase", "m_flHitHeading")]
	public ref float HitHeading => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flHitHeading");

	// m_nHitBodyPart
	[SchemaMember("CCSPlayerPawnBase", "m_nHitBodyPart")]
	public ref Int32 HitBodyPart => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_nHitBodyPart");

	// m_iHostagesKilled
	[SchemaMember("CCSPlayerPawnBase", "m_iHostagesKilled")]
	public ref Int32 HostagesKilled => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_iHostagesKilled");

	// m_vecTotalBulletForce
	[SchemaMember("CCSPlayerPawnBase", "m_vecTotalBulletForce")]
	public Vector TotalBulletForce => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawnBase", "m_vecTotalBulletForce");

	// m_flFlashDuration
	[SchemaMember("CCSPlayerPawnBase", "m_flFlashDuration")]
	public ref float FlashDuration => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flFlashDuration");

	// m_flFlashMaxAlpha
	[SchemaMember("CCSPlayerPawnBase", "m_flFlashMaxAlpha")]
	public ref float FlashMaxAlpha => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flFlashMaxAlpha");

	// m_flProgressBarStartTime
	[SchemaMember("CCSPlayerPawnBase", "m_flProgressBarStartTime")]
	public ref float ProgressBarStartTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flProgressBarStartTime");

	// m_iProgressBarDuration
	[SchemaMember("CCSPlayerPawnBase", "m_iProgressBarDuration")]
	public ref Int32 ProgressBarDuration => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_iProgressBarDuration");

	// m_bWaitForNoAttack
	[SchemaMember("CCSPlayerPawnBase", "m_bWaitForNoAttack")]
	public ref bool WaitForNoAttack => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bWaitForNoAttack");

	// m_flLowerBodyYawTarget
	[SchemaMember("CCSPlayerPawnBase", "m_flLowerBodyYawTarget")]
	public ref float LowerBodyYawTarget => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flLowerBodyYawTarget");

	// m_bStrafing
	[SchemaMember("CCSPlayerPawnBase", "m_bStrafing")]
	public ref bool Strafing => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bStrafing");

	// m_lastStandingPos
	[SchemaMember("CCSPlayerPawnBase", "m_lastStandingPos")]
	public Vector LastStandingPos => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawnBase", "m_lastStandingPos");

	// m_ignoreLadderJumpTime
	[SchemaMember("CCSPlayerPawnBase", "m_ignoreLadderJumpTime")]
	public ref float IgnoreLadderJumpTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_ignoreLadderJumpTime");

	// m_ladderSurpressionTimer
	[SchemaMember("CCSPlayerPawnBase", "m_ladderSurpressionTimer")]
	public CountdownTimer LadderSurpressionTimer => Schema.GetDeclaredClass<CountdownTimer>(this.Handle, "CCSPlayerPawnBase", "m_ladderSurpressionTimer");

	// m_lastLadderNormal
	[SchemaMember("CCSPlayerPawnBase", "m_lastLadderNormal")]
	public Vector LastLadderNormal => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawnBase", "m_lastLadderNormal");

	// m_lastLadderPos
	[SchemaMember("CCSPlayerPawnBase", "m_lastLadderPos")]
	public Vector LastLadderPos => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawnBase", "m_lastLadderPos");

	// m_thirdPersonHeading
	[SchemaMember("CCSPlayerPawnBase", "m_thirdPersonHeading")]
	public QAngle ThirdPersonHeading => Schema.GetDeclaredClass<QAngle>(this.Handle, "CCSPlayerPawnBase", "m_thirdPersonHeading");

	// m_flSlopeDropOffset
	[SchemaMember("CCSPlayerPawnBase", "m_flSlopeDropOffset")]
	public ref float SlopeDropOffset => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flSlopeDropOffset");

	// m_flSlopeDropHeight
	[SchemaMember("CCSPlayerPawnBase", "m_flSlopeDropHeight")]
	public ref float SlopeDropHeight => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flSlopeDropHeight");

	// m_vHeadConstraintOffset
	[SchemaMember("CCSPlayerPawnBase", "m_vHeadConstraintOffset")]
	public Vector HeadConstraintOffset => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawnBase", "m_vHeadConstraintOffset");

	// m_iLastWeaponFireUsercmd
	[SchemaMember("CCSPlayerPawnBase", "m_iLastWeaponFireUsercmd")]
	public ref Int32 LastWeaponFireUsercmd => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_iLastWeaponFireUsercmd");

	// m_angEyeAngles
	[SchemaMember("CCSPlayerPawnBase", "m_angEyeAngles")]
	public QAngle EyeAngles => Schema.GetDeclaredClass<QAngle>(this.Handle, "CCSPlayerPawnBase", "m_angEyeAngles");

	// m_bVCollisionInitted
	[SchemaMember("CCSPlayerPawnBase", "m_bVCollisionInitted")]
	public ref bool VCollisionInitted => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bVCollisionInitted");

	// m_storedSpawnPosition
	[SchemaMember("CCSPlayerPawnBase", "m_storedSpawnPosition")]
	public Vector StoredSpawnPosition => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawnBase", "m_storedSpawnPosition");

	// m_storedSpawnAngle
	[SchemaMember("CCSPlayerPawnBase", "m_storedSpawnAngle")]
	public QAngle StoredSpawnAngle => Schema.GetDeclaredClass<QAngle>(this.Handle, "CCSPlayerPawnBase", "m_storedSpawnAngle");

	// m_bIsSpawning
	[SchemaMember("CCSPlayerPawnBase", "m_bIsSpawning")]
	public ref bool IsSpawning => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bIsSpawning");

	// m_bHideTargetID
	[SchemaMember("CCSPlayerPawnBase", "m_bHideTargetID")]
	public ref bool HideTargetID => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bHideTargetID");

	// m_nNumDangerZoneDamageHits
	[SchemaMember("CCSPlayerPawnBase", "m_nNumDangerZoneDamageHits")]
	public ref Int32 NumDangerZoneDamageHits => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_nNumDangerZoneDamageHits");

	// m_bHud_MiniScoreHidden
	[SchemaMember("CCSPlayerPawnBase", "m_bHud_MiniScoreHidden")]
	public ref bool Hud_MiniScoreHidden => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bHud_MiniScoreHidden");

	// m_bHud_RadarHidden
	[SchemaMember("CCSPlayerPawnBase", "m_bHud_RadarHidden")]
	public ref bool Hud_RadarHidden => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bHud_RadarHidden");

	// m_nLastKillerIndex
	[SchemaMember("CCSPlayerPawnBase", "m_nLastKillerIndex")]
	public CEntityIndex LastKillerIndex => Schema.GetDeclaredClass<CEntityIndex>(this.Handle, "CCSPlayerPawnBase", "m_nLastKillerIndex");

	// m_nLastConcurrentKilled
	[SchemaMember("CCSPlayerPawnBase", "m_nLastConcurrentKilled")]
	public ref Int32 LastConcurrentKilled => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_nLastConcurrentKilled");

	// m_nDeathCamMusic
	[SchemaMember("CCSPlayerPawnBase", "m_nDeathCamMusic")]
	public ref Int32 DeathCamMusic => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_nDeathCamMusic");

	// m_iAddonBits
	[SchemaMember("CCSPlayerPawnBase", "m_iAddonBits")]
	public ref Int32 AddonBits => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_iAddonBits");

	// m_iPrimaryAddon
	[SchemaMember("CCSPlayerPawnBase", "m_iPrimaryAddon")]
	public ref Int32 PrimaryAddon => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_iPrimaryAddon");

	// m_iSecondaryAddon
	[SchemaMember("CCSPlayerPawnBase", "m_iSecondaryAddon")]
	public ref Int32 SecondaryAddon => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_iSecondaryAddon");

	// m_currentDeafnessFilter
	[SchemaMember("CCSPlayerPawnBase", "m_currentDeafnessFilter")]
	public CUtlStringToken CurrentDeafnessFilter => Schema.GetDeclaredClass<CUtlStringToken>(this.Handle, "CCSPlayerPawnBase", "m_currentDeafnessFilter");

	// m_NumEnemiesKilledThisSpawn
	[SchemaMember("CCSPlayerPawnBase", "m_NumEnemiesKilledThisSpawn")]
	public ref Int32 NumEnemiesKilledThisSpawn => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_NumEnemiesKilledThisSpawn");

	// m_NumEnemiesKilledThisRound
	[SchemaMember("CCSPlayerPawnBase", "m_NumEnemiesKilledThisRound")]
	public ref Int32 NumEnemiesKilledThisRound => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_NumEnemiesKilledThisRound");

	// m_NumEnemiesAtRoundStart
	[SchemaMember("CCSPlayerPawnBase", "m_NumEnemiesAtRoundStart")]
	public ref Int32 NumEnemiesAtRoundStart => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_NumEnemiesAtRoundStart");

	// m_wasNotKilledNaturally
	[SchemaMember("CCSPlayerPawnBase", "m_wasNotKilledNaturally")]
	public ref bool WasNotKilledNaturally => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_wasNotKilledNaturally");

	// m_vecPlayerPatchEconIndices
	[SchemaMember("CCSPlayerPawnBase", "m_vecPlayerPatchEconIndices")]
	public Span<UInt32> PlayerPatchEconIndices => Schema.GetFixedArray<UInt32>(this.Handle, "CCSPlayerPawnBase", "m_vecPlayerPatchEconIndices", 5);

	// m_iDeathFlags
	[SchemaMember("CCSPlayerPawnBase", "m_iDeathFlags")]
	public ref Int32 DeathFlags => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_iDeathFlags");

	// m_hPet
	[SchemaMember("CCSPlayerPawnBase", "m_hPet")]
	public CHandle<CChicken> Pet => Schema.GetDeclaredClass<CHandle<CChicken>>(this.Handle, "CCSPlayerPawnBase", "m_hPet");

	// m_unCurrentEquipmentValue
	[SchemaMember("CCSPlayerPawnBase", "m_unCurrentEquipmentValue")]
	public ref UInt16 CurrentEquipmentValue => ref Schema.GetRef<UInt16>(this.Handle, "CCSPlayerPawnBase", "m_unCurrentEquipmentValue");

	// m_unRoundStartEquipmentValue
	[SchemaMember("CCSPlayerPawnBase", "m_unRoundStartEquipmentValue")]
	public ref UInt16 RoundStartEquipmentValue => ref Schema.GetRef<UInt16>(this.Handle, "CCSPlayerPawnBase", "m_unRoundStartEquipmentValue");

	// m_unFreezetimeEndEquipmentValue
	[SchemaMember("CCSPlayerPawnBase", "m_unFreezetimeEndEquipmentValue")]
	public ref UInt16 FreezetimeEndEquipmentValue => ref Schema.GetRef<UInt16>(this.Handle, "CCSPlayerPawnBase", "m_unFreezetimeEndEquipmentValue");

	// m_nSurvivalTeamNumber
	[SchemaMember("CCSPlayerPawnBase", "m_nSurvivalTeamNumber")]
	public ref Int32 SurvivalTeamNumber => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_nSurvivalTeamNumber");

	// m_bHasDeathInfo
	[SchemaMember("CCSPlayerPawnBase", "m_bHasDeathInfo")]
	public ref bool HasDeathInfo => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bHasDeathInfo");

	// m_flDeathInfoTime
	[SchemaMember("CCSPlayerPawnBase", "m_flDeathInfoTime")]
	public ref float DeathInfoTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flDeathInfoTime");

	// m_vecDeathInfoOrigin
	[SchemaMember("CCSPlayerPawnBase", "m_vecDeathInfoOrigin")]
	public Vector DeathInfoOrigin => Schema.GetDeclaredClass<Vector>(this.Handle, "CCSPlayerPawnBase", "m_vecDeathInfoOrigin");

	// m_bKilledByHeadshot
	[SchemaMember("CCSPlayerPawnBase", "m_bKilledByHeadshot")]
	public ref bool KilledByHeadshot => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bKilledByHeadshot");

	// m_LastHitBox
	[SchemaMember("CCSPlayerPawnBase", "m_LastHitBox")]
	public ref Int32 LastHitBox => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_LastHitBox");

	// m_LastHealth
	[SchemaMember("CCSPlayerPawnBase", "m_LastHealth")]
	public ref Int32 LastHealth => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerPawnBase", "m_LastHealth");

	// m_flLastCollisionCeiling
	[SchemaMember("CCSPlayerPawnBase", "m_flLastCollisionCeiling")]
	public ref float LastCollisionCeiling => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flLastCollisionCeiling");

	// m_flLastCollisionCeilingChangeTime
	[SchemaMember("CCSPlayerPawnBase", "m_flLastCollisionCeilingChangeTime")]
	public ref float LastCollisionCeilingChangeTime => ref Schema.GetRef<float>(this.Handle, "CCSPlayerPawnBase", "m_flLastCollisionCeilingChangeTime");

	// m_pBot
	[SchemaMember("CCSPlayerPawnBase", "m_pBot")]
	public CCSBot? Bot => Schema.GetPointer<CCSBot>(this.Handle, "CCSPlayerPawnBase", "m_pBot");

	// m_bBotAllowActive
	[SchemaMember("CCSPlayerPawnBase", "m_bBotAllowActive")]
	public ref bool BotAllowActive => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bBotAllowActive");

	// m_bCommittingSuicideOnTeamChange
	[SchemaMember("CCSPlayerPawnBase", "m_bCommittingSuicideOnTeamChange")]
	public ref bool CommittingSuicideOnTeamChange => ref Schema.GetRef<bool>(this.Handle, "CCSPlayerPawnBase", "m_bCommittingSuicideOnTeamChange");

}
