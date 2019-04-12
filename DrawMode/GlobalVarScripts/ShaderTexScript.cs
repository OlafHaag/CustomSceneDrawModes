using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ShaderTexScript : MonoBehaviour
{
    public Texture texture;
    public string shaderVariableName = "_MipTex";

    void OnValidate() {
        Shader.SetGlobalTexture(shaderVariableName, texture);
    }
}