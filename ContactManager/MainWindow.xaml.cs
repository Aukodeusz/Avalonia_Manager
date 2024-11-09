
using System.IO;
using System.Windows;
using System.Xml.Serialization;

namespace ContactManager
{
    public partial class MainWindow
    {
        private List<Contact> contactList = new();

        public MainWindow()
        {
            InitializeComponent();
            LoadContacts();
            UpdateContactList();
        }

        private void OnAddClick(object sender, RoutedEventArgs e)
        {
            var newContact = new Contact
            {
                FirstName = inputFirstName.Text,
                LastName = inputLastName.Text,
                PhoneNumber = inputPhone.Text,
                Email = inputEmail.Text,
                IsFavorite = favoriteCheckBox.IsChecked == true
            };

            contactList.Add(newContact);
            UpdateContactList();
            SaveContacts();
        }

        private void OnEditClick(object sender, RoutedEventArgs e)
        {
            if (contactListBox.SelectedItem is Contact selectedContact)
            {
                selectedContact.FirstName = inputFirstName.Text;
                selectedContact.LastName = inputLastName.Text;
                selectedContact.PhoneNumber = inputPhone.Text;
                selectedContact.Email = inputEmail.Text;
                selectedContact.IsFavorite = favoriteCheckBox.IsChecked == true;

                UpdateContactList();
                SaveContacts();
            }
        }

        private void OnDeleteClick(object sender, RoutedEventArgs e)
        {
            if (contactListBox.SelectedItem is Contact selectedContact)
            {
                contactList.Remove(selectedContact);
                UpdateContactList();
                SaveContacts();
            }
        }

        private void UpdateContactList()
        {
            contactListBox.ItemsSource = null;
            contactListBox.ItemsSource = contactList.OrderBy(c => c.LastName).ThenBy(c => c.FirstName).ToList();
        }

        private void OnFilterChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (filterComboBox.SelectedIndex == 1) 
            {
                contactListBox.ItemsSource = contactList.Where(c => c.IsFavorite).OrderBy(c => c.LastName).ThenBy(c => c.FirstName).ToList();
            }
            else 
            {
                UpdateContactList();
            }
        }

        private void SaveContacts()
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Contact>));
            using (var writer = new StreamWriter("contacts.xml"))
            {
                xmlSerializer.Serialize(writer, contactList);
            }
        }

        private void LoadContacts()
        {
            if (File.Exists("contacts.xml"))
            {
                var xmlSerializer = new XmlSerializer(typeof(List<Contact>));
                using (var reader = new StreamReader("contacts.xml"))
                {
                    contactList = (List<Contact>)xmlSerializer.Deserialize(reader);
                }
            }
        }
    }
}
