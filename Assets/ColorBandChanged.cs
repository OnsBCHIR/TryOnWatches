using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColorBandChanged : MonoBehaviour
{
    public Material band1;
    public Material band2;
    public Material band3;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void w1ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "blue") {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#0E00B0", out myColor);
            band1.color = myColor;
        }
        
        else if (buttonName == "black") {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band1.color = myColor;
        }
    }
    public void w2ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "red") { 
                Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#990000", out myColor);
            band2.color = myColor;
        }
        else if (buttonName == "black") {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#000000", out myColor);
            band2.color = myColor;
        }

    }
    public void w3ColorSelect()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "Silver") {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#A4A1A1", out myColor);
            band3.color = myColor;
        }
        else if (buttonName == "black") {
            Color myColor = new Color();
            ColorUtility.TryParseHtmlString("#201F1F", out myColor);
            band3.color = myColor;
        }

    }


}
