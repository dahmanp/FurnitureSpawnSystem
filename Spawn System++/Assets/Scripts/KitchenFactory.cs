using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenFactory : IFurnitureFactory
{
    public IFurniture Create(FurnitureRequirements requirements)
    {
        if (requirements.height == 0) //tall
        {
            if (requirements.action == 0) //sitting
            {
                return new Barstool();
            }
            else //laying
            {
                return new Counter();
            }
        }
        else //short
        {
            if (requirements.action == 0) //sitting
            {
                return new KitchenChair();
            }
            else //laying
            {
                return new DiningTable();
            }
        }
    }
}
