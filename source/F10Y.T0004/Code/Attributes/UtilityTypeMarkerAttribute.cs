using System;

using F10Y.T0000;


namespace F10Y.T0004
{
    /// <summary>
    /// Attribute indicating a type is a utility type. (Does not represent data, but provides type-based functionality.)
    /// </summary>
    /// <remarks>
    /// The utility type marker should go on types for which equality is not the defining operation.
    /// For example, with the WasFound&lt;T&gt; type, the defining operation is testing whether the value of the instance exists.
    /// Rarely, if ever, will you want to equate two instances.
    /// The marker attribute is useful for surveying assemblies and code, then building a catalogue of utility types.
    /// </remarks>
    [MarkerAttributeMarker]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct | AttributeTargets.Enum, // This should be all the types.
        AllowMultiple = false, // No.
        Inherited = false // Make inheritors also use the marker type.
    )]
    public class UtilityTypeMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a type is *not* a utility type.
        /// This is useful for marking types that end up canonical utility type code file locations, but are not actually utility types.
        /// </summary>
        public bool IsUtilityType { get; }


        public UtilityTypeMarkerAttribute(
            bool isUtilityType = true)
        {
            this.IsUtilityType = isUtilityType;
        }
    }
}
