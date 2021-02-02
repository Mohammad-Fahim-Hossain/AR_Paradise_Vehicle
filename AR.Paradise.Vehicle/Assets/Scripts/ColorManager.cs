using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ColorManager : MonoBehaviour
{
    [SerializeField] private Material CarColorMaterial;
    [SerializeField] private Material CarRimMaterial;

    [SerializeField] private Material CarLightMaterial;

    

    private Color CarColor;

    public void ChangeColor()
    {
        string ButtonName = EventSystem.current.currentSelectedGameObject.name;

        if (ButtonName == "Aqua")
        {
            CarColor = new Color();
            ColorUtility.TryParseHtmlString("#00FDFF", out CarColor);
            CarColorMaterial.color = CarColor;
            CarRimMaterial.color = CarColor;
        }
        else if( ButtonName== "Marron")
        {
            CarColor = new Color();
            ColorUtility.TryParseHtmlString("#FF0000", out CarColor);
            CarColorMaterial.color = CarColor;
            CarRimMaterial.color = CarColor;
        }
        else if(ButtonName =="White")
        {
            CarColor = new Color();
            ColorUtility.TryParseHtmlString("#FFFFFF", out CarColor);
            CarColorMaterial.color = CarColor;
            CarRimMaterial.color = CarColor;
        }
        else if (ButtonName == "Green")
        {
            CarColor = new Color();
            ColorUtility.TryParseHtmlString("#4BD400", out CarColor);
            CarColorMaterial.color = CarColor;
            CarRimMaterial.color = CarColor;
        }
        else if(ButtonName == "Purpule")
        {
            CarColor = new Color();
            ColorUtility.TryParseHtmlString("#8D00BC", out CarColor);
            CarColorMaterial.color = CarColor;
            CarRimMaterial.color = CarColor;
        }
        else if(ButtonName == "Black")
        {
            CarColor = new Color();
            ColorUtility.TryParseHtmlString("#050505", out CarColor);
            CarColorMaterial.color = CarColor;
            CarRimMaterial.color = CarColor;
        }

    }

    public void LightOn()
    {

        CarLightMaterial.SetColor("_TintColor", Color.white);    
        
    }

    public void LightOff()
    {

        CarLightMaterial.SetColor("_TintColor", Color.black);

    }
        

}
