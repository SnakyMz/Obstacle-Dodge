using Unity.VisualScripting;
using UnityEngine;

public class FlyToPlayer : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] Transform player;
    Vector3 playerPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        gameObject.SetActive(false);
    }
    
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
