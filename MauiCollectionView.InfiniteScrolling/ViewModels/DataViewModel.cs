using MauiCollectionView.InfiniteScrolling.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCollectionView.InfiniteScrolling.ViewModels;
public class DataViewModel
{
    public DataViewModel()
    {
        GetEmployees();
    }

    public ObservableCollection<EmployeeModel> Employees { get; set; } = [];

    public async Task GetEmployees()
    {
        await Task.Delay(1000);
        var employeesFromApi = EmployeeModel.GetData();
        foreach (var emp in employeesFromApi)
        {
            Employees.Add(emp);
        }
    }
}
