﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAP3D
{
    public interface IFSUIPCFactory
    {
        IFSUIPCInterface createFSUIPCInterface(IFSUIPC fsuipc, IOffsetFactory offsetFactory);
    }
}
