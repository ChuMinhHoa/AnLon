using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ColorType { 
    Red,
    Green,
    Blue
}

[System.Serializable]
public class MaterialByColor {
    public Material material;
    public ColorType colorType;
}

[CreateAssetMenu(fileName = "MaterialDataConfig", menuName = "ScriptAbleObject/MaterialDataConfig" )]
public class MaterialDataConfig : ScriptableObject
{
    public List<MaterialByColor> materials = new List<MaterialByColor>();

    public Material GetMaterialByColor(ColorType colorType) {
        for (int i = 0; i < materials.Count; i++)
        {
            if (colorType == materials[i].colorType)
            {
                return materials[i].material;
            }
        }
        return null;
    }
}
