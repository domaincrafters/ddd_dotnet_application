using System;

namespace Domaincrafters.Application;

/// <summary>
/// Represents a Unit type – a type that has exactly one value.
/// This is useful when you want a function to return a value, but have no useful data to return.
/// </summary>
public readonly struct Unit : IEquatable<Unit>
{
    /// <summary>
    /// The single value of the Unit type.
    /// </summary>
    public static readonly Unit Value = new Unit();

    /// <summary>
    /// Determines whether the specified <see cref="Unit"/> is equal to the current <see cref="Unit"/>.
    /// Since all <see cref="Unit"/> values are equal, this always returns <c>true</c>.
    /// </summary>
    /// <param name="other">The <see cref="Unit"/> to compare with the current instance.</param>
    /// <returns><c>true</c> in all cases.</returns>
    public bool Equals(Unit other) => true;

    /// <summary>
    /// Determines whether the specified object is equal to the current <see cref="Unit"/>.
    /// </summary>
    /// <param name="obj">The object to compare with the current instance.</param>
    /// <returns><c>true</c> if the object is a <see cref="Unit"/>; otherwise, <c>false</c>.</returns>
    public override bool Equals(object? obj) => obj is Unit;

    /// <summary>
    /// Returns a hash code for the current <see cref="Unit"/>.
    /// Since all <see cref="Unit"/> values are equal, this always returns 0.
    /// </summary>
    /// <returns>A hash code (always 0).</returns>
    public override int GetHashCode() => 0;

    /// <summary>
    /// Returns a string representation of the <see cref="Unit"/>.
    /// </summary>
    /// <returns>A string representation of the <see cref="Unit"/>.</returns>
    public override string ToString() => "()";

    /// <summary>
    /// Determines whether two <see cref="Unit"/> instances are equal.
    /// </summary>
    /// <param name="first">The first <see cref="Unit"/> to compare.</param>
    /// <param name="second">The second <see cref="Unit"/> to compare.</param>
    /// <returns><c>true</c> because all <see cref="Unit"/> instances are equal.</returns>
    public static bool operator ==(Unit first, Unit second) => true;

    /// <summary>
    /// Determines whether two <see cref="Unit"/> instances are not equal.
    /// </summary>
    /// <param name="first">The first <see cref="Unit"/> to compare.</param>
    /// <param name="second">The second <see cref="Unit"/> to compare.</param>
    /// <returns><c>false</c> because all <see cref="Unit"/> instances are equal.</returns>
    public static bool operator !=(Unit first, Unit second) => false;
}
