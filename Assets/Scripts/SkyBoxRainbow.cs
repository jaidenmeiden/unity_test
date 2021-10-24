using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxRainbow : MonoBehaviour
{
    public Material skyMidday;
    public Material skyEvening;
    public Material skyMidninght;
    public Material skySunset;
    public Material skyDaybreak;
    
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.skybox = skyMidday;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
