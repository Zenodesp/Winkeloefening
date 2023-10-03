namespace Winkeloefening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDBContext())
            {

                context.Start();


            }
        }
    }
}