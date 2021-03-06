﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ERPSzakdolgozat.Models
{
	public class Employee : BaseProperties
	{
		[Required]
		public string EmployeeName { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime DateOfBirth { get; set; }

		[Required]
		[DataType(DataType.Date)]
		public DateTime JoinedOn { get; set; }

		[DataType(DataType.Date)]
		public DateTime? LeavingOn { get; set; }

		public bool Active { get; set; }

		[Required]
		public string CompanyIdentifier { get; set; }

		[Required]
		public int SkillLevelId { get; set; }

		[Required]
		public int RoleId { get; set; }

		[Required]
		public int LeaderId { get; set; }

		public bool IsLeader { get; set; }

		[Required]
		public int TeamId { get; set; }

		[Required]
		public string HomeCountry { get; set; }

		[Required]
		public string HomeZIP { get; set; }

		[Required]
		public string HomeCity { get; set; }

		[Required]
		public string HomeStreet { get; set; }

		public string MailCountry { get; set; }
		public string MailZIP { get; set; }
		public string MailCity { get; set; }
		public string MailStreet { get; set; }
		public bool SameAddress { get; set; }
		public string Mobile { get; set; }

		[Required]
		public string Email { get; set; }

		public List<EmployeeFinancial> EmployeeFinancials { get; set; }
	}
}