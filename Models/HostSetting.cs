﻿using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class HostSetting
{
    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    public bool SettingIsSecure { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }
}
