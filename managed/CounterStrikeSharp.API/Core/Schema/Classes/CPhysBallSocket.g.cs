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
public partial class CPhysBallSocket : CPhysConstraint, ICPhysBallSocket
{
    public CPhysBallSocket (IntPtr pointer) : base(pointer) {}

	// m_flFriction
	[SchemaMember("CPhysBallSocket", "m_flFriction")]
	public ref float Friction => ref Schema.GetRef<float>(this.Handle, "CPhysBallSocket", "m_flFriction");

	// m_bEnableSwingLimit
	[SchemaMember("CPhysBallSocket", "m_bEnableSwingLimit")]
	public ref bool EnableSwingLimit => ref Schema.GetRef<bool>(this.Handle, "CPhysBallSocket", "m_bEnableSwingLimit");

	// m_flSwingLimit
	[SchemaMember("CPhysBallSocket", "m_flSwingLimit")]
	public ref float SwingLimit => ref Schema.GetRef<float>(this.Handle, "CPhysBallSocket", "m_flSwingLimit");

	// m_bEnableTwistLimit
	[SchemaMember("CPhysBallSocket", "m_bEnableTwistLimit")]
	public ref bool EnableTwistLimit => ref Schema.GetRef<bool>(this.Handle, "CPhysBallSocket", "m_bEnableTwistLimit");

	// m_flMinTwistAngle
	[SchemaMember("CPhysBallSocket", "m_flMinTwistAngle")]
	public ref float MinTwistAngle => ref Schema.GetRef<float>(this.Handle, "CPhysBallSocket", "m_flMinTwistAngle");

	// m_flMaxTwistAngle
	[SchemaMember("CPhysBallSocket", "m_flMaxTwistAngle")]
	public ref float MaxTwistAngle => ref Schema.GetRef<float>(this.Handle, "CPhysBallSocket", "m_flMaxTwistAngle");

}
