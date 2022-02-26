using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public static class AxisDefinition {
    public static Vector3 GetAxisVector(Transform point, Axis ChosenAxis, bool Positive=true)
    {
        Vector3 Axis;
        switch (ChosenAxis)
        {
            case global::Axis.X:
                Axis = point.right;
                break;
            case global::Axis.Y:
                Axis = point.up;
                break;
            case global::Axis.Z:
                Axis = point.forward;
                break;
            default:
                Axis = Vector3.zero;
                break;
        }
        if(!Positive) { Axis = -Axis; }
        return Axis;
    }
}
public enum Axis {X,Y,Z }