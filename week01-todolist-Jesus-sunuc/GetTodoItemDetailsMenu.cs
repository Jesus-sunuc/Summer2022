class GetTodoItemDetailsMenu
{
    static int IdMenu;
    static string TitleMenu;
    static string DescriptionMenu;

    public GetTodoItemDetailsMenu(ToDoItem item)
    {
        IdMenu = item.GetId;
        TitleMenu = item.GetTitle;
        DescriptionMenu = item.GetDescription;
    }

    static public string MenuDetails()
    {
        var itemsList = "ID: " + IdMenu;
        itemsList += "\r\n";
        itemsList += "Title: " + TitleMenu;
        itemsList += "\r\n";
        itemsList += "Description: " + DescriptionMenu;
        itemsList += "\r\n";
        itemsList += "\r\n";
        itemsList += "-------------------------------------------------------------";
        itemsList += "\r\n";
        itemsList += "\r\n";
        itemsList += "Enter 'x' to toggle whether or not the task is complete.";
        itemsList += "\r\n";
        itemsList += "Enter 't' to update the title.";
        itemsList += "\r\n";
        itemsList += "Enter 'd' to update the description.";
        itemsList += "\r\n";
        itemsList += "Enter 'q' to return to the list menu";

        return itemsList;
    }
}