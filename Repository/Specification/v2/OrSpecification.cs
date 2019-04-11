﻿using System;
using System.Linq.Expressions;
using Specification.Utils;

namespace Specification.v2
{
    public class OrSpecification<T> : Specification<T>
    {
        private Specification<T> leftSpecification;
        private Specification<T> rightSpecification;
        public OrSpecification(Specification<T> leftSpecification, Specification<T> rightSpecification)
        {
            this.leftSpecification = leftSpecification;
            this.rightSpecification = rightSpecification;
        }
        public override Expression<Func<T, bool>> ToExpression()
        {
            var leftExpression = leftSpecification.ToExpression();
            var rightExpression = rightSpecification.ToExpression();
            var paramExpr = Expression.Parameter(typeof(T));
            var exprBody = Expression.OrElse(leftExpression.Body, rightExpression.Body);
            exprBody = (BinaryExpression)new ParameterReplacer(paramExpr).Visit(exprBody);
            var finalExpr = Expression.Lambda<Func<T, bool>>(exprBody, paramExpr);

            return finalExpr;
        }
    }
}