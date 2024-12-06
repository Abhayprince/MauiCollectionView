using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiCollectionView.MultiSelection.Model;
public class SeatModel
{
    public string SeatNumber { get; set; }

    public static SeatModel[] GetSeats() =>
        [
            new SeatModel { SeatNumber = "A1" },
            new SeatModel { SeatNumber = "A2" },
            new SeatModel { SeatNumber = "A3" },
            new SeatModel { SeatNumber = "A4" },
            new SeatModel { SeatNumber = "B1" },
            new SeatModel { SeatNumber = "B2" },
            new SeatModel { SeatNumber = "B3" },
            new SeatModel { SeatNumber = "B4" },
            new SeatModel { SeatNumber = "C1" },
            new SeatModel { SeatNumber = "C2" },
            new SeatModel { SeatNumber = "C3" },
            new SeatModel { SeatNumber = "C4" },
            new SeatModel { SeatNumber = "D1" },
            new SeatModel { SeatNumber = "D2" },
            new SeatModel { SeatNumber = "D3" },
            new SeatModel { SeatNumber = "D4" },
            ];
}


