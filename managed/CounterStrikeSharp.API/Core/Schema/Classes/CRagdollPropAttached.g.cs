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
public partial class CRagdollPropAttached : CRagdollProp, ICRagdollPropAttached
{
    public CRagdollPropAttached (IntPtr pointer) : base(pointer) {}

	// m_boneIndexAttached
	[SchemaMember("CRagdollPropAttached", "m_boneIndexAttached")]
	public ref UInt32 BoneIndexAttached => ref Schema.GetRef<UInt32>(this.Handle, "CRagdollPropAttached", "m_boneIndexAttached");

	// m_ragdollAttachedObjectIndex
	[SchemaMember("CRagdollPropAttached", "m_ragdollAttachedObjectIndex")]
	public ref UInt32 RagdollAttachedObjectIndex => ref Schema.GetRef<UInt32>(this.Handle, "CRagdollPropAttached", "m_ragdollAttachedObjectIndex");

	// m_attachmentPointBoneSpace
	[SchemaMember("CRagdollPropAttached", "m_attachmentPointBoneSpace")]
	public Vector AttachmentPointBoneSpace => Schema.GetDeclaredClass<Vector>(this.Handle, "CRagdollPropAttached", "m_attachmentPointBoneSpace");

	// m_attachmentPointRagdollSpace
	[SchemaMember("CRagdollPropAttached", "m_attachmentPointRagdollSpace")]
	public Vector AttachmentPointRagdollSpace => Schema.GetDeclaredClass<Vector>(this.Handle, "CRagdollPropAttached", "m_attachmentPointRagdollSpace");

	// m_bShouldDetach
	[SchemaMember("CRagdollPropAttached", "m_bShouldDetach")]
	public ref bool ShouldDetach => ref Schema.GetRef<bool>(this.Handle, "CRagdollPropAttached", "m_bShouldDetach");

	// m_bShouldDeleteAttachedActivationRecord
	[SchemaMember("CRagdollPropAttached", "m_bShouldDeleteAttachedActivationRecord")]
	public ref bool ShouldDeleteAttachedActivationRecord => ref Schema.GetRef<bool>(this.Handle, "CRagdollPropAttached", "m_bShouldDeleteAttachedActivationRecord");

}
