using CommunityToolkit.Mvvm.ComponentModel;
using http.Models;
using http.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace http.ViewModels
{
    public partial class PostViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Post> posts;
        PostServices postsServices;

        private ICommand getPostagensCommand { get; }

        public PostViewModel() 
        {
            getPostagensCommand = new Command(getPostagens);
            postsServices = new PostServices();
        }

        public async void getPostagens() 
        {
            Posts = await postsServices.GetPostsAsync();
        }
    }
}
