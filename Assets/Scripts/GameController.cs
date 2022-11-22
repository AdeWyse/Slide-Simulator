using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameController : MonoBehaviour
{
    public GameObject slideIconArea;
    public GameObject slideArea;

    public GameObject slideIcon;
    public Button slideIconButton;
    public GameObject slidePanel;

    public ArrayList slideList;

    public int hourCount = 1;
    public int quantityOfSlides;

    public int typeSlide;

    SetUp setUp;
    // Start is called before the first frame update
    void Start()
    {
        setUp = GameObject.Find("SetUp").GetComponent<SetUp>();
        slideList = new ArrayList();
        GetHourCount();
        CalculateNumberOfSLides();
        CreateSlides();
        SetGoals();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetHourCount()
    {
        hourCount = setUp.horasAula;

        if (hourCount <= 0)
        {
            hourCount = 1;
        }
    }

    public void CalculateNumberOfSLides()
    {
        quantityOfSlides = 5 * hourCount;
    }

    public void CreateSlides()
    {
        for (int i = 0; i < quantityOfSlides; i++)
        {
            GameObject slideI = Instantiate(slideIcon, slideIconArea.transform, true);
            GameObject slideP = Instantiate(slidePanel, slideArea.transform, false);
            slideI.name = "slideIcon" + i;
            slideP.name = "slidePanel" + i;
            slideList.Add(slideP);
            slideIconButton = slideI.GetComponentInChildren<Button>();
            slideIconButton.gameObject.name = "Button" + i;
            slideIconButton.onClick.AddListener(ButtonSlideControl);
        }
    }

    public void ButtonSlideControl()
    {
        string buttonClicked = EventSystem.current.currentSelectedGameObject.name;
        char number = buttonClicked[buttonClicked.Length - 1];
        foreach(GameObject slide in slideList)
        {
            char numberSlide = slide.name[slide.name.Length - 1];
            if ( numberSlide == number){
                slide.SetActive(true);
            }
            else
            {
                slide.SetActive(false);
            }
        }
    }

    public void SetGoals()
    {
        typeSlide = setUp.historia;
    }
}
