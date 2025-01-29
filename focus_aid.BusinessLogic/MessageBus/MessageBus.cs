using DTO;

namespace focus_aid.BusinessLogic.MessageBus
{
    /// <summary>
    /// Talks to UI and BL. Middleman between UI and BL. 
    /// </summary>
    public class MessageBus : IMessageBus
    {
        public bool ReceiveFromUI(UiDto countdownSessionDTO)
        {
            throw new NotImplementedException();
        }

        public UiDto SendToUI()
        {
            throw new NotImplementedException();
        }
    }
}
