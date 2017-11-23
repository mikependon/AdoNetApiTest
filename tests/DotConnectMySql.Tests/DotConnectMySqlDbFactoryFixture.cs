using System.Data.Common;
using AdoNet.Specification.Tests;
using Devart.Data.MySql;

namespace DotConnectMySql.Tests
{
    public sealed class DotConnectMySqlDbFactoryFixture : IDbFactoryFixture
	{
		public DbProviderFactory Factory => MySqlProviderFactory.Instance;

		// docker run --name mysql -e MYSQL_ROOT_PASSWORD=test -p 3306:3306 -d mysql:5.7
		public string ConnectionString => "server=localhost;user id=root;password=test;character set=utf8mb4";
	}
}
