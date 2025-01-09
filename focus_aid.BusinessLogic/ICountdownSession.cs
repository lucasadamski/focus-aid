﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace focus_aid.BusinessLogic
{
    public interface ICountdownSession
    {
        bool Start(int seconds);
        bool Stop();
        bool Pause();
        bool Cancel();
        bool DelegateCountdownToUI(int seconds);
    }
}
