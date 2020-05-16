using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    // Start is called before the first frame update
    public Material[] BodyColorMat;
    Material CurrMat;
    Renderer renderer;
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void JeansMat()
    {
        Debug.Log("change jeans");
        renderer.material = BodyColorMat[0];
        CurrMat = renderer.material;
    }
    public void RedMat()
    {
        Debug.Log("change red");
        renderer.material = BodyColorMat[1];
        CurrMat = renderer.material;
    }

    public void GrayMat()
    {
        Debug.Log("change gray");
        renderer.material = BodyColorMat[2];
        CurrMat = renderer.material;
    }
}
