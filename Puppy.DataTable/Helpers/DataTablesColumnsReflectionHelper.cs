using Puppy.DataTable.Helpers.Reflection;
using Puppy.DataTable.Models;
using System;
using System.Collections.Generic;

namespace Puppy.DataTable.Helpers
{
    public static class DataTablesColumnsReflectionHelper
    {
        public static ColDefModel[] ColDefs(this Type t)
        {
            var propInfos = DataTablesTypeInfo.Properties(t);
            var columnList = new List<ColDefModel>();

            foreach (var dataTablesPropertyInfo in propInfos)
            {
                var colDef = new ColDefModel(dataTablesPropertyInfo.PropertyInfo.Name, dataTablesPropertyInfo.PropertyInfo.PropertyType);

                foreach (var att in dataTablesPropertyInfo.Attributes)
                {
                    att.ApplyTo(colDef, dataTablesPropertyInfo.PropertyInfo);
                }

                columnList.Add(colDef);
            }
            return columnList.ToArray();
        }

        public static ColDefModel[] ColDefs<TResult>()
        {
            return ColDefs(typeof(TResult));
        }
    }
}