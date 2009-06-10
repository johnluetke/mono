﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;

using MonoTests.DataSource;
using MonoTests.ModelProviders;

namespace MonoTests.Common
{
	class TestDataContainer <DataType>: DynamicDataContainer<DataType>
	{
		public TestDataContainer ()
		: this (default (DataType))
		{ }

		public TestDataContainer (DataType data)
		: base (data)
		{ }

		public override int Update (IDictionary keys, IDictionary values, IDictionary oldValues)
		{
			throw new NotImplementedException ();
		}

		public override int Insert (IDictionary values)
		{
			throw new NotImplementedException ();
		}

		public override int Delete (IDictionary keys, IDictionary oldValues)
		{
			throw new NotImplementedException ();
		}

		public override IEnumerable Select (DataSourceSelectArguments args, string where, global::System.Web.UI.WebControls.ParameterCollection whereParams)
		{
			throw new NotImplementedException ();
		}

		public override List<DynamicDataTable> GetTables ()
		{
			var ret = new List<DynamicDataTable> ();
			ret.Add (new TestDataTable <DataType> ());

			return ret;
		}
	}
}
