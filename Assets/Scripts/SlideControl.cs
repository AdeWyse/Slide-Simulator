using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideControl : MonoBehaviour
{
    public GameObject statusAtualObj;
    public GameObject goalObj;
    public Status atual;
    public Status goal;

    GameObject[] objsCount;

    // Start is called before the first frame update
    private void Awake()
    {
       objsCount = GameObject.FindGameObjectsWithTag("components");

    }
    void Start()
    {
        
        goalObj = GameObject.FindGameObjectWithTag("goal");
        goal = new Status(100, 100, 5);//Implementar recuperar infomrção da historia
        atual = new Status(0, 0, 0);
        goalObj.GetComponent<StatusControl>().statusToControl = goal;
        statusAtualObj.GetComponent<StatusControl>().statusToControl = atual;



    }

    // Update is called once per frame
    void Update()
    {
        statusAtualObj.GetComponent<StatusControl>().statusToControl = StatusAtualModification();

    }

    Status StatusAtualModification()
    {
        statusAtualObj = GameObject.FindGameObjectWithTag("status");
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
}
