using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class SearchCommonWord
{
    public int CommonWordId { get; set; }

    public string CommonWord { get; set; } = null!;

    public string? Locale { get; set; }
}
