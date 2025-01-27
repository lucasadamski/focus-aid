using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using focus_aid.BusinessLogic.DTOs;

namespace focus_aid.BusinessLogic.Countdown
{
    public class CoutdownByDelegatingToUi : ICountdownStrategy
    {
        public bool IsSessionActive { get; private set; }
        public int InitialSeconds { get; private set; }
        public int SecondsElapsed { get; private set; }

        public CoutdownByDelegatingToUi()
        { }
        public CoutdownByDelegatingToUi(int initialSeconds)
        {
            InitialSeconds = initialSeconds;
        }

        public CountdownDto Cancel()
        {
            throw new NotImplementedException();
        }
        public CountdownDto Pause()
        {
            CountdownDto result = new CountdownDto();
            if (IsSessionActive == false)
            {
                IsSessionActive = true;
                result.Success = true;
            }
            else
            {
                result.Success = false;
            }
            return result;
        }

        public CountdownDto Start()
        {
            CountdownDto result = new CountdownDto();
            if (InitialSeconds < 1)
            {
                result.Success = false;
            }
            else
            {
                IsSessionActive = true;
                result.Success = true;
            }
            return result;
        }

        public CountdownDto Stop()
        {
            CountdownDto result = new CountdownDto();
            result.Success = true;
            IsSessionActive = false;
            return result;
        }
    }
}
