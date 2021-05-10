using System;
using System.Data.SqlClient;

namespace Contpaqi.Sql.Nominas.Empresa.Factories
{
    public static class NominasEmpresaDbContextFactory
    {
        public static NominasEmpresaDbContext CreateInstance(string contpaqiConnectionString, string initialCatalog)
        {
            if (contpaqiConnectionString == null)
            {
                throw new ArgumentNullException(nameof(contpaqiConnectionString));
            }

            if (initialCatalog == null)
            {
                throw new ArgumentNullException(nameof(initialCatalog));
            }

            var connectionStringBuilder = new SqlConnectionStringBuilder(contpaqiConnectionString)
            {
                InitialCatalog = initialCatalog
            };

            return new NominasEmpresaDbContext(new SqlConnection(connectionStringBuilder.ToString()), true);
        }
    }
}