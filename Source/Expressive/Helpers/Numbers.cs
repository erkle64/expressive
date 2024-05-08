﻿using System;

namespace Expressive.Helpers
{
    /// <summary>
    /// Helper class for performing number operations.
    /// </summary>
    public static class Numbers
    {
        private static object ConvertIfString(object s)
        {
            if (s is String || s is char)
            {
                return Decimal.Parse(s.ToString(), System.Globalization.CultureInfo.InvariantCulture);
            }

            return s;
        }

        /// <summary>
        /// Adds the specified <paramref name="a"/> value to the specified <paramref name="b"/>.
        /// </summary>
        /// <param name="a">The first value.</param>
        /// <param name="b">The second value.</param>
        /// <returns>The result of <paramref name="a"/> + <paramref name="b"/></returns>
        public static object Add(object a, object b)
        {
            if (a is null || b is null)
            {
                return null;
            }

            a = ConvertIfString(a);
            b = ConvertIfString(b);

            if (a is double && double.IsNaN((double)a))
            {
                return a;
            }
            if (b is double && double.IsNaN((double)b))
            {
                return b;
            }

            TypeCode typeCodeA = TypeHelper.GetTypeCode(a);
            TypeCode typeCodeB = TypeHelper.GetTypeCode(b);

            switch (typeCodeA)
            {
                case TypeCode.Boolean:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'bool' and 'bool'");
                        case TypeCode.Byte: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.SByte: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.Int16: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.UInt16: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.Int32: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.UInt32: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.Int64: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.Single: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.Double: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.Decimal: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'bool' and 'byte'");
                    }
                    break;
                case TypeCode.Byte:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'byte' and 'bool'");
                        case TypeCode.Byte: return (Byte)a + (Byte)b;
                        case TypeCode.SByte: return (Byte)a + (SByte)b;
                        case TypeCode.Int16: return (Byte)a + (Int16)b;
                        case TypeCode.UInt16: return (Byte)a + (UInt16)b;
                        case TypeCode.Int32: return (Byte)a + (Int32)b;
                        case TypeCode.UInt32: return (Byte)a + (UInt32)b;
                        case TypeCode.Int64: return (Byte)a + (Int64)b;
                        case TypeCode.UInt64: return (Byte)a + (UInt64)b;
                        case TypeCode.Single: return (Byte)a + (Single)b;
                        case TypeCode.Double: return (Byte)a + (Double)b;
                        case TypeCode.Decimal: return (Byte)a + (Decimal)b;
                    }
                    break;
                case TypeCode.SByte:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'sbyte' and 'bool'");
                        case TypeCode.Byte: return (SByte)a + (Byte)b;
                        case TypeCode.SByte: return (SByte)a + (SByte)b;
                        case TypeCode.Int16: return (SByte)a + (Int16)b;
                        case TypeCode.UInt16: return (SByte)a + (UInt16)b;
                        case TypeCode.Int32: return (SByte)a + (Int32)b;
                        case TypeCode.UInt32: return (SByte)a + (UInt32)b;
                        case TypeCode.Int64: return (SByte)a + (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'sbyte' and 'ulong'");
                        case TypeCode.Single: return (SByte)a + (Single)b;
                        case TypeCode.Double: return (SByte)a + (Double)b;
                        case TypeCode.Decimal: return (SByte)a + (Decimal)b;
                    }
                    break;

                case TypeCode.Int16:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'short' and 'bool'");
                        case TypeCode.Byte: return (Int16)a + (Byte)b;
                        case TypeCode.SByte: return (Int16)a + (SByte)b;
                        case TypeCode.Int16: return (Int16)a + (Int16)b;
                        case TypeCode.UInt16: return (Int16)a + (UInt16)b;
                        case TypeCode.Int32: return (Int16)a + (Int32)b;
                        case TypeCode.UInt32: return (Int16)a + (UInt32)b;
                        case TypeCode.Int64: return (Int16)a + (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'short' and 'ulong'");
                        case TypeCode.Single: return (Int16)a + (Single)b;
                        case TypeCode.Double: return (Int16)a + (Double)b;
                        case TypeCode.Decimal: return (Int16)a + (Decimal)b;
                    }
                    break;

                case TypeCode.UInt16:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'ushort' and 'bool'");
                        case TypeCode.Byte: return (UInt16)a + (Byte)b;
                        case TypeCode.SByte: return (UInt16)a + (SByte)b;
                        case TypeCode.Int16: return (UInt16)a + (Int16)b;
                        case TypeCode.UInt16: return (UInt16)a + (UInt16)b;
                        case TypeCode.Int32: return (UInt16)a + (Int32)b;
                        case TypeCode.UInt32: return (UInt16)a + (UInt32)b;
                        case TypeCode.Int64: return (UInt16)a + (Int64)b;
                        case TypeCode.UInt64: return (UInt16)a + (UInt64)b;
                        case TypeCode.Single: return (UInt16)a + (Single)b;
                        case TypeCode.Double: return (UInt16)a + (Double)b;
                        case TypeCode.Decimal: return (UInt16)a + (Decimal)b;
                    }
                    break;

                case TypeCode.Int32:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'int' and 'bool'");
                        case TypeCode.Byte: return (Int32)a + (Byte)b;
                        case TypeCode.SByte: return (Int32)a + (SByte)b;
                        case TypeCode.Int16: return (Int32)a + (Int16)b;
                        case TypeCode.UInt16: return (Int32)a + (UInt16)b;
                        case TypeCode.Int32: return (Int32)a + (Int32)b;
                        case TypeCode.UInt32: return (Int32)a + (UInt32)b;
                        case TypeCode.Int64: return (Int32)a + (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'int' and 'ulong'");
                        case TypeCode.Single: return (Int32)a + (Single)b;
                        case TypeCode.Double: return (Int32)a + (Double)b;
                        case TypeCode.Decimal: return (Int32)a + (Decimal)b;
                    }
                    break;

