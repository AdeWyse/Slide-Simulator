using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LibraryControl : MonoBehaviour
{
    public GameObject openButton;
    public GameObject closeButton;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {
        openButton.SetActive(false);
        this.gameObject.SetActive(true);
    }

    public void Close()
    {
        openButton.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
