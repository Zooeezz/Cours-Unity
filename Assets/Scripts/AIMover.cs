using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMover : MonoBehaviour
{

    [Tooltip("Vitesse de déplacement"), Range(0, 15)]
    public float linearSpeed = 6;
    [Tooltip("Vitesse de rotation"), Range(1, 5)]
    public float angularSpeed = 1;
    private Transform player;
    public Vector3 dirPlayer;
    public float life = 100;
    Animator anim;
    KillCount killCountScript;

    // Start is called before the first frame update
    public void Start()
    {
        GameObject goPlayer = GameObject.FindGameObjectWithTag("Player");
        player = goPlayer.transform;
        anim = GetComponent<Animator>();
        killCountScript = GameObject.Find("GameManager").GetComponent<KillCount>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            dirPlayer = player.position - transform.position;

            dirPlayer.y = 0;
            Quaternion rotation = Quaternion.LookRotation(dirPlayer);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, angularSpeed);

            if (rb.velocity.magnitude < 10)
            {
                rb.AddForce(transform.forward * 5 * linearSpeed);
            }

            if (anim != null)
            {
                anim.SetFloat("Speed", rb.velocity.magnitude);
            }
        }

        if (life <= 0)
        {
            killCountScript.killCount += 1;
            Destroy(gameObject);
        }

    }
    private void OnDrawGizmos()
    {
        //Gizmos.color = Color.green;
        //Gizmos.DrawLine(transform.position)
    }
}
