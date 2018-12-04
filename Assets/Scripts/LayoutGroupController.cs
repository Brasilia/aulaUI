using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(HorizontalOrVerticalLayoutGroup))]
public class LayoutGroupController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        Invoke("DisableLayoutGroup", 0.1f);
    }

    private void DisableLayoutGroup()
    {
        GetComponent<HorizontalOrVerticalLayoutGroup>().enabled = false;
    }
}
