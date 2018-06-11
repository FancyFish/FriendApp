using FriendApp.Helpers;
using FriendApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FriendApp.ViewModel
{
    public class MainPageViewModel : NotificableFriend
    {
        private FriendRepository friendRepository;
        public ObservableCollection
            <Grouping<string, Friend>> Friends { get; set; }

        public MainPageViewModel()
        {
            friendRepository = new FriendRepository();
            Friends = friendRepository.GetAllGrouped();
        }
        
    }
    
}
