using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class HccStoreDomain
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public string DomainName { get; set; } = null!;
}
