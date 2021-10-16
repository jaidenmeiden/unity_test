using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public float sensitivity = 100;
    public float loudness = 0;
    AudioSource _audio; 
    
    // Start is called before the first frame update
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        _audio.clip = Microphopne.Start(null, true, 10, 44100);
        _audio.loop = true;
        _audio.mute = true;
        while (!(Microphopne.GetPosition(null) > 0))
        {
            
        }
        _audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        loudness = GetAverageVolume() * sensitivity;
        if (loudness > 8)
            this.GetComponent<RigidBody>().velocity = new Vector2(this.GetComponent<RigidBody>().velocity.x, 4);
    }
    //
    float GetAveragedVolume()
    {
        float[] data = new float[256];
        float a = 0;
        _audio.GetOutputData(data, 0);
        foreach (float s in data)
        {
            a+=Mathf.Abs(s);
        }

        return a / 256;
    }
}
