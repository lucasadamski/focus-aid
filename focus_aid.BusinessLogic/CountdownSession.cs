using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace focus_aid.BusinessLogic
{
    public class CountdownSession : ICountdownSession
    {
        public bool IsSessionActive { get; private set; }
        public int InitialSeconds { get; private set; }
        public int SecondsElapsed { get; private set; }

        public CountdownSession(int initialSeconds)
        {
            InitialSeconds = initialSeconds;
        }

        public bool Cancel()
        {
            throw new NotImplementedException();
        }
        public bool Pause()
        {
            bool result = false;
            if(IsSessionActive == false)
            {
                IsSessionActive = true;
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public bool Start()
        {
            bool result = false;
            if (InitialSeconds < 1)
            {
                result = false;
            }
            else
            {
                IsSessionActive = true;
                result = true;
            }
            return result;
        }

        public bool Stop()
        {
            IsSessionActive = false;
            return true;
        }
    }
}
