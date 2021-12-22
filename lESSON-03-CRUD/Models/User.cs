using Microsoft.EntityFrameworkCore;

namespace Models
{
	// باید ایندکس ها را در بالای کلاس مورد نظر تعریف کرد   ef core در  
	[Index(nameof(Username),nameof(FullName),nameof(EmailAddress))]
	public class User : BaseEntity
	{
		public User() : base()
		{
		}

		// **********
		[System.ComponentModel.DataAnnotations.Range
			(type: typeof(int), minimum: "25", maximum: "35")]
		public int Age { get; set; }
		// **********

		// **********
		public bool IsActive { get; set; }
		// **********

		// **********
		//[System.ComponentModel.DataAnnotations.Required]
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20, MinimumLength = 6)]

	
			
		public string Username { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20, MinimumLength = 8)]

		//[System.ComponentModel.DataAnnotations.StringLength
		//	(maximumLength: 40, MinimumLength = 40)]
		public string Password { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50, MinimumLength = 3)]

		// وجود ندارد ef core کار می کند ولی در  ef6  این اتریبیوت در   
		//[System.ComponentModel.DataAnnotations.Schema.Index
		//	(IsUnique = false)]
		public string FullName { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 250, MinimumLength = 5)]

		//[System.ComponentModel.DataAnnotations.Schema.Index
		//	(IsUnique = true)]
		public string EmailAddress { get; set; }
		// **********
	}
}
