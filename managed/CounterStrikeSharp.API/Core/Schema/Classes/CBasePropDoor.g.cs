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
public partial class CBasePropDoor : CDynamicProp, ICBasePropDoor
{
    public CBasePropDoor (IntPtr pointer) : base(pointer) {}

	// m_flAutoReturnDelay
	[SchemaMember("CBasePropDoor", "m_flAutoReturnDelay")]
	public ref float AutoReturnDelay => ref Schema.GetRef<float>(this.Handle, "CBasePropDoor", "m_flAutoReturnDelay");

	// m_hDoorList
	[SchemaMember("CBasePropDoor", "m_hDoorList")]
	public NetworkedVector<CHandle<CBasePropDoor>> DoorList => Schema.GetDeclaredClass<NetworkedVector<CHandle<CBasePropDoor>>>(this.Handle, "CBasePropDoor", "m_hDoorList");

	// m_nHardwareType
	[SchemaMember("CBasePropDoor", "m_nHardwareType")]
	public ref Int32 HardwareType => ref Schema.GetRef<Int32>(this.Handle, "CBasePropDoor", "m_nHardwareType");

	// m_bNeedsHardware
	[SchemaMember("CBasePropDoor", "m_bNeedsHardware")]
	public ref bool NeedsHardware => ref Schema.GetRef<bool>(this.Handle, "CBasePropDoor", "m_bNeedsHardware");

	// m_eDoorState
	[SchemaMember("CBasePropDoor", "m_eDoorState")]
	public ref DoorState_t DoorState => ref Schema.GetRef<DoorState_t>(this.Handle, "CBasePropDoor", "m_eDoorState");

	// m_bLocked
	[SchemaMember("CBasePropDoor", "m_bLocked")]
	public ref bool Locked => ref Schema.GetRef<bool>(this.Handle, "CBasePropDoor", "m_bLocked");

	// m_closedPosition
	[SchemaMember("CBasePropDoor", "m_closedPosition")]
	public Vector ClosedPosition => Schema.GetDeclaredClass<Vector>(this.Handle, "CBasePropDoor", "m_closedPosition");

	// m_closedAngles
	[SchemaMember("CBasePropDoor", "m_closedAngles")]
	public QAngle ClosedAngles => Schema.GetDeclaredClass<QAngle>(this.Handle, "CBasePropDoor", "m_closedAngles");

	// m_hBlocker
	[SchemaMember("CBasePropDoor", "m_hBlocker")]
	public CHandle<CBaseEntity> Blocker => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CBasePropDoor", "m_hBlocker");

	// m_bFirstBlocked
	[SchemaMember("CBasePropDoor", "m_bFirstBlocked")]
	public ref bool FirstBlocked => ref Schema.GetRef<bool>(this.Handle, "CBasePropDoor", "m_bFirstBlocked");

	// m_ls
	[SchemaMember("CBasePropDoor", "m_ls")]
	public locksound_t Ls => Schema.GetDeclaredClass<locksound_t>(this.Handle, "CBasePropDoor", "m_ls");

	// m_bForceClosed
	[SchemaMember("CBasePropDoor", "m_bForceClosed")]
	public ref bool ForceClosed => ref Schema.GetRef<bool>(this.Handle, "CBasePropDoor", "m_bForceClosed");

	// m_vecLatchWorldPosition
	[SchemaMember("CBasePropDoor", "m_vecLatchWorldPosition")]
	public Vector LatchWorldPosition => Schema.GetDeclaredClass<Vector>(this.Handle, "CBasePropDoor", "m_vecLatchWorldPosition");

	// m_hActivator
	[SchemaMember("CBasePropDoor", "m_hActivator")]
	public CHandle<CBaseEntity> Activator => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CBasePropDoor", "m_hActivator");

	// m_SoundMoving
	[SchemaMember("CBasePropDoor", "m_SoundMoving")]
	public string SoundMoving
	{
		get { return Schema.GetUtf8String(this.Handle, "CBasePropDoor", "m_SoundMoving"); }
		set { Schema.SetString(this.Handle, "CBasePropDoor", "m_SoundMoving", value); }
	}

	// m_SoundOpen
	[SchemaMember("CBasePropDoor", "m_SoundOpen")]
	public string SoundOpen
	{
		get { return Schema.GetUtf8String(this.Handle, "CBasePropDoor", "m_SoundOpen"); }
		set { Schema.SetString(this.Handle, "CBasePropDoor", "m_SoundOpen", value); }
	}

	// m_SoundClose
	[SchemaMember("CBasePropDoor", "m_SoundClose")]
	public string SoundClose
	{
		get { return Schema.GetUtf8String(this.Handle, "CBasePropDoor", "m_SoundClose"); }
		set { Schema.SetString(this.Handle, "CBasePropDoor", "m_SoundClose", value); }
	}

	// m_SoundLock
	[SchemaMember("CBasePropDoor", "m_SoundLock")]
	public string SoundLock
	{
		get { return Schema.GetUtf8String(this.Handle, "CBasePropDoor", "m_SoundLock"); }
		set { Schema.SetString(this.Handle, "CBasePropDoor", "m_SoundLock", value); }
	}

