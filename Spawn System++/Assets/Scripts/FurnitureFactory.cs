using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureFactory : AbstractFurnitureFactory
{
    private readonly IFurnitureFactory _factory;
    private readonly FurnitureRequirements _requirements;

    public FurnitureFactory(FurnitureRequirements requirements)
    {
        switch (requirements.roomType)
        {
            case 1:
                _factory = new KitchenFactory();
                break;
            case 2:
                _factory = new LivingRoomFactory();
                break;
            case 3:
                _factory = new BedroomFactory();
                break;
        }
        _requirements = requirements;
    }

    public override IFurniture Create()
    {
        return _factory.Create(_requirements);
    }
}