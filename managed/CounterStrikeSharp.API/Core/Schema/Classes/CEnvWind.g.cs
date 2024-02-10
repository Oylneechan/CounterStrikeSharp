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
public partial class CEnvWind : CBaseEntity, ICEnvWind
{
    public CEnvWind (IntPtr pointer) : base(pointer) {}

	// m_EnvWindShared
	[SchemaMember("CEnvWind", "m_EnvWindShared")]
	public CEnvWindShared EnvWindShared => Schema.GetDeclaredClass<CEnvWindShared>(this.Handle, "CEnvWind", "m_EnvWindShared");

}
