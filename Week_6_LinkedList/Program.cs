namespace Week_6_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List
            //LinkedList<int> list = new LinkedList<int>();
            //list.AddFirst(23);
            //list.AddLast(40);

            //foreach (int i in list)
            //{
            //    Console.WriteLine(i); // ouput 23, 40
            //}
            //list.AddFirst(12); // 12, 23, 40
            //Console.WriteLine("Updated lsit");
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //// 12, 100, 23, 40
            //var temp = list.Find(23);
            //if (temp != null)
            //{
            //    list.AddBefore(temp, 100);
            //}
            //Console.WriteLine("Recently Updated");
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(AddFirst());
            //Console.ReadKey();

            #endregion


            CustomList customlist = new CustomList();
            customlist.AddFirst(1);
            customlist.AddFirst(23);
            customlist.AddFirst(34);          
            customlist.Display();
            customlist.AddLast(50);
            customlist.Display();
            customlist.RemoveFirst();
            customlist.Display();
            customlist.RemoveLast();
            customlist.Display();
            customlist.AddFirst(90);
            customlist.AddLast(67);
            customlist.Display();

            int index;
            bool found = customlist.Search(67, out index);
            if (found) {
                Console.WriteLine($"The number is found at {index} position");
            }
            else
            {
                Console.WriteLine("Not found");
            }


                Console.ReadKey();
        }
    }
}
