using System.Collections.ObjectModel; // Needed for the ObservableCollection.
using PracticeMVVM.Pages.Users.Models; // Imports the User model.

namespace PracticeMVVM.Pages.Users.ViewModels
{
	// ViewModel that manages the collection of users.
	public class UserListViewModel
	{
		// Constructor: Calls Initialize to populate the user list with dummy data.
		public UserListViewModel()
		{
			Initialize();
		}

		// ObservableCollection of users. This collection is bound to the UI and notifies the UI of changes.
		public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>();

		// Initializes the list with some dummy data for testing purposes.
		public void Initialize()
		{
			for (int i = 0; i < 5; i++)
			{
				Users.Add(new User
				{
					Name = $"User {i + 1}", // Sets the name for the user.
					Address = $"Address {i + 1}", // Sets the address for the user.
					Username = $"Username {i + 1}", // Sets the username for the user.
					Password = $"$uper$ecret" // Sets a dummy password (not shown in the UI).
				});
			}
		}
	}
}
