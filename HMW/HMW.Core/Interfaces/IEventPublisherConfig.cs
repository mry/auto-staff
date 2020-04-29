namespace HMW.Core.Interfaces
{
    public interface IEventPublisherConfig
    {
        string Endpoint { get; set; }
        string Key { get; set; }
    }
}