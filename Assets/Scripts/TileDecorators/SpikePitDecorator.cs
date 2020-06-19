using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikePitDecorator : TileDecorator
{
    private void Awake()
    {
            
    }

    public override int Damage
    {
        get { return base.Damage + CalcDamage(); }
    }

    //Calculate the spike pit will deal
    protected int CalcDamage()
    {
        return 5;
    }
}
