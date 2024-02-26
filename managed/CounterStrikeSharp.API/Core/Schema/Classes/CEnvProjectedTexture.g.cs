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

public partial class CEnvProjectedTexture : CModelPointEntity
{
    public CEnvProjectedTexture (IntPtr pointer) : base(pointer) {}

	// m_hTargetEntity
	[SchemaMember("CEnvProjectedTexture", "m_hTargetEntity")]
	public CHandle<CBaseEntity> TargetEntity => Schema.GetDeclaredClass<CHandle<CBaseEntity>>(this.Handle, "CEnvProjectedTexture", "m_hTargetEntity");

	// m_bState
	[SchemaMember("CEnvProjectedTexture", "m_bState")]
	public ref bool State => ref Schema.GetRef<bool>(this.Handle, "CEnvProjectedTexture", "m_bState");

	// m_bAlwaysUpdate
	[SchemaMember("CEnvProjectedTexture", "m_bAlwaysUpdate")]
	public ref bool AlwaysUpdate => ref Schema.GetRef<bool>(this.Handle, "CEnvProjectedTexture", "m_bAlwaysUpdate");

	// m_flLightFOV
	[SchemaMember("CEnvProjectedTexture", "m_flLightFOV")]
	public ref float LightFOV => ref Schema.GetRef<float>(this.Handle, "CEnvProjectedTexture", "m_flLightFOV");

	// m_bEnableShadows
	[SchemaMember("CEnvProjectedTexture", "m_bEnableShadows")]
	public ref bool EnableShadows => ref Schema.GetRef<bool>(this.Handle, "CEnvProjectedTexture", "m_bEnableShadows");

	// m_bSimpleProjection
	[SchemaMember("CEnvProjectedTexture", "m_bSimpleProjection")]
	public ref bool SimpleProjection => ref Schema.GetRef<bool>(this.Handle, "CEnvProjectedTexture", "m_bSimpleProjection");

	// m_bLightOnlyTarget
	[SchemaMember("CEnvProjectedTexture", "m_bLightOnlyTarget")]
	public ref bool LightOnlyTarget => ref Schema.GetRef<bool>(this.Handle, "CEnvProjectedTexture", "m_bLightOnlyTarget");

	// m_bLightWorld
	[SchemaMember("CEnvProjectedTexture", "m_bLightWorld")]
	public ref bool LightWorld => ref Schema.GetRef<bool>(this.Handle, "CEnvProjectedTexture", "m_bLightWorld");

	// m_bCameraSpace
	[SchemaMember("CEnvProjectedTexture", "m_bCameraSpace")]
	public ref bool CameraSpace => ref Schema.GetRef<bool>(this.Handle, "CEnvProjectedTexture", "m_bCameraSpace");

	// m_flBrightnessScale
	[SchemaMember("CEnvProjectedTexture", "m_flBrightnessScale")]
	public ref float BrightnessScale => ref Schema.GetRef<float>(this.Handle, "CEnvProjectedTexture", "m_flBrightnessScale");

	// m_LightColor
	[SchemaMember("CEnvProjectedTexture", "m_LightColor")]
	public Color LightColor
	{
		get { return Schema.GetCustomMarshalledType<Color>(this.Handle, "CEnvProjectedTexture", "m_LightColor"); }
		set { Schema.SetCustomMarshalledType<Color>(this.Handle, "CEnvProjectedTexture", "m_LightColor", value); }
	}

	// m_flIntensity
	[SchemaMember("CEnvProjectedTexture", "m_flIntensity")]
	public ref float Intensity => ref Schema.GetRef<float>(this.Handle, "CEnvProjectedTexture", "m_flIntensity");

	// m_flLinearAttenuation
	[SchemaMember("CEnvProjectedTexture", "m_flLinearAttenuation")]
	public ref float LinearAttenuation => ref Schema.GetRef<float>(this.Handle, "CEnvProjectedTexture", "m_flLinearAttenuation");

	// m_flQuadraticAttenuation
	[SchemaMember("CEnvProjectedTexture", "m_flQuadraticAttenuation")]
	public ref float QuadraticAttenuation => ref Schema.GetRef<float>(this.Handle, "CEnvProjectedTexture", "m_flQuadraticAttenuation");

	// m_bVolumetric
	[SchemaMember("CEnvProjectedTexture", "m_bVolumetric")]
	public ref bool Volumetric => ref Schema.GetRef<bool>(this.Handle, "CEnvProjectedTexture", "m_bVolumetric");

	// m_flNoiseStrength
	[SchemaMember("CEnvProjectedTexture", "m_flNoiseStrength")]
	public ref float NoiseStrength => ref Schema.GetRef<float>(this.Handle, "CEnvProjectedTexture", "m_flNoiseStrength");

	// m_flFlashlightTime
	[SchemaMember("CEnvProjectedTexture", "m_flFlashlightTime")]
	public ref float FlashlightTime => ref Schema.GetRef<float>(this.Handle, "CEnvProjectedTexture", "m_flFlashlightTime");

	// m_nNumPlanes
	[SchemaMember("CEnvProjectedTexture", "m_nNumPlanes")]
	public ref UInt32 NumPlanes => ref Schema.GetRef<UInt32>(this.Handle, "CEnvProjectedTexture", "m_nNumPlanes");

	// m_flPlaneOffset
	[SchemaMember("CEnvProjectedTexture", "m_flPlaneOffset")]
	public ref float PlaneOffset => ref Schema.GetRef<float>(this.Handle, "CEnvProjectedTexture", "m_flPlaneOffset");

	// m_flVolumetricIntensity
	[SchemaMember("CEnvProjectedTexture", "m_flVolumetricIntensity")]
	public ref float VolumetricIntensity => ref Schema.GetRef<float>(this.Handle, "CEnvProjectedTexture", "m_flVolumetricIntensity");

	// m_flColorTransitionTime
	[SchemaMember("CEnvProjectedTexture", "m_flColorTransitionTime")]
	public ref float ColorTransitionTime => ref Schema.GetRef<float>(this.Handle, "CEnvProjectedTexture", "m_flColorTransitionTime");

	// m_flAmbient
	[SchemaMember("CEnvProjectedTexture", "m_flAmbient")]
	public ref float Ambient => ref Schema.GetRef<float>(this.Handle, "CEnvProjectedTexture", "m_flAmbient");

	// m_SpotlightTextureName
	[SchemaMember("CEnvProjectedTexture", "m_SpotlightTextureName")]
	public string SpotlightTextureName
	{
		get { return Schema.GetString(this.Handle, "CEnvProjectedTexture", "m_SpotlightTextureName"); }
		set { Schema.SetStringBytes(this.Handle, "CEnvProjectedTexture", "m_SpotlightTextureName", value, 512); }
	}

	// m_nSpotlightTextureFrame
	[SchemaMember("CEnvProjectedTexture", "m_nSpotlightTextureFrame")]
	public ref Int32 SpotlightTextureFrame => ref Schema.GetRef<Int32>(this.Handle, "CEnvProjectedTexture", "m_nSpotlightTextureFrame");

	// m_nShadowQuality
	[SchemaMember("CEnvProjectedTexture", "m_nShadowQuality")]
	public ref UInt32 ShadowQuality => ref Schema.GetRef<UInt32>(this.Handle, "CEnvProjectedTexture", "m_nShadowQuality");

	// m_flNearZ
	[SchemaMember("CEnvProjectedTexture", "m_flNearZ")]
	public ref float NearZ => ref Schema.GetRef<float>(this.Handle, "CEnvProjectedTexture", "m_flNearZ");

	// m_flFarZ
	[SchemaMember("CEnvProjectedTexture", "m_flFarZ")]
	public ref float FarZ => ref Schema.GetRef<float>(this.Handle, "CEnvProjectedTexture", "m_flFarZ");

	// m_flProjectionSize
	[SchemaMember("CEnvProjectedTexture", "m_flProjectionSize")]
	public ref float ProjectionSize => ref Schema.GetRef<float>(this.Handle, "CEnvProjectedTexture", "m_flProjectionSize");

	// m_flRotation
	[SchemaMember("CEnvProjectedTexture", "m_flRotation")]
	public ref float Rotation => ref Schema.GetRef<float>(this.Handle, "CEnvProjectedTexture", "m_flRotation");

	// m_bFlipHorizontal
	[SchemaMember("CEnvProjectedTexture", "m_bFlipHorizontal")]
	public ref bool FlipHorizontal => ref Schema.GetRef<bool>(this.Handle, "CEnvProjectedTexture", "m_bFlipHorizontal");

}
