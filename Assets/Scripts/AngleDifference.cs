using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleDifference : MonoBehaviour {
    #region Public Fields
    #endregion
    #region Private Fields
    [SerializeField] private IRotate Rotate;
    [SerializeField] private float PreviousAngle = 0f;
    private float current;
#endregion
#region Unity Methods
    void Start() {
        if(Rotate==null){
            Rotate = GetComponent<IRotate>();
        }
    }
#endregion
#region MyMethods 
    public void CAngleDifference(float newAngle){
        current = newAngle - PreviousAngle;
        
        Rotate?.RotateConnectedGears(current);
        PreviousAngle = newAngle;
    }
#endregion
}
