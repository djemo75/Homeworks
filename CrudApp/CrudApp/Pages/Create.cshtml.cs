using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudApp.Pages
{
	public class CreateModel : PageModel
	{
		private readonly AppDbContext _db;

		public CreateModel(AppDbContext db)
		{
			_db = db;
		}

		[BindProperty]
		public Customer Customer { get; set; }

		public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			_db.Customers.Add(Customer);
			await _db.SaveChangesAsync();
			return RedirectToPage("/Index");
		}
	}
}