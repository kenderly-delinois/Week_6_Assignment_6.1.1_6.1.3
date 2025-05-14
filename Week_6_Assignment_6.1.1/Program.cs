namespace Week_6_Assignment_6._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customlist customlist = new Customlist();
            customlist.AddFirst(455 , "NW Ave", "SingleFamilyHouse");
            customlist.Display();

            int index;
            bool found = customlist.Search(455, "NW Ave", "SingleFamilyHouse", out index);
            if (found)
            {
              
                Console.WriteLine($"House position is at Index: {index}");              
            }
            else
            {
                Console.WriteLine("Not found");
            }
            customlist.Display();
        }
    }
}
