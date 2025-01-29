using DTO;

namespace focus_aid.BusinessLogic.Countdown
{
    public interface ICountdownStrategy
    {
        CountdownDto Start();
        CountdownDto Stop();
        CountdownDto Pause();
        CountdownDto Cancel();
    }
}
