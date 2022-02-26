
using UnityEngine;

public class RotateAroundAxis : MonoBehaviour {
    #region Public Fields
    #endregion
    #region Private Fields
    [SerializeField] private Transform RotationAxisProvider;
    [SerializeField] private Axis axis;
    [SerializeField] private bool Positive;
#endregion
#region Unity Methods

#endregion
#region MyMethods 
    
    public void Rotate(float angle){
        transform.RotateAround(RotationAxisProvider.position, AxisDefinition.GetAxisVector(RotationAxisProvider,axis, Positive), angle);
        
    }
    #endregion
}
