﻿using Expressive.Expressions;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Expressive
{
    public sealed class Expression
    {
        #region Fields

        private IExpression _compiledExpression;
        private ExpressiveOptions _options;
        private string _originalExpression;
        private ExpressionParser _parser;

        #endregion

        #region Properties

        /// <summary>
        /// Gets a list of the Variable names that are contained within this Expression.
        /// </summary>
        public string[] Variables { get; private set; }

        #endregion

        #region Constructors

        public Expression(string expression) : this (expression, ExpressiveOptions.None)
        {
        }

        public Expression(string expression, ExpressiveOptions options)
        {
            _originalExpression = expression;
            _options = options;
        }

        #endregion

        #region Public Methods

        public object Evaluate()
        {
            return Evaluate(null);
        }

        public object Evaluate(IDictionary<string, object> parameters)
        {
            object result = null;

            if (_parser == null)
            {
                _parser = new ExpressionParser(_options);
            }

            // Cache the expression to save us having to recompile.
            if (_compiledExpression == null ||
                _options.HasFlag(ExpressiveOptions.NoCache))
            {
                var variables = new List<string>();

                _compiledExpression = _parser.CompileExpression(_originalExpression, variables);

                this.Variables = variables.ToArray();
            }
            
            if (parameters != null &&
                _options.HasFlag(ExpressiveOptions.IgnoreCase))
            {
                parameters = new Dictionary<string, object>(parameters, StringComparer.OrdinalIgnoreCase);
            }

            result = _compiledExpression.Evaluate(parameters);

            return result;
        }

        public void EvaluateAsync(Action<object> callback)
        {
            EvaluateAsync(callback, null);
        }

        public void EvaluateAsync(Action<object> callback, IDictionary<string, object> parameters)
        {
            if (callback == null)
            {
                throw new ArgumentNullException("callback");
            }

            ThreadPool.QueueUserWorkItem((o) =>
            {
                var result = this.Evaluate(parameters);

                if (callback != null)
                {
                    callback(result);
                }
            });
        }

        #endregion
    }
}