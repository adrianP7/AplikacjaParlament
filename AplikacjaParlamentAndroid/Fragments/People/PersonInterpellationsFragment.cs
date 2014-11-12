﻿//
//  PersonInterpellationsFragment.cs
//
//  Author:
//       Jakub Syty <j.syty@media30.pl>
//
//  Copyright (c) 2014 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AplikacjaParlamentShared.Models;

namespace AplikacjaParlamentAndroid
{
	public class PersonInterpellationsFragment : ListFragment
	{
		private PersonDetailsActivity personDetailsActivity;

		private IInterpellationPerson person;

		private string[] values;

		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			personDetailsActivity = Activity as PersonDetailsActivity;
			if(personDetailsActivity.Person is IInterpellationPerson)
				person = personDetailsActivity.Person;

			values = new[] { "Interpelacja 1", "Interpelacja 2 ", "Interpelacja 3" };
			this.ListAdapter = new ArrayAdapter<string>(Activity, Android.Resource.Layout.SimpleExpandableListItem1, values);
		}
	}
}
