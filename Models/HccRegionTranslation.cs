﻿using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class HccRegionTranslation
{
    public long RegionTranslationId { get; set; }

    public Guid RegionId { get; set; }

    public string Culture { get; set; } = null!;

    public string? DisplayName { get; set; }

    public virtual HccRegion Region { get; set; } = null!;
}
