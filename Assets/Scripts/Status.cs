using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Status 
{
    public int textCount;
    public int imageCount;
    public int itensCount;

    public Status(int textCount, int imageCount, int itensCount)
    {
        this.textCount = textCount;
        this.imageCount = imageCount;
        this.itensCount = itensCount;
    }

    public void ChangeValues(int textCount, int imageCount, int itensCount)
    {
        this.textCount = textCount;
        this.imageCount = imageCount;
        this.itensCount = itensCount;
    }
}
