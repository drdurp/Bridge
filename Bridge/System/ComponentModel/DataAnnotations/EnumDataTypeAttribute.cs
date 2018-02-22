
namespace System.ComponentModel.DataAnnotations
{
    [AttributeUsage(
        AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Method | AttributeTargets.Parameter,
        AllowMultiple = false)]
    [Bridge.External]
    [Bridge.NonScriptable]
    public sealed class EnumDataTypeAttribute : DataTypeAttribute
    {
        public extern EnumDataTypeAttribute(Type enumType);

        public extern Type EnumType { get; }
    }
}
