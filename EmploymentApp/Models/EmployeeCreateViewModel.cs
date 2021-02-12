using Employment.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmploymentApp.Models
{
	public class EmployeeCreateViewModel
	{
		public int Id { get; set; }
		[Required(ErrorMessage = "Employee number is required")]
		public string EmployeeNo { get; set; }
		[Required(ErrorMessage = "First Name is required"), StringLength(50, MinimumLength = 3), Display(Name = "First Name")]
		public string FirstName { get; set; }
		[StringLength(50), Display(Name = "Middle Name")]
		public string MiddleName { get; set; }
		[Required, MaxLength(50), Display(Name = "Last Name")]
		public string LastName { get; set; }
		[Display(Name = "Full Name")]
		public string FullName
		{
			get
			{
				return FirstName + (string.IsNullOrEmpty(MiddleName) ? " " : (" " + (char?)MiddleName[0] + ". ").ToUpper()) + LastName;
			}
		}
		public string Gender { get; set; }
		[Display(Name = "Photo")]
		public IFormFile ImageUrl { get; set; }
		[DataType(DataType.Date), Display(Name = "Date of birth")]
		public DateTime DOB { get; set; }
		[DataType(DataType.Date), Display(Name = "Date joined")]
		public DateTime DateJoined { get; set; } = DateTime.UtcNow;
		public string Phone { get; set; }
		[Required(ErrorMessage = "Job role is required")]
		public string Designation { get; set; }
		public string Email { get; set; }
		[Required, MaxLength(10)]
		public string NationalInsuranceNo { get; set; }
		[Display(Name = "Payment Method")]
		public PaymentMethod PaymentMethod { get; set; }
		[Display(Name = "Student Loan")]
		public StudentLoan StudentLoan { get; set; }
		[Display(Name = "Union Member")]
		public UnionMember UnionMember { get; set; }
		[Required, MaxLength(50), DataType(DataType.MultilineText)]
		public string Address { get; set; }
		[Required, StringLength(50)]
		public string City { get; set; }
		[Required, StringLength(50), Display(Name = "Post Code")]
		public string Postcode { get; set; }
		
	}
}
