using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PageSetter : MonoBehaviour, IPointerClickHandler
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPointerDown(BaseEventData eventData)
    {
        
    }

    public void O(BaseEventData eventData)
    {
        
    }

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        transform.parent.GetComponent<HorizontalOrVerticalLayoutGroup>().enabled = false;
        transform.SetAsLastSibling();
        foreach(Transform t in transform.parent.GetComponentInChildren<Transform>())
        {
            t.localScale = Vector3.one;
        }
        transform.localScale = 1.2f * Vector3.one;
        Debug.Log("Clicked");
    }
}
