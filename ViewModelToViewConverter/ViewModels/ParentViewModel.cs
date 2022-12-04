using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Telerik.Maui.Controls;

namespace ViewModelToViewConverter.ViewModels;

public class ParentViewModel : NotifyPropertyChangedBase
{
    private string pageTitle;
    public string PageTitle { get => pageTitle; set => UpdateValue(ref pageTitle, value); }
    public ParentViewModel(string title) 
    {
        PageTitle = title;
    }
}
