﻿using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class ExtensionUrlProvider
{
    public int ExtensionUrlProviderId { get; set; }

    public string ProviderName { get; set; } = null!;

    public string ProviderType { get; set; } = null!;

    public string? SettingsControlSrc { get; set; }

    public bool IsActive { get; set; }

    public bool RewriteAllUrls { get; set; }

    public bool RedirectAllUrls { get; set; }

    public bool ReplaceAllUrls { get; set; }

    public int? DesktopModuleId { get; set; }
}
