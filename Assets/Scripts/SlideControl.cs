using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideControl : MonoBehaviour
{
    public GameObject statusAtualObj;
    public GameObject goalObj;
    public Status atual;
    public Status goal;
    public bool start =  false;

    public GameObject libraryOpen;

    GameObject[] objsCount;

    // Start is called before the first frame update
    private void Awake()
    {
       objsCount = GameObject.FindGameObjectsWithTag("components");
    }
    void Start()
    {
        Invoke("Initiate", 0.5f);
    }

    public void Initiate()
    {
        goal = this.GetComponentInChildren<Goal>().status;
        atual = new Status(0, 0, 0);
        goalObj.GetComponent<StatusControl>().statusToControl = goal;
        statusAtualObj.GetComponent<StatusControl>().statusToControl = atual;
        start = true;   
    }

    // Update is called once per frame
    void Update()
    {
        if (start)
        {
            statusAtualObj.GetComponent<StatusControl>().statusToControl = StatusAtualModification();
            CheckTotal(statusAtualObj.GetComponent<StatusControl>().statusToControl);
        }
    }

    Status StatusAtualModification()
    {
        objsCount = GameObject.FindGameObjectsWithTag("components");
        int image = 0;
        int text = 0;
        int size = 0;
        foreach (GameObject obj in objsCount)
        {
           if (obj.GetComponent<StatusControl>().insideSlide)
            {
                image += obj.GetComponent<StatusControl>().statusToControl.imageCount;
                text += obj.GetComponent<StatusControl>().statusToControl.textCount;
                size += obj.GetComponent<StatusControl>().statusToControl.itensCount;
            }
        }
        atual.ChangeValues(text, image, size);
        return atual;
    }

    public void CheckTotal(Status check)
    {
        if(check.textCount > goal.textCount || check.imageCount > goal.imageCount || check.itensCount > goal.itensCount)
        {
            libraryOpen.SetActive(false);
        }
        else
        {
            libraryOpen.SetActive(true);
        }
    }
}
