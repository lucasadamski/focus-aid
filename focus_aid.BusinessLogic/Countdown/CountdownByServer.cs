using focus_aid.BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace focus_aid.BusinessLogic.Countdown
{
    public class CountdownByServer : ICountdownStrategy
    {
        public CountdownDto Cancel()
        {
            throw new NotImplementedException();
        }

        public CountdownDto Pause()
        {
            throw new NotImplementedException();
        }

        public CountdownDto Start()
        {
            return new CountdownDto() { Seconds = 0, Success = true, Message = "Test countdown successful!" };
        }

        public CountdownDto Stop()
        {
            throw new NotImplementedException();
        }
    }
}
