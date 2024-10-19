using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFurnitureFactory
{
    IFurniture Create(FurnitureRequirements requirements);
}