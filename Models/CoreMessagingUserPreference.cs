﻿using System;
using System.Collections.Generic;

namespace Kliens_Hajnyirok.Models;

public partial class CoreMessagingUserPreference
{
    public int UserPreferenceId { get; set; }

    public int PortalId { get; set; }

    public int UserId { get; set; }

    public int MessagesEmailFrequency { get; set; }

    public int NotificationsEmailFrequency { get; set; }
}
