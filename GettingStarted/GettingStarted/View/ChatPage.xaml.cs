using Syncfusion.XForms.Chat;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GettingStarted
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatPage : ContentPage
    {
        //SfChat sfChat;
        //GettingStartedViewModel viewModel;
        public ChatPage()
        {
            InitializeComponent();

            //sfChat = new SfChat();
            //viewModel = new GettingStartedViewModel();
            //sfChat.Messages = viewModel.Messages;
            //sfChat.CurrentUser = viewModel.CurrentUser;
            ///this.Content = sfChat;
        }
    }
}