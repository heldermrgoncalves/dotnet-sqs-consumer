using Proto;
using Queueing.Models;

namespace Consumer.Factories
{
    public interface IActorFactory
    {
        PID GetActor<T>(string id = null, string address = null, IContext parent = null) where T : IActor;
        PID GetActor(ISQSCommand command);
        PID GetActor(string id, string address = null, IContext parent = null);
        PID RegisterActor<T>(T actor, string id = null, string address = null, IContext parent = null) where T : IActor;
    }
}