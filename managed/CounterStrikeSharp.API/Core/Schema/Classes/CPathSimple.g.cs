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

public partial class CPathSimple : CBaseEntity
{
    public CPathSimple (IntPtr pointer) : base(pointer) {}

	// m_pathString
	[SchemaMember("CPathSimple", "m_pathString")]
	public string PathString
	{
		get { return Schema.GetUtf8String(this.Handle, "CPathSimple", "m_pathString"); }
		set { Schema.SetString(this.Handle, "CPathSimple", "m_pathString", value); }
	}

}
