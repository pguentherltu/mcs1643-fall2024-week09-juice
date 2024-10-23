using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSparks : MonoBehaviour
{
    public AudioClip BounceSound;

    public GameObject SparksPrefab;
    private void OnCollisionEnter(Collision coll)
    {
        // figure out where the collision happened
        Vector3 point = coll.GetContact(0).point;

        // instantiate the spark prefab there
        GameObject sparks = Instantiate(SparksPrefab, point, Quaternion.identity);

        // shake the camera
        CameraEffects.Shake(.4f, true);

        //play the sound effect
        AudioSource.PlayClipAtPoint(BounceSound, point);

        // destroy the sparks after a second
        Destroy(sparks, 1.0f);
    }
}
