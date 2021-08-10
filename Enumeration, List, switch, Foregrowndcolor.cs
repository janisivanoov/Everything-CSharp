using Nest;
using System;
using System.Collections.Generic;

namespace Enumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ToDo> todo = new List<ToDo>()
            {
                new ToDo{ Description = "Task 1",Hours = 8, Status = Status.OnHold },
                new ToDo{ Description = "Task 2",Hours = 6, Status = Status.Completed },
                new ToDo{ Description = "Task 3",Hours = 3, Status = Status.OnHold },
                new ToDo{ Description = "Task 4",Hours = 12, Status = Status.NotStarted },
                new ToDo{ Description = "Task 5",Hours = 8, Status = Status.Completed },
                new ToDo{ Description = "Task 6",Hours = 7, Status = Status.NotStarted },
                new ToDo{ Description = "Task 7",Hours = 9, Status = Status.NotStarted },
                new ToDo{ Description = "Task 8",Hours = 2, Status = Status.OnHold },
                new ToDo{ Description = "Task 9",Hours = 17, Status = Status.Deleted }
        };
            Console.ForegroundColor = ConsoleColor.DarkRed;
            PrintAssesment(todo);
            Console.ReadLine();
        }
        private static void PrintAssesment(List<ToDo> todo)
        {
            foreach(var todos in todo)
            {
                switch (todos.Status)
                {
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case Status.Completed:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    default:
                        break;
                }
                Console.WriteLine(todos.Description);
            }
        }
    }
    class ToDo
    {
        public string Description { get; set; }
        public int Hours { get; set; }
        public Status Status { get; set; }
    }
    enum Status
    {
        OnHold,
        Deleted,
        Completed,
        NotStarted
    }
}
