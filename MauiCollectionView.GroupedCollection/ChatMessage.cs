using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCollectionView.GroupedCollection;
public class ChatMessage
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Message { get; set; }
    public DateTime SentOn { get; set; }

    public static List<ChatMessage> GetSeedData() =>
        [
        new ChatMessage { Id =  1, Name = "Alice",   Message = "Hey team, good morning!",                  SentOn = new DateTime(2025, 6,  9, 8, 15,  0) },
        new ChatMessage { Id =  2, Name = "Bob",     Message = "Morning Alice!",                             SentOn = new DateTime(2025, 6,  9, 8, 16,  0) },
        new ChatMessage { Id =  3, Name = "Carol",   Message = "Anyone available for code review?",          SentOn = new DateTime(2025, 6,  9, 8, 20,  0) },
        new ChatMessage { Id =  4, Name = "Dave",    Message = "I'll take a look in 10 mins.",               SentOn = new DateTime(2025, 6,  9, 8, 21, 30) },
        new ChatMessage { Id =  5, Name = "Eva",     Message = "Deployed version 2.1.0 to staging.",         SentOn = new DateTime(2025, 6,  9, 8, 30,  0) },
        new ChatMessage { Id =  6, Name = "Frank",   Message = "Nice, I'll test it.",                         SentOn = new DateTime(2025, 6,  9, 8, 32, 15) },
        new ChatMessage { Id =  7, Name = "Grace",   Message = "Found a bug in the login flow.",              SentOn = new DateTime(2025, 6,  7, 8, 45,  0) },
        new ChatMessage { Id =  8, Name = "Heidi",   Message = "Can you share the logs?",                     SentOn = new DateTime(2025, 6,  7, 8, 47,  0) },
        new ChatMessage { Id =  9, Name = "Ivan",    Message = "Logs sent via email.",                        SentOn = new DateTime(2025, 6,  9, 8, 50,  0) },
        new ChatMessage { Id = 10, Name = "Judy",    Message = "Let's have a quick stand-up at 9.",           SentOn = new DateTime(2025, 6,  9, 8, 55,  0) },
        new ChatMessage { Id = 11, Name = "Karl",    Message = "On it.",                                      SentOn = new DateTime(2025, 6,  9, 8, 56,  0) },
        new ChatMessage { Id = 12, Name = "Laura",   Message = "Stand-up meeting start now.",                 SentOn = new DateTime(2025, 6,  9, 9,  0,  0) },
        new ChatMessage { Id = 13, Name = "Mallory", Message = "Joining.",                                    SentOn = new DateTime(2025, 6,  19, 9,  1,  0) },
        new ChatMessage { Id = 14, Name = "Nancy",   Message = "Sorry, running late.",                        SentOn = new DateTime(2025, 6,  9, 9,  2,  0) },
        new ChatMessage { Id = 15, Name = "Oscar",   Message = "No worries, take your time.",                 SentOn = new DateTime(2025, 6,  9, 9,  5,  0) },
        new ChatMessage { Id = 16, Name = "Peggy",   Message = "Today's sprint tasks: implement feature A.",  SentOn = new DateTime(2025, 6,  9, 9, 10,  0) },
        new ChatMessage { Id = 17, Name = "Quentin", Message = "Feature B is almost done.",                   SentOn = new DateTime(2025, 6,  8, 17, 30,  0) },
        new ChatMessage { Id = 18, Name = "Ruth",    Message = "Review comments on PR #42.",                 SentOn = new DateTime(2025, 6,  8, 17, 45,  0) },
        new ChatMessage { Id = 19, Name = "Sam",     Message = "I'll address them tonight.",                  SentOn = new DateTime(2025, 6,  8, 18,  0,  0) },
        new ChatMessage { Id = 20, Name = "Trent",   Message = "Reminder: deploy hotfix tomorrow.",           SentOn = new DateTime(2025, 6,  8, 18, 15,  0) }

        ];

    public static List<GroupedChats> GetGroupedChatData()
    {
        var chatMessages = GetSeedData();
        
        var groupedMessages = new List<GroupedChats>();
        foreach (var message in chatMessages)
        {
            var date = message.SentOn.Date.ToString("dd-MMM-yyyy");
            var existinGroup = groupedMessages.FirstOrDefault(g => g.Title == date);
            if(existinGroup is null)
            {
                existinGroup = new GroupedChats(date);
                groupedMessages.Add(existinGroup);
            }
            existinGroup.Add(message);
        }
        return groupedMessages;
    }
}
