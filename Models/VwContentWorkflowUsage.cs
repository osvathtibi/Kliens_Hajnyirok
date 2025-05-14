using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class VwContentWorkflowUsage
{
    public string? ContentName { get; set; }

    public string ContentType { get; set; } = null!;

    public int? WorkflowId { get; set; }
}
