using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivingRoomFactory : IFurnitureFactory
{
    public IFurniture Create(FurnitureRequirements requirements)
    {
        if (requirements.height == 0) //tall
        {
            if (requirements.action == 0) //sitting
            {
                return new Ottoman();
            }
            else //laying
            {
                return new Sofa();
            }
        }
        else //short
        {
            if (requirements.action == 0) //sitting
            {
                return new Beanbag();
            }
            else //laying
            {
                return new CoffeeTable();
            }
        }
    }
}