	// m_SoundUnlock
	[SchemaMember("CBasePropDoor", "m_SoundUnlock")]
	public string SoundUnlock
	{
		get { return Schema.GetUtf8String(this.Handle, "CBasePropDoor", "m_SoundUnlock"); }
		set { Schema.SetString(this.Handle, "CBasePropDoor", "m_SoundUnlock", value); }
	}

	// m_SoundLatch
	[SchemaMember("CBasePropDoor", "m_SoundLatch")]
	public string SoundLatch
	{
		get { return Schema.GetUtf8String(this.Handle, "CBasePropDoor", "m_SoundLatch"); }
		set { Schema.SetString(this.Handle, "CBasePropDoor", "m_SoundLatch", value); }
	}

	// m_SoundPound
	[SchemaMember("CBasePropDoor", "m_SoundPound")]
	public string SoundPound
	{
		get { return Schema.GetUtf8String(this.Handle, "CBasePropDoor", "m_SoundPound"); }
		set { Schema.SetString(this.Handle, "CBasePropDoor", "m_SoundPound", value); }
	}

	// m_SoundJiggle
	[SchemaMember("CBasePropDoor", "m_SoundJiggle")]
	public string SoundJiggle
	{
		get { return Schema.GetUtf8String(this.Handle, "CBasePropDoor", "m_SoundJiggle"); }
		set { Schema.SetString(this.Handle, "CBasePropDoor", "m_SoundJiggle", value); }
	}

	// m_SoundLockedAnim
	[SchemaMember("CBasePropDoor", "m_SoundLockedAnim")]
	public string SoundLockedAnim
	{
		get { return Schema.GetUtf8String(this.Handle, "CBasePropDoor", "m_SoundLockedAnim"); }
		set { Schema.SetString(this.Handle, "CBasePropDoor", "m_SoundLockedAnim", value); }
	}

	// m_numCloseAttempts
	[SchemaMember("CBasePropDoor", "m_numCloseAttempts")]
	public ref Int32 NumCloseAttempts => ref Schema.GetRef<Int32>(this.Handle, "CBasePropDoor", "m_numCloseAttempts");

	// m_nPhysicsMaterial
	[SchemaMember("CBasePropDoor", "m_nPhysicsMaterial")]
	public CUtlStringToken PhysicsMaterial => Schema.GetDeclaredClass<CUtlStringToken>(this.Handle, "CBasePropDoor", "m_nPhysicsMaterial");

	// m_SlaveName
	[SchemaMember("CBasePropDoor", "m_SlaveName")]
	public string SlaveName
	{
		get { return Schema.GetUtf8String(this.Handle, "CBasePropDoor", "m_SlaveName"); }
		set { Schema.SetString(this.Handle, "CBasePropDoor", "m_SlaveName", value); }
	}

	// m_hMaster
	[SchemaMember("CBasePropDoor", "m_hMaster")]
	public CHandle<CBasePropDoor> Master => Schema.GetDeclaredClass<CHandle<CBasePropDoor>>(this.Handle, "CBasePropDoor", "m_hMaster");

	// m_OnBlockedClosing
	[SchemaMember("CBasePropDoor", "m_OnBlockedClosing")]
	public CEntityIOOutput OnBlockedClosing => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBasePropDoor", "m_OnBlockedClosing");

	// m_OnBlockedOpening
	[SchemaMember("CBasePropDoor", "m_OnBlockedOpening")]
	public CEntityIOOutput OnBlockedOpening => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBasePropDoor", "m_OnBlockedOpening");

	// m_OnUnblockedClosing
	[SchemaMember("CBasePropDoor", "m_OnUnblockedClosing")]
	public CEntityIOOutput OnUnblockedClosing => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBasePropDoor", "m_OnUnblockedClosing");

	// m_OnUnblockedOpening
	[SchemaMember("CBasePropDoor", "m_OnUnblockedOpening")]
	public CEntityIOOutput OnUnblockedOpening => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBasePropDoor", "m_OnUnblockedOpening");

	// m_OnFullyClosed
	[SchemaMember("CBasePropDoor", "m_OnFullyClosed")]
	public CEntityIOOutput OnFullyClosed => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBasePropDoor", "m_OnFullyClosed");

	// m_OnFullyOpen
	[SchemaMember("CBasePropDoor", "m_OnFullyOpen")]
	public CEntityIOOutput OnFullyOpen => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBasePropDoor", "m_OnFullyOpen");

	// m_OnClose
	[SchemaMember("CBasePropDoor", "m_OnClose")]
	public CEntityIOOutput OnClose => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBasePropDoor", "m_OnClose");

	// m_OnOpen
	[SchemaMember("CBasePropDoor", "m_OnOpen")]
	public CEntityIOOutput OnOpen => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBasePropDoor", "m_OnOpen");

	// m_OnLockedUse
	[SchemaMember("CBasePropDoor", "m_OnLockedUse")]
	public CEntityIOOutput OnLockedUse => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBasePropDoor", "m_OnLockedUse");

	// m_OnAjarOpen
	[SchemaMember("CBasePropDoor", "m_OnAjarOpen")]
	public CEntityIOOutput OnAjarOpen => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBasePropDoor", "m_OnAjarOpen");

}
