namespace MyTestLib
{
    public class TestDebugWithSymbolPackage
    {
        public TestDebugWithSymbolPackage()
        {
            this.StrField = "this is a string";

            this.IntField = 0;

            this.DoubleField = 0.0;

            this.LongField = (long)(int.MaxValue) + 1;

            this.FloatField = (float)(int.MaxValue) + 1;
        }

        public string StrField { get; set; }

        public int IntField { get; set; }

        public double DoubleField { get; set; }

        public long LongField { get; set; }

        public float FloatField { get; set; }
    }
}