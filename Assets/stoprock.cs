using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoprock : Collidable
{
    public bool colltrawarock;

    protected override void OnCollide(Collider2D coll)
    {
        if(coll.name == "trawa")
        {
            colltrawarock = true;
        }
    }
}
