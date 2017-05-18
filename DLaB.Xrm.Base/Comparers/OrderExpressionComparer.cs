using System.Collections.Generic;
using DLaB.Common;
using Microsoft.Xrm.Sdk.Query;

namespace DLaB.Xrm.Comparers
{
    /// <summary>
    /// Comparer for OrderExpressions
    /// </summary>
#if DLAB_PUBLIC
    public class OrderExpressionComparer : IEqualityComparer<OrderExpression>
#else
    internal class OrderExpressionComparer : IEqualityComparer<OrderExpression>
#endif
    {
        private static IEqualityComparer<OrderExpression> Comparer { get; set; }

        static OrderExpressionComparer()
        {
            Comparer = ProjectionEqualityComparer<OrderExpression>.Create(o => new { o.AttributeName, o.OrderType });
        }
        /// <summary>
        /// Compares the two Order Expressions
        /// </summary>
        /// <param name="order1">The order1.</param>
        /// <param name="order2">The order2.</param>
        /// <returns></returns>
        public bool Equals(OrderExpression order1, OrderExpression order2)
        {
            return Comparer.Equals(order1, order2);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <param name="order">The order.</param>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public int GetHashCode(OrderExpression order)
        {
            order.ThrowIfNull("order");
            return Comparer.GetHashCode(order);
        }
    }
}
