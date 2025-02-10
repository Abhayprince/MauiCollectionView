
using MauiCollectionView.InfiniteScrolling.ViewModels;

namespace MauiCollectionView.InfiniteScrolling;

public partial class MainPage : ContentPage
{
    private readonly DataViewModel _viewModel;
    

    public MainPage(DataViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

}

