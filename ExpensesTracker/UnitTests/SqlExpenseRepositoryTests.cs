using NUnit.Framework;
using Moq;
using ExpensesTracker.Repositories;
using System.Data.SqlClient;
using ExpensesTracker.RepositoryPattern.Interfaces;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;

namespace ExpensesTracker.Tests
{
    [TestFixture]
    public class SqlExpenseRepositoryTests
    {
        private Mock<IUserRepository> _mockUserRepository;
        private SqlConnection _fakeSqlConnection;

        [SetUp]
        public void Setup()
        {
            _mockUserRepository = new Mock<IUserRepository>();
            _fakeSqlConnection = new SqlConnection(); // You can use a mock if needed
        }
 
            //[Test]
            //public void GetConnection_ConnectionOpened_Successfully()
            //{
            //    // Arrange
            //    var sqlConnectionManager = SqlConnectionManager.Instance;

            //    // Act
            //    SqlConnection connection = sqlConnectionManager.GetConnection();

            //    // Assert
            //    Assert.AreEqual(System.Data.ConnectionState.Open, connection.State);
            //}

            //[Test]
            //public void GetConnection_CalledTwice_SameConnectionInstance()
            //{
            //    // Arrange
            //    var sqlConnectionManager = SqlConnectionManager.Instance;

            //    // Act
            //    SqlConnection connection1 = sqlConnectionManager.GetConnection();
            //    SqlConnection connection2 = sqlConnectionManager.GetConnection();

            //    // Assert
            //    Assert.AreSame(connection1, connection2);
            //}

            //[Test]
            //public void CloseConnection_ConnectionClosed_Successfully()
            //{
            //    // Arrange
            //    var sqlConnectionManager = SqlConnectionManager.Instance;
            //    SqlConnection connection = sqlConnectionManager.GetConnection();

            //    // Act
            //    sqlConnectionManager.CloseConnection();

            //    // Assert
            //    Assert.That(System.Data.ConnectionState.Closed, Is.EqualTo(connection.State));
            //}
        }
    }

