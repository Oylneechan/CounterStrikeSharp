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
public partial class CBaseProp : CBaseAnimGraph, ICBaseProp
{
    public CBaseProp (IntPtr pointer) : base(pointer) {}

	// m_bModelOverrodeBlockLOS
	[SchemaMember("CBaseProp", "m_bModelOverrodeBlockLOS")]
	public ref bool ModelOverrodeBlockLOS => ref Schema.GetRef<bool>(this.Handle, "CBaseProp", "m_bModelOverrodeBlockLOS");

	// m_iShapeType
	[SchemaMember("CBaseProp", "m_iShapeType")]
	public ref Int32 ShapeType => ref Schema.GetRef<Int32>(this.Handle, "CBaseProp", "m_iShapeType");

	// m_bConformToCollisionBounds
	[SchemaMember("CBaseProp", "m_bConformToCollisionBounds")]
	public ref bool ConformToCollisionBounds => ref Schema.GetRef<bool>(this.Handle, "CBaseProp", "m_bConformToCollisionBounds");

	// m_mPreferredCatchTransform
	[SchemaMember("CBaseProp", "m_mPreferredCatchTransform")]
	public matrix3x4_t MPreferredCatchTransform => Schema.GetDeclaredClass<matrix3x4_t>(this.Handle, "CBaseProp", "m_mPreferredCatchTransform");

}
