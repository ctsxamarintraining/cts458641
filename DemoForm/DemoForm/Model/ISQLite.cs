using System;
using SQLite;

namespace DemoForm
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection ();
	}
}

