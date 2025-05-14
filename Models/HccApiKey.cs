using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class HccApiKey
{
    public long Id { get; set; }

    public long StoreId { get; set; }

    public string ApiKey { get; set; } = null!;
}
