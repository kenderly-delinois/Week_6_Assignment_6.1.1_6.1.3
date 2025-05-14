using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Week_6_Assignment_6._1._1
{
   
    internal class HouseNode
    {
        public int houseNumber;
        public string houseAddress;
        public string houseType;
        public HouseNode next;

        public HouseNode(int houseNumber, string houseAddress, string houseType, HouseNode next)
        {
            this.houseNumber = houseNumber;
            this.houseAddress = houseAddress;
            this.houseType = houseType;
            this.next = next;
        }
    }


    class Customlist
    {
        private HouseNode head;
        private HouseNode tail;
        private int size;


        public int Size
        {
            get { return size; } 
        }

        public Customlist()
        {
            this.head = null;
            this.tail = null; 
            this.size = 0;
        }

        public bool IsEmpty()
        {
            return this.size == 0;
        }

        public void AddFirst(int houseNumber, string houseAddress, string houseType)
        {
            HouseNode newHouse = new HouseNode(houseNumber, houseAddress, houseType, null);
            if (IsEmpty())
            {
                this.head = newHouse;
                this.tail = newHouse;
            }
            else
            {
                newHouse.next = this.head;
                this.head = newHouse;
            }
            size++;
        }

        public void AddLast(int houseNumber, string houseAddress, string houseType)
        {
            HouseNode newHouse = new HouseNode(houseNumber, houseAddress, houseType, null);
            if (IsEmpty())
            {
                this.head = newHouse;
            }
            else
            {
                this.tail.next = newHouse;
            }
            size--;
        }

        public bool Search(int houseNumber, string houseAddress, string houseType, out int index)
        {
            HouseNode temp = head;
            int i = 1;
            while (temp != null)
            {
                if (temp.houseNumber == houseNumber && temp.houseAddress == houseAddress && temp.houseType == houseType)
                {
                    index = i;
                    return true;
                }
                temp = temp.next;
                i++;
            }
            index = i;
            return false;
        }

        public void Display()
        {
            HouseNode temp = head;
            if (IsEmpty())
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                while (temp != null)
                {

                    Console.WriteLine($"{temp.houseNumber} - {temp.houseAddress} - {temp.houseType}");
                    temp = temp.next;
                }
                
            }
        }
    }   
}
