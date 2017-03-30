using System;
using SQLite.Net;

namespace templateBase
{
	public interface Isqlite
	{
		SQLiteConnection GetConnection();
	}
}
