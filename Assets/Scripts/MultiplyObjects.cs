using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplyObjects : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Sphere;
    public GameObject Capsule;
    public GameObject Cylinder;
    public GameObject container;
    void Start()
    {
        CreateSphere(1000, Cube);
        CreateSphere(1000, Sphere);
        CreateSphere(1000, Capsule);
        CreateSphere(1000, Cylinder);
    }
    
    void CreateSphere(int qty, GameObject sphere)
    {
        for (int i = 1; i <= qty; i++)
        {
            Vector3 position;
            Collider[] hitColliders;
            do
            {
                position = new Vector3(Random.Range(-200, 200), Random.Range(0.1f, 7), Random.Range(-200, 200));
                hitColliders = Physics.OverlapSphere(position, 0.5f);
            } while (hitColliders.Length > 0);
            
            GameObject sphereClone = Instantiate(sphere, position, sphere.transform.rotation);
            sphereClone.transform.parent = container.transform;
            sphereClone.name = "Sphere" + i;
        }
    }
}
