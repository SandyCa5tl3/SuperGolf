using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlockDestruction : MonoBehaviour
{
    public GameObject shrapnel;
    public int maxShrap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        System.Random rand = new System.Random();

        if (other.tag == "Projectile")
        {
            for (int count = 0; count <= rand.Next(1, maxShrap + 1);)
            {
                Instantiate(shrapnel, this.transform.position + new Vector3(4,0,4), Quaternion.identity);
                count++;
            }
            Destroy(this.gameObject);

        }
    }
}
