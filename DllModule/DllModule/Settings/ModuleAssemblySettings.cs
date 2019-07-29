﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KoeLib.DllModule.Settings
{
    public sealed class ModuleAssemblySettings
    {
        public string Filename { get; set; }

        public List<ModuleSettings> Modules { get; set; } = new List<ModuleSettings>();
    }
}