using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconSize : MonoBehaviour
{
    public Vector2 size;
    public Vector2 sizeBig;
    public Vector2 sizeGiant;
    public Vector2 sizeTitle;
    // Start is called before the first frame update
    void Start()
    {
        size = new Vector2(227.96f, 176.38f);
        sizeBig = new Vector2(435.2278f, 321.2397f);
        sizeGiant = new Vector2(500f, 400f);
        sizeTitle = new Vector2(331.8695f, 30.7742f);
}

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Resize()
    {
        string nome = this.gameObject.name;
        switch (nome)
        {
            case "Size":
                this.gameObject.GetComponent<Image>().rectTransform.sizeDelta = size;
                break;
            case "Big":
                this.gameObject.GetComponent<Image>().rectTransform.sizeDelta = sizeBig;
                break;
            case "Giant":
                this.gameObject.GetComponent<Image>().rectTransform.sizeDelta = sizeGiant;
                break;
            case "Title":
                this.gameObject.GetComponent<Image>().rectTransform.sizeDelta = sizeTitle;
                break;
            default:
                break;
        }
        
    }
}
