using UnityEngine;
using System.Collections.Generic;
using System;

// KitchenManager monobehaviour will have a KitchenData. Kitchendata will hold StructureData classes that have initialization information for each structure.
[Serializable] // json haline dönüştürülüp kaydedilip tekrar yüklenebilmesi için
public class KitchenData
{
    public List<StructureData> structuresInKitchen = new List<StructureData>(); // To hold all structure info when changing scene.
    // Maybe something to hold walls and decoration too
    
    
}
