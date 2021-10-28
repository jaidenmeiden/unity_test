using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplyBalloons : MonoBehaviour
{
    public GameObject sphere;
    public GameObject container;
    void Start()
    {
        CreateSphere(5);
    }
    
    void CreateSphere(int qty)
    {
        for (int i = 1; i <= qty; i++)
        {
            GameObject sphereClone = Instantiate(sphere,new Vector3(i * 0.6f, sphere.transform.position.y, i * 0.75f), sphere.transform.rotation);
            sphereClone.transform.parent = container.transform;
            sphereClone.name = "Sphere" + i;
        }
    }
}
