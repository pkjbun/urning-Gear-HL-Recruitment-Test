
using UnityEngine;

public class ComplexGearSystem : MonoBehaviour, IRotate{
    #region Public Fields
    #endregion
    #region Private Fields
    [SerializeField] private ConnectedGearsSystemDefinition connectedGears;
    [SerializeField] private bool FirstPositive = true;
    #endregion
    #region Unity Methods
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }
    #endregion
    #region MyMethods 
    public void RotateConnectedGears(float angle)
    {
        float secondAngle=0;

        for (int i = 0; i < connectedGears.ListOfGears.Count; i += 2){
           
            if (i != 0){
                angle = secondAngle * connectedGears.GearRatio(i - 1);
            }
           
            Utilities.Rotate(connectedGears.ListOfGears[i].transform, angle, connectedGears.ListOfGears[i].transform, connectedGears.ListOfGears[i].GetAxis(), FirstPositive);
            if (i + 1 < connectedGears.ListOfGears.Count){
            secondAngle = angle * connectedGears.GearRatio(i);
                Utilities.Rotate(connectedGears.ListOfGears[i + 1].transform, secondAngle, connectedGears.ListOfGears[i + 1].transform, connectedGears.ListOfGears[i + 1].GetAxis(), !FirstPositive);
            }
        }



    }
    #endregion
}
