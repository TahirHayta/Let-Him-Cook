using UnityEngine;

public interface SaveableLoadable // Structure Parent class will have this information.
{
    public void SaveData();
    public void initalizeEmptyCounter();
    public void initalizeFromData(StructureData data);

}
