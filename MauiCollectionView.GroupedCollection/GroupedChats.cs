using System.Collections.ObjectModel;

namespace MauiCollectionView.GroupedCollection;

// If You Need Dynamic Item Add and Remove in the Collection
// then use ObservableCollection as base class
//public class GroupedChats : ObservableCollection<ChatMessage>
public class GroupedChats : List<ChatMessage>
{
    public string Title { get; set; }
    public GroupedChats(string title) => Title = title;
}