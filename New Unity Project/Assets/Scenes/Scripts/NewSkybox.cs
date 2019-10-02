using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSkybox : MonoBehaviour
{
    public Material skybox;
    void Awake()
    {
        RenderSettings.skybox = skybox;
    }
}
