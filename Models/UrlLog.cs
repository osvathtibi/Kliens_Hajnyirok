﻿using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class UrlLog
{
    public int UrlLogId { get; set; }

    public int UrlTrackingId { get; set; }

    public DateTime ClickDate { get; set; }

    public int? UserId { get; set; }

    public virtual UrlTracking UrlTracking { get; set; } = null!;
}
