using DTO;

namespace focus_aid.BusinessLogic.MessageBus
{
    public interface IMessageBus
    {
        UiDto SendToUI();
        bool ReceiveFromUI(UiDto countdownSessionDTO);
    }
}
