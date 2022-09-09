using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public sealed class Exploder : MonoBehaviour
{
    private ExploderState exploderState;
    private NormalMotion normalMotion;
    private SlowMotion slowMotion;
    private ReadyForExplode readyForExplode;
    [SerializeField]private List<Junk> junks;

    private void Start()
    {
        readyForExplode = new ReadyForExplode();
        slowMotion = new SlowMotion();
        normalMotion = new NormalMotion();
        exploderState = readyForExplode;

        for (int i = 2; i < 10; i++)
        {
            Debug.Log(i);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            exploderState.Exacute(this);

       
            
    }

    public void Explode()
    {
        while (junks.Count>0)
        {
            junks[0].Explode(transform.position);
            junks.RemoveAt(0);
        }
        exploderState = normalMotion;
    }
    public void SlowMotion()
    {
        Time.timeScale = .1f;
        Time.fixedDeltaTime = Time.timeScale * .02f;
        exploderState = slowMotion;
    }
    public void NormalMotion()
    {
        Time.timeScale = 1f;
        
        exploderState = normalMotion;
    }
}
