using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusControl : MonoBehaviour
{
    public Status statusToControl;
    public Slider imageSlider;
    public Slider textSlider;
    public Slider itenSlider;

    public Boolean insideSlide;
    // Start is called before the first frame update
    void Start()
    {
        insideSlide = false;
    }

    // Update is called once per frame
    void Update()
    {
        NotNegative();
        NotTooMuch();
        SetSliderPos();
    }

    public void NotNegative()
    {

        if (statusToControl.textCount < 0)
        {
            statusToControl.textCount = 0;
        }
        if (statusToControl.imageCount < 0)
        {
            statusToControl.imageCount = 0;
        }
        if (statusToControl.itensCount < 0)
        {
            statusToControl.itensCount = 0;
        }
    }

    public void NotTooMuch()
    {

        if (statusToControl.textCount > 100)
        {
            statusToControl.textCount = 100;
        }
        if (statusToControl.imageCount > 100)
        {
            statusToControl.imageCount = 100;
        }
        if (statusToControl.itensCount > 5)
        {
            statusToControl.itensCount = 5;
        }
    }

    public void SetSliderPos()
    {
        imageSlider.value = statusToControl.imageCount;
        textSlider.value = statusToControl.textCount;
        itenSlider.value = statusToControl.itensCount;
    }
}
