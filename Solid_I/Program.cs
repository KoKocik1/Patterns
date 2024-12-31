using Solid_I;

public class Program
{
    public static void Main()
    {
        var d = new Document();
        var mfp = new MultiFunctionPrinter();
        mfp.print(d);
        mfp.scan(d);
        mfp.fax(d);
    }

    public class MultiFunctionPrinter : IFax, IPrinter, IScanner //IMashine -błąd
    {
        public void fax(Document d)
        {
            //
        }

        public void print(Document d)
        {
            //
        }

        public void scan(Document d)
        {
            //
        }
    }

    public class OldFashionedPrinter : IPrinter
    {
        public void print(Document d)
        {
            //
        }
    }

    public class Photocopier : IMultiFunctionDevice
    {
        public void print(Document d)
        {
            //
        }

        public void scan(Document d)
        {
            //
        }
    }
}