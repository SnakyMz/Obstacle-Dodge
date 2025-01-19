using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int timeToWait = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            Debug.Log("Lookout below!");
        }
    }
}
