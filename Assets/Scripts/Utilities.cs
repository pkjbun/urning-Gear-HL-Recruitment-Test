
using UnityEngine;

public static class Utilities  {
    /// <summary>Rotates selected Object Around axis, with given Angle
    ///</summary>
    ///
    public static void Rotate(Transform ObjectToRotate, float angle, Transform RotationAxisProvider, Axis axis, bool Positive)
    {
        ObjectToRotate.RotateAround(RotationAxisProvider.position, AxisDefinition.GetAxisVector(RotationAxisProvider, axis, Positive), angle);

    }
    /// <summary>Rotates selected Object Around axis, with given Angle. Call if object And axis has the same pivot and coordinate system
    ///</summary>
    ///
    public static void Rotate( float angle, Transform RotationAxisProvider, Axis axis, bool Positive)
    {
        RotationAxisProvider.RotateAround(RotationAxisProvider.position, AxisDefinition.GetAxisVector(RotationAxisProvider, axis, Positive), angle);

    }
}
