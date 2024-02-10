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
public partial class CCSPlayer_BuyServices : CPlayerPawnComponent, ICCSPlayer_BuyServices
{
    public CCSPlayer_BuyServices (IntPtr pointer) : base(pointer) {}

	// m_vecSellbackPurchaseEntries
	[SchemaMember("CCSPlayer_BuyServices", "m_vecSellbackPurchaseEntries")]
	public NetworkedVector<SellbackPurchaseEntry_t> SellbackPurchaseEntries => Schema.GetDeclaredClass<NetworkedVector<SellbackPurchaseEntry_t>>(this.Handle, "CCSPlayer_BuyServices", "m_vecSellbackPurchaseEntries");

}
