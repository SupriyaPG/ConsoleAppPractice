using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

//ArrayList stores objects of any like an array.However, there is no need to specify the size of the ArrayList
//like with an array as it grows automatically. It contains Add() and Remove()

namespace practiceApp
{
	internal class CollectionExample
	{
		internal void ArrayListFun()
		{
			ArrayList o = new ArrayList();
			o.Add(1);
			o.Add(2);
			o.Add("A");
			o.Add(12.52);
			o.Add(true);
			o.Remove(1);

			for (int i = 0; i < o.Count; i++)
			{
					Console.WriteLine(o[i]);
			}

			//foreach (object o1 in o)
			//{
			//	Console.WriteLine("data is:{0}",o1);
			//}
		}

	
	}
}