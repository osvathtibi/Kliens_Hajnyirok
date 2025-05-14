﻿using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class HccStoreSetting
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public string SettingName { get; set; } = null!;

    public string SettingValue { get; set; } = null!;

    public virtual ICollection<HccStoreSettingsTranslation> HccStoreSettingsTranslations { get; set; } = new List<HccStoreSettingsTranslation>();

    public virtual HccStore Store { get; set; } = null!;
}
