using UnityEngine;

public class SoundMoveSphere : MonoBehaviour
{
    public AudioSource audioSource;
    public float updateStep = 0.1f;
    public int sampleDataLenght = 1024;

    private float currentUpdateTime = 0f;

    public float clipLoudness;
    public float[] clipSampleData;

    public GameObject sphere;
    public float sizeFactor = 1;

    public float minSize = 500;
    public float maxSize = 1000;

    private void Awake()
    {
        clipSampleData = new float[sampleDataLenght];
    }

    private void Update()
    {
        currentUpdateTime += Time.deltaTime;
        if (currentUpdateTime >= updateStep)
        {
            currentUpdateTime = 0f;
            audioSource.clip.GetData(clipSampleData, audioSource.timeSamples);
            clipLoudness = 0f;
            foreach (var sample in clipSampleData)
            {
                clipLoudness += Mathf.Abs(sample);
            }
            clipLoudness /= sampleDataLenght;
            clipLoudness *= sizeFactor;
            clipLoudness = Mathf.Clamp(clipLoudness, minSize, maxSize);
            sphere.transform.localScale = new Vector3(clipLoudness, clipLoudness, clipLoudness);
        }
    }
}
