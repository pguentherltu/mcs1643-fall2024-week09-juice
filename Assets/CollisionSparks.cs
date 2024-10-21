using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSparks : MonoBehaviour
{
    public GameObject SparksPrefab;
    private void OnCollisionEnter(Collision coll)
    {
        // figure out where the collision happened
        Vector3 point = coll.GetContact(0).point;

        // instantiate the spark prefab there
        Instantiate(SparksPrefab, point, Quaternion.identity);

        // destroy the sparks after a second
        Destroy(SparksPrefab, 1.0f);
    }
}
