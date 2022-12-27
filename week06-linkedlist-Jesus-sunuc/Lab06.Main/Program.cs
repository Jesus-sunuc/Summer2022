// using System.Diagnostics;
// namespace DataStructures
// {
//     class Program {
//         class LinkedListNode
//         {
//             public string data;
//             public LinkedListNode next;

//             public LinkedListNode(string x)
//             {
//                 data = x;
//                 next = null;
//             }
//         }

//         class LinkedList
//         {
//             int count;
//             LinkedListNode head;

//             public LinkedList()
//             {
//                 count = 0;
//                 head = null;
//             }

//             public void AddNodeToFront(string data)
//             {
//                 LinkedListNode node = new LinkedListNode(data);
//                 node.next = head;
//                 head = node;
//                 count++;
//             }

//             public void PrintList()
//             {
//                 LinkedListNode runner = head;
//                 while(runner != null)
//                 {
//                     Console.Write(runner.data);
//                     runner = runner.next;
//                 }
//             }
//         }

//         static void Main(string[] args)
//         {
//             Console.WriteLine("Please enter a string: ");
//             LinkedList list = new LinkedList();
//             var words = Console.ReadLine();
//             list.AddNodeToFront(words);
//             var words1 = Console.ReadLine();
//             list.AddNodeToFront(words1);
//             var words2 = Console.ReadLine();
//             list.AddNodeToFront(words2);
//             var words3 = Console.ReadLine();
//             list.AddNodeToFront(words3);
//             list.PrintList();
//         }
//     }
// }

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

