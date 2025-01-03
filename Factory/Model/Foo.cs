namespace Factory.Model;

public class Foo
{
    private Foo()
    {
    }

    private async Task<Foo> InitAsync()
    {
        await Task.Delay(1000);
        return this;
    }

    public static Task<Foo> CreateAsync()
    {
        var result = new Foo();
        return result.InitAsync();
    }

    public override string ToString()
    {
        return "Foo instance";
    }
}