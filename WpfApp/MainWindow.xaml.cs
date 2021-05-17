using System.Collections.Generic;
using System.Windows.Documents;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var items = new List<Person>
            {
                new Person("osama", "albanna", "0223355556625", 25),
                new Person("osama - osama - osama ", "albanna - albanna - albanna", "0223355556625", 25),
            };

            this.FirstItemsCollection.ItemsSource = items;
            this.SecondItemsCollection.ItemsSource = items;
        }
        
        public class Person
        {
            public Person(string firstname, string lastname, string phone, int age)
            {
                Firstname = firstname;
                Lastname = lastname;
                Phone = phone;
                Age = age;
            }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Phone { get; set; }
            public int Age { get; set; }
        }
    }
}