namespace JavaEnum
{
    abstract class JavaEnum
    {
        public string Name { get; private set; }

        public static readonly JavaEnum TEST = new Test() { Name = "Test" };

        private JavaEnum()
        {
        }

        public abstract void PrintName();

        private class Test : JavaEnum
        {
            public override void PrintName()
            {
                System.Console.WriteLine(Name);
            }
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            var javaEnum = JavaEnum.TEST;
            javaEnum.PrintName();
        }
    }
}
