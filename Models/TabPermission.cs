﻿using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class TabPermission
{
    public int TabPermissionId { get; set; }

    public int TabId { get; set; }

    public int PermissionId { get; set; }

    public bool AllowAccess { get; set; }

    public int? RoleId { get; set; }

    public int? UserId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual Permission Permission { get; set; } = null!;

    public virtual Role? Role { get; set; }

    public virtual Tab Tab { get; set; } = null!;

    public virtual User? User { get; set; }
}
