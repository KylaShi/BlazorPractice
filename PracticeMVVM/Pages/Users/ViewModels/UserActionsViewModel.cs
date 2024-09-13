using Microsoft.AspNetCore.Components; // Needed for NavigationManager.
using PracticeMVVM.Pages.Users.Models; // Imports the User model.

namespace PracticeMVVM.Pages.Users.ViewModels
{
	// ViewModel that handles user creation and updating actions.
	public class UserActionsViewModel
	{
		private readonly NavigationManager _navigation; // Used to handle navigation between pages.
		private readonly UserListViewModel _userListViewModel; // Reference to the list of users.
		private readonly UserFormViewModel _userFormViewModel; // Reference to the form ViewModel for user data.

		// Constructor: Injects dependencies needed for navigation and user management.
		public UserActionsViewModel(NavigationManager navigation, UserListViewModel userListViewModel, UserFormViewModel userFormViewModel)
		{
			_navigation = navigation;
			_userListViewModel = userListViewModel;
			_userFormViewModel = userFormViewModel;
		}

		// Method called when creating a new user.
		public void CreateUser()
		{
			_userFormViewModel.IsUpdate = false; // Set to false since we are creating a new user.

			// Initialize a new blank user so the form is empty.
			_userFormViewModel.User = new User
			{
				Name = string.Empty,
				Address = string.Empty,
				Username = string.Empty,
				Password = string.Empty
			};

			// Navigate to the "create user" form.
			_navigation.NavigateTo("/users/create");
		}

		// Method called when updating an existing user.
		public void UpdateUser(User user)
		{
			_userFormViewModel.IsUpdate = true; // Set to true since we are updating an existing user.
			_userFormViewModel.User = user; // Pass the user to the form ViewModel for editing.
			_navigation.NavigateTo("/users/update"); // Navigate to the "update user" form.
		}
	}
}
