using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiCollectionView.InfiniteScrolling.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCollectionView.InfiniteScrolling.ViewModels;
public partial class DataViewModel : ObservableObject
{
    public DataViewModel()
    {
        GetEmployeesAsync();
    }

    public ObservableCollection<EmployeeModel> Employees { get; set; } = [];

    private bool _dataCompleted;

    private int _pageSize = 20;

    [RelayCommand]
    private async Task GetEmployeesAsync()
    {
        if (_dataCompleted) // There is no more data in the api
            return;

        await Task.Delay(1000);
        var employeesFromApi = EmployeeModel.GetData(_pageSize);

        if (employeesFromApi.Length < _pageSize)
            _dataCompleted = true;

        foreach (var emp in employeesFromApi)
        {
            Employees.Add(emp);
        }
    }
}
