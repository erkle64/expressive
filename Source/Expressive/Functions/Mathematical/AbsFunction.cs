﻿using Expressive.Expressions;
using Expressive.Helpers;
using System;

namespace Expressive.Functions.Mathematical
{
    internal class AbsFunction : FunctionBase
    {
        #region IFunction Members

        public override string Name { get { return "Abs"; } }

        public override object Evaluate(IExpression[] parameters, Context context)
        {
            this.ValidateParameterCount(parameters, 1, 1);

            var value = parameters[0].Evaluate(Variables);

            if (value != null)
            {
                var valueType = TypeHelper.GetTypeCode(value);

                switch (valueType)
                {
                    case TypeCode.Decimal:
                        return (decimal)Math.Abs((double)Convert.ToDecimal(value, System.Globalization.CultureInfo.InvariantCulture));
                    case TypeCode.Double:
                        return Math.Abs(Convert.ToDouble(value, System.Globalization.CultureInfo.InvariantCulture));
                    case TypeCode.Int16:
                        return Math.Abs(Convert.ToInt16(value, System.Globalization.CultureInfo.InvariantCulture));
                    case TypeCode.UInt16:
                        return Math.Abs(Convert.ToUInt16(value, System.Globalization.CultureInfo.InvariantCulture));
                    case TypeCode.Int32:
                        return Math.Abs(Convert.ToInt32(value, System.Globalization.CultureInfo.InvariantCulture));
                    case TypeCode.UInt32:
                        return Math.Abs(Convert.ToUInt32(value, System.Globalization.CultureInfo.InvariantCulture));
                    case TypeCode.Int64:
                        return Math.Abs(Convert.ToInt64(value, System.Globalization.CultureInfo.InvariantCulture));
                    case TypeCode.SByte:
                        return Math.Abs(Convert.ToSByte(value, System.Globalization.CultureInfo.InvariantCulture));
                    case TypeCode.Single:
                        return Math.Abs(Convert.ToSingle(value, System.Globalization.CultureInfo.InvariantCulture));
                    default:
                        break;
                }
            }

            return null;
        }

        #endregion
    }
}
