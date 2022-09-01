
using System.Reflection;

public static class ModalState
{
    public static void IsValid<T>(T Entity)
    {
        List<PropertyInfo> list = Entity.GetType().GetProperties().Where(x => Attribute.GetCustomAttributes(x).Count() > 0).ToList();
        foreach (var item in list)
        {
            Attribute[] data = Attribute.GetCustomAttributes(item);

                foreach (Attribute attr in data)
                {
                    var method = attr.GetType().GetMethod("Check");
                    var t = item.GetValue(Entity);
                    method.Invoke(attr, new object[] { t });

                }
        }

    }

 
}

