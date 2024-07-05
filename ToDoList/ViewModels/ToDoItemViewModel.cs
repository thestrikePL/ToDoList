using CommunityToolkit.Mvvm.ComponentModel;
using SimpleToDoList.Models;

namespace SimpleToDoList.ViewModels;


public partial class ToDoItemViewModel : ViewModelBase
{

    public ToDoItemViewModel()
    {
        
    }
    

    public ToDoItemViewModel(ToDoItem item)
    {

        IsChecked = item.IsChecked;
        Content = item.Content;
    }
    

    private bool _isChecked;

    public bool IsChecked
    {
        get { return _isChecked; }
        set { SetProperty(ref _isChecked, value); }
    }
    

    [ObservableProperty] 
    private string? _content;
    

    public ToDoItem GetToDoItem()
    {
        return new ToDoItem()
        {
            IsChecked = this.IsChecked,
            Content = this.Content
        };
    }
}