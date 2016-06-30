﻿// ============================================================================
// Project: Framework
// Name/Class: 
// Author: João Carreiro (joao.carreiro@cybermap.pt)
// Create date: 26/Nov/2015
// Company: Coop4Creativity
// Description: 
// ============================================================================

using System;
using System.Reflection;

namespace Framework.Core.Reflection
{
    public static class Converter
    {

        /// <summary>
        /// Check to see if can convert to appropriate type
        /// </summary>
        /// <param name="propInfo">Information of property to check.</param>
        /// <param name="val">Object to convert to.</param>
        /// <returns>True if the object can be converted to the property type.</returns>
        public static bool CanConvertToCorrectType(PropertyInfo propInfo, object val)
        {
            // Data could be passed as string value.
            // Try to change type to check type safety.                    
            try
            {
                if (propInfo.PropertyType == typeof(int))
                {
                    int i = Convert.ToInt32(val);
                }
                else if (propInfo.PropertyType == typeof(double))
                {
                    double d = Convert.ToDouble(val);
                }
                else if (propInfo.PropertyType == typeof(long))
                {
                    double l = Convert.ToInt64(val);
                }
                else if (propInfo.PropertyType == typeof(float))
                {
                    double f = Convert.ToSingle(val);
                }
                else if (propInfo.PropertyType == typeof(bool))
                {
                    bool b = Convert.ToBoolean(val);
                }
                else if (propInfo.PropertyType == typeof(DateTime))
                {
                    DateTime d = Convert.ToDateTime(val);
                }
                else if (propInfo.PropertyType.BaseType == typeof(Enum) && val is string)
                {
                    Enum.Parse(propInfo.PropertyType, (string)val, true);
                }
            }
            catch (Exception)
            {
                return false;
            }

            //Conversion worked.
            return true;
        }


        /// <summary>
        /// Checks whether or not the string can be converted to a propert type.
        /// </summary>
        /// <param name="propInfo">The property represnting the type to convert 
        /// val to</param>
        /// <param name="val">The value to test for conversion to the type
        /// associated with the property</param>
        /// <returns>True if the string can be converted.</returns>
        public static bool CanConvertToCorrectType(PropertyInfo propInfo, string val)
        {
            // Data could be passed as string value.
            // Try to change type to check type safety.                    
            try
            {
                if (propInfo.PropertyType == typeof(int))
                {
                    int result = 0;
                    if (int.TryParse(val, out result)) return true;

                    return false;
                }
                else if (propInfo.PropertyType == typeof(string))
                {
                    return true;
                }
                else if (propInfo.PropertyType == typeof(double))
                {
                    double d = 0;
                    if (double.TryParse(val, out d)) return true;

                    return false;
                }
                else if (propInfo.PropertyType == typeof(long))
                {
                    long l = 0;
                    if (long.TryParse(val, out l)) return true;

                    return false;
                }
                else if (propInfo.PropertyType == typeof(float))
                {
                    float f = 0;
                    if (float.TryParse(val, out f)) return true;

                    return false;
                }
                else if (propInfo.PropertyType == typeof(bool))
                {
                    bool b = false;
                    if (bool.TryParse(val, out b)) return true;

                    return false;
                }
                else if (propInfo.PropertyType == typeof(DateTime))
                {
                    DateTime d = DateTime.MinValue;
                    if (DateTime.TryParse(val, out d)) return true;

                    return false;
                }
                else if (propInfo.PropertyType.BaseType == typeof(Enum))
                {
                    Enum.Parse(propInfo.PropertyType, val, true);
                }
            }
            catch (Exception)
            {
                return false;
            }

            //Conversion worked.
            return true;
        }


        /// <summary>
        /// Convert the val from string type to the same time as the property.
        /// </summary>
        /// <param name="propInfo">Property representing the type to convert to</param>
        /// <param name="val">val to convert</param>
        /// <returns>converted value with the same time as the property</returns>
        public static object ConvertToSameType(PropertyInfo propInfo, object val)
        {
            object convertedType = null;

            if (propInfo.PropertyType == typeof(int))
            {
                convertedType = Convert.ChangeType(val, typeof(int));
            }
            else if (propInfo.PropertyType == typeof(double))
            {
                convertedType = Convert.ChangeType(val, typeof(double));
            }
            else if (propInfo.PropertyType == typeof(long))
            {
                convertedType = Convert.ChangeType(val, typeof(long));
            }
            else if (propInfo.PropertyType == typeof(float))
            {
                convertedType = Convert.ChangeType(val, typeof(float));
            }
            else if (propInfo.PropertyType == typeof(bool))
            {
                convertedType = Convert.ChangeType(val, typeof(bool));
            }
            else if (propInfo.PropertyType == typeof(DateTime))
            {
                convertedType = Convert.ChangeType(val, typeof(DateTime));
            }
            else if (propInfo.PropertyType == typeof(string))
            {
                convertedType = Convert.ChangeType(val, typeof(string));
            }
            else if (propInfo.PropertyType.BaseType == typeof(Enum) && val is string)
            {
                convertedType = Enum.Parse(propInfo.PropertyType, (string)val, true);
            }
            return convertedType;
        }


        /// <summary>
        /// Determine if the type of the property and the val are the same type.
        /// </summary>
        /// <param name="propInfo">Property info to check.</param>
        /// <param name="val">Value to check against property info.</param>
        /// <returns>True if the property and the value are of the same type.</returns>
        public static bool IsSameType(PropertyInfo propInfo, object val)
        {
            // Quick Validation.
            if (propInfo.PropertyType == typeof(int) && val is int) { return true; }
            if (propInfo.PropertyType == typeof(bool) && val is bool) { return true; }
            if (propInfo.PropertyType == typeof(string) && val is string) { return true; }
            if (propInfo.PropertyType == typeof(double) && val is double) { return true; }
            if (propInfo.PropertyType == typeof(long) && val is long) { return true; }
            if (propInfo.PropertyType == typeof(float) && val is float) { return true; }
            if (propInfo.PropertyType == typeof(DateTime) && val is DateTime) { return true; }
            if (propInfo.PropertyType is object && propInfo.PropertyType.GetType() == val.GetType()) { return true; }

            return false;
        }
    }
}
