using Xamarin.Forms;

namespace Exercise04
{
    public class MainPageViewModel : BaseViewModel
    {
        private static string[] _listIMG = new string[] {
            $"https://images.unsplash.com/photo-1615349806916-6d514ca4eb8f?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=750&q=80",
            $"https://images.unsplash.com/photo-1615230106436-fd04a9cbaef6?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=751&q=80",
            $"https://images.unsplash.com/photo-1615239540150-14fc4f3ebdbc?ixid=MXwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHw%3D&ixlib=rb-1.2.1&auto=format&fit=crop&w=752&q=80"
        };
        private static string _img;
        private int temp=0;
        public string[] ListIMG { 
            get => _listIMG;
            set { SetProperty(ref _listIMG, value); } 
        }
        public string IMG { 
            get => _img;
            set {
                SetProperty(ref _img, value);
            }
                }
        public Command BackCommand { get; }
        public Command NextCommand { get; }
        
        public MainPageViewModel()
        {
            //Khoi tao gtri dau
            IMG=ListIMG[0];

            //Command
            NextCommand = new Command(OnNextClicked);
            BackCommand = new Command(OnBackClicked);
        }
        private void OnNextClicked()
        {
            string x = "";
            temp++;          
            if (temp >= ListIMG.Length)
            {
                temp = 0;
            }
            x = ListIMG[temp];
            IMG = x;
        }
        private void OnBackClicked()
        {
            string x = "";
            temp--;
            if (temp < 0)
            {
                temp = ListIMG.Length-1;
            }
            x = ListIMG[temp];
            IMG = x;
        }
        
    }
}
