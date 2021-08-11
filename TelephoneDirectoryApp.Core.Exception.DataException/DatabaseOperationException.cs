using System;
using TelephoneDirectoryApp.Core.Exception.Base;

namespace TelephoneDirectoryApp.Core.Exception.DataException
{
    public class DatabaseOperationException : BaseException
    {
        /// <summary>
        /// Database name of handling exception
        /// </summary>
        public string DatabaseName { get; }

        /// <summary>
        /// Table name of handling exception
        /// </summary>
        public string TableName { get; }

        /// <summary>
        /// SQL error message and code
        /// </summary>
        public string SqlErrorMessage { get; }

        /// <summary>
        /// DB Operation specific exception
        /// </summary>
        /// <param name="message">Custom message of exception</param>
        /// <param name="databaseName">Database name of handling exception</param>
        /// <param name="tableName">Table name of handling exception</param>
        /// <param name="sqlErrorMessage">SQL error message and code</param>
        public DatabaseOperationException(string message, string databaseName, string tableName, string sqlErrorMessage)
            : base(message)
        {
            DatabaseName = databaseName;
            TableName = tableName;
            SqlErrorMessage = sqlErrorMessage;
        }
    }
}
