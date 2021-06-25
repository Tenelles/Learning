using System;

abstract class BasicItem
{
    private string _name;
    private string _description;

    public string Name => _name;
    public string Description => _description;

    public BasicItem(string name)
    {
        _name = name;
    }
    public BasicItem(string name, string description)
    {
        _name = name;
        _description = description;
    }
}

