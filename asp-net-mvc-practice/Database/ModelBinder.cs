namespace MvcPractice.Database
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Reflection;

    public class ModelBinder
    {
        public static List<T> SqlDataReaderMapToList<T>(SqlDataReader sqlDataReader)
        {
            List<T> list = new List<T>();
            T obj = default(T);

            while (sqlDataReader.Read())
            {
                obj = Activator.CreateInstance<T>();

                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    PropertyInfo prop = obj.GetType().GetProperty(sqlDataReader.GetName(i));
                    if (object.Equals(sqlDataReader[i], DBNull.Value))
                    {
                        prop.SetValue(obj, null, null);
                    }
                    else
                    {
                        prop.SetValue(obj, sqlDataReader[prop.Name], null);
                    }
                }

                list.Add(obj);
            }

            return list;
        }

        public static object SqlDataReaderMapToModel(SqlDataReader sqlDataReader, object model)
        {
            for (int i = 0; i < sqlDataReader.FieldCount; i++)
            {
                PropertyInfo prop = model.GetType().GetProperty(sqlDataReader.GetName(i));
                if (object.Equals(sqlDataReader[i], DBNull.Value))
                {
                    prop.SetValue(model, null, null);
                }
                else
                {
                    prop.SetValue(model, sqlDataReader[prop.Name], null);
                }
            }

            return model;
        }

        public static List<T> SqlDataReaderToList<T>(SqlDataReader sqlDataReader, bool optIsDateTime = false, string optDateFormat = "")
        {
            T obj = default(T);

            if (obj != null && obj.GetType().IsClass)
            {
                return SqlDataReaderMapToList<T>(sqlDataReader);
            }
            else
            {
                List<T> list = new List<T>();

                while (sqlDataReader.Read())
                {
                    if (!object.Equals(sqlDataReader[0], DBNull.Value))
                    {
                        if (optIsDateTime)
                        {
                            string date = Convert.ToDateTime(sqlDataReader[0]).ToString(optDateFormat);

                            list.Add((T)Convert.ChangeType(date, typeof(T)));
                        }
                        else
                        {
                            list.Add((T)sqlDataReader[0]);
                        }
                    }
                }

                return list;
            }
        }
    }
}