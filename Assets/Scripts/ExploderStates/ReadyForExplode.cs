using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyForExplode : ExploderState
{
    public override void Exacute(Exploder exploder) => exploder.Explode();
}
