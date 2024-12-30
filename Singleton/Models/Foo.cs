namespace Singleton.Models;

public class Foo
{
    public EventBroker Broker;

    public Foo(EventBroker broker)
    {
        Broker = broker ?? throw new ArgumentNullException(paramName: nameof(broker));
    }
}