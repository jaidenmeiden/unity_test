using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMoveSphere : MonoBehaviour
{
//    public float sensitivity = 100;
//    public float loudness = 0;
    public float speed = .1f;
    AudioSource _audio;

    // Start is called before the first frame update
    void Start()
    {
//        _audio = GetComponent<AudioSource>();
//        _audio.clip = Microphone.Start(null, true, 10, 44100);
//        _audio.loop = true;
//        _audio.mute = true;
//        while (!(Microphone.GetPosition(null) > 0))
//        {

//        }
//        _audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
            float xDir = Input.GetAxis("Horizontal");
            float zDir = Input.GetAxis("Vertical");

            Vector3 moveDirection = new Vector3(xDir, 0.0f, zDir);

            transform.position += moveDirection * speed;
//        loudness = GetAverageVolume() * sensitivity;
//        if (loudness > 8)
//            this.GetComponent<Rigidbody>().velocity = new Vector2(this.GetComponent<Rigidbody>().velocity.x, 4);
    }
    //
    float GetAverageVolume()
    {
        float[] data = new float[256];
        float a = 0;
        _audio.GetOutputData(data, 0);
        foreach (float s in data)
        {
            a += Mathf.Abs(s);
        }

        return a / 256;
    }
}
