using MauiCollectionView.MultiSelection.Model;
using MauiCollectionView.MultiSelection.ViewModels;

namespace MauiCollectionView.MultiSelection;

public partial class MainPage : ContentPage
{
    public MainPage(SeatViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    
}