                case TypeCode.UInt32:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'unit' and 'bool'");
                        case TypeCode.Byte: return (UInt32)a + (Byte)b;
                        case TypeCode.SByte: return (UInt32)a + (SByte)b;
                        case TypeCode.Int16: return (UInt32)a + (Int16)b;
                        case TypeCode.UInt16: return (UInt32)a + (UInt16)b;
                        case TypeCode.Int32: return (UInt32)a + (Int32)b;
                        case TypeCode.UInt32: return (UInt32)a + (UInt32)b;
                        case TypeCode.Int64: return (UInt32)a + (Int64)b;
                        case TypeCode.UInt64: return (UInt32)a + (UInt64)b;
                        case TypeCode.Single: return (UInt32)a + (Single)b;
                        case TypeCode.Double: return (UInt32)a + (Double)b;
                        case TypeCode.Decimal: return (UInt32)a + (Decimal)b;
                    }
                    break;

                case TypeCode.Int64:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'long' and 'bool'");
                        case TypeCode.Byte: return (Int64)a + (Byte)b;
                        case TypeCode.SByte: return (Int64)a + (SByte)b;
                        case TypeCode.Int16: return (Int64)a + (Int16)b;
                        case TypeCode.UInt16: return (Int64)a + (UInt16)b;
                        case TypeCode.Int32: return (Int64)a + (Int32)b;
                        case TypeCode.UInt32: return (Int64)a + (UInt32)b;
                        case TypeCode.Int64: return (Int64)a + (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'long' and 'ulong'");
                        case TypeCode.Single: return (Int64)a + (Single)b;
                        case TypeCode.Double: return (Int64)a + (Double)b;
                        case TypeCode.Decimal: return (Int64)a + (Decimal)b;
                    }
                    break;

                case TypeCode.UInt64:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'ulong' and 'bool'");
                        case TypeCode.Byte: return (UInt64)a + (Byte)b;
                        case TypeCode.SByte: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'ulong' and 'sbyte'");
                        case TypeCode.Int16: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'ulong' and 'short'");
                        case TypeCode.UInt16: return (UInt64)a + (UInt16)b;
                        case TypeCode.Int32: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'ulong' and 'int'");
                        case TypeCode.UInt32: return (UInt64)a + (UInt32)b;
                        case TypeCode.Int64: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'ulong' and 'long'");
                        case TypeCode.UInt64: return (UInt64)a + (UInt64)b;
                        case TypeCode.Single: return (UInt64)a + (Single)b;
                        case TypeCode.Double: return (UInt64)a + (Double)b;
                        case TypeCode.Decimal: return (UInt64)a + (Decimal)b;
                    }
                    break;

                case TypeCode.Single:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'float' and 'bool'");
                        case TypeCode.Byte: return (Single)a + (Byte)b;
                        case TypeCode.SByte: return (Single)a + (SByte)b;
                        case TypeCode.Int16: return (Single)a + (Int16)b;
                        case TypeCode.UInt16: return (Single)a + (UInt16)b;
                        case TypeCode.Int32: return (Single)a + (Int32)b;
                        case TypeCode.UInt32: return (Single)a + (UInt32)b;
                        case TypeCode.Int64: return (Single)a + (Int64)b;
                        case TypeCode.UInt64: return (Single)a + (UInt64)b;
                        case TypeCode.Single: return (Single)a + (Single)b;
                        case TypeCode.Double: return (Single)a + (Double)b;
                        case TypeCode.Decimal: return Convert.ToDecimal(a, System.Globalization.CultureInfo.InvariantCulture) + (Decimal)b;
                    }
                    break;

                case TypeCode.Double:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'double' and 'bool'");
                        case TypeCode.Byte: return (Double)a + (Byte)b;
                        case TypeCode.SByte: return (Double)a + (SByte)b;
                        case TypeCode.Int16: return (Double)a + (Int16)b;
                        case TypeCode.UInt16: return (Double)a + (UInt16)b;
                        case TypeCode.Int32: return (Double)a + (Int32)b;
                        case TypeCode.UInt32: return (Double)a + (UInt32)b;
                        case TypeCode.Int64: return (Double)a + (Int64)b;
                        case TypeCode.UInt64: return (Double)a + (UInt64)b;
                        case TypeCode.Single: return (Double)a + (Single)b;
                        case TypeCode.Double: return (Double)a + (Double)b;
                        case TypeCode.Decimal: return Convert.ToDecimal(a, System.Globalization.CultureInfo.InvariantCulture) + (Decimal)b;
                    }
                    break;

                case TypeCode.Decimal:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '+' can't be applied to operands of types 'decimal' and 'bool'");
                        case TypeCode.Byte: return (Decimal)a + (Byte)b;
                        case TypeCode.SByte: return (Decimal)a + (SByte)b;
                        case TypeCode.Int16: return (Decimal)a + (Int16)b;
                        case TypeCode.UInt16: return (Decimal)a + (UInt16)b;
                        case TypeCode.Int32: return (Decimal)a + (Int32)b;
                        case TypeCode.UInt32: return (Decimal)a + (UInt32)b;
                        case TypeCode.Int64: return (Decimal)a + (Int64)b;
                        case TypeCode.UInt64: return (Decimal)a + (UInt64)b;
                        case TypeCode.Single: return (Decimal)a + Convert.ToDecimal(b, System.Globalization.CultureInfo.InvariantCulture);
                        case TypeCode.Double: return (Decimal)a + Convert.ToDecimal(b, System.Globalization.CultureInfo.InvariantCulture);
                        case TypeCode.Decimal: return (Decimal)a + (Decimal)b;
                    }
                    break;
            }

            return null;
        }

        /// <summary>
        /// Divides the specified <paramref name="a"/> value by the specified <paramref name="b"/> value.
        /// </summary>
        /// <param name="a">The first value.</param>
        /// <param name="b">The second value.</param>
        /// <returns>The result of <paramref name="a"/> / <paramref name="b"/>.</returns>
        public static object Divide(object a, object b)
        {
            if (a is null || b is null)
            {
                return null;
            }

            a = ConvertIfString(a);
            b = ConvertIfString(b);

            if (a is double && double.IsNaN((double)a))
            {
                return a;
            }
            if (b is double && double.IsNaN((double)b))
            {
                return b;
            }

            TypeCode typeCodeA = TypeHelper.GetTypeCode(a);
            TypeCode typeCodeB = TypeHelper.GetTypeCode(b);

            switch (typeCodeA)
            {
                case TypeCode.Byte:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'byte' and 'bool'");
                        case TypeCode.SByte: return (Byte)a / (SByte)b;
                        case TypeCode.Int16: return (Byte)a / (Int16)b;
                        case TypeCode.UInt16: return (Byte)a / (UInt16)b;
                        case TypeCode.Int32: return (Byte)a / (Int32)b;
                        case TypeCode.UInt32: return (Byte)a / (UInt32)b;
                        case TypeCode.Int64: return (Byte)a / (Int64)b;
                        case TypeCode.UInt64: return (Byte)a / (UInt64)b;
                        case TypeCode.Single: return (Byte)a / (Single)b;
                        case TypeCode.Double: return (Byte)a / (Double)b;
                        case TypeCode.Decimal: return (Byte)a / (Decimal)b;
                    }
                    break;
                case TypeCode.SByte:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'sbyte' and 'bool'");
                        case TypeCode.SByte: return (SByte)a / (SByte)b;
                        case TypeCode.Int16: return (SByte)a / (Int16)b;
                        case TypeCode.UInt16: return (SByte)a / (UInt16)b;
                        case TypeCode.Int32: return (SByte)a / (Int32)b;
                        case TypeCode.UInt32: return (SByte)a / (UInt32)b;
                        case TypeCode.Int64: return (SByte)a / (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'sbyte' and 'ulong'");
                        case TypeCode.Single: return (SByte)a / (Single)b;
                        case TypeCode.Double: return (SByte)a / (Double)b;
                        case TypeCode.Decimal: return (SByte)a / (Decimal)b;
                    }
                    break;

                case TypeCode.Int16:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'short' and 'bool'");
                        case TypeCode.SByte: return (Int16)a / (SByte)b;
                        case TypeCode.Int16: return (Int16)a / (Int16)b;
                        case TypeCode.UInt16: return (Int16)a / (UInt16)b;
                        case TypeCode.Int32: return (Int16)a / (Int32)b;
                        case TypeCode.UInt32: return (Int16)a / (UInt32)b;
                        case TypeCode.Int64: return (Int16)a / (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'short' and 'ulong'");
                        case TypeCode.Single: return (Int16)a / (Single)b;
                        case TypeCode.Double: return (Int16)a / (Double)b;
                        case TypeCode.Decimal: return (Int16)a / (Decimal)b;
                    }
                    break;

                case TypeCode.UInt16:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'ushort' and 'bool'");
                        case TypeCode.SByte: return (UInt16)a / (SByte)b;
                        case TypeCode.Int16: return (UInt16)a / (Int16)b;
                        case TypeCode.UInt16: return (UInt16)a / (UInt16)b;
                        case TypeCode.Int32: return (UInt16)a / (Int32)b;
                        case TypeCode.UInt32: return (UInt16)a / (UInt32)b;
                        case TypeCode.Int64: return (UInt16)a / (Int64)b;
                        case TypeCode.UInt64: return (UInt16)a / (UInt64)b;
                        case TypeCode.Single: return (UInt16)a / (Single)b;
                        case TypeCode.Double: return (UInt16)a / (Double)b;
                        case TypeCode.Decimal: return (UInt16)a / (Decimal)b;
                    }
                    break;

                case TypeCode.Int32:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'int' and 'bool'");
                        case TypeCode.SByte: return (Int32)a / (SByte)b;
                        case TypeCode.Int16: return (Int32)a / (Int16)b;
                        case TypeCode.UInt16: return (Int32)a / (UInt16)b;
                        case TypeCode.Int32: return (Int32)a / (Int32)b;
                        case TypeCode.UInt32: return (Int32)a / (UInt32)b;
                        case TypeCode.Int64: return (Int32)a / (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'int' and 'ulong'");
                        case TypeCode.Single: return (Int32)a / (Single)b;
                        case TypeCode.Double: return (Int32)a / (Double)b;
                        case TypeCode.Decimal: return (Int32)a / (Decimal)b;
                    }
                    break;

                case TypeCode.UInt32:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'uint' and 'bool'");
                        case TypeCode.SByte: return (UInt32)a / (SByte)b;
                        case TypeCode.Int16: return (UInt32)a / (Int16)b;
                        case TypeCode.UInt16: return (UInt32)a / (UInt16)b;
                        case TypeCode.Int32: return (UInt32)a / (Int32)b;
                        case TypeCode.UInt32: return (UInt32)a / (UInt32)b;
                        case TypeCode.Int64: return (UInt32)a / (Int64)b;
                        case TypeCode.UInt64: return (UInt32)a / (UInt64)b;
                        case TypeCode.Single: return (UInt32)a / (Single)b;
                        case TypeCode.Double: return (UInt32)a / (Double)b;
                        case TypeCode.Decimal: return (UInt32)a / (Decimal)b;
                    }
                    break;

                case TypeCode.Int64:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'long' and 'bool'");
                        case TypeCode.SByte: return (Int64)a / (SByte)b;
                        case TypeCode.Int16: return (Int64)a / (Int16)b;
                        case TypeCode.UInt16: return (Int64)a / (UInt16)b;
                        case TypeCode.Int32: return (Int64)a / (Int32)b;
                        case TypeCode.UInt32: return (Int64)a / (UInt32)b;
                        case TypeCode.Int64: return (Int64)a / (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'long' and 'ulong'");
                        case TypeCode.Single: return (Int64)a / (Single)b;
                        case TypeCode.Double: return (Int64)a / (Double)b;
                        case TypeCode.Decimal: return (Int64)a / (Decimal)b;
                    }
                    break;

                case TypeCode.UInt64:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'ulong' and 'bool'");
                        case TypeCode.SByte: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'ulong' and 'sbyte'");
                        case TypeCode.Int16: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'ulong' and 'short'");
                        case TypeCode.UInt16: return (UInt64)a / (UInt16)b;
                        case TypeCode.Int32: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'ulong' and 'int'");
                        case TypeCode.UInt32: return (UInt64)a / (UInt32)b;
                        case TypeCode.Int64: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'ulong' and 'long'");
                        case TypeCode.UInt64: return (UInt64)a / (UInt64)b;
                        case TypeCode.Single: return (UInt64)a / (Single)b;
                        case TypeCode.Double: return (UInt64)a / (Double)b;
                        case TypeCode.Decimal: return (UInt64)a / (Decimal)b;
                    }
                    break;

                case TypeCode.Single:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'float' and 'bool'");
                        case TypeCode.SByte: return (Single)a / (SByte)b;
                        case TypeCode.Int16: return (Single)a / (Int16)b;
                        case TypeCode.UInt16: return (Single)a / (UInt16)b;
                        case TypeCode.Int32: return (Single)a / (Int32)b;
                        case TypeCode.UInt32: return (Single)a / (UInt32)b;
                        case TypeCode.Int64: return (Single)a / (Int64)b;
                        case TypeCode.UInt64: return (Single)a / (UInt64)b;
                        case TypeCode.Single: return (Single)a / (Single)b;
                        case TypeCode.Double: return (Single)a / (Double)b;
                        case TypeCode.Decimal: return Convert.ToDecimal(a, System.Globalization.CultureInfo.InvariantCulture) / (Decimal)b;
                    }
                    break;

                case TypeCode.Double:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'double' and 'bool'");
                        case TypeCode.SByte: return (Double)a / (SByte)b;
                        case TypeCode.Int16: return (Double)a / (Int16)b;
                        case TypeCode.UInt16: return (Double)a / (UInt16)b;
                        case TypeCode.Int32: return (Double)a / (Int32)b;
                        case TypeCode.UInt32: return (Double)a / (UInt32)b;
                        case TypeCode.Int64: return (Double)a / (Int64)b;
                        case TypeCode.UInt64: return (Double)a / (UInt64)b;
                        case TypeCode.Single: return (Double)a / (Single)b;
                        case TypeCode.Double: return (Double)a / (Double)b;
                        case TypeCode.Decimal: return Convert.ToDecimal(a, System.Globalization.CultureInfo.InvariantCulture) / (Decimal)b;
                    }
                    break;

                case TypeCode.Decimal:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '/' can't be applied to operands of types 'decimal' and 'bool'");
                        case TypeCode.SByte: return (Decimal)a / (SByte)b;
                        case TypeCode.Int16: return (Decimal)a / (Int16)b;
                        case TypeCode.UInt16: return (Decimal)a / (UInt16)b;
                        case TypeCode.Int32: return (Decimal)a / (Int32)b;
                        case TypeCode.UInt32: return (Decimal)a / (UInt32)b;
                        case TypeCode.Int64: return (Decimal)a / (Int64)b;
                        case TypeCode.UInt64: return (Decimal)a / (UInt64)b;
                        case TypeCode.Single: return (Decimal)a / Convert.ToDecimal(b, System.Globalization.CultureInfo.InvariantCulture);
                        case TypeCode.Double: return (Decimal)a / Convert.ToDecimal(b, System.Globalization.CultureInfo.InvariantCulture);
                        case TypeCode.Decimal: return (Decimal)a / (Decimal)b;
                    }
                    break;
            }

            return null;
        }

        /// <summary>
        /// Multiplies the specified <paramref name="a"/> value by the specified <paramref name="b"/> value.
        /// </summary>
        /// <param name="a">The first value.</param>
        /// <param name="b">The second value.</param>
        /// <returns>The result of <paramref name="a"/> * <paramref name="b"/>.</returns>
        public static object Multiply(object a, object b)
        {
            if (a is null || b is null)
            {
                return null;
            }

            a = ConvertIfString(a);
            b = ConvertIfString(b);

            if (a is double && double.IsNaN((double)a))
            {
                return a;
            }
            if (b is double && double.IsNaN((double)b))
            {
                return b;
            }

            TypeCode typeCodeA = TypeHelper.GetTypeCode(a);
            TypeCode typeCodeB = TypeHelper.GetTypeCode(b);

            switch (typeCodeA)
            {
                case TypeCode.Byte:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'byte' and 'bool'");
                        case TypeCode.SByte: return (Byte)a * (SByte)b;
                        case TypeCode.Int16: return (Byte)a * (Int16)b;
                        case TypeCode.UInt16: return (Byte)a * (UInt16)b;
                        case TypeCode.Int32: return (Byte)a * (Int32)b;
                        case TypeCode.UInt32: return (Byte)a * (UInt32)b;
                        case TypeCode.Int64: return (Byte)a * (Int64)b;
                        case TypeCode.UInt64: return (Byte)a * (UInt64)b;
                        case TypeCode.Single: return (Byte)a * (Single)b;
                        case TypeCode.Double: return (Byte)a * (Double)b;
                        case TypeCode.Decimal: return (Byte)a * (Decimal)b;
                    }
                    break;
                case TypeCode.SByte:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'sbyte' and 'bool'");
                        case TypeCode.SByte: return (SByte)a * (SByte)b;
                        case TypeCode.Int16: return (SByte)a * (Int16)b;
                        case TypeCode.UInt16: return (SByte)a * (UInt16)b;
                        case TypeCode.Int32: return (SByte)a * (Int32)b;
                        case TypeCode.UInt32: return (SByte)a * (UInt32)b;
                        case TypeCode.Int64: return (SByte)a * (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'sbyte' and 'ulong'");
                        case TypeCode.Single: return (SByte)a * (Single)b;
                        case TypeCode.Double: return (SByte)a * (Double)b;
                        case TypeCode.Decimal: return (SByte)a * (Decimal)b;
                    }
                    break;

                case TypeCode.Int16:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'short' and 'bool'");
                        case TypeCode.SByte: return (Int16)a * (SByte)b;
                        case TypeCode.Int16: return (Int16)a * (Int16)b;
                        case TypeCode.UInt16: return (Int16)a * (UInt16)b;
                        case TypeCode.Int32: return (Int16)a * (Int32)b;
                        case TypeCode.UInt32: return (Int16)a * (UInt32)b;
                        case TypeCode.Int64: return (Int16)a * (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'short' and 'ulong'");
                        case TypeCode.Single: return (Int16)a * (Single)b;
                        case TypeCode.Double: return (Int16)a * (Double)b;
                        case TypeCode.Decimal: return (Int16)a * (Decimal)b;
                    }
                    break;

                case TypeCode.UInt16:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'ushort' and 'bool'");
                        case TypeCode.SByte: return (UInt16)a * (SByte)b;
                        case TypeCode.Int16: return (UInt16)a * (Int16)b;
                        case TypeCode.UInt16: return (UInt16)a * (UInt16)b;
                        case TypeCode.Int32: return (UInt16)a * (Int32)b;
                        case TypeCode.UInt32: return (UInt16)a * (UInt32)b;
                        case TypeCode.Int64: return (UInt16)a * (Int64)b;
                        case TypeCode.UInt64: return (UInt16)a * (UInt64)b;
                        case TypeCode.Single: return (UInt16)a * (Single)b;
                        case TypeCode.Double: return (UInt16)a * (Double)b;
                        case TypeCode.Decimal: return (UInt16)a * (Decimal)b;
                    }
                    break;

                case TypeCode.Int32:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'int' and 'bool'");
                        case TypeCode.SByte: return (Int32)a * (SByte)b;
                        case TypeCode.Int16: return (Int32)a * (Int16)b;
                        case TypeCode.UInt16: return (Int32)a * (UInt16)b;
                        case TypeCode.Int32: return (Int32)a * (Int32)b;
                        case TypeCode.UInt32: return (Int32)a * (UInt32)b;
                        case TypeCode.Int64: return (Int32)a * (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'int' and 'ulong'");
                        case TypeCode.Single: return (Int32)a * (Single)b;
                        case TypeCode.Double: return (Int32)a * (Double)b;
                        case TypeCode.Decimal: return (Int32)a * (Decimal)b;
                    }
                    break;

                case TypeCode.UInt32:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'uint' and 'bool'");
                        case TypeCode.SByte: return (UInt32)a * (SByte)b;
                        case TypeCode.Int16: return (UInt32)a * (Int16)b;
                        case TypeCode.UInt16: return (UInt32)a * (UInt16)b;
                        case TypeCode.Int32: return (UInt32)a * (Int32)b;
                        case TypeCode.UInt32: return (UInt32)a * (UInt32)b;
                        case TypeCode.Int64: return (UInt32)a * (Int64)b;
                        case TypeCode.UInt64: return (UInt32)a * (UInt64)b;
                        case TypeCode.Single: return (UInt32)a * (Single)b;
                        case TypeCode.Double: return (UInt32)a * (Double)b;
                        case TypeCode.Decimal: return (UInt32)a * (Decimal)b;
                    }
                    break;

                case TypeCode.Int64:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'long' and 'bool'");
                        case TypeCode.SByte: return (Int64)a * (SByte)b;
                        case TypeCode.Int16: return (Int64)a * (Int16)b;
                        case TypeCode.UInt16: return (Int64)a * (UInt16)b;
                        case TypeCode.Int32: return (Int64)a * (Int32)b;
                        case TypeCode.UInt32: return (Int64)a * (UInt32)b;
                        case TypeCode.Int64: return (Int64)a * (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'long' and 'ulong'");
                        case TypeCode.Single: return (Int64)a * (Single)b;
                        case TypeCode.Double: return (Int64)a * (Double)b;
                        case TypeCode.Decimal: return (Int64)a * (Decimal)b;
                    }
                    break;

                case TypeCode.UInt64:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'ulong' and 'bool'");
                        case TypeCode.SByte: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'ulong' and 'sbyte'");
                        case TypeCode.Int16: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'ulong' and 'short'");
                        case TypeCode.UInt16: return (UInt64)a * (UInt16)b;
                        case TypeCode.Int32: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'ulong' and 'int'");
                        case TypeCode.UInt32: return (UInt64)a * (UInt32)b;
                        case TypeCode.Int64: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'ulong' and 'long'");
                        case TypeCode.UInt64: return (UInt64)a * (UInt64)b;
                        case TypeCode.Single: return (UInt64)a * (Single)b;
                        case TypeCode.Double: return (UInt64)a * (Double)b;
                        case TypeCode.Decimal: return (UInt64)a * (Decimal)b;
                    }
                    break;

                case TypeCode.Single:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'float' and 'bool'");
                        case TypeCode.SByte: return (Single)a * (SByte)b;
                        case TypeCode.Int16: return (Single)a * (Int16)b;
                        case TypeCode.UInt16: return (Single)a * (UInt16)b;
                        case TypeCode.Int32: return (Single)a * (Int32)b;
                        case TypeCode.UInt32: return (Single)a * (UInt32)b;
                        case TypeCode.Int64: return (Single)a * (Int64)b;
                        case TypeCode.UInt64: return (Single)a * (UInt64)b;
                        case TypeCode.Single: return (Single)a * (Single)b;
                        case TypeCode.Double: return (Single)a * (Double)b;
                        case TypeCode.Decimal: return Convert.ToDecimal(a, System.Globalization.CultureInfo.InvariantCulture) * (Decimal)b;
                    }
                    break;

                case TypeCode.Double:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'double' and 'bool'");
                        case TypeCode.SByte: return (Double)a * (SByte)b;
                        case TypeCode.Int16: return (Double)a * (Int16)b;
                        case TypeCode.UInt16: return (Double)a * (UInt16)b;
                        case TypeCode.Int32: return (Double)a * (Int32)b;
                        case TypeCode.UInt32: return (Double)a * (UInt32)b;
                        case TypeCode.Int64: return (Double)a * (Int64)b;
                        case TypeCode.UInt64: return (Double)a * (UInt64)b;
                        case TypeCode.Single: return (Double)a * (Single)b;
                        case TypeCode.Double: return (Double)a * (Double)b;
                        case TypeCode.Decimal: return Convert.ToDecimal(a, System.Globalization.CultureInfo.InvariantCulture) * (Decimal)b;
                    }
                    break;

                case TypeCode.Decimal:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '*' can't be applied to operands of types 'decimal' and 'bool'");
                        case TypeCode.SByte: return (Decimal)a * (SByte)b;
                        case TypeCode.Int16: return (Decimal)a * (Int16)b;
                        case TypeCode.UInt16: return (Decimal)a * (UInt16)b;
                        case TypeCode.Int32: return (Decimal)a * (Int32)b;
                        case TypeCode.UInt32: return (Decimal)a * (UInt32)b;
                        case TypeCode.Int64: return (Decimal)a * (Int64)b;
                        case TypeCode.UInt64: return (Decimal)a * (UInt64)b;
                        case TypeCode.Single: return (Decimal)a * Convert.ToDecimal(b, System.Globalization.CultureInfo.InvariantCulture);
                        case TypeCode.Double: return (Decimal)a * Convert.ToDecimal(b, System.Globalization.CultureInfo.InvariantCulture);
                        case TypeCode.Decimal: return (Decimal)a * (Decimal)b;
                    }
                    break;
            }

            return null;
        }

        /// <summary>
        /// Subtracts the specified <paramref name="b"/> value from the specified <paramref name="a"/>.
        /// </summary>
        /// <param name="a">The first value.</param>
        /// <param name="b">The second value.</param>
        /// <returns>The result of <paramref name="a"/> - <paramref name="b"/></returns>
        public static object Subtract(object a, object b)
        {
            if (a is null || b is null)
            {
                return null;
            }

            a = ConvertIfString(a);
            b = ConvertIfString(b);

            if (a is double && double.IsNaN((double)a))
            {
                return a;
            }
            if (b is double && double.IsNaN((double)b))
            {
                return b;
            }

            TypeCode typeCodeA = TypeHelper.GetTypeCode(a);
            TypeCode typeCodeB = TypeHelper.GetTypeCode(b);

            switch (typeCodeA)
            {
                case TypeCode.Boolean:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'bool' and 'bool'");
                        case TypeCode.Byte: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.SByte: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.Int16: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.UInt16: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.Int32: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.UInt32: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.Int64: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.Single: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.Double: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'bool' and 'byte'");
                        case TypeCode.Decimal: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'bool' and 'byte'");
                    }
                    break;
                case TypeCode.Byte:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'byte' and 'bool'");
                        case TypeCode.SByte: return (Byte)a - (SByte)b;
                        case TypeCode.Int16: return (Byte)a - (Int16)b;
                        case TypeCode.UInt16: return (Byte)a - (UInt16)b;
                        case TypeCode.Int32: return (Byte)a - (Int32)b;
                        case TypeCode.UInt32: return (Byte)a - (UInt32)b;
                        case TypeCode.Int64: return (Byte)a - (Int64)b;
                        case TypeCode.UInt64: return (Byte)a - (UInt64)b;
                        case TypeCode.Single: return (Byte)a - (Single)b;
                        case TypeCode.Double: return (Byte)a - (Double)b;
                        case TypeCode.Decimal: return (Byte)a - (Decimal)b;
                    }
                    break;
                case TypeCode.SByte:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'sbyte' and 'bool'");
                        case TypeCode.SByte: return (SByte)a - (SByte)b;
                        case TypeCode.Int16: return (SByte)a - (Int16)b;
                        case TypeCode.UInt16: return (SByte)a - (UInt16)b;
                        case TypeCode.Int32: return (SByte)a - (Int32)b;
                        case TypeCode.UInt32: return (SByte)a - (UInt32)b;
                        case TypeCode.Int64: return (SByte)a - (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'sbyte' and 'ulong'");
                        case TypeCode.Single: return (SByte)a - (Single)b;
                        case TypeCode.Double: return (SByte)a - (Double)b;
                        case TypeCode.Decimal: return (SByte)a - (Decimal)b;
                    }
                    break;

                case TypeCode.Int16:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'short' and 'bool'");
                        case TypeCode.SByte: return (Int16)a - (SByte)b;
                        case TypeCode.Int16: return (Int16)a - (Int16)b;
                        case TypeCode.UInt16: return (Int16)a - (UInt16)b;
                        case TypeCode.Int32: return (Int16)a - (Int32)b;
                        case TypeCode.UInt32: return (Int16)a - (UInt32)b;
                        case TypeCode.Int64: return (Int16)a - (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'short' and 'ulong'");
                        case TypeCode.Single: return (Int16)a - (Single)b;
                        case TypeCode.Double: return (Int16)a - (Double)b;
                        case TypeCode.Decimal: return (Int16)a - (Decimal)b;
                    }
                    break;

                case TypeCode.UInt16:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'ushort' and 'bool'");
                        case TypeCode.SByte: return (UInt16)a - (SByte)b;
                        case TypeCode.Int16: return (UInt16)a - (Int16)b;
                        case TypeCode.UInt16: return (UInt16)a - (UInt16)b;
                        case TypeCode.Int32: return (UInt16)a - (Int32)b;
                        case TypeCode.UInt32: return (UInt16)a - (UInt32)b;
                        case TypeCode.Int64: return (UInt16)a - (Int64)b;
                        case TypeCode.UInt64: return (UInt16)a - (UInt64)b;
                        case TypeCode.Single: return (UInt16)a - (Single)b;
                        case TypeCode.Double: return (UInt16)a - (Double)b;
                        case TypeCode.Decimal: return (UInt16)a - (Decimal)b;
                    }
                    break;

                case TypeCode.Int32:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'int' and 'bool'");
                        case TypeCode.SByte: return (Int32)a - (SByte)b;
                        case TypeCode.Int16: return (Int32)a - (Int16)b;
                        case TypeCode.UInt16: return (Int32)a - (UInt16)b;
                        case TypeCode.Int32: return (Int32)a - (Int32)b;
                        case TypeCode.UInt32: return (Int32)a - (UInt32)b;
                        case TypeCode.Int64: return (Int32)a - (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'int' and 'ulong'");
                        case TypeCode.Single: return (Int32)a - (Single)b;
                        case TypeCode.Double: return (Int32)a - (Double)b;
                        case TypeCode.Decimal: return (Int32)a - (Decimal)b;
                    }
                    break;

                case TypeCode.UInt32:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'uint' and 'bool'");
                        case TypeCode.SByte: return (UInt32)a - (SByte)b;
                        case TypeCode.Int16: return (UInt32)a - (Int16)b;
                        case TypeCode.UInt16: return (UInt32)a - (UInt16)b;
                        case TypeCode.Int32: return (UInt32)a - (Int32)b;
                        case TypeCode.UInt32: return (UInt32)a - (UInt32)b;
                        case TypeCode.Int64: return (UInt32)a - (Int64)b;
                        case TypeCode.UInt64: return (UInt32)a - (UInt64)b;
                        case TypeCode.Single: return (UInt32)a - (Single)b;
                        case TypeCode.Double: return (UInt32)a - (Double)b;
                        case TypeCode.Decimal: return (UInt32)a - (Decimal)b;
                    }
                    break;

                case TypeCode.Int64:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'long' and 'bool'");
                        case TypeCode.SByte: return (Int64)a - (SByte)b;
                        case TypeCode.Int16: return (Int64)a - (Int16)b;
                        case TypeCode.UInt16: return (Int64)a - (UInt16)b;
                        case TypeCode.Int32: return (Int64)a - (Int32)b;
                        case TypeCode.UInt32: return (Int64)a - (UInt32)b;
                        case TypeCode.Int64: return (Int64)a - (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'long' and 'ulong'");
                        case TypeCode.Single: return (Int64)a - (Single)b;
                        case TypeCode.Double: return (Int64)a - (Double)b;
                        case TypeCode.Decimal: return (Int64)a - (Decimal)b;
                    }
                    break;

                case TypeCode.UInt64:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'ulong' and 'bool'");
                        case TypeCode.SByte: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'ulong' and 'double'");
                        case TypeCode.Int16: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'ulong' and 'short'");
                        case TypeCode.UInt16: return (UInt64)a - (UInt16)b;
                        case TypeCode.Int32: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'ulong' and 'int'");
                        case TypeCode.UInt32: return (UInt64)a - (UInt32)b;
                        case TypeCode.Int64: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'ulong' and 'long'");
                        case TypeCode.UInt64: return (UInt64)a - (UInt64)b;
                        case TypeCode.Single: return (UInt64)a - (Single)b;
                        case TypeCode.Double: return (UInt64)a - (Double)b;
                        case TypeCode.Decimal: return (UInt64)a - (Decimal)b;
                    }
                    break;

                case TypeCode.Single:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'float' and 'bool'");
                        case TypeCode.SByte: return (Single)a - (SByte)b;
                        case TypeCode.Int16: return (Single)a - (Int16)b;
                        case TypeCode.UInt16: return (Single)a - (UInt16)b;
                        case TypeCode.Int32: return (Single)a - (Int32)b;
                        case TypeCode.UInt32: return (Single)a - (UInt32)b;
                        case TypeCode.Int64: return (Single)a - (Int64)b;
                        case TypeCode.UInt64: return (Single)a - (UInt64)b;
                        case TypeCode.Single: return (Single)a - (Single)b;
                        case TypeCode.Double: return (Single)a - (Double)b;
                        case TypeCode.Decimal: return Convert.ToDecimal(a, System.Globalization.CultureInfo.InvariantCulture) - (Decimal)b;
                    }
                    break;

                case TypeCode.Double:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'double' and 'bool'");
                        case TypeCode.SByte: return (Double)a - (SByte)b;
                        case TypeCode.Int16: return (Double)a - (Int16)b;
                        case TypeCode.UInt16: return (Double)a - (UInt16)b;
                        case TypeCode.Int32: return (Double)a - (Int32)b;
                        case TypeCode.UInt32: return (Double)a - (UInt32)b;
                        case TypeCode.Int64: return (Double)a - (Int64)b;
                        case TypeCode.UInt64: return (Double)a - (UInt64)b;
                        case TypeCode.Single: return (Double)a - (Single)b;
                        case TypeCode.Double: return (Double)a - (Double)b;
                        case TypeCode.Decimal: return Convert.ToDecimal(a, System.Globalization.CultureInfo.InvariantCulture) - (Decimal)b;
                    }
                    break;

                case TypeCode.Decimal:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '-' can't be applied to operands of types 'decimal' and 'bool'");
                        case TypeCode.SByte: return (Decimal)a - (SByte)b;
                        case TypeCode.Int16: return (Decimal)a - (Int16)b;
                        case TypeCode.UInt16: return (Decimal)a - (UInt16)b;
                        case TypeCode.Int32: return (Decimal)a - (Int32)b;
                        case TypeCode.UInt32: return (Decimal)a - (UInt32)b;
                        case TypeCode.Int64: return (Decimal)a - (Int64)b;
                        case TypeCode.UInt64: return (Decimal)a - (UInt64)b;
                        case TypeCode.Single: return (Decimal)a - Convert.ToDecimal(b, System.Globalization.CultureInfo.InvariantCulture);
                        case TypeCode.Double: return (Decimal)a - Convert.ToDecimal(b, System.Globalization.CultureInfo.InvariantCulture);
                        case TypeCode.Decimal: return (Decimal)a - (Decimal)b;
                    }
                    break;
            }

            return null;
        }

        /// <summary>
        /// Determines the remainder from the specified <paramref name="a"/> value and the specified <paramref name="b"/>.
        /// </summary>
        /// <param name="a">The first value.</param>
        /// <param name="b">The second value.</param>
        /// <returns>The result of <paramref name="a"/> % <paramref name="b"/></returns>
        public static object Modulus(object a, object b)
        {
            if (a is null || b is null)
            {
                return null;
            }

            a = ConvertIfString(a);
            b = ConvertIfString(b);

            if (a is double && double.IsNaN((double)a))
            {
                return a;
            }
            if (b is double && double.IsNaN((double)b))
            {
                return b;
            }

            TypeCode typeCodeA = TypeHelper.GetTypeCode(a);
            TypeCode typeCodeB = TypeHelper.GetTypeCode(b);

            switch (typeCodeA)
            {
                case TypeCode.Byte:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'byte' and 'bool'");
                        case TypeCode.SByte: return (Byte)a % (SByte)b;
                        case TypeCode.Int16: return (Byte)a % (Int16)b;
                        case TypeCode.UInt16: return (Byte)a % (UInt16)b;
                        case TypeCode.Int32: return (Byte)a % (Int32)b;
                        case TypeCode.UInt32: return (Byte)a % (UInt32)b;
                        case TypeCode.Int64: return (Byte)a % (Int64)b;
                        case TypeCode.UInt64: return (Byte)a % (UInt64)b;
                        case TypeCode.Single: return (Byte)a % (Single)b;
                        case TypeCode.Double: return (Byte)a % (Double)b;
                        case TypeCode.Decimal: return (Byte)a % (Decimal)b;
                    }
                    break;
                case TypeCode.SByte:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'sbyte' and 'bool'");
                        case TypeCode.SByte: return (SByte)a % (SByte)b;
                        case TypeCode.Int16: return (SByte)a % (Int16)b;
                        case TypeCode.UInt16: return (SByte)a % (UInt16)b;
                        case TypeCode.Int32: return (SByte)a % (Int32)b;
                        case TypeCode.UInt32: return (SByte)a % (UInt32)b;
                        case TypeCode.Int64: return (SByte)a % (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'sbyte' and 'ulong'");
                        case TypeCode.Single: return (SByte)a % (Single)b;
                        case TypeCode.Double: return (SByte)a % (Double)b;
                        case TypeCode.Decimal: return (SByte)a % (Decimal)b;
                    }
                    break;

                case TypeCode.Int16:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'short' and 'bool'");
                        case TypeCode.SByte: return (Int16)a % (SByte)b;
                        case TypeCode.Int16: return (Int16)a % (Int16)b;
                        case TypeCode.UInt16: return (Int16)a % (UInt16)b;
                        case TypeCode.Int32: return (Int16)a % (Int32)b;
                        case TypeCode.UInt32: return (Int16)a % (UInt32)b;
                        case TypeCode.Int64: return (Int16)a % (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'short' and 'ulong'");
                        case TypeCode.Single: return (Int16)a % (Single)b;
                        case TypeCode.Double: return (Int16)a % (Double)b;
                        case TypeCode.Decimal: return (Int16)a % (Decimal)b;
                    }
                    break;

                case TypeCode.UInt16:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'ushort' and 'bool'");
                        case TypeCode.SByte: return (UInt16)a % (SByte)b;
                        case TypeCode.Int16: return (UInt16)a % (Int16)b;
                        case TypeCode.UInt16: return (UInt16)a % (UInt16)b;
                        case TypeCode.Int32: return (UInt16)a % (Int32)b;
                        case TypeCode.UInt32: return (UInt16)a % (UInt32)b;
                        case TypeCode.Int64: return (UInt16)a % (Int64)b;
                        case TypeCode.UInt64: return (UInt16)a % (UInt64)b;
                        case TypeCode.Single: return (UInt16)a % (Single)b;
                        case TypeCode.Double: return (UInt16)a % (Double)b;
                        case TypeCode.Decimal: return (UInt16)a % (Decimal)b;
                    }
                    break;

                case TypeCode.Int32:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'int' and 'bool'");
                        case TypeCode.SByte: return (Int32)a % (SByte)b;
                        case TypeCode.Int16: return (Int32)a % (Int16)b;
                        case TypeCode.UInt16: return (Int32)a % (UInt16)b;
                        case TypeCode.Int32: return (Int32)a % (Int32)b;
                        case TypeCode.UInt32: return (Int32)a % (UInt32)b;
                        case TypeCode.Int64: return (Int32)a % (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'int' and 'ulong'");
                        case TypeCode.Single: return (Int32)a % (Single)b;
                        case TypeCode.Double: return (Int32)a % (Double)b;
                        case TypeCode.Decimal: return (Int32)a % (Decimal)b;
                    }
                    break;

                case TypeCode.UInt32:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'uint' and 'bool'");
                        case TypeCode.SByte: return (UInt32)a % (SByte)b;
                        case TypeCode.Int16: return (UInt32)a % (Int16)b;
                        case TypeCode.UInt16: return (UInt32)a % (UInt16)b;
                        case TypeCode.Int32: return (UInt32)a % (Int32)b;
                        case TypeCode.UInt32: return (UInt32)a % (UInt32)b;
                        case TypeCode.Int64: return (UInt32)a % (Int64)b;
                        case TypeCode.UInt64: return (UInt32)a % (UInt64)b;
                        case TypeCode.Single: return (UInt32)a % (Single)b;
                        case TypeCode.Double: return (UInt32)a % (Double)b;
                        case TypeCode.Decimal: return (UInt32)a % (Decimal)b;
                    }
                    break;

                case TypeCode.Int64:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'long' and 'bool'");
                        case TypeCode.SByte: return (Int64)a % (SByte)b;
                        case TypeCode.Int16: return (Int64)a % (Int16)b;
                        case TypeCode.UInt16: return (Int64)a % (UInt16)b;
                        case TypeCode.Int32: return (Int64)a % (Int32)b;
                        case TypeCode.UInt32: return (Int64)a % (UInt32)b;
                        case TypeCode.Int64: return (Int64)a % (Int64)b;
                        case TypeCode.UInt64: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'long' and 'ulong'");
                        case TypeCode.Single: return (Int64)a % (Single)b;
                        case TypeCode.Double: return (Int64)a % (Double)b;
                        case TypeCode.Decimal: return (Int64)a % (Decimal)b;
                    }
                    break;

                case TypeCode.UInt64:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'ulong' and 'bool'");
                        case TypeCode.SByte: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'ulong' and 'sbyte'");
                        case TypeCode.Int16: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'ulong' and 'short'");
                        case TypeCode.UInt16: return (UInt64)a % (UInt16)b;
                        case TypeCode.Int32: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'ulong' and 'int'");
                        case TypeCode.UInt32: return (UInt64)a % (UInt32)b;
                        case TypeCode.Int64: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'ulong' and 'long'");
                        case TypeCode.UInt64: return (UInt64)a % (UInt64)b;
                        case TypeCode.Single: return (UInt64)a % (Single)b;
                        case TypeCode.Double: return (UInt64)a % (Double)b;
                        case TypeCode.Decimal: return (UInt64)a % (Decimal)b;
                    }
                    break;

                case TypeCode.Single:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'float' and 'bool'");
                        case TypeCode.SByte: return (Single)a % (SByte)b;
                        case TypeCode.Int16: return (Single)a % (Int16)b;
                        case TypeCode.UInt16: return (Single)a % (UInt16)b;
                        case TypeCode.Int32: return (Single)a % (Int32)b;
                        case TypeCode.UInt32: return (Single)a % (UInt32)b;
                        case TypeCode.Int64: return (Single)a % (Int64)b;
                        case TypeCode.UInt64: return (Single)a % (UInt64)b;
                        case TypeCode.Single: return (Single)a % (Single)b;
                        case TypeCode.Double: return (Single)a % (Double)b;
                        case TypeCode.Decimal: return Convert.ToDecimal(a, System.Globalization.CultureInfo.InvariantCulture) % (Decimal)b;
                    }
                    break;

                case TypeCode.Double:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'double' and 'bool'");
                        case TypeCode.SByte: return (Double)a % (SByte)b;
                        case TypeCode.Int16: return (Double)a % (Int16)b;
                        case TypeCode.UInt16: return (Double)a % (UInt16)b;
                        case TypeCode.Int32: return (Double)a % (Int32)b;
                        case TypeCode.UInt32: return (Double)a % (UInt32)b;
                        case TypeCode.Int64: return (Double)a % (Int64)b;
                        case TypeCode.UInt64: return (Double)a % (UInt64)b;
                        case TypeCode.Single: return (Double)a % (Single)b;
                        case TypeCode.Double: return (Double)a % (Double)b;
                        case TypeCode.Decimal: return Convert.ToDecimal(a, System.Globalization.CultureInfo.InvariantCulture) % (Decimal)b;
                    }
                    break;

                case TypeCode.Decimal:
                    switch (typeCodeB)
                    {
                        case TypeCode.Boolean: throw new InvalidOperationException("Operator '%' can't be applied to operands of types 'decimal' and 'bool'");
                        case TypeCode.SByte: return (Decimal)a % (SByte)b;
                        case TypeCode.Int16: return (Decimal)a % (Int16)b;
                        case TypeCode.UInt16: return (Decimal)a % (UInt16)b;
                        case TypeCode.Int32: return (Decimal)a % (Int32)b;
                        case TypeCode.UInt32: return (Decimal)a % (UInt32)b;
                        case TypeCode.Int64: return (Decimal)a % (Int64)b;
                        case TypeCode.UInt64: return (Decimal)a % (UInt64)b;
                        case TypeCode.Single: return (Decimal)a % Convert.ToDecimal(b, System.Globalization.CultureInfo.InvariantCulture);
                        case TypeCode.Double: return (Decimal)a % Convert.ToDecimal(b, System.Globalization.CultureInfo.InvariantCulture);
                        case TypeCode.Decimal: return (Decimal)a % (Decimal)b;
                    }
                    break;
            }

            return null;
        }
    }
}
