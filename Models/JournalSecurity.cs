using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class JournalSecurity
{
    public int JournalSecurityId { get; set; }

    public int JournalId { get; set; }

    public string SecurityKey { get; set; } = null!;
}
