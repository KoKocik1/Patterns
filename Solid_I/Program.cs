using Solid_I;

public class Program
{
    
    public class MultiFunctionPrinter: IFax, IPrinter, IScanner //IMashine -błąd
    {
        public void print(Document d)
        {
            //
        }

        public void scan(Document d)
        {
            //
        }

        public void fax(Document d)
        {
            //
        }
    }
    public class OldFashionedPrinter: IPrinter
    {
        public void print(Document d)
        {
            //
        }
    }
    public class Photocopier: IMultiFunctionDevice
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
    public static void Main()
    {
        Document d = new Document();
        MultiFunctionPrinter mfp = new MultiFunctionPrinter();
        mfp.print(d);
        mfp.scan(d);
        mfp.fax(d);
    }
    
}