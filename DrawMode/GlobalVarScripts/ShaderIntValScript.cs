using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ShaderIntValScript : MonoBehaviour
{
    public int IntValue = 128;
    public string shaderVariableName = "_Density";

    void OnValidate() {
        Shader.SetGlobalInt(shaderVariableName, IntValue);
    }
}