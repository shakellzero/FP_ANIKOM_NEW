using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTopiUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private ShowModelButton buttonPrefab;
    void Start()
    {
        var models = FindObjectOfType<ShowTopiController>().GetModels();
        foreach ( var model in models)
        {
            CreateButtonForModel(model);
        }
    }

    private void CreateButtonForModel(Transform model)
    {
        var button = Instantiate(buttonPrefab);
        button.transform.SetParent(this.transform);
        button.transform.localScale = Vector3.one;
        button.transform.localRotation = Quaternion.identity;

        var controller = FindObjectOfType<ShowTopiController>();
        button.Initialize(model, controller.EnableModel);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
