using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxRainbow : MonoBehaviour
{
    public float RotationPerSecond = 1;
    public Material skyMidday;
    public Material skyEvening;
    public Material skyMidninght;
    public Material skySunset;
    public Material skyDaybreak;
    
    Material[] skies = new Material[5];
    
    // Start is called before the first frame update
    void Start()
    {
        skies[0] = skyMidday;
        skies[1] = skyEvening;
        skies[2] = skyMidninght;
        skies[3] = skySunset;
        skies[4] = skyDaybreak;
        RenderSettings.skybox = skies[Random.Range(0, 5)];
        RenderSettings.skybox.SetFloat("_Rotation", 0);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Event.current.type == EventType.MouseDown)
        {
            RenderSettings.skybox = skies[Random.Range(0, 4)];
        }*/
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * RotationPerSecond);
    }
}
