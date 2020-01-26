using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enlarge : Command
{
    // Start is called before the first frame update
   public override void Execute(PlayerMovement x)
   {
       x.transform.localScale = new Vector3 ((x.transform.localScale.x*2), (x.transform.localScale.y*2), (x.transform.localScale.z*2));
   }
}
