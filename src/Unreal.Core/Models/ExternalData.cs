﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unreal.Core.Contracts;

namespace Unreal.Core.Models
{
    public class ExternalData : IExternalData
    {
        public uint NetGUID { get; init; }
        public FArchive Archive { get; init; }
        public int TimeSeconds { get; init; }
    }
}
