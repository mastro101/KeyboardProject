using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialColor : MonoBehaviour
{
    [SerializeField] MeshRenderer mr = null;
    [SerializeField] Color color = Color.white;

    Material m;

    public void ChangeColor()
    {
        if (mr)
        {
            if (m)
                m.color = color;
            else
                m = mr.material;
        }
    }
}