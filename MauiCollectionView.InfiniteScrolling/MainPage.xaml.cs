
using MauiCollectionView.InfiniteScrolling.ViewModels;

namespace MauiCollectionView.InfiniteScrolling;

public partial class MainPage : ContentPage
{
    private readonly DataViewModel _viewModel;
    

    public MainPage(DataViewModel viewModel)
    {
        InitializeComponent();
        this._viewModel = viewModel;
        BindingContext = _viewModel;
    }

}

