using PracticeMVVM.Pages.Users.Models; // Imports the User model.

namespace PracticeMVVM.Pages.Users.ViewModels
{
	// ViewModel that manages the state of the user form.
	public class UserFormViewModel
	{
		private readonly UserListViewModel _userListViewModel;
		// Constructor: Takes in UserListViewModel to allow interaction with the user list.
		public UserFormViewModel(UserListViewModel userListViewModel)
		{
			_userListViewModel = userListViewModel;
		}

 // Reference to the user list ViewModel.

		// The User object being edited or created in the form.
		public User User { get; set; }
		// Flag to determine whether we are creating a new user or updating an existing one.
		public bool IsUpdate { get; set; }

		// Saves the user to the list.
		public void SaveUser()
		{
			// If we are updating an existing user.
			if (IsUpdate)
			{
				var index = _userListViewModel.Users.IndexOf(User); // Find the index of the user in the list.
				_userListViewModel.Users[index] = User; // Update the user in the list.
			}
			// If we are creating a new user.
			else
			{
				_userListViewModel.Users.Add(User); // Add the new user to the list.
			}
		}
	}
}
