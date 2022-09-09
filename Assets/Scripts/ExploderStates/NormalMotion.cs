using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalMotion : ExploderState
{
    public override void Exacute(Exploder exploder) => exploder.SlowMotion();
    
}
