using System;
using System.Collections.Generic;

namespace PaperInteractive
{
	public class Parent
	{
		int parent_Id;
		string name;
		string mail;
		string address;
		int phoneNumber;
		List<Child> childList;

		public Parent(string Name, string Mail, string Address)
		{
			name = Name;
			mail = Mail;
			address = Address;
		}
	}
}
