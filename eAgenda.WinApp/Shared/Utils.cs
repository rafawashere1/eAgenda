namespace eAgenda.WinApp.Shared
{
    public static class Utils
    {
        public static TEnum GetEnumValueFromDescription<TEnum>(string description)
        {
            foreach (var field in typeof(TEnum).GetFields())
            {
                if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
                {
                    if (attribute.Description == description)
                        return (TEnum)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (TEnum)field.GetValue(null);
                }
            }
            throw new ArgumentException($"No enum value found with the description '{description}'.");
        }
    }
}
