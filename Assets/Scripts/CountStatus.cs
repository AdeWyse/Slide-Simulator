using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountStatus : MonoBehaviour
{
    public GameObject goal;
    public GameObject atual;

    public ArrayList statusCount;
    // Start is called before the first frame update
    void Start()
    {
        statusCount = new ArrayList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddStatusCount(GameObject add)
    {
        Status addCount = add.GetComponentInChildren<StatusControl>().statusToControl;
        statusCount.Add(addCount);
    }
}
