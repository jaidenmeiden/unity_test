using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintInBlack : MonoBehaviour
{
    public GameObject House;

    void start() {
        print(House.transform.childCount);

        Transform[] allChildren = House.GetComponentsInChildren<Transform>();
        List<GameObject> childObjects = new List<GameObject>();
        foreach (Transform child in allChildren)
        { 
            childObjects.Add(child.gameObject);
        }
        
        /*MeshRenderer my_renderer = House.GetComponent<MeshRenderer>();
        if ( my_renderer != null )
        {
            my_renderer.material = ;
        }*/
    }
    void Update()
    {
        
    }
}
