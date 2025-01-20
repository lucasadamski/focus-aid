using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace focus_aid.BusinessLogic
{
    public interface ICountdown
    {
        bool Start();
        bool Stop();
        bool Pause();
        bool Cancel();
    }
}
