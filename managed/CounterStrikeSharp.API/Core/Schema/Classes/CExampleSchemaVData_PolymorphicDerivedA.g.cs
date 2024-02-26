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

public partial class CExampleSchemaVData_PolymorphicDerivedA : CExampleSchemaVData_PolymorphicBase
{
    public CExampleSchemaVData_PolymorphicDerivedA (IntPtr pointer) : base(pointer) {}

	// m_nDerivedA
	[SchemaMember("CExampleSchemaVData_PolymorphicDerivedA", "m_nDerivedA")]
	public ref Int32 DerivedA => ref Schema.GetRef<Int32>(this.Handle, "CExampleSchemaVData_PolymorphicDerivedA", "m_nDerivedA");

}
