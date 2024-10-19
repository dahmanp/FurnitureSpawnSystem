using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedroomFactory : IFurnitureFactory
{
    public IFurniture Create(FurnitureRequirements requirements)
    {
        if (requirements.height == 0) //tall
        {
            if (requirements.action == 0) //sitting
            {
                return new Desk();
            }
            else //laying
            {
                return new Bed();
            }
        }
        else //short
        {
            if (requirements.action == 0) //sitting
            {
                return new AccentChair();
            }
            else //laying
            {
                return new Rug();
            }
        }
    }
}
