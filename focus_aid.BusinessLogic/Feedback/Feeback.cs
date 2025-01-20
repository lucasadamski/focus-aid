using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace focus_aid.BusinessLogic.Feedback
{
    public class Feeback : IFeedback
    {
        public string? Message { get; set; }
        public bool Success { get; set; }

        public bool MarkSuccess(bool successful)
        {
            throw new NotImplementedException();
        }

        public string ReadFeedback()
        {
            throw new NotImplementedException();
        }

        public bool WriteFeedback(string message)
        {
            throw new NotImplementedException();
        }
    }
}
