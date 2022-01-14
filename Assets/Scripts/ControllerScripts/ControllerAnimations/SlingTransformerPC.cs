using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingTransformerPC : MonoBehaviour
{
    public GameObject cannon;
    public float transformerDampener = 0.01f;

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y, 1 + -(cannon.GetComponent<FinalControllerPC>().pullDis * transformerDampener));
    }
}
