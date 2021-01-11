using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMouseHover : MonoBehaviour
{
    private Vector3 increasedSize, originalSize;
    // Start is called before the first frame update
    void Start()
    {
        increasedSize = new Vector3(0.28f, 0.28f, 0.28f);
        originalSize = new Vector3(.25f, .25f, .25f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        transform.localScale = increasedSize;
    }

    private void OnMouseExit()
    {
        transform.localScale = originalSize;
    }
}
