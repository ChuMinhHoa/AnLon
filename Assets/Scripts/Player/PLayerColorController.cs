using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PLayerColorController : MonoBehaviour
{
    [SerializeField] MeshRenderer meshRenderer;
    int randomColorIndex = 0;
    Material currentMaterial;
    Material[] materials = new Material[1];
    private void Start()
    {
        ChangeRandomColor();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeRandomColor();
        }
    }
    void ChangeRandomColor() {
        randomColorIndex = UnityEngine.Random.Range(0, Enum.GetNames(typeof(ColorType)).Length);
        currentMaterial = GameManager.Instance.GetMaterialByColor((ColorType)randomColorIndex);
        materials[0] = currentMaterial;
        meshRenderer.materials = materials;
    }
}
