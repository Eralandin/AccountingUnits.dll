using Npgsql;
using SharedModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingUnits
{
    public class AccountingUnitsService
    {
        private readonly string _connectionString;
        private User _currentUser;
        private Form? mainForm;

        public AccountingUnitsService(string connectionString, User currentUser, Form? mainForm)
        {
            _connectionString = connectionString;
            _currentUser = currentUser;
            if (mainForm != null)
            {
                this.mainForm = mainForm;
            }
        }
        public List<AccountingUnit> GetUnitsAsync()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM tbAccountingUnits;";
                List<AccountingUnit> units = new List<AccountingUnit>();
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            units.Add(new AccountingUnit
                            {
                                Id = reader.GetInt32(0),
                                Name = reader.GetString(1)
                            });
                        }
                    }
                }
                return units;
            }
        }
    }
}
