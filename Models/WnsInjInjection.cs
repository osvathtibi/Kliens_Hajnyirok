using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class WnsInjInjection
{
    public int InjectionId { get; set; }

    public int ModuleId { get; set; }

    public bool InjectTop { get; set; }

    public string InjectName { get; set; } = null!;

    public string InjectContent { get; set; } = null!;

    public int OrderShown { get; set; }

    public bool IsEnabled { get; set; }

    public string? CustomProperties { get; set; }

    public virtual Module Module { get; set; } = null!;
}
