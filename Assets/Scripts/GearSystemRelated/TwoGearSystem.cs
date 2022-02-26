
using System.Collections.Generic;
using UnityEngine;

public class TwoGearSystem : MonoBehaviour, IRotate
{
    #region Public Fields
    #endregion
    #region Private Fields

    [SerializeField] private  List<ConnectedGears> connectedGears =new List<ConnectedGears>();
    [SerializeField] private bool FirstPositive=true; 
    #endregion
    #region Unity Methods
    private void Start()
    {
        foreach(ConnectedGears connected in connectedGears)
        {
            connected.CalculateGearRatio();
        }
    }
    #endregion
    #region MyMethods 
    public void RotateConnectedGears(float angle)
    {
        float secondAngle = angle * connectedGears[0].GetGearRatio();
        Utilities.Rotate(connectedGears[0].GearOne.transform, angle, connectedGears[0].GearOne.transform, connectedGears[0].GearOne.GetAxis(), FirstPositive);
        Utilities.Rotate(connectedGears[0].GearTwo.transform, secondAngle, connectedGears[0].GearTwo.transform, connectedGears[0].GearTwo.GetAxis(), !FirstPositive);

    }

#endregion
}

[System.Serializable]
public class ConnectedGears
{
   public GearInfo GearOne;
   public GearInfo GearTwo;
  [SerializeField]  private float gearRatio;
    public void CalculateGearRatio()
    {
        gearRatio = (float)GearOne.GetNumberOfTooth() / GearTwo.GetNumberOfTooth();
    }
    public float GetGearRatio() { return gearRatio; }
}
