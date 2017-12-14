using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using OAD.Data;

namespace OAD.Service
{
    public interface IOrderService
    {
        List<Orders> GetAllOrders();
        List<Orders> GetConditionalOrders(Expression<Func<Orders, bool>> predicate);
        Orders GetOrder(int id);
        Orders GetOrder(Expression<Func<Orders, bool>> predicate);
        bool Insert(Orders entity);
        bool Update(Orders entity);
        bool Delete(Orders entity);
    }
}
