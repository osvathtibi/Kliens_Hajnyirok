﻿using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class SearchType
{
    public int SearchTypeId { get; set; }

    public string SearchTypeName { get; set; } = null!;

    public string SearchResultClass { get; set; } = null!;

    public bool? IsPrivate { get; set; }
}
