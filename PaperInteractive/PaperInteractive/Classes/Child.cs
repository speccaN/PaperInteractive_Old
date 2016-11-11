using System;
using System.Collections.Generic;
namespace PaperInteractive
{
	public class Child
	{
		int child_Id;
		string name;
		List<Excercise> excerciseList;
		List<Parent> parentList;

		public Child(string Name, Parent parent)
		{
			name = Name;
			parentList = new List<Parent>();
			excerciseList = new List<Excercise>();
			parentList.Add(parent);
		}
	}
}
