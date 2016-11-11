using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using SQLiteNetExtensions.Extensions;

namespace AppFinalMITInfnet
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        readonly object _lock = new object();

        public BaseRepository()
        {
            if (App.dbConn == null)
                App.dbConn = DatabaseConfig.GetDatabaseConnection;

            CreateDatabase();
        }

        void CreateDatabase()
        {
            lock (_lock)
            {
                try
                {
                    App.dbConn.CreateTable<Result>(SQLite.CreateFlags.None);
                    App.dbConn.CreateTable<Name>(SQLite.CreateFlags.None);
                    App.dbConn.CreateTable<Location>(SQLite.CreateFlags.None);
                    App.dbConn.CreateTable<Picture>(SQLite.CreateFlags.None);
                    App.dbConn.CreateTable<Product>(SQLite.CreateFlags.None);
                    App.dbConn.CreateTable<Menu>(SQLite.CreateFlags.None);
                    App.dbConn.CreateTable<MenuItem>(SQLite.CreateFlags.None);
                    App.dbConn.CreateTable<User>(SQLite.CreateFlags.None);

                    ConfigureLocalDb();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void Delete(T TEntity)
        {
            lock (_lock)
            {
                if (TEntity == null)
                    return;

                App.dbConn.Delete<T>(TEntity);
            }
        }

        public IList<T> GetAll()
        {
            lock (_lock)
            {
                if (App.dbConn.Table<T>().Count() <= 0)
                    throw new ArgumentNullException();

                return App.dbConn.GetAllWithChildren<T>();
            }
        }

        public IList<T> GetAllByFilter(Expression<Func<T, bool>> filter)
        {
            lock (_lock)
            {
                if (filter == null)
                    throw new ArgumentNullException(nameof(filter), "Nenhum filtro foi configurado");

                var result = App.dbConn.GetAllWithChildren<T>(filter, recursive: true);
                if (result == null)
                    throw new ArgumentNullException(nameof(result), "Nenhum registro encontrado");

                return result;
            }
        }

        public T GetByFilter(Expression<Func<T, bool>> filter)
        {
            lock (_lock)
            {
                if (filter == null)
                    throw new ArgumentNullException(nameof(filter), "Nenhum filtro foi configurado");

                //Não tem um método que recebe a expressão e retorna apenas um único elemento.
                var result = App.dbConn.GetAllWithChildren<T>(filter, recursive: true);

                if (result == null || result.Count == 0)
                    throw new ArgumentNullException(nameof(result), "Nenhum registro encontrado");

                if (result.Count > 1)
                    throw new ArgumentNullException(nameof(result), "Mais de um registro encontrado");

                return result[0];
            }
        }

        public T GetById(int id)
        {
            lock (_lock)
            {
                if (id <= 0)
                    throw new ArgumentOutOfRangeException(nameof(id), "É necessário informar um ID válido");

                var result = App.dbConn.GetWithChildren<T>(id.ToString(), recursive: true);
                if (result == null)
                    throw new ArgumentNullException(nameof(result), "Nenhum registro encontrado");

                return result;
            }
        }

        public void Insert(T TEntity)
        {
            lock (_lock)
            {
                if (TEntity == null)
                    throw new ArgumentNullException(nameof(TEntity), "É preciso informar uma Entidade válida");

                if (typeof(T) != TEntity.GetType())
                    throw new ArgumentException("Foi informado uma entidade diferente do tipo instanciado do repositório", nameof(TEntity));

                App.dbConn.InsertOrReplaceWithChildren(TEntity, recursive: true);
            }
        }

        public void Update(T TEntity)
        {
            lock (_lock)
            {
                if (TEntity == null)
                    throw new ArgumentNullException(nameof(TEntity), "É preciso informar uma Entidade válida");

                if (typeof(T) != TEntity.GetType())
                    throw new ArgumentException("Foi informado uma entidade diferente do tipo instanciado do repositório", nameof(TEntity));

                App.dbConn.UpdateWithChildren(TEntity);
            }
        }

        void ConfigureLocalDb()
        {
            try
            {
                if (App.dbConn.Table<User>().Count() <= 0)
                {
                    var user = new User
                    {
                        FirstName = "Aluno",
                        LastName = "do Infnet",
                        Password = "123",
                        Username = "aluno",
                        Id = new Random().Next(),
                        Status = true
                    };

                    App.dbConn.Insert(user, typeof(User));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}