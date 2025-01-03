namespace Builder.Builders;

public abstract class FunctionalBuilder<TSubject, TSelf>
    where TSelf : FunctionalBuilder<TSubject, TSelf>
    where TSubject : new()
{
    private readonly List<Func<TSubject, TSubject>> actions = new();

    public TSelf Do(Action<TSubject> action)
    {
        return AddAction(action);
    }

    private TSelf AddAction(Action<TSubject> action)
    {
        actions.Add(p =>
        {
            action(p);
            return p;
        });
        return (TSelf)this;
    }

    public TSubject Build()
    {
        return actions.Aggregate(new TSubject(), (p, f) => f(p));
    }
}