﻿using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class RedirectMessage
{
    public Guid MessageId { get; set; }

    public int? UserId { get; set; }

    public int? TabId { get; set; }

    public string MessageText { get; set; } = null!;

    public DateTime CreatedOnDate { get; set; }
}
