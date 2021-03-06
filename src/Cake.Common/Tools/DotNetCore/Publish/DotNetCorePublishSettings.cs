﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Cake.Common.Tools.DotNetCore.MSBuild;
using Cake.Core.IO;

namespace Cake.Common.Tools.DotNetCore.Publish
{
    /// <summary>
    /// Contains settings used by <see cref="DotNetCorePublisher" />.
    /// </summary>
    public sealed class DotNetCorePublishSettings : DotNetCoreSettings
    {
        /// <summary>
        /// Gets or sets the output directory.
        /// </summary>
        public DirectoryPath OutputDirectory { get; set; }

        /// <summary>
        /// Gets or sets the target runtime.
        /// </summary>
        public string Runtime { get; set; }

        /// <summary>
        /// Gets or sets a specific framework to compile.
        /// </summary>
        public string Framework { get; set; }

        /// <summary>
        /// Gets or sets the configuration under which to build.
        /// </summary>
        public string Configuration { get; set; }

        /// <summary>
        /// Gets or sets the value that defines what `*` should be replaced with in version field in project.json.
        /// </summary>
        public string VersionSuffix { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to ignore project to project references and only build the root project.
        /// </summary>
        /// <remarks>
        /// Requires .NET Core 2.x or newer.
        /// </remarks>
        public bool NoDependencies { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to not do implicit NuGet package restore.
        /// This makes build faster, but requires restore to be done before build is executed.
        /// </summary>
        /// <remarks>
        /// Requires .NET Core 2.x or newer.
        /// </remarks>
        public bool NoRestore { get; set; }

        /// <summary>
        /// Gets or sets additional arguments to be passed to MSBuild.
        /// </summary>
        public DotNetCoreMSBuildSettings MSBuildSettings { get; set; }
    }
}
