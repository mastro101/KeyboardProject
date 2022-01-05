using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MeshRendererController
{
    public static void ChangeColor(this MeshRenderer m, Color c)
    {
        m.material.color = c;
    }
}