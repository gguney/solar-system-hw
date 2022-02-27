using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class Spawner : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            GameObject newStar = Instantiate(Resources.Load("Prefabs/Star") as GameObject, Vector3.zero, Quaternion.identity);
            newStar.transform.position = new Vector3(Random.Range(1, 20), Random.Range(0, 10), Random.Range(-5, 20));
            newStar.transform.Rotate(new Vector3(Random.Range(0, 90), Random.Range(0, 90), Random.Range(0, 90)));
            yield return new WaitForSeconds(1);
        }
    }
}
