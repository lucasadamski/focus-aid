using focus_aid.BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace focus_aid.BusinessLogic.Countdown
{
    public interface ICountdownStrategy
    {
        CountdownDto Start();
        CountdownDto Stop();
        CountdownDto Pause();
        CountdownDto Cancel();
    }
}
