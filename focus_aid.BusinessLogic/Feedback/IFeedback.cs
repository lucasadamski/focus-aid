using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace focus_aid.BusinessLogic.Feedback
{
    public interface IFeedback
    {
        public bool WriteFeedback(string message);
        public string ReadFeedback();
        public bool MarkSuccess(bool successful);

    }
}
