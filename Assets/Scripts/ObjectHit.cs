using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Changes object color upon contact
    void OnCollisionEnter(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
        Debug.Log("Something hit me");
    }
}
