using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplyBalloons : MonoBehaviour
{
    public GameObject BlueSphere;
    public GameObject GreenSphere;
    public GameObject OrangeSphere;
    public GameObject PinkSphere;
    public GameObject RedSphere;
    public GameObject YellowSphere;
    public GameObject container;
    void Start()
    {
        CreateSphere(500, BlueSphere);
        CreateSphere(500, GreenSphere);
        CreateSphere(500, OrangeSphere);
        CreateSphere(500, PinkSphere);
        CreateSphere(500, RedSphere);
        CreateSphere(500, YellowSphere);
    }
    
    void CreateSphere(int qty, GameObject sphere)
    {
        for (int i = 1; i <= qty; i++)
        {
            Vector3 position;
            Collider[] hitColliders;
            do
            {
                position = new Vector3(Random.Range(-70, 70), Random.Range(0.1f, 7), Random.Range(-70, 70));
                hitColliders = Physics.OverlapSphere(position, 1.0f);
            } while (hitColliders.Length > 0);
            
            GameObject sphereClone = Instantiate(sphere, position, sphere.transform.rotation);
            sphereClone.transform.parent = container.transform;
            sphereClone.name = "Sphere" + i;
        }
    }
}
