using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUp : MonoBehaviour
{
    public int modo = 1;
    public int historia = 0;
    public int horasAula = 1;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void SetHistoriaParque()
    {
        historia = 1;
    }

    public void SetHistoriaJornal()
    {
        historia = 2;
    }



    public void SetHorasAula(int i)
    {
        if(i > 0)
        {
            horasAula = i;

        }
        else
        {
            horasAula = 1;
        }
    }

}
