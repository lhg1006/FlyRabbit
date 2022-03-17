using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VineMake : MonoBehaviour
{
    public GameObject Vine;
    public float timeDiff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            GameObject newVine = Instantiate(Vine);
            newVine.transform.position = new Vector3(12, Random.Range(-1.2f, 3.9f) ,0);
            timer = 0;
            Destroy(newVine, 11);
        }
        
    }
}
