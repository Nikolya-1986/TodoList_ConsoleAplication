using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TodoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to the to do list program!");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add a task to the list.");
                Console.WriteLine("Enter 2 to remove a task from the list.");
                Console.WriteLine("Enter 3 to edit a task from the list.");
                Console.WriteLine("Enter 4 to view the list.");
                Console.WriteLine("Enter 5 to remove all task.");
                Console.WriteLine("Enter e to exit the program.");

                option = Console.ReadLine();

                if (option == "1")
                {
                    Console.Write("Please enter the name of the task to add to the list: ");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine($"Task {task} added to the list.");
                }
                else if (option == "2")
                {
                    Console.WriteLine($"Task list:");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine($"{i}: {taskList[i]}");
                    }
                    Console.Write("Plese enter the number of the task to remove to the list: ");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);
                    Console.WriteLine($"Task number {taskNumber} removed from the list.");
                }
                else if (option == "3")
                {
                    Console.WriteLine($"Task list:");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine($"{i}: {taskList[i]}");
                    }
                    Console.WriteLine("Plese enter the number of the task tou want to change: ");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter the new task name: ");
                    string editedTast = Console.ReadLine();
                    taskList[taskNumber] = editedTast;
                    Console.WriteLine($"Task {taskNumber} has been changed.");
                }
                else if (option == "4")
                {
                    Console.WriteLine("Current tasks in the list:");
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }
                }
                else if (option == "5")
                {
                    taskList.Clear();
                    Console.WriteLine($"Task list were cleared.");
                }
                else if (option == "e")
                {
                    Console.WriteLine("Existing program");
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again");
                }
            }
            Console.WriteLine("Thank you for using the program!");
        }
    }
}
