using System.Diagnostics;
class Program
{
    static void Main()
    {
        RunTests();
        Greetings();
        var toDoList = new List<ToDoItem>();
        ProgramRun(toDoList);
    }

    public static void Greetings()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Welcome to this program! This program will help you to create a ToDo list for your daily life.");
    }

    static void ProgramRun(List<ToDoItem> toDoList)
    {
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(ToDoList.GetTodoItemListMenu(toDoList));
        UserInput(toDoList);
    }

    private static void UserInput(List<ToDoItem> toDoList)
    {
        string input = Console.ReadLine();
        if (input == "+")
        {
            AddItems(toDoList);
        }
        else if (input == "q")
        {
            return;
        }
        else if (IsIDFromList(input, toDoList))
        {
            DisplayDetailPageToUser(input, toDoList);
        }
    }

    private static void DisplayDetailPageToUser(string input, List<ToDoItem> toDoList)
    {
        Console.Clear();
        int position = 0;
        for (int i = 0; i < toDoList.Count; i++)
        {
            if (toDoList[i].GetId == int.Parse(input))
            {
                position = i;
            }
        }
        var item = new GetTodoItemDetailsMenu(toDoList[position]);
        var stringMenu = GetTodoItemDetailsMenu.MenuDetails();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(stringMenu);
        UserInputDetailMenu(toDoList[position], toDoList);
    }

    private static void UserInputDetailMenu(ToDoItem toDoItem, List<ToDoItem> toDoList)
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "x")
            {
                toDoItem.SetComplete();
                if (toDoItem.GetisComplete())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Completed!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Uncompleted!");
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter another input.");
            }
            else if (input == "q")
            {
                ProgramRun(toDoList);
                break;
            }
            else if (input == "d")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Type a description.");
                var newDescription = Console.ReadLine();
                toDoItem.SetDescription(newDescription);

                Console.WriteLine("Insert another input.");

            }
            else if (input == "t")
            {
                Console.WriteLine("Type a title.");
                var newTitle = Console.ReadLine();
                toDoItem.SetTitle(newTitle);

                Console.WriteLine("Insert another input.");
            }
        }
    }

    private static void AddItems(List<ToDoItem> toDoList)
    {
        Console.Clear();
        int futureId;
        string futureTitle;
        string futureDescription;

        Console.WriteLine("Type an ID for the item.");
        futureId = int.Parse(Console.ReadLine());

        Console.WriteLine("Type a title for the item.");
        futureTitle = Console.ReadLine();

        Console.WriteLine("Give a description for the item.");
        futureDescription = Console.ReadLine();

        var Item = new ToDoItem(futureId, futureTitle, futureDescription);
        toDoList.Add(Item);

        Console.Clear();
        ProgramRun(toDoList);
    }
    private static bool IsIDFromList(string input, List<ToDoItem> toDoList)
    {
        for (int i = 0; i < toDoList.Count; i++)
        {
            if (input == toDoList[i].GetId.ToString())
            {
                return true;
            }
        }
        return false;
    }
    public static void RunTests()
    {
        TestTitleModification();
        TestTitleModification();
        TestIdModification();
        TestListMenuWithOneItem();
        TestListMenuWithOneItem2();
        TestGetTodoItemDetailsMenu();
        // Console.WriteLine("All tests passed.");
    }

    private static string GetTodoItemListMenu(List<ToDoItem> list)
    {
        var listItems = "    ID  Task";
        listItems += "\r\n";
        listItems += "-----------------------------------";
        listItems += "\r\n";

        for (int i = 0; i < list.Count; i++)
        {
            listItems += "[ ] " + list[i].GetId + "   " + list[i].GetTitle + "\r\n";
        }

        listItems += "\r\n";
        listItems += "Enter '+' to add an item";
        listItems += "\r\n";
        listItems += "Enter an Item's ID to enter it's detail menu";
        listItems += "\r\n";
        listItems += "Enter 'q' to quit";

        return listItems;
    }

    private static void TestTitleModification()
    {
        var item = new ToDoItem(934, "starting title", "starting description");
        var newTitle = "new title";
        item.SetTitle(newTitle);
        Debug.Assert(item.GetTitle == newTitle);
    }

    private static void TestDescriptionModification()
    {
        var item2 = new ToDoItem(99, "starting title", "starting description");
        var newDescription = "new description";
        item2.SetDescription(newDescription);
        Debug.Assert(item2.GetDescription == newDescription);
    }

    private static void TestIdModification()
    {
        var item3 = new ToDoItem(323, "starting title", "starting desription");
        var newId = 432;
        item3.SetId(newId);
        Debug.Assert(item3.GetId == newId);
    }


    public static void TestListMenuWithOneItem()
    {
        var items = new List<ToDoItem> { new ToDoItem(1, "one menu item", "this is my favorite description") };
        var stringMenu = GetTodoItemListMenu(items);
        var expectedMenuString = @"    ID  Task
-----------------------------------
[ ] 1   one menu item

Enter '+' to add an item
Enter an Item's ID to enter it's detail menu
Enter 'q' to quit";
        Debug.Assert(stringMenu == expectedMenuString);
    }

    public static void TestListMenuWithOneItem2()
    {
        var items = new List<ToDoItem> { new ToDoItem(1, "one menu item", "this is my favorite description") };
        var items2 = new List<ToDoItem> { new ToDoItem(1, "one menu item", "this is my favorite description") };


        var stringMenu = GetTodoItemListMenu(items);
        var stringMenu2 = GetTodoItemListMenu(items2);

        var expectedMenuString = @"    ID  Task
-----------------------------------
[ ] 1   one menu item

Enter '+' to add an item
Enter an Item's ID to enter it's detail menu
Enter 'q' to quit";
        Debug.Assert(stringMenu == expectedMenuString);
        Debug.Assert(stringMenu2 == expectedMenuString);
    }

    public static void TestGetTodoItemDetailsMenu()
    {
        var items = new GetTodoItemDetailsMenu(new ToDoItem(1, "one menu item", "this is my favorite description"));
        var stringMenu = GetTodoItemDetailsMenu.MenuDetails();
        var expectedMenuString = @"ID: 1
Title: one menu item
Description: this is my favorite description

-------------------------------------------------------------

Enter 'x' to toggle whether or not the task is complete.
Enter 't' to update the title.
Enter 'd' to update the description.
Enter 'q' to return to the list menu";
        Debug.Assert(stringMenu == expectedMenuString);
    }
}
