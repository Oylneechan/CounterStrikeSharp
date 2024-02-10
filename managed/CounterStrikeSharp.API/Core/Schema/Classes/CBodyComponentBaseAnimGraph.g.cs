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
public partial class CBodyComponentBaseAnimGraph : CBodyComponentSkeletonInstance, ICBodyComponentBaseAnimGraph
{
    public CBodyComponentBaseAnimGraph (IntPtr pointer) : base(pointer) {}

	// m_animationController
	[SchemaMember("CBodyComponentBaseAnimGraph", "m_animationController")]
	public CBaseAnimGraphController AnimationController => Schema.GetDeclaredClass<CBaseAnimGraphController>(this.Handle, "CBodyComponentBaseAnimGraph", "m_animationController");

	// __m_pChainEntity
	[SchemaMember("CBodyComponentBaseAnimGraph", "__m_pChainEntity")]
	public CNetworkVarChainer __m_pChainEntity => Schema.GetDeclaredClass<CNetworkVarChainer>(this.Handle, "CBodyComponentBaseAnimGraph", "__m_pChainEntity");

}
