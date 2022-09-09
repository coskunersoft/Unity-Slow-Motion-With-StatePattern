using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkData 
{
    private readonly float forceFactor;

    public JunkData(float forceFactor)
    {
        this.forceFactor = forceFactor;
    }

    public static implicit operator float(JunkData junkData)=>junkData.forceFactor;
}
