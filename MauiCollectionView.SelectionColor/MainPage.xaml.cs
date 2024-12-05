using MauiCollectionView.SelectionColor.Models;

namespace MauiCollectionView.SelectionColor
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            collectionView.ItemsSource = CategoryModel.GetSeedCategories();
        }

       
    }

}
