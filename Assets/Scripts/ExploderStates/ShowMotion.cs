using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMotion : ExploderState
{
    public override void Exacute(Exploder exploder) => exploder.NormalMotion();
}
