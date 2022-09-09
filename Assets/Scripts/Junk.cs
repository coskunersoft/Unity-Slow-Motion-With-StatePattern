using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Junk : MonoBehaviour
{
    JunkData junkData;
    private Rigidbody physicBody;

    private void Awake()
    {
        TryGetComponent(out physicBody);
    }
    void Start()
    {
        junkData = new JunkData(Random.Range(1, 20));
    }

    public void Explode(Vector3 explosionCenter)
    {
        physicBody.AddExplosionForce(junkData,explosionCenter,5,3);
    }
}
