using System.Collections.Generic;
[System.Serializable]
public class ConnectedGearsSystemDefinition
{
    public List<GearInfo> ListOfGears = new List<GearInfo>();
    public float GearRatio(int indexOfFirst)
    {
        float gearRatio;
        gearRatio = (float)ListOfGears[indexOfFirst].GetNumberOfTooth() / ListOfGears[indexOfFirst + 1].GetNumberOfTooth();
        return gearRatio;
    }
}
