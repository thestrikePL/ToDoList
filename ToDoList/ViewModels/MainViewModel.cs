using System.Collections.ObjectModel;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SimpleToDoList.Models;
using SimpleToDoList.Services;

namespace SimpleToDoList.ViewModels;


public partial class MainViewModel : ViewModelBase
{
    public MainViewModel()
    {

        if (Design.IsDesignMode)
        {
            ToDoItems = new ObservableCollection<ToDoItemViewModel>(new[]
            {
                new ToDoItemViewModel() { Content = "Witaj" },
                new ToDoItemViewModel() { Content = "Avalonio", IsChecked = true}
            });
        }
    }
    

    public ObservableCollection<ToDoItemViewModel> ToDoItems { get; } = new ObservableCollection<ToDoItemViewModel>();

    

    [RelayCommand (CanExecute = nameof(CanAddItem))]
    private void AddItem()
    {
   
        ToDoItems.Add(new ToDoItemViewModel() {Content = NewItemContent});
        

        NewItemContent = null;
    }


    [ObservableProperty] 
    [NotifyCanExecuteChangedFor(nameof(AddItemCommand))] 
    private string? _newItemContent;


    private bool CanAddItem() => !string.IsNullOrWhiteSpace(NewItemContent);
    

    [RelayCommand]
    private void RemoveItem(ToDoItemViewModel item)
    {

        ToDoItems.Remove(item);
    }
}