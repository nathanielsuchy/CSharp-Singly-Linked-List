using System;

namespace MyLinkedList
{

    

    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            MyLinkedList obj = new MyLinkedList();
            obj.AddAtHead(5);

            Console.WriteLine($"index 0 = {obj.Get(0)}");
            Console.WriteLine($"index 1 = {obj.Get(1)}");
            Console.WriteLine($"index 2 = {obj.Get(2)}");
            Console.WriteLine($"index 3 = {obj.Get(3)}");
            Console.WriteLine($"index 4 = {obj.Get(4)}");
            Console.WriteLine($"index 5 = {obj.Get(5)}");
            Console.WriteLine($"index 6 = {obj.Get(6)}");
            Console.WriteLine($"index 7 = {obj.Get(7)}");
            Console.WriteLine($"index 8 = {obj.Get(8)}");
            Console.WriteLine($"index 9 = {obj.Get(9)}");

        }
    }
}
