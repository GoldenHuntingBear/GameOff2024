using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionController : MonoBehaviour
{
    public LayerMask visionLayer;
    private SpriteMask spriteMask;

    // Start is called before the first frame update
    void Start()
    {
        spriteMask = GetComponent<SpriteMask>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Collider2D[] visionObjects = Physics2D.OverlapCircleAll(new Vector2(transform.position.x, transform.position.y), transform.lossyScale.x / 2, visionLayer);
        foreach (Collider2D g in visionObjects)
        {
            g.transform.parent.GetComponent<HoleController>().Activate();
        }
    }
}
