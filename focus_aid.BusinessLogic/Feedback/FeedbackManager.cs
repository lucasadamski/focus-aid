using focus_aid.BusinessLogic.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace focus_aid.BusinessLogic.Feedback
{
    public class FeedbackManager : IManager
    {
        public Feedback Feedback { get; set; }
        public FeedbackManager()
        {
            
        }

        public bool ReceiveDTOFromMessageBus(UiDto uiDTO)
        {
            throw new NotImplementedException();
        }

        public UiDto SendDTOToMessageBus()
        {
            throw new NotImplementedException();
        }
    }
}
