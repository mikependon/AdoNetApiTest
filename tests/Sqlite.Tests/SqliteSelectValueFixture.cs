using System;
using System.Collections.Generic;
using System.Data;
using AdoNet.Databases;
using AdoNet.Specification.Tests;

namespace Sqlite.Tests
{
	public class SqliteSelectValueFixture : SqliteDbFactoryFixture, ISelectValueFixture, IDisposable
	{
		public SqliteSelectValueFixture() => SqliteDatabase.CreateSelectValueTable(this);
		public void Dispose() => SqliteDatabase.DropSelectValueTable(this);
		public string CreateSelectSql(DbType dbType, ValueKind kind) => SqliteDatabase.CreateSelectSql(dbType, kind);
		public string CreateSelectSql(byte[] value) => SqliteDatabase.CreateSelectSql(value);
		public string SelectNoRows => SqliteDatabase.SelectNoRows;
		public IReadOnlyCollection<DbType> SupportedDbTypes => SqliteDatabase.SupportedDbTypes;
	}
}