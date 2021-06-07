using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpDataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array demo
            Console.WriteLine("** Array Demo **");
            //Seed the array when you define it 
            string[] starWarsCharacters = { "Luke", "Leia", "Han", "Lando", "Chewie" };
            
            Console.WriteLine("First array");
            foreach(string sw1 in starWarsCharacters)
            {
                Console.WriteLine(sw1);
            }
            
            //Define the array then add to it
            string[] newStarWarsCharacters = new string[4];
            newStarWarsCharacters[0] = "Rey";
            newStarWarsCharacters[1] = "Fin";
            newStarWarsCharacters[2] = "Poe";
            newStarWarsCharacters[3] = "Rose";
            
            Console.WriteLine("Second array");
            foreach (string sw2 in newStarWarsCharacters)
            {
                Console.WriteLine(sw2);
            }

            //Sort the array
            Array.Sort(newStarWarsCharacters);

            Console.WriteLine("Second array after sorting");
            foreach (string sw2s in newStarWarsCharacters)
            {
                Console.WriteLine(sw2s);
            }

            //List Demo
            Console.WriteLine("** List Demo **");
            List<string>  theHundredCharacters = new List<string>();
            theHundredCharacters.Add("Clark");
            theHundredCharacters.Add("Bellamy");
            theHundredCharacters.Add("Murphy");
            theHundredCharacters.Add("Lexa");
            Console.WriteLine("Initial List");
            Console.WriteLine($"Number of items in the List: {theHundredCharacters.Count}.");
            foreach (string hc in theHundredCharacters)
            {
                Console.WriteLine(hc);
            }

            //Remove Lexa from the list (gah!)
            theHundredCharacters.Remove("Lexa");
            //Remove Bellamy from the list (seriously Clark??)
            theHundredCharacters.Remove("Bellamy");

            Console.WriteLine("List after questionable writing decisions from The 100 writers");
            Console.WriteLine($"Number of items in the List: {theHundredCharacters.Count}.");
            foreach (string hc2 in theHundredCharacters)
            {
                Console.WriteLine(hc2);
            }

            //Simple Stack demo
            Console.WriteLine("** Simple Stack Demo **");
            Stack myStack = new Stack();
            myStack.Push("First");
            myStack.Push("Second");
            myStack.Push("Third");

            //Save the original count for our loop, since .count() will change after each pop().
            int originialStackCount = myStack.Count;

            for(int i = 0; i < originialStackCount; i++)
            {
                Console.WriteLine(myStack.Pop());
            }

            //Generic Stack Demo
            Console.WriteLine("** Generic Stack Demo **");
            Stack<string> myGenericStack = new Stack<string>();
            myGenericStack.Push("Uno");
            myGenericStack.Push("Dos");
            myGenericStack.Push("Tres");

            foreach (string mgs in myGenericStack)
            {
                Console.WriteLine(mgs);
            }

            //Simple Queue Demo
            Console.WriteLine("** Simple Queue Demo **");
            Queue myQueue = new Queue();
            myQueue.Enqueue("One");
            myQueue.Enqueue("Two");
            myQueue.Enqueue("Three");

            int originalCount = myQueue.Count;
            for(int c = 0; c < originalCount; c++)
            {
                Console.WriteLine(myQueue.Dequeue());
            }

            //Generic Queue Demo
            Console.WriteLine("** Generic Queue Demo **");
            Queue<string> myQueue2 = new Queue<string>();
            myQueue2.Enqueue("Uno");
            myQueue2.Enqueue("Dos");
            myQueue2.Enqueue("Tres");

            foreach(string q in myQueue2)
            {
                Console.WriteLine(q);
            }

            //Linked List Demo
            Console.WriteLine("** Linked List Demo ** ");
            LinkedList<string> myLinkedList = new LinkedList<string>();
            myLinkedList.AddLast("Captain Marvel");
            myLinkedList.AddLast("Captain America (Sam)");
            myLinkedList.AddLast("Bucky (Winter Soldier)");
            myLinkedList.AddLast("Spiderman");
            //Loop through the Linked List with foreach
            Console.WriteLine("Full Linked List");
            foreach(string av in myLinkedList)
            {
                Console.WriteLine(av);
            }
            myLinkedList.Remove("Spiderman");
            Console.WriteLine("Linked List without Spiderman (blame Sony!)");
            foreach (string mv in myLinkedList)
            {
                Console.WriteLine(mv);
            }
            myLinkedList.AddLast("Iron Man");
            Console.WriteLine("Linked List with Iron Man added");
            foreach (string im in myLinkedList)
            {
                Console.WriteLine(im);
            }


            Console.ReadKey();
        }
    }
}
