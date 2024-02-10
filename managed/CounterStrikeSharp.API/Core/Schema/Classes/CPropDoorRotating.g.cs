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
public partial class CPropDoorRotating : CBasePropDoor, ICPropDoorRotating
{
    public CPropDoorRotating (IntPtr pointer) : base(pointer) {}

	// m_vecAxis
	[SchemaMember("CPropDoorRotating", "m_vecAxis")]
	public Vector Axis => Schema.GetDeclaredClass<Vector>(this.Handle, "CPropDoorRotating", "m_vecAxis");

	// m_flDistance
	[SchemaMember("CPropDoorRotating", "m_flDistance")]
	public ref float Distance => ref Schema.GetRef<float>(this.Handle, "CPropDoorRotating", "m_flDistance");

	// m_eSpawnPosition
	[SchemaMember("CPropDoorRotating", "m_eSpawnPosition")]
	public ref PropDoorRotatingSpawnPos_t SpawnPosition => ref Schema.GetRef<PropDoorRotatingSpawnPos_t>(this.Handle, "CPropDoorRotating", "m_eSpawnPosition");

	// m_eOpenDirection
	[SchemaMember("CPropDoorRotating", "m_eOpenDirection")]
	public ref PropDoorRotatingOpenDirection_e OpenDirection => ref Schema.GetRef<PropDoorRotatingOpenDirection_e>(this.Handle, "CPropDoorRotating", "m_eOpenDirection");

	// m_eCurrentOpenDirection
	[SchemaMember("CPropDoorRotating", "m_eCurrentOpenDirection")]
	public ref PropDoorRotatingOpenDirection_e CurrentOpenDirection => ref Schema.GetRef<PropDoorRotatingOpenDirection_e>(this.Handle, "CPropDoorRotating", "m_eCurrentOpenDirection");

	// m_flAjarAngle
	[SchemaMember("CPropDoorRotating", "m_flAjarAngle")]
	public ref float AjarAngle => ref Schema.GetRef<float>(this.Handle, "CPropDoorRotating", "m_flAjarAngle");

	// m_angRotationAjarDeprecated
	[SchemaMember("CPropDoorRotating", "m_angRotationAjarDeprecated")]
	public QAngle RotationAjarDeprecated => Schema.GetDeclaredClass<QAngle>(this.Handle, "CPropDoorRotating", "m_angRotationAjarDeprecated");

	// m_angRotationClosed
	[SchemaMember("CPropDoorRotating", "m_angRotationClosed")]
	public QAngle RotationClosed => Schema.GetDeclaredClass<QAngle>(this.Handle, "CPropDoorRotating", "m_angRotationClosed");

	// m_angRotationOpenForward
	[SchemaMember("CPropDoorRotating", "m_angRotationOpenForward")]
	public QAngle RotationOpenForward => Schema.GetDeclaredClass<QAngle>(this.Handle, "CPropDoorRotating", "m_angRotationOpenForward");

	// m_angRotationOpenBack
	[SchemaMember("CPropDoorRotating", "m_angRotationOpenBack")]
	public QAngle RotationOpenBack => Schema.GetDeclaredClass<QAngle>(this.Handle, "CPropDoorRotating", "m_angRotationOpenBack");

	// m_angGoal
	[SchemaMember("CPropDoorRotating", "m_angGoal")]
	public QAngle Goal => Schema.GetDeclaredClass<QAngle>(this.Handle, "CPropDoorRotating", "m_angGoal");

	// m_vecForwardBoundsMin
	[SchemaMember("CPropDoorRotating", "m_vecForwardBoundsMin")]
	public Vector ForwardBoundsMin => Schema.GetDeclaredClass<Vector>(this.Handle, "CPropDoorRotating", "m_vecForwardBoundsMin");

	// m_vecForwardBoundsMax
	[SchemaMember("CPropDoorRotating", "m_vecForwardBoundsMax")]
	public Vector ForwardBoundsMax => Schema.GetDeclaredClass<Vector>(this.Handle, "CPropDoorRotating", "m_vecForwardBoundsMax");

	// m_vecBackBoundsMin
	[SchemaMember("CPropDoorRotating", "m_vecBackBoundsMin")]
	public Vector BackBoundsMin => Schema.GetDeclaredClass<Vector>(this.Handle, "CPropDoorRotating", "m_vecBackBoundsMin");

	// m_vecBackBoundsMax
	[SchemaMember("CPropDoorRotating", "m_vecBackBoundsMax")]
	public Vector BackBoundsMax => Schema.GetDeclaredClass<Vector>(this.Handle, "CPropDoorRotating", "m_vecBackBoundsMax");

	// m_bAjarDoorShouldntAlwaysOpen
	[SchemaMember("CPropDoorRotating", "m_bAjarDoorShouldntAlwaysOpen")]
	public ref bool AjarDoorShouldntAlwaysOpen => ref Schema.GetRef<bool>(this.Handle, "CPropDoorRotating", "m_bAjarDoorShouldntAlwaysOpen");

	// m_hEntityBlocker
	[SchemaMember("CPropDoorRotating", "m_hEntityBlocker")]
	public CHandle<CEntityBlocker> EntityBlocker => Schema.GetDeclaredClass<CHandle<CEntityBlocker>>(this.Handle, "CPropDoorRotating", "m_hEntityBlocker");

}
