using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App380
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            listView.ItemsSource = new List<ContactGroup> {
                new ContactGroup("P", "P")
                {
                   new Contact { Name = "Peter Parker", Status = "Nice to meet you!" }
                },
                new ContactGroup("J", "J")
                {
                   new Contact { Name = "John Smith", Status = "Hey, let's talk!" }
                }
            };
        }
    }
    public class Contact
    {
        public string Name { get; set; }
        public string Status { get; set; }

    }

    public class ContactGroup : List<Contact>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }


        public ContactGroup(string title, string shortTitle)
        {
            Title = title;
            ShortTitle = shortTitle;
        }

    }
}
