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
public partial class sky3dparams_t : NativeObject, Isky3dparams_t
{
    public sky3dparams_t (IntPtr pointer) : base(pointer) {}

	// scale
	[SchemaMember("sky3dparams_t", "scale")]
	public ref Int16 Scale => ref Schema.GetRef<Int16>(this.Handle, "sky3dparams_t", "scale");

	// origin
	[SchemaMember("sky3dparams_t", "origin")]
	public Vector Origin => Schema.GetDeclaredClass<Vector>(this.Handle, "sky3dparams_t", "origin");

	// bClip3DSkyBoxNearToWorldFar
	[SchemaMember("sky3dparams_t", "bClip3DSkyBoxNearToWorldFar")]
	public ref bool BClip3DSkyBoxNearToWorldFar => ref Schema.GetRef<bool>(this.Handle, "sky3dparams_t", "bClip3DSkyBoxNearToWorldFar");

	// flClip3DSkyBoxNearToWorldFarOffset
	[SchemaMember("sky3dparams_t", "flClip3DSkyBoxNearToWorldFarOffset")]
	public ref float FlClip3DSkyBoxNearToWorldFarOffset => ref Schema.GetRef<float>(this.Handle, "sky3dparams_t", "flClip3DSkyBoxNearToWorldFarOffset");

	// fog
	[SchemaMember("sky3dparams_t", "fog")]
	public fogparams_t Fog => Schema.GetDeclaredClass<fogparams_t>(this.Handle, "sky3dparams_t", "fog");

	// m_nWorldGroupID
	[SchemaMember("sky3dparams_t", "m_nWorldGroupID")]
	public WorldGroupId_t WorldGroupID => Schema.GetDeclaredClass<WorldGroupId_t>(this.Handle, "sky3dparams_t", "m_nWorldGroupID");

}
