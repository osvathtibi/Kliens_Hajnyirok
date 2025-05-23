﻿using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public int? PortalId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? ServiceFee { get; set; }

    public string? BillingFrequency { get; set; }

    public int? TrialPeriod { get; set; }

    public string? TrialFrequency { get; set; }

    public int? BillingPeriod { get; set; }

    public decimal? TrialFee { get; set; }

    public bool IsPublic { get; set; }

    public bool AutoAssignment { get; set; }

    public int? RoleGroupId { get; set; }

    public string? Rsvpcode { get; set; }

    public string? IconFile { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public int Status { get; set; }

    public int SecurityMode { get; set; }

    public bool IsSystemRole { get; set; }

    public virtual ICollection<DesktopModulePermission> DesktopModulePermissions { get; set; } = new List<DesktopModulePermission>();

    public virtual ICollection<FolderPermission> FolderPermissions { get; set; } = new List<FolderPermission>();

    public virtual ICollection<ModulePermission> ModulePermissions { get; set; } = new List<ModulePermission>();

    public virtual ICollection<PersonaBarMenuPermission> PersonaBarMenuPermissions { get; set; } = new List<PersonaBarMenuPermission>();

    public virtual Portal? Portal { get; set; }

    public virtual ICollection<PortalPermission> PortalPermissions { get; set; } = new List<PortalPermission>();

    public virtual RoleGroup? RoleGroup { get; set; }

    public virtual ICollection<TabPermission> TabPermissions { get; set; } = new List<TabPermission>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}
