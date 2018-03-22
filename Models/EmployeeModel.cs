using System;
using System.ComponentModel.DataAnnotations;


namespace employee_scheduling.Models

{
	public class EmployeeModel : BaseEntity
	{
		
		public int EmployeeId { get; set; }

		[Required(ErrorMessage="Please Enter a First Name")]
		[Display(Name = "First Name:")]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Please Enter a Last Name")]
		[Display(Name = "Last Name:")]
		public string LastName { get; set; }

		[Required(ErrorMessage = "Please Enter An Email Address")]
		[EmailAddress]
		[Display(Name = "Email:")]

		public string Email { get; set; }

		[Required(ErrorMessage = "Please Enter A UserId")]
		[Display(Name = "User Id:")]

		public string UserId { get; set; }

		[Required(ErrorMessage = "Please Enter a Password")]
		[Display(Name = "Password:")]

		public string Password { get; set; }

		[Required(ErrorMessage = "Please Re-Type Your Password")]
		[Compare("Password")]
		[Display(Name = "Confirm Password:")]

		public string ConfirmPassword { get; set; }

		public DateTime? CreatedAt{ get; set; }

		public DateTime? ModifiedAt {get; set;}

		public EmployeeModel()
		{
			
		}

		public string ReturnEmployee()
		{
			return $"First_Name: {FirstName}, Last_Name: {LastName}, Email: {Email}, UserId: {UserId}, Created_At: {CreatedAt}, Modified_At :{ModifiedAt}";
		}
	}
}