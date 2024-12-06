using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiCollectionView.MultiSelection.Model;
using System.Collections.ObjectModel;

namespace MauiCollectionView.MultiSelection.ViewModels;
public partial class SeatViewModel : ObservableObject
{
    public ObservableCollection<SeatModel> Seats { get; set; } = new();
    public SeatViewModel()
    {
        Seats = new ObservableCollection<SeatModel>(SeatModel.GetSeats());
    }

    [ObservableProperty]
    private string _selectedSeatNumbers;

    public ObservableCollection<object> SelectedSeats { get; set; } = [];

    [RelayCommand]
    private void SeatSelected()
    {
        //foreach (var seat in SelectedSeats)
        //{
        //    if(seat is SeatModel selectedSeat)
        //    {
        //        selectedSeat.SeatNumber
        //    }
        //}
        SelectedSeatNumbers = string.Join(", ", SelectedSeats.OfType<SeatModel>().Select(s => s.SeatNumber));
    }
}
