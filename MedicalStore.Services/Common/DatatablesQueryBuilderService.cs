using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using MedicalStore.Core.Linq;
using MedicalStore.Core.Linq.LinqKit;

namespace MedicalStore.Services.Common
{
    public class DatatablesQueryBuilderService: IDatatablesQrBuilderService,IExpressionBuilder
    {
        /// <summary>
        /// Buils the query.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request">The request.</param>
        /// <param name="queryable">The queryable.</param>
        /// <returns></returns>
        public DatatablesQueryResult<T> BuildQuery<T>(HttpRequestBase request, IQueryable<T> queryable)
        {
            var dtParams = ParseRequest(request);
            var result = new DatatablesQueryResult<T>();
            result.recordsTotal = queryable.Count();
            // search query
            var predicate = PredicateBuilder.New<T>();
            bool searchHasValue = !string.IsNullOrEmpty(dtParams.Search.Value);
            bool clHasValue = false;

            #region the where clause part

            foreach (var p in dtParams.Columns)
            {
                if (!p.Searchable || string.IsNullOrEmpty(p.Search.Value)) continue;
                GetValue(p, predicate, p.Search.Value);

                clHasValue = true;
            }
            foreach (var p in dtParams.Columns)
            {
                if (!string.IsNullOrEmpty(dtParams.Search.Value))
                    GetValue(p, predicate, dtParams.Search.Value);
            }
            if (searchHasValue || clHasValue)
                queryable = queryable.Where(predicate);

            #endregion

            #region the order clause part

            foreach (var p in dtParams.Orders)
            {
                var c = dtParams.Columns[p.Column];
                if (!c.Orderable) continue;
                PropertyInfo pi = typeof(T).GetProperty(c.Data);
                if (pi == null) continue;
                switch (pi.PropertyType.FullName)
                {
                    case "System.String":
                    {
                        queryable = p.Dir == "asc"
                            ? queryable.OrderBy(OrderByExpression<T, string>(c.Data))
                            : queryable.AsQueryable().OrderByDescending(OrderByExpression<T, string>(c.Data));
                    }
                        break;
                    case "System.DateTime":
                    {
                        queryable = p.Dir == "asc"
                            ? queryable.OrderBy(OrderByExpression<T, DateTime>(c.Data))
                            : queryable.AsQueryable().OrderByDescending(OrderByExpression<T, DateTime>(c.Data));
                    }
                        break;
                    case "System.Nullable<DateTime>":
                    {
                        queryable = p.Dir == "asc"
                            ? queryable.OrderBy(OrderByExpression<T, Nullable<DateTime>>(c.Data))
                            : queryable.AsQueryable()
                                .OrderByDescending(OrderByExpression<T, Nullable<DateTime>>(c.Data));
                    }
                        break;
                    case "System.Int32":
                    {
                        queryable = p.Dir == "asc"
                            ? queryable.OrderBy(OrderByExpression<T, Int32>(c.Data))
                            : queryable.AsQueryable().OrderByDescending(OrderByExpression<T, Int32>(c.Data));
                    }
                        break;
                    case "System.Nullable<Int32>":
                    {
                        queryable = p.Dir == "asc"
                            ? queryable.OrderBy(keySelector: OrderByExpression<T, Nullable<Int32>>(c.Data))
                            : queryable.AsQueryable()
                                .OrderByDescending(OrderByExpression<T, Nullable<Int32>>(c.Data));
                    }
                        break;
                    case "System.Int64":
                    {
                        queryable = p.Dir == "asc"
                            ? queryable.OrderBy(OrderByExpression<T, Int64>(c.Data))
                            : queryable.AsQueryable().OrderByDescending(OrderByExpression<T, Int64>(c.Data));
                    }
                        break;
                    case "System.Nullable<Int64>":
                    {
                        queryable = p.Dir == "asc"
                            ? queryable.OrderBy(keySelector: OrderByExpression<T, Nullable<Int64>>(c.Data))
                            : queryable.AsQueryable()
                                .OrderByDescending(OrderByExpression<T, Nullable<Int64>>(c.Data));
                    }
                        break;

                    case "System.Decimal":
                    {
                        queryable = p.Dir == "asc"
                            ? queryable.OrderBy(OrderByExpression<T, Decimal>(c.Data))
                            : queryable.AsQueryable().OrderByDescending(OrderByExpression<T, Decimal>(c.Data));
                    }
                        break;
                    case "System.Nullable<Decimal>":
                    {
                        queryable = p.Dir == "asc"
                            ? queryable.OrderBy(OrderByExpression<T, Nullable<Decimal>>(c.Data))
                            : queryable.AsQueryable().OrderByDescending(OrderByExpression<T, Decimal?>(c.Data));
                    }
                        break;
                    case "System.Double":
                    {
                        queryable = p.Dir == "asc"
                            ? queryable.OrderBy(OrderByExpression<T, Double>(c.Data))
                            : queryable.AsQueryable().OrderByDescending(OrderByExpression<T, Double>(c.Data));
                    }
                        break;
                    case "System.Nullable<Double>":
                    {
                        queryable = p.Dir == "asc"
                            ? queryable.OrderBy(OrderByExpression<T, Nullable<Double>>(c.Data))
                            : queryable.AsQueryable().OrderByDescending(OrderByExpression<T, Double?>(c.Data));
                    }
                        break;
                    case "System.Nullable<Guid>":
                    {
                        queryable = p.Dir == "asc"
                            ? queryable.OrderBy(OrderByExpression<T, Nullable<Guid>>(c.Data))
                            : queryable.AsQueryable().OrderByDescending(OrderByExpression<T, Guid?>(c.Data));
                    }
                        break;
                    case "System.Guid":
                    {
                        queryable = p.Dir == "asc"
                            ? queryable.OrderBy(OrderByExpression<T, Guid>(c.Data))
                            : queryable.AsQueryable().OrderByDescending(OrderByExpression<T, Guid>(c.Data));
                    }
                        break;
                }
            }

            #endregion
            result.draw = dtParams.Draw;
            result.length = dtParams.Length;
            result.data = queryable.AsQueryable().Skip(result.start).Take(result.length).ToList();
            result.recordsFiltered = queryable.Count();
            return result;
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="p">The p.</param>
        /// <param name="predicate">The predicate.</param>
        /// <param name="searchValue">The search value.</param>
        private void GetValue<T>(DatatablesColumn p, ExpressionStarter<T> predicate, string searchValue)
        {
           // PropertyInfo pi = typeof(T).GetProperty(p.Data);
            var exp = ContainsExpression<T>(searchValue, p.Data);
            predicate.Or(exp);
        }

        /// <summary>
        /// Parses the request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        private static DatatablesModel ParseRequest(HttpRequestBase request)
        {
            var form = request.QueryString;
            // Retrieve request data
            var draw = int.Parse(form["draw"]);
            var start = int.Parse(form["start"]);
            var length = int.Parse(form["length"]);
            var search = new DatatablesSearch
            {
                Value = form["search[value]"],
                Regx = Convert.ToBoolean(form["search[regex]"])
            };
            var o = 0;
            var orders = new List<DatatablesOrder>();
            while (!string.IsNullOrEmpty(form["order[" + o + "][column]"]))
            {
                orders.Add(new DatatablesOrder
                {
                    Column = int.Parse(form["order[" + o + "][column]"]),
                    Dir = form["order[" + o + "][dir]"]
                });
                o++;
            }
            var c = 0;
            var columns = new List<DatatablesColumn>();
            while (!string.IsNullOrEmpty(form["columns[" + c + "][data]"]))
            {
                columns.Add(new DatatablesColumn
                {
                    Data = form["columns[" + c + "][data]"],
                    Name = form["columns[" + c + "][name]"],
                    Orderable = Convert.ToBoolean(form["columns[" + c + "][orderable]"]),
                    Searchable = Convert.ToBoolean(form["columns[" + c + "][searchable]"]),
                    Search = new DatatablesSearch
                    {
                        Value = form["columns[" + c + "][search][value]"],
                        Regx = Convert.ToBoolean(form["columns[" + c + "][search][regex]"])
                    }
                });
                c++;
            }
            var result = new DatatablesModel
            {
                Draw = draw,
                Start = start,
                Length = length,
                Search = search,
                Orders = orders,
                Columns = columns
            };
            return result;
        }
        /// <summary>
        /// Determines whether the specified term contains expression.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="term">The term.</param>
        /// <param name="property">The property.</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public Expression<Func<T, bool>> ContainsExpression<T>(string term, string property)
        {

            PropertyInfo pi = typeof(T).GetProperty(property);
            ParameterExpression lhsParam = Expression.Parameter(typeof(T));
            Expression lhs = Expression.Property(lhsParam, pi ?? throw new InvalidOperationException());

            var rf = Expression.Constant(term);
            var tt = Expression.Call(lhs, "ToString", null);
            var bn2 = Expression.Call(tt, "Contains", null, rf);
            var lambda = Expression.Lambda<Func<T, bool>>(bn2, lhsParam);
            return lambda;
        }

        /// <summary>
        /// Operationses the expression.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="term">The term.</param>
        /// <param name="property">The property.</param>
        /// <param name="operation">The operation.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Expression<Func<T, bool>> OperationsExpression<T>(string term, string property, ExpressionType operation)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Orders  by expression.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <typeparam name="TTargetKey">The type of the target key.</typeparam>
        /// <param name="property">The property.</param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public Expression<Func<TSource, TTargetKey>> OrderByExpression<TSource, TTargetKey>(string property)
        { 
            PropertyInfo pi = typeof(TSource).GetProperty(property);
            ParameterExpression lhsParam = Expression.Parameter(typeof(TSource), "o");
            Expression orderBy = Expression.Property(lhsParam, pi ?? throw new InvalidOperationException());
            var orderByLambda = Expression.Lambda<Func<TSource, TTargetKey>>(orderBy, lhsParam);
            return orderByLambda;
        }
    }

    internal class DatatablesOrder
    {
        public int Column { get; set; }
        public string Dir { get; set; }
    }

    internal class DatatablesSearch
    {
        public string Value { get; set; }
        public bool Regx { get; set; }
    }

    internal class DatatablesModel
    {
        public int Draw { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }
        public DatatablesSearch Search { get; set; }
        public List<DatatablesOrder> Orders { get; set; }
        public List<DatatablesColumn> Columns { get; set; }
    }

    internal class DatatablesColumn

    {
        public string Data { get; set; }
        public string Name { get; set; }
        public bool Searchable { get; set; }
        public bool Orderable { get; set; }
        public DatatablesSearch Search { get; set; }
    }
}
