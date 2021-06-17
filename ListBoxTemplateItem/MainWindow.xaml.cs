using System.Collections.ObjectModel;
using System.Windows;

namespace ListBoxTemplateItem
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<User> _users;
        public MainWindow()
        {
            InitializeComponent();
            _users = new ObservableCollection<User>
            {
                new User("A", "123"),
                new User("AA", "12"),
                new User("AAA", "1"),
            };
            list_Users.ItemsSource = _users;
        }

        private void Button_Add_OnClick(object sender, RoutedEventArgs e)
        {
            var login = input_Login.Text;
            var password = input_Password.Text;
        }
    }
}