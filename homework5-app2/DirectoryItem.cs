﻿namespace homework5_app2;

public record DirectoryItem(DirectoryItem.ItemTypes Type, string Name, DateTime DateLastChange)
{
    public enum ItemTypes
    {
        Folder,
        File
    }

    public ItemTypes Type { get; set; } = Type;
    public string Name { get; set; } = Name;
    public DateTime DateLastChange { get; set; } = DateLastChange;
}
