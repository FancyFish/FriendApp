using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using System.IO;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FriendApp.Services;

namespace FriendApp.Droid.Services
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal)];
            return Path.Combine(path, fileName);
        }
    }
}