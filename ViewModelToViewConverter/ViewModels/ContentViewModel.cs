using System.Collections.ObjectModel;
using Telerik.Maui.Controls;
using ViewModelToViewConverter.Models;

namespace ViewModelToViewConverter.ViewModels;

public class ContentViewModel : NotifyPropertyChangedBase
{
    long watchMS;
    public long WatchMS { get => watchMS; set => UpdateValue(ref watchMS, value); }
    public ObservableCollection<Person> PersonCollection { get; set; }
    public ContentViewModel()
    {
        PersonCollection = new ObservableCollection<Person>()
        {
            new Person { Name = "Kiko", Age = 23, Department = "Production" },
            new Person { Name = "Jerry", Age = 23, Department = "Accounting & Finance"},
            new Person { Name = "Ethan", Age = 51, Department = "Marketing" },
            new Person { Name = "Isabella", Age = 25, Department = "Marketing" },
            new Person { Name = "Joshua", Age = 45, Department = "Production" },
            new Person { Name = "Logan", Age = 26, Department = "Production"},
            new Person { Name = "Aaron", Age = 32, Department = "Production" },
            new Person { Name = "Elena", Age = 37, Department = "Accounting & Finance"},
            new Person { Name = "Ross", Age = 30, Department = "Marketing" },
            new Person { Name = "Ethan2", Age = 51, Department = "Marketing" },
            new Person { Name = "Isabella2", Age = 25, Department = "Marketing" },
            new Person { Name = "Joshua2", Age = 45, Department = "Production" },
            new Person { Name = "Logan2", Age = 26, Department = "Production"},
            new Person { Name = "Aaron2", Age = 32, Department = "Production" },
            new Person { Name = "Elena2", Age = 37, Department = "Accounting & Finance"}
        };
    }
}
