﻿using Expressive.Expressions;
using System;

namespace Expressive.Functions
{
    internal class ExpFunction : FunctionBase
    {
        #region FunctionBase Members

        public override string Name { get { return "Exp"; } }

        public override object Evaluate(IExpression[] participants)
        {
            this.ValidateParameterCount(participants, 1, 1);

            return Math.Exp(Convert.ToDouble(participants[0].Evaluate(Arguments)));
        }

        #endregion
    }
}