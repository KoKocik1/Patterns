namespace Solid_I;

public interface IMashine
{
    void print(Document d);
    void scan(Document d);
    void fax(Document d);
}

public interface IPrinter
{
    void print(Document d);
}

public interface IScanner
{
    void scan(Document d);
}

public interface IFax
{
    void fax(Document d);
}

public interface IMultiFunctionDevice : IPrinter, IScanner
{
}