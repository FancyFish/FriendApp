using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FriendApp.ViewModel
{
    public class FriendViewModel
    {
        public Command SaveCommand { get; set; }
        public Command DeleteCommand { get; set; }
        public bool IsEnabled { get; set; }
        public Friend FriendModel { get; set; }

    }
}
