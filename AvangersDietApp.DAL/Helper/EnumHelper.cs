using System.ComponentModel;

namespace AvangersDietApp.DAL.Helper



{
    public static class EnumHelper
    {

        // Enum değerinin Description özniteliğini alır
        public static string GetDescription(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());

            var attribute = Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute));

            return attribute == null ? value.ToString() : attribute.ToString();
        }

    }
}
