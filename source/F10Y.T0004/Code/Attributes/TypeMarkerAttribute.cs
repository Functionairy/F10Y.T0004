using System;

using F10Y.T0000;


namespace F10Y.T0004
{
    /// <summary>
    /// Attribute indicating a type is a type (can be either an interface, or a class).
    /// Use this marker for any type that is not one of the sub-types (data-type, utility-type, etc.), but that you will want to track as a type.
    /// </summary>
    /// <remarks>
    /// The type marker is a catch-all for types that are not data types (where equality-by-value is the defining operation of the type),
    /// nor is the type a utility type (where equality is not a defining operation at all).
    /// It's just a type.
    /// The marker attribute is useful for surveying context implementation types and building a catalogue of those types.
    /// </remarks>
    [MarkerAttributeMarker]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct | AttributeTargets.Enum, // Theis should be all the types.
        AllowMultiple = false,
        Inherited = false // Make inheritors also use the marker type.
    )]
    public class TypeMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a type is *not* a type.
        /// This is useful for marking types that end up canonical type file locations, but are not actually types.
        /// </summary>
        public bool Is_Type { get; }


        public TypeMarkerAttribute(
            bool is_Type = true)
        {
            this.Is_Type = is_Type;
        }
    }
}
