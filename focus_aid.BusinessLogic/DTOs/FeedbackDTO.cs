using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace focus_aid.BusinessLogic.DTOs
{
    public class FeedbackDTO : UIDTO
    {
        public string? Feedback { get; set; }
        public bool Success { get; set; }
    }
}
