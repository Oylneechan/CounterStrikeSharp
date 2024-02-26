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

public partial class CBlood : CPointEntity
{
    public CBlood (IntPtr pointer) : base(pointer) {}

	// m_vecSprayAngles
	[SchemaMember("CBlood", "m_vecSprayAngles")]
	public QAngle SprayAngles => Schema.GetDeclaredClass<QAngle>(this.Handle, "CBlood", "m_vecSprayAngles");

	// m_vecSprayDir
	[SchemaMember("CBlood", "m_vecSprayDir")]
	public Vector SprayDir => Schema.GetDeclaredClass<Vector>(this.Handle, "CBlood", "m_vecSprayDir");

	// m_flAmount
	[SchemaMember("CBlood", "m_flAmount")]
	public ref float Amount => ref Schema.GetRef<float>(this.Handle, "CBlood", "m_flAmount");

	// m_Color
	[SchemaMember("CBlood", "m_Color")]
	public ref Int32 Color => ref Schema.GetRef<Int32>(this.Handle, "CBlood", "m_Color");

}
