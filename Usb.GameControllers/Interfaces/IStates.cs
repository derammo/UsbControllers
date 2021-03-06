﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usb.GameControllers.Interfaces
{
    public interface IStates
    {
        IState Current { get; set; }
        IState Previous { get; set; }

        void Initialize();
        IState CreateFromBuffer(byte[] buffer);
    }
}
