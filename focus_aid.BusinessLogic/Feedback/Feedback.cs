using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace focus_aid.BusinessLogic.Feedback
{
    public class Feedback : IFeedback
    {
        public string? Message { get; set; }
        public bool Success { get; set; }

        public bool MarkSuccess(bool successful)
        {
            Success = successful;
            return true;
        }

        public string? ReadFeedback() => Message;

        public bool WriteFeedback(string message)
        {
            bool result = false;
            if(string.IsNullOrEmpty(message))
            {
                result = false;
            }
            if (message.Length < 26)
            {
                Message = message;
                result = true;
            }
            else
            {
                Message = message.Substring(0, 25);
                result = true;
            }
            return result;
        }
    }
}
