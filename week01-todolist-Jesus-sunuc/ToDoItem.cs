class ToDoItem
{
    private int id {get => _id;}
    private int _id {get; set;}
    private string title {get; set;}
    private string description {get; set;}
    private bool isComplete {get; set;}
    public string GetTitle {get => title;}
    public string GetDescription { get => description; }
    public int GetId { get => id; }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public ToDoItem(int ID, string Title, string Description)
    {
        _id = ID;
        title = Title;
        description = Description;
    }

    public void SetDescription(string newDescription)
    {
        description = newDescription;
    }

    public void SetId(int newId)
    {
        _id = newId;
    }

    internal bool GetisComplete()
    {
        return isComplete;
    }

     public void SetComplete()
    {
        if(isComplete)
        {
            isComplete = false;
        }
        else
        {
            isComplete = true;
        }
    }
}