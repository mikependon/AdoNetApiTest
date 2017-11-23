using System.Data.Common;
using AdoNet.Specification.Tests.Databases;
using Devart.Data.PostgreSql;

namespace DotConnectPostgres.Tests
{
	public sealed class DotConnectPostgresDbFactoryFixture : DbFactoryFixtureBase<PostgresDatabaseBase>
	{
		public override DbProviderFactory Factory => PgSqlProviderFactory.Instance;
	}
}