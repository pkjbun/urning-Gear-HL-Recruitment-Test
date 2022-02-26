using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearInfo : MonoBehaviour {
    #region Public Fields
    #endregion
    #region Private Fields
    [SerializeField] private int NumberOfTooths;
    [SerializeField] private Axis RotationAxis;
#endregion
#region Unity Methods

#endregion
#region MyMethods 

    public int GetNumberOfTooth() { return NumberOfTooths; }
    public Axis GetAxis() { return RotationAxis; }
#endregion
}
