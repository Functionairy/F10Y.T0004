using System;

using F10Y.T0000;


namespace F10Y.T0004
{
    /// <summary>
    /// Attribute indicating a type is a data type. (Zero or few methods, mostly for representing data.)
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for surveying assemblies and code, then building a catalogue of data types.
    /// Generally, the data type marker should go on types that are equality-by-value. (If the data of two instances is equal, then the two instances are equal.)
    /// </remarks>
    [MarkerAttributeMarker]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct | AttributeTargets.Enum, // These are the supported data types.
        AllowMultiple = false, // No.
        Inherited = false // Make the inheritor also use the marker attribute.
    )]
    public class DataTypeMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a type is *not* a data type.
        /// This is useful for marking types that end up canonical data type code file locations, but are not actually data types.
        /// </summary>
        public bool Is_DataType { get; }


        public DataTypeMarkerAttribute(
            bool is_DataType = true)
        {
            this.Is_DataType = is_DataType;
        }
    }
}
