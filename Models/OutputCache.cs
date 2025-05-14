﻿using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class OutputCache
{
    public string CacheKey { get; set; } = null!;

    public int ItemId { get; set; }

    public string Data { get; set; } = null!;

    public DateTime Expiration { get; set; }
}
