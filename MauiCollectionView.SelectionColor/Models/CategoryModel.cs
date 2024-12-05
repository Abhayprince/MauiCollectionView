namespace MauiCollectionView.SelectionColor.Models;
public class CategoryModel
{
    public int Id { get; set; }
    public string Name { get; set; }

    public static CategoryModel[] GetSeedCategories() =>
        [
            new CategoryModel { Id = 1, Name = "Blazor" },
            new CategoryModel { Id = 2, Name = "Entity Framework" },
            new CategoryModel { Id = 3, Name = "ASP.NET Core API" },
            new CategoryModel { Id = 4, Name = "Minimal API" },
            new CategoryModel { Id = 5, Name = "C#" },
            new CategoryModel { Id = 6, Name = "Dapper" },
            new CategoryModel { Id = 7, Name = ".NET MAUI" },
            new CategoryModel { Id = 8, Name = "Vue.js" },
            new CategoryModel { Id = 9, Name = "JavaScript" },
            new CategoryModel { Id = 10, Name = "jQuery" },
            new CategoryModel { Id = 11, Name = "Bootstrap" }
        ];
}
