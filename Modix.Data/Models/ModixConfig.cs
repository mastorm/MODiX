﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Modix.Data.Models
{
    public class ModixConfig
    {
        public string DiscordToken { get; set; }
        public string StackoverflowToken { get; set; }
        public string ReplToken { get; set; }
        public string PostgreConnectionString { get; set; }
    }
}
