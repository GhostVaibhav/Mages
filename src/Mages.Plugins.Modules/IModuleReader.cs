﻿namespace Mages.Plugins.Modules
{
    using Mages.Core;
    using System;

    public interface IModuleFileReader
    {
        Action<Engine> Prepare(String path);

        Boolean TryGetPath(String fileName, out String path);
    }
}
