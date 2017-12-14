using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using OAD.Data;
using OAD.Repo;

namespace OAD.Service
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Orders> _orderRepository;

        public OrderService(IRepository<Orders> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Orders> GetAllOrders()
        {
            return _orderRepository.GetAll();
        }

        public List<Orders> GetConditionalOrders(Expression<Func<Orders, bool>> predicate)
        {
            return _orderRepository.GetConditionalEntities(predicate);
        }

        public Orders GetOrder(int id)
        {
            return _orderRepository.Get(id);
        }

        public Orders GetOrder(Expression<Func<Orders, bool>> predicate)
        {
            return _orderRepository.Get(predicate);
        }

        public bool Insert(Orders entity)
        {
            return _orderRepository.Insert(entity);
        }

        public bool Update(Orders entity)
        {
            return _orderRepository.Update(entity);
        }

        public bool Delete(Orders entity)
        {
            return _orderRepository.Delete(entity);
        }
    }
}
