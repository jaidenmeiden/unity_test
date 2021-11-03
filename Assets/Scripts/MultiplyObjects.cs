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
        int min = 30;
        int max = 1000;
        CreateSphere(min, max, Cube);
        CreateSphere(min, max, Sphere);
        CreateSphere(min, max, Capsule);
        CreateSphere(min, max, Cylinder);
    }
    
    void CreateSphere(int min, int max, GameObject figure)
    {
        for (int i = 1; i <= min; i++)
        {
            Vector3 position;
            Collider[] hitColliders;
            do
            {
                position = new Vector3(Random.Range(-10, 10), Random.Range(0.1f, 2), Random.Range(-15, 15));
                hitColliders = Physics.OverlapSphere(position, 0.5f);
            } while (hitColliders.Length > 0);

            GameObject sphereClone = Instantiate(figure, position, figure.transform.rotation);
            sphereClone.transform.parent = container.transform;
            sphereClone.name = figure.name + i;
        }
        
        for (int i = 1; i <= max; i++)
        {
            Vector3 position;
            Collider[] hitColliders;
            do
            {
                position = new Vector3(Random.Range(-200, 200), Random.Range(0.1f, 3), Random.Range(-200, 200));
                hitColliders = Physics.OverlapSphere(position, 1.0f);
            } while (hitColliders.Length > 0);
            
            GameObject sphereClone = Instantiate(figure, position, figure.transform.rotation);
            sphereClone.transform.parent = container.transform;
            sphereClone.name = figure.name + (i + min);
        }
    }
}
