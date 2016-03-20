using UnityEngine;
using System.Collections;

public class TrashMove : MonoBehaviour
{
    public float speed = 1f;
    GameObject player;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Player");
        if (player)
            GetComponent<NavMeshAgent>().destination = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(player.transform.position);
        //transform.Rotate(Vector3.down, speed );
    }

    void Awake() { Destroy(gameObject, 20); }
}