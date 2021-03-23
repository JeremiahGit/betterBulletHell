using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMouseHover : MonoBehaviour
{
    private Vector3 increasedSize, originalSize;
    public float incSizeF = 0.28f;
    public float originalSizeF = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        increasedSize = new Vector3(incSizeF, incSizeF, incSizeF);
        originalSize = new Vector3(originalSizeF, originalSizeF, originalSizeF);
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
