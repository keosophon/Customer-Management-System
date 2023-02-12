﻿//using Android.App;
//using Android.Content;
//using Android.OS;
//using Android.Runtime;
//using Android.Views;
//using Android.Widget;
//using System;
//using System.Linq;
//using System.Text;
using System.Collections.Generic;


namespace A1
{
	//CRUD Interface for entities
	public interface ICRUD<T>
	{
		public int UpdateObject(T obj);
		public void DeleteObject(int id);
		public int Add(T obj) ;
		public T GetObject(string par);

		public T GetObject(int id);

		public List<T> GetObjects();
	}
}