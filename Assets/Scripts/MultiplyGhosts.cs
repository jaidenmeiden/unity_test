using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplyGhosts : MonoBehaviour
{
    public GameObject Ghost1;
    public GameObject Ghost2;
    public GameObject Ghost3;
    public GameObject container;
    void Start()
    {
        int qty = 30;
        CreateSphere(500, Ghost1);
        CreateSphere(500, Ghost2);
        CreateSphere(500, Ghost3);
    }
    
    void CreateSphere(int qty, GameObject ghost)
    {
        for (int i = 1; i <= qty; i++)
        {
            Vector3 position;
            Collider[] hitColliders;
            do
            {
                position = new Vector3(Random.Range(-200, 200), Random.Range(0.1f, 2), Random.Range(-200, 200));
                hitColliders = Physics.OverlapSphere(position, 1.0f);
            } while (hitColliders.Length > 0);
            
            GameObject sphereClone = Instantiate(ghost, position, Quaternion.Euler(new Vector3(0, Random.Range(0, 330), 0)));
            sphereClone.transform.parent = container.transform;
            sphereClone.name = "Sphere" + i;
        }
    }
}
