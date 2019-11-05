using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Random.Range(-2f,2f)*Time.deltaTime, Mathf.Sin(Time.time)*Time.deltaTime*0.8f, Random.Range(-2f, 2f) * Time.deltaTime);

    }
}
