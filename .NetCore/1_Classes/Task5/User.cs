using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
	class User
	{
		string login;
		string firstname;
		string lastname;
		int age;
		readonly DateTime date;

		public User(string login, string firstname, string lastname, int age, DateTime date)
		{
			this.login = login;
			this.firstname = firstname;
			this.lastname = lastname;
			this.age = age;
			this.date = date;
		}
		public override string ToString()
		{
			return $"\nLogin: {login}\n" +
				   $"First name : {firstname}\n" +
	               $"Last name: {lastname}\n" +
				   $"Age: {age}\n" +
				   $"Date of registration: {date}";
		}
	}
}
