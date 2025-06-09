namespace MauiCollectionView.GroupedCollection;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public List<GroupedChats> Messages { get; set; } = ChatMessage.GetGroupedChatData();

    // // If You Need Dynamic Item Add and Remove in the Collection
    // then use ObservableCollection
    //public ObservableCollection<GroupedChats> Messages { get; set; } = ChatMessage.GetGroupedChatData();
}
