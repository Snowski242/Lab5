using DitzelGames.FastIK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    // Start is called before the first frame update
    public FastIKFabric iKFabric;
    private void Start()
    {
        iKFabric = GetComponent<FastIKFabric>();
        iKFabric.enabled = false;
    }
}
