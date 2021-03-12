using System.Text;
using System.Reflection;
using System.Data;
using System.Collections.Generic;
using System;
using System.Linq;

namespace NEGOCIO
{
    public static class Convertions
    {
        private static Dictionary<Type, IList<PropertyInfo>> typeDictionary = new Dictionary<Type, IList<PropertyInfo>>();

        public static IList<PropertyInfo> GetPropertiesForType<T>()
        {
            var type = typeof(T);
            if (!typeDictionary.ContainsKey(typeof(T)))
            {
                typeDictionary.Add(type, type.GetProperties().ToList());
            }
            return typeDictionary[type];
        }

        public static List<T> ToList<T>(this DataTable table) where T : new()
        {
            //Pegando todas as propriedades da classe genérica.
            IList<PropertyInfo> properties = GetPropertiesForType<T>();
            IList<T> result = new List<T>();

            //Convertendo e adicionando os itens na lista.
            foreach (var row in table.Rows)
            {
                var item = CreateItemFromRow<T>((DataRow)row, properties);
                result.Add(item);                
                
            }

            return result.ToList();
        }

        private static T CreateItemFromRow<T>(DataRow row, IList<PropertyInfo> properties) where T : new()
        {
            T item = new T();
            foreach (var property in properties)
            {
                property.SetValue(item, row[property.Name], null);
            }
            return item;
        }

        public static DataTable ToDataTable<T>(this List<T> list)
        {
            DataTable dt = new DataTable();
            if (list.Count > 0)
            {
                Type listType = list.ElementAt(0).GetType();
                //Pegando o elemento da propriedade e adicionando a coluna do DataTable
                PropertyInfo[] properties = listType.GetProperties();
                foreach (PropertyInfo property in properties)
                    dt.Columns.Add(new DataColumn() { ColumnName = property.Name });
                foreach (object item in list)
                {
                    DataRow dr = dt.NewRow();
                    foreach (DataColumn col in dt.Columns)
                        dr[col] = listType.GetProperty(col.ColumnName).GetValue(item, null);
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
    }
}
