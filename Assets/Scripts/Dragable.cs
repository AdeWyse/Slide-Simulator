using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dragable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Transform initialPos;
    public GameObject background;
    public GameObject library;
    public Boolean ismoving = false;

    public GameObject item;
    public GameObject icon;
    public Boolean onList = true;

    private void Start()
    {
        icon.SetActive(false);
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        initialPos = transform.parent;
        transform.SetParent(background.transform);
        transform.SetAsLastSibling();
        library.GetComponent<LibraryControl>().Close();
        ismoving = true;
        if (onList)
        {
            item.SetActive(false);
            icon.SetActive(true);
        }  
        

        if (onList)
        {
            onList = false;
        }

    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
       ismoving = false;
    }
}
