﻿using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class JournalTypeFilter
{
    public int JournalTypeFilterId { get; set; }

    public int PortalId { get; set; }

    public int ModuleId { get; set; }

    public int JournalTypeId { get; set; }
}
