using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Client : MonoBehaviour
{
    public TMP_Text FurnitureName;
    public TMP_Dropdown roomTypeOptions;
    public TMP_Dropdown actionOptions;
    public TMP_Dropdown heightOptions;
    public Image furnImage;
    public Sprite[] images;

    public int r;
    public int a;
    public int h;

    public void FurnitureButton()
    {
        r = roomTypeOptions.value;
        h = heightOptions.value - 1;
        a = actionOptions.value - 1;

        FurnitureRequirements requirements = new FurnitureRequirements
        {
            roomType = r,
            height = h,
            action = a
        };

        IFurniture v = GetFurniture(requirements);
        Debug.Log(v);

        FurnitureName.text = v.GetType().Name;

        if (v.GetType().Name == "Barstool")
        {
            furnImage.sprite = images[0];
        }
        else if (v.GetType().Name == "DiningTable")
        {
            furnImage.sprite = images[1];
        }
        else if (v.GetType().Name == "Counter")
        {
            furnImage.sprite = images[2];
        }
        else if (v.GetType().Name == "KitchenChair")
        {
            furnImage.sprite = images[3];
        }
        else if (v.GetType().Name == "Bed")
        {
            furnImage.sprite = images[4];
        }
        else if (v.GetType().Name == "Desk")
        {
            furnImage.sprite = images[5];
        }
        else if (v.GetType().Name == "Rug")
        {
            furnImage.sprite = images[6];
        }
        else if (v.GetType().Name == "AccentChair")
        {
            furnImage.sprite = images[7];
        }
        else if (v.GetType().Name == "Sofa")
        {
            furnImage.sprite = images[8];
        }
        else if (v.GetType().Name == "Ottoman")
        {
            furnImage.sprite = images[9];
        }
        else if (v.GetType().Name == "CoffeeTable")
        {
            furnImage.sprite = images[10];
        }
        else if (v.GetType().Name == "Beanbag")
        {
            furnImage.sprite = images[11];
        }
    }

    private static IFurniture GetFurniture(FurnitureRequirements requirements)
    {
        FurnitureFactory factory = new FurnitureFactory(requirements);
        return factory.Create();
    }
}