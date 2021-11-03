using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintInBlack : MonoBehaviour
{
    public GameObject House;
    private List<MaterialsListByGameObject> listGameObject = new List<MaterialsListByGameObject>();

    void Start()
    {
        Debug.Log("Hello: " + gameObject.name);

        Transform[] allChildren = House.GetComponentsInChildren<Transform>();
        foreach (Transform child in allChildren)
        {
            //Debug.Log(blackMaterial.name);
            
            MeshRenderer renderer = child.gameObject.GetComponent<MeshRenderer>();
            List<Material> material = new List<Material>();
            if (renderer != null)
            {
                renderer.GetMaterials(material);
                // The following command (GetComponent<Renderer>) always take the first element
                // child.gameObject.GetComponent<Renderer>().material.color = Color.black;
                foreach (Material mat in material)
                {
                    mat.color = Color.black;
                }
            }

            listGameObject.Add(new MaterialsListByGameObject(child.gameObject, child.transform.childCount, material));
        }

        foreach (MaterialsListByGameObject gameChild in listGameObject)
        {
            
            Debug.Log(gameChild.PuzzleTab.name);
            Debug.Log("<color=blue>Children: </color>" + gameChild.Children);
            Debug.Log("<color=green>Material count: </color>" + gameChild.MaterialList.Count);
            foreach (Material mat in gameChild.MaterialList)
            {
                Debug.Log("<color=red>Material: </color>" + mat.name);
                //mat.color = Color.white;
            }
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

    void MyGameMethod()
    {
        // Message with a GameObject name.
        //Debug.Log("Hello: " + gameObject.name);

        // Message with light type. This is an Object example.
        //Debug.Log(light.type);

        // Message using rich text.
        Debug.Log("<color=red>Error: </color>AssetBundle not found");
    }
}

public class MaterialsListByGameObject
{
    private GameObject _puzzleTab;
    private int _children;
    private List<Material> _materialList;
  
    public MaterialsListByGameObject(GameObject puzzleTab, int children, List<Material> materialList)
    {
        this._puzzleTab = puzzleTab;
        this._children = children;
        this._materialList = materialList;
    }
            
    public GameObject PuzzleTab
    {
        get { return _puzzleTab;  }
        set { _puzzleTab = value; }
    }
            
    public int Children
    {
        get { return _children;  }
        set { _children = value; }
    }
            
    public List<Material> MaterialList
    {
        get { return _materialList;  }
        set { _materialList = value; }
    }
}
