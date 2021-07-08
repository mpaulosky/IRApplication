using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IR.Shared.Models
{
	public class BaseEntity
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Display(Name = "Date Added")] public DateTimeOffset DateAddedUtc { get; set; } = DateTimeOffset.UtcNow;

		[Display(Name = "Date Modified")] public DateTimeOffset DateModifiedUtc { get; set; } = DateTimeOffset.UtcNow;

		[Display(Name = "Is Deleted")] public bool IsDeleted { get; set; }
	}
}