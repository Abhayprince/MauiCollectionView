using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCollectionView.InfiniteScrolling.Models;
public class EmployeeModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Team { get; set; }

    private static string[] Teams = ["Development", "Designing", "Testing", "Client Implementation", "Sales"];

    private const int MaxData = 100;
    private static int _dataSent;
    public static EmployeeModel[] GetData(int count = 20)
    {
        if (_dataSent >= MaxData)
            return [];

        var faker = new Faker<EmployeeModel>()
            .RuleFor(e=> e.Name, f=> f.Name.FullName())
            .RuleFor(e=> e.Team, f=> f.PickRandom(Teams));

        var employees = faker.Generate(count);
        
        _dataSent += count;


        return [..employees];
    }
}
