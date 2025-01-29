using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace focus_aid.DTO
{
    public class FeedbackDto : UiDto
    {
        public string? Feedback { get; set; }
        public bool Successful { get; set; }
    }
}
