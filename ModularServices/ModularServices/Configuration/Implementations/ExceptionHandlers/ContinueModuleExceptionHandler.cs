﻿using KoeLib.ModularServices.Configuration;
using KoeLib.ModularServices.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace KoeLib.ModularServices.Configuration.Implementations.ExceptionHandlers
{
    internal class ContinueModuleExceptionHandler<TService> : IModuleExceptionHandler<TService>
        where TService : class
    {
        public OnModuleExceptionAction Handle(Exception e, TService service, IModule<TService> module, ModuleExceptionLocation location)
            => OnModuleExceptionAction.Continue;
    }
}