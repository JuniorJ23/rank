using System.Data;
using Npgsql;
using Rank.Util;

namespace sComercial.Statistics
{
    internal class ExecuteFunction
    {
        private NpgsqlConnection connection;
        private GetRank getRank;
        private NpgsqlDataReader dr;

        internal ExecuteFunction(NpgsqlConnection connection)
        {
            this.connection = connection;
            dr = null;
        }

        internal DataTable GetRankLeague()
        {
            getRank = new GetRank(connection);
            dr = getRank.getRankLeague();
            return new TableData().ConvertDataTable(dr);
        }
    }
}