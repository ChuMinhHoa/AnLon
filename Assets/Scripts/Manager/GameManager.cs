using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else Destroy(gameObject);
    }

    public Material GetMaterialByColor(ColorType colorType) {
        return ProfileManager.Instance.dataConfig.materialDataConfig.GetMaterialByColor(colorType);
    }
}
