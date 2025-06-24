using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class scanner : MonoBehaviour
{
    public float scanRange;
    public LayerMask targerLayer;
    public RaycastHit2D[] targets;
    public Transform nearsetTarget;

    void FixedUpdate()
    {
        targets = Physics2D.CircleCastAll(transform.position, scanRange, Vector2.zero, 0, targerLayer);
        nearsetTarget = GetNearest();
    }

    Transform GetNearest()
    {
        Transform result = null;
        float diff = 100;

        foreach (RaycastHit2D target in targets)
        {
            Vector3 myPos = transform.position;
            Vector3 targetPos = target.transform.position;
            float curDiff = Vector3.Distance(myPos, targetPos);

            if (curDiff < diff) {
                curDiff = diff;
                result = target.transform;
            }
        }

        return result;
    }

}
