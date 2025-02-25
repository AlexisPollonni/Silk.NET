// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSpaceVelocitiesKHR")]
    [NativeName("AliasOf", "XrSpaceVelocities")]
    public unsafe partial struct SpaceVelocitiesKHR
    {
        public SpaceVelocitiesKHR
        (
            StructureType? type = StructureType.TypeSpaceVelocities,
            void* next = null,
            uint? velocityCount = null,
            SpaceVelocityData* velocities = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (velocityCount is not null)
            {
                VelocityCount = velocityCount.Value;
            }

            if (velocities is not null)
            {
                Velocities = velocities;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "velocityCount")]
        public uint VelocityCount;
/// <summary></summary>
        [NativeName("Type", "XrSpaceVelocityData*")]
        [NativeName("Type.Name", "XrSpaceVelocityData")]
        [NativeName("Name", "velocities")]
        public SpaceVelocityData* Velocities;
    }
}
