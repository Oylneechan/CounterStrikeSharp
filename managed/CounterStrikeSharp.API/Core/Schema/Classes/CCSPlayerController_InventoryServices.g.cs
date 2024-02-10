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
public partial class CCSPlayerController_InventoryServices : CPlayerControllerComponent, ICCSPlayerController_InventoryServices
{
    public CCSPlayerController_InventoryServices (IntPtr pointer) : base(pointer) {}

	// m_unMusicID
	[SchemaMember("CCSPlayerController_InventoryServices", "m_unMusicID")]
	public ref UInt16 MusicID => ref Schema.GetRef<UInt16>(this.Handle, "CCSPlayerController_InventoryServices", "m_unMusicID");

	// m_rank
	[SchemaMember("CCSPlayerController_InventoryServices", "m_rank")]
	public Span<MedalRank_t> Rank => Schema.GetFixedArray<MedalRank_t>(this.Handle, "CCSPlayerController_InventoryServices", "m_rank", 6);

	// m_nPersonaDataPublicLevel
	[SchemaMember("CCSPlayerController_InventoryServices", "m_nPersonaDataPublicLevel")]
	public ref Int32 PersonaDataPublicLevel => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerController_InventoryServices", "m_nPersonaDataPublicLevel");

	// m_nPersonaDataPublicCommendsLeader
	[SchemaMember("CCSPlayerController_InventoryServices", "m_nPersonaDataPublicCommendsLeader")]
	public ref Int32 PersonaDataPublicCommendsLeader => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerController_InventoryServices", "m_nPersonaDataPublicCommendsLeader");

	// m_nPersonaDataPublicCommendsTeacher
	[SchemaMember("CCSPlayerController_InventoryServices", "m_nPersonaDataPublicCommendsTeacher")]
	public ref Int32 PersonaDataPublicCommendsTeacher => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerController_InventoryServices", "m_nPersonaDataPublicCommendsTeacher");

	// m_nPersonaDataPublicCommendsFriendly
	[SchemaMember("CCSPlayerController_InventoryServices", "m_nPersonaDataPublicCommendsFriendly")]
	public ref Int32 PersonaDataPublicCommendsFriendly => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerController_InventoryServices", "m_nPersonaDataPublicCommendsFriendly");

	// m_unEquippedPlayerSprayIDs
	[SchemaMember("CCSPlayerController_InventoryServices", "m_unEquippedPlayerSprayIDs")]
	public Span<UInt32> EquippedPlayerSprayIDs => Schema.GetFixedArray<UInt32>(this.Handle, "CCSPlayerController_InventoryServices", "m_unEquippedPlayerSprayIDs", 1);

	// m_vecServerAuthoritativeWeaponSlots
	[SchemaMember("CCSPlayerController_InventoryServices", "m_vecServerAuthoritativeWeaponSlots")]
	public NetworkedVector<ServerAuthoritativeWeaponSlot_t> ServerAuthoritativeWeaponSlots => Schema.GetDeclaredClass<NetworkedVector<ServerAuthoritativeWeaponSlot_t>>(this.Handle, "CCSPlayerController_InventoryServices", "m_vecServerAuthoritativeWeaponSlots");

}
