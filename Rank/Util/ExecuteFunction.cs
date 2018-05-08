using System;
using System.Data;
using Npgsql;

namespace Rank.Util
{
    internal class ExecuteFunction
    {
        private NpgsqlConnection connection;
        private GetRank getRank;
        private GetLogic getLogic;
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

        internal DataTable GetTrainer()
        {
            getLogic = new GetLogic(connection);
            dr = getLogic.GetListTrainer();
            return new TableData().ConvertDataTable(dr);
        }

        internal void AddBattle(int id, int trainer_winner, int trainer_losser, int pkm_w, int pkm_l, DateTime date, int id_type, char id_group)
        {
            getLogic = new GetLogic(connection);
            getLogic.AddBattle(id, trainer_winner, trainer_losser, pkm_w, pkm_l, date, id_type, id_group);
        }
    }
}