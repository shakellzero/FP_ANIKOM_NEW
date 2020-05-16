using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSepatuController : MonoBehaviour
{
    // Start is called before the first frame update
    private List<Transform> models;
    private void Awake()
    {
        models = new List<Transform>();
        for ( int i = 0; i < transform.childCount; i++)
        {
            var model = transform.GetChild(i);
            models.Add(model);
            model.gameObject.SetActive(i == 0);
        }
    }

    public void EnableModel(Transform modelTransform)
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            var transformToToggle = transform.GetChild(i);
            bool shouldBeActive = transformToToggle == modelTransform;
            transformToToggle.gameObject.SetActive(shouldBeActive);
        }
    }

    public List<Transform> GetModels()
    {
        return new List<Transform>(models);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
