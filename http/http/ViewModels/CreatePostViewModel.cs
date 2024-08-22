using CommunityToolkit.Mvvm.ComponentModel;
using http.Models;
using http.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace http.ViewModels
{
    public partial class CreatePostViewModel : ObservableObject
    {
        [ObservableProperty]
        string title;
        [ObservableProperty]
        string body;
        [ObservableProperty]
        int id;
        [ObservableProperty]
        int userId = 1;

        public ICommand SavePostCommand { get; }

        CreatePostViewModel() 
        {
            SavePostCommand = new Command(SavePost);
        }

        public async void SavePost() 
        {
            //TO DO
            Post post = new Post();
            Post newPost = new Post();
            post.Title = Title;
            post.Body = Body;
            post.UserId = UserId;

            PostServices postServices = new PostServices();
            newPost = await postServices.SavePostAsync(post);
        }
    }
}
