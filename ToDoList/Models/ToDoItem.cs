﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace SimpleToDoList.Models;

public class ToDoItem
{

    public bool IsChecked { get; set; }


    public string? Content { get; set; }
}