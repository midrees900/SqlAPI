using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SqlAPI.Model
{
	public class TblEmployee
	{

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]

		public int Id { get; set; }
		[StringLength(250)]
		[Required]
		public string Name { get; set; }
		[StringLength(250)]
		[Required]

		public string LastName { get; set; }
		[StringLength(250)]
		[Required]
		public string Email { get; set; }
		[Required]
		public int Age { get; set; }
		[Required]
		public DateTime Doj { get; set; }
		[Required]
		public string Gender { get; set; }
		[Required]
		public int IsMarried { get; set; }
		[Required]
		public int IsActive { get; set; }
		[Required]
		public int DesignationID { get; set; }
		[NotMapped]

		public string Designation { get; set; }

	}
}
