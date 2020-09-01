using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ProjectStructure.DAL.Context;

namespace ProjectStructure.BL.Tests
{
    public class ProjectStructureContextFake : ProjectStructureContext
    {
        private readonly DbConnection _connection;

        public ProjectStructureContextFake()
            : base(
                new DbContextOptionsBuilder<ProjectStructureContext>()
                    .UseSqlite(CreateInMemoryDatabase())
                    .Options) {
        }

        private static DbConnection CreateInMemoryDatabase() {
            var connection = new SqliteConnection("Filename=:memory:");

            connection.Open();

            return connection;
        }

        public override void Dispose()
        {
            
            _connection.Dispose();
            base.Dispose();
        }
    }
}
