using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class ControlUI : MonoBehaviour
{
    public SetUp setUp;
    public GameObject horasPanel;
    public GameObject historiasPanel;
    public GameObject initialPanel;
    public GameObject qntHoras;
    public Slider qntHorasSlide;
    // Start is called before the first frame update
    void Start()
    {
        horasPanel.SetActive(false);
        historiasPanel.SetActive(false);
    }

    public void Hitorias()
    {
        historiasPanel.SetActive(true);
        initialPanel.SetActive(false);
    }

    public void ClickParque()
    {
        setUp.SetHistoriaParque();
        CallHoras();

    }

    public void ClickJornal()
    {
        setUp.SetHistoriaJornal();
        CallHoras();

    }

    public void CallHoras()
    {
        horasPanel.SetActive(true);
    }

    public void Voltar()
    {
        horasPanel.SetActive(false);
    }

    public void SetHoras()
    {
        qntHoras.GetComponent<TextMeshProUGUI>().text = qntHorasSlide.value.ToString();
        setUp.SetHorasAula((int)qntHorasSlide.value);
    }

    public void CallSlides()
    {
        SceneManager.LoadScene("Slides");
    }
}
