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
public partial class locksound_t : NativeObject, Ilocksound_t
{
    public locksound_t (IntPtr pointer) : base(pointer) {}

	// sLockedSound
	[SchemaMember("locksound_t", "sLockedSound")]
	public string SLockedSound
	{
		get { return Schema.GetUtf8String(this.Handle, "locksound_t", "sLockedSound"); }
		set { Schema.SetString(this.Handle, "locksound_t", "sLockedSound", value); }
	}

	// sUnlockedSound
	[SchemaMember("locksound_t", "sUnlockedSound")]
	public string SUnlockedSound
	{
		get { return Schema.GetUtf8String(this.Handle, "locksound_t", "sUnlockedSound"); }
		set { Schema.SetString(this.Handle, "locksound_t", "sUnlockedSound", value); }
	}

	// flwaitSound
	[SchemaMember("locksound_t", "flwaitSound")]
	public ref float FlwaitSound => ref Schema.GetRef<float>(this.Handle, "locksound_t", "flwaitSound");

}
