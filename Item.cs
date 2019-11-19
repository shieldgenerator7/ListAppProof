using System;

public class Item
{
    public string name;
    public DateTime dateCompleted;

    private bool complete = false;
    public bool Complete
    {
        get
        {
            return complete;
        }
        set
        {
            complete = value;
            if (complete)
            {
                dateCompleted = DateTime.Now;
            }
        }
    }

    public string DisplayInfo
    {
        get
        {
            string result = name + Environment.NewLine
                + "Complete? "
                + ((complete) ? "yes" : "no") + Environment.NewLine;
            if (complete)
            {
                result += "Date completed: " + dateCompleted
                    +Environment.NewLine;
            }
            return result;
        }
    }

    public Item(string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        string checkedString;
        if (complete)
        {
            checkedString = "[+]";
        }
        else
        {
            checkedString = "[ ]";
        }
        return checkedString + " " + name;
    }

    public static implicit operator bool (Item item)
        => item != null;
}
