﻿using Dapper;
using ICare.Core.Data;
using ICare.Core.ICommon;
using ICare.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ICare.Infra.Repository
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly IDbContext _dbContext;

        public NotificationRepository(IDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public bool Create(Notification t)
        {
            var p = new DynamicParameters();
            p.Add("@CreatedOn"          , t.CreatedOn           , DbType.DateTime   , ParameterDirection.Input);
            p.Add("@Message"            , t.Message             , DbType.String     , ParameterDirection.Input);
            p.Add("@PatientId"          , t.PatientId           , DbType.Int32      , ParameterDirection.Input);
            p.Add("@NotificationTypeId" , t.NotificationTypeId  , DbType.Int32      , ParameterDirection.Input);


            try
            {
                var result = _dbContext.Connection.Execute("NotificationInsert", p, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, ParameterDirection.Input);

            try
            {
                var result = _dbContext.Connection.Execute("NotificationDelete", p, commandType: CommandType.StoredProcedure);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IEnumerable<Notification> GetAll()
        {
            var result = _dbContext.Connection.Query<Notification>("NotificationGetAll", commandType: CommandType.StoredProcedure);
            return result;
        }

        public Notification GetById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, DbType.Int32, ParameterDirection.Input);
            var result = _dbContext.Connection.QueryFirstOrDefault<Notification>("NotificationSelect", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public bool Update(Notification t)
        {
            var p = new DynamicParameters();
            p.Add("@Id"                 , t.Id                   , dbType: DbType.Int32 , ParameterDirection.Input);
            p.Add("@CreatedOn"          , t.CreatedOn           , DbType.DateTime       , ParameterDirection.Input);
            p.Add("@Message"            , t.Message             , DbType.String         , ParameterDirection.Input);
            p.Add("@PatientId"          , t.PatientId           , DbType.Int32          , ParameterDirection.Input);
            p.Add("@NotificationTypeId" , t.NotificationTypeId  , DbType.Int32          , ParameterDirection.Input);



            try
            {
                var result = _dbContext.Connection.Execute("NotificationUpdate", p, commandType: CommandType.StoredProcedure);
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }
    }
}
