using System;
using System.Collections.Generic;
using System.Text;

namespace Task7
{
	class Employee
	{
		string lastname;
		string firstname;

		string level;
		double  tax = 0.95;
		int salary;

		public Employee(string lastname, string firstname)
		{
			this.lastname = lastname;
			this.firstname = firstname;
		}

		public void Payroll(string level, int experience)
		{
			this.level = level;
			int a = 0;
			double b = 0;

			switch (level)
			{
				case "junior":
					a = 500;
					switch (experience)
					{
						case 1:
							b = 1;
							break;
						case 2:
							b = 2;
							break;
						case 3:
							b = 3;
							break;
					}
					break;
				case "middle":
					a = 2000;

					switch (experience)
					{
						case 1:
							b = 1;
							break;
						case 2:
							b = 1.5;
							break;
						case 3:
							b = 2;
							break;
					}
					break;
				case "senior":
					a = 4000;
					switch (experience)
					{
						case 1:
							b = 1;
							break;
						case 2:
							b = 1.25;
							break;
						case 3:
							b = 1.5;
							break;
					}
					break;
			}
			salary = Convert.ToInt32 (a * b * tax);
		}

		public override string ToString()
		{
			return $"Name: {firstname}\n" +
				   $"Surname: {lastname}\n" +
				   $"Position: {level}\n" +
				   $"Tax: {tax}\n" +
				   $"Salary: {salary}\n";
		}
	}
}
