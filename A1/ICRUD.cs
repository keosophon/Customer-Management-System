﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace A1
{
	//CRUD Interface for entities
	public interface ICRUD<T>
	{
		public int Add(T obj) ;
		public T GetObject(string par);

		public T GetObject(int id);

		public List<T> GetObjects();
	}
}