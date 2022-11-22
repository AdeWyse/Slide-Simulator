using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameController  gm;
    public int type;

    public Status status;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameController").GetComponent<GameController>();
        type = gm.typeSlide;
        SetGoals();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetGoals()
    {
        switch (type)
        {
            case 1:
                setParque();
                break;
            case 2:
                setJornal();
                break;
            default:
                setSafe();
                break;
        }
    }

    public void setParque()
    {
        status = new Status(25, 50, 5);
    }

    public void setJornal()
    {
        status = new Status(50, 25, 5);
    }

    public void setSafe()
    {
        status = new Status(50, 50, 5);
    }
}
