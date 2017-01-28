namespace FactoryLib.Utilities
{
    using System.Threading;

    public class IDGenerator
    {
        private int id;

        public IDGenerator()
        {
            this.id = 0;
        }
        public int GenerateID()
        {
            return Interlocked.Increment(ref this.id);
        }
    }
}
