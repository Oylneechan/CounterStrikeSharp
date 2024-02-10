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
public partial class CPointValueRemapper : CBaseEntity, ICPointValueRemapper
{
    public CPointValueRemapper (IntPtr pointer) : base(pointer) {}

	// m_bDisabled
	[SchemaMember("CPointValueRemapper", "m_bDisabled")]
	public ref bool Disabled => ref Schema.GetRef<bool>(this.Handle, "CPointValueRemapper", "m_bDisabled");

	// m_bUpdateOnClient
	[SchemaMember("CPointValueRemapper", "m_bUpdateOnClient")]
	public ref bool UpdateOnClient => ref Schema.GetRef<bool>(this.Handle, "CPointValueRemapper", "m_bUpdateOnClient");

	// m_nInputType
	[SchemaMember("CPointValueRemapper", "m_nInputType")]
	public ref ValueRemapperInputType_t InputType => ref Schema.GetRef<ValueRemapperInputType_t>(this.Handle, "CPointValueRemapper", "m_nInputType");

	// m_iszRemapLineStartName
	[SchemaMember("CPointValueRemapper", "m_iszRemapLineStartName")]
	public string RemapLineStartName
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointValueRemapper", "m_iszRemapLineStartName"); }
		set { Schema.SetString(this.Handle, "CPointValueRemapper", "m_iszRemapLineStartName", value); }
	}

	// m_iszRemapLineEndName
	[SchemaMember("CPointValueRemapper", "m_iszRemapLineEndName")]
	public string RemapLineEndName
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointValueRemapper", "m_iszRemapLineEndName"); }
		set { Schema.SetString(this.Handle, "CPointValueRemapper", "m_iszRemapLineEndName", value); }
	}

	// m_hRemapLineStart
	[SchemaMember("CPointValueRemapper", "m_hRemapLineStart")]
	public CHandle<CBaseEntity> RemapLineStart => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CPointValueRemapper", "m_hRemapLineStart");

	// m_hRemapLineEnd
	[SchemaMember("CPointValueRemapper", "m_hRemapLineEnd")]
	public CHandle<CBaseEntity> RemapLineEnd => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CPointValueRemapper", "m_hRemapLineEnd");

	// m_flMaximumChangePerSecond
	[SchemaMember("CPointValueRemapper", "m_flMaximumChangePerSecond")]
	public ref float MaximumChangePerSecond => ref Schema.GetRef<float>(this.Handle, "CPointValueRemapper", "m_flMaximumChangePerSecond");

	// m_flDisengageDistance
	[SchemaMember("CPointValueRemapper", "m_flDisengageDistance")]
	public ref float DisengageDistance => ref Schema.GetRef<float>(this.Handle, "CPointValueRemapper", "m_flDisengageDistance");

	// m_flEngageDistance
	[SchemaMember("CPointValueRemapper", "m_flEngageDistance")]
	public ref float EngageDistance => ref Schema.GetRef<float>(this.Handle, "CPointValueRemapper", "m_flEngageDistance");

	// m_bRequiresUseKey
	[SchemaMember("CPointValueRemapper", "m_bRequiresUseKey")]
	public ref bool RequiresUseKey => ref Schema.GetRef<bool>(this.Handle, "CPointValueRemapper", "m_bRequiresUseKey");

	// m_nOutputType
	[SchemaMember("CPointValueRemapper", "m_nOutputType")]
	public ref ValueRemapperOutputType_t OutputType => ref Schema.GetRef<ValueRemapperOutputType_t>(this.Handle, "CPointValueRemapper", "m_nOutputType");

	// m_iszOutputEntityName
	[SchemaMember("CPointValueRemapper", "m_iszOutputEntityName")]
	public string OutputEntityName
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointValueRemapper", "m_iszOutputEntityName"); }
		set { Schema.SetString(this.Handle, "CPointValueRemapper", "m_iszOutputEntityName", value); }
	}

	// m_iszOutputEntity2Name
	[SchemaMember("CPointValueRemapper", "m_iszOutputEntity2Name")]
	public string OutputEntity2Name
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointValueRemapper", "m_iszOutputEntity2Name"); }
		set { Schema.SetString(this.Handle, "CPointValueRemapper", "m_iszOutputEntity2Name", value); }
	}

	// m_iszOutputEntity3Name
	[SchemaMember("CPointValueRemapper", "m_iszOutputEntity3Name")]
	public string OutputEntity3Name
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointValueRemapper", "m_iszOutputEntity3Name"); }
		set { Schema.SetString(this.Handle, "CPointValueRemapper", "m_iszOutputEntity3Name", value); }
	}

	// m_iszOutputEntity4Name
	[SchemaMember("CPointValueRemapper", "m_iszOutputEntity4Name")]
	public string OutputEntity4Name
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointValueRemapper", "m_iszOutputEntity4Name"); }
		set { Schema.SetString(this.Handle, "CPointValueRemapper", "m_iszOutputEntity4Name", value); }
	}

	// m_hOutputEntities
	[SchemaMember("CPointValueRemapper", "m_hOutputEntities")]
	public NetworkedVector<CHandle<CBaseEntity>> OutputEntities => Schema.GetDeclaredClass<NetworkedVector<CHandle<CBaseEntity>>>(this.Handle, "CPointValueRemapper", "m_hOutputEntities");

	// m_nHapticsType
	[SchemaMember("CPointValueRemapper", "m_nHapticsType")]
	public ref ValueRemapperHapticsType_t HapticsType => ref Schema.GetRef<ValueRemapperHapticsType_t>(this.Handle, "CPointValueRemapper", "m_nHapticsType");

	// m_nMomentumType
	[SchemaMember("CPointValueRemapper", "m_nMomentumType")]
	public ref ValueRemapperMomentumType_t MomentumType => ref Schema.GetRef<ValueRemapperMomentumType_t>(this.Handle, "CPointValueRemapper", "m_nMomentumType");

	// m_flMomentumModifier
	[SchemaMember("CPointValueRemapper", "m_flMomentumModifier")]
	public ref float MomentumModifier => ref Schema.GetRef<float>(this.Handle, "CPointValueRemapper", "m_flMomentumModifier");

	// m_flSnapValue
	[SchemaMember("CPointValueRemapper", "m_flSnapValue")]
	public ref float SnapValue => ref Schema.GetRef<float>(this.Handle, "CPointValueRemapper", "m_flSnapValue");

	// m_flCurrentMomentum
	[SchemaMember("CPointValueRemapper", "m_flCurrentMomentum")]
	public ref float CurrentMomentum => ref Schema.GetRef<float>(this.Handle, "CPointValueRemapper", "m_flCurrentMomentum");

	// m_nRatchetType
	[SchemaMember("CPointValueRemapper", "m_nRatchetType")]
	public ref ValueRemapperRatchetType_t RatchetType => ref Schema.GetRef<ValueRemapperRatchetType_t>(this.Handle, "CPointValueRemapper", "m_nRatchetType");

	// m_flRatchetOffset
	[SchemaMember("CPointValueRemapper", "m_flRatchetOffset")]
	public ref float RatchetOffset => ref Schema.GetRef<float>(this.Handle, "CPointValueRemapper", "m_flRatchetOffset");

	// m_flInputOffset
	[SchemaMember("CPointValueRemapper", "m_flInputOffset")]
	public ref float InputOffset => ref Schema.GetRef<float>(this.Handle, "CPointValueRemapper", "m_flInputOffset");

	// m_bEngaged
	[SchemaMember("CPointValueRemapper", "m_bEngaged")]
	public ref bool Engaged => ref Schema.GetRef<bool>(this.Handle, "CPointValueRemapper", "m_bEngaged");

	// m_bFirstUpdate
	[SchemaMember("CPointValueRemapper", "m_bFirstUpdate")]
	public ref bool FirstUpdate => ref Schema.GetRef<bool>(this.Handle, "CPointValueRemapper", "m_bFirstUpdate");

	// m_flPreviousValue
	[SchemaMember("CPointValueRemapper", "m_flPreviousValue")]
	public ref float PreviousValue => ref Schema.GetRef<float>(this.Handle, "CPointValueRemapper", "m_flPreviousValue");

	// m_flPreviousUpdateTickTime
	[SchemaMember("CPointValueRemapper", "m_flPreviousUpdateTickTime")]
	public ref float PreviousUpdateTickTime => ref Schema.GetRef<float>(this.Handle, "CPointValueRemapper", "m_flPreviousUpdateTickTime");

	// m_vecPreviousTestPoint
	[SchemaMember("CPointValueRemapper", "m_vecPreviousTestPoint")]
	public Vector PreviousTestPoint => Schema.GetDeclaredClass<Vector>(this.Handle, "CPointValueRemapper", "m_vecPreviousTestPoint");

	// m_hUsingPlayer
	[SchemaMember("CPointValueRemapper", "m_hUsingPlayer")]
	public CHandle<CBasePlayerPawn> UsingPlayer => Schema.GetDeclaredClass<CHandle<CBasePlayerPawn>>(this.Handle, "CPointValueRemapper", "m_hUsingPlayer");

	// m_flCustomOutputValue
	[SchemaMember("CPointValueRemapper", "m_flCustomOutputValue")]
	public ref float CustomOutputValue => ref Schema.GetRef<float>(this.Handle, "CPointValueRemapper", "m_flCustomOutputValue");

	// m_iszSoundEngage
	[SchemaMember("CPointValueRemapper", "m_iszSoundEngage")]
	public string SoundEngage
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointValueRemapper", "m_iszSoundEngage"); }
		set { Schema.SetString(this.Handle, "CPointValueRemapper", "m_iszSoundEngage", value); }
	}

	// m_iszSoundDisengage
	[SchemaMember("CPointValueRemapper", "m_iszSoundDisengage")]
	public string SoundDisengage
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointValueRemapper", "m_iszSoundDisengage"); }
		set { Schema.SetString(this.Handle, "CPointValueRemapper", "m_iszSoundDisengage", value); }
	}

	// m_iszSoundReachedValueZero
	[SchemaMember("CPointValueRemapper", "m_iszSoundReachedValueZero")]
	public string SoundReachedValueZero
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointValueRemapper", "m_iszSoundReachedValueZero"); }
		set { Schema.SetString(this.Handle, "CPointValueRemapper", "m_iszSoundReachedValueZero", value); }
	}

	// m_iszSoundReachedValueOne
	[SchemaMember("CPointValueRemapper", "m_iszSoundReachedValueOne")]
	public string SoundReachedValueOne
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointValueRemapper", "m_iszSoundReachedValueOne"); }
		set { Schema.SetString(this.Handle, "CPointValueRemapper", "m_iszSoundReachedValueOne", value); }
	}

	// m_iszSoundMovingLoop
	[SchemaMember("CPointValueRemapper", "m_iszSoundMovingLoop")]
	public string SoundMovingLoop
	{
		get { return Schema.GetUtf8String(this.Handle, "CPointValueRemapper", "m_iszSoundMovingLoop"); }
		set { Schema.SetString(this.Handle, "CPointValueRemapper", "m_iszSoundMovingLoop", value); }
	}

	// m_OnReachedValueZero
	[SchemaMember("CPointValueRemapper", "m_OnReachedValueZero")]
	public CEntityIOOutput OnReachedValueZero => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPointValueRemapper", "m_OnReachedValueZero");

	// m_OnReachedValueOne
	[SchemaMember("CPointValueRemapper", "m_OnReachedValueOne")]
	public CEntityIOOutput OnReachedValueOne => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPointValueRemapper", "m_OnReachedValueOne");

	// m_OnReachedValueCustom
	[SchemaMember("CPointValueRemapper", "m_OnReachedValueCustom")]
	public CEntityIOOutput OnReachedValueCustom => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPointValueRemapper", "m_OnReachedValueCustom");

	// m_OnEngage
	[SchemaMember("CPointValueRemapper", "m_OnEngage")]
	public CEntityIOOutput OnEngage => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPointValueRemapper", "m_OnEngage");

	// m_OnDisengage
	[SchemaMember("CPointValueRemapper", "m_OnDisengage")]
	public CEntityIOOutput OnDisengage => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CPointValueRemapper", "m_OnDisengage");

}
