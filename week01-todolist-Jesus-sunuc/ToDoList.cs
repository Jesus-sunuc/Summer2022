class ToDoList
{
    public static string GetTodoItemListMenu(List<ToDoItem> itemList)
    {
        
        var stringTodoList = "    ID  Task";
        stringTodoList += "\r\n";
        stringTodoList += "-----------------------------------";
        stringTodoList += "\r\n";

        for (int i = 0; i < itemList.Count; i++)
        {
            string done;
            if (itemList[i].GetisComplete())
            { 
                done = "X";
            }
            else
            {
                done = " ";
            }
            stringTodoList += "[" + done +"] " + itemList[i].GetId + "   " + itemList[i].GetTitle + "\r\n";
        }
        stringTodoList += "\r\n";
        stringTodoList += "Enter '+' to add an item";
        stringTodoList += "\r\n";
        stringTodoList += "Enter an Item's ID to enter it's detail menu";
        stringTodoList += "\r\n";
        stringTodoList += "Enter 'q' to quit";
        return stringTodoList;
    }

}