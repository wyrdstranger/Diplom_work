using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondLevelNpc : MonoBehaviour
{
    public GameObject CharacterToFollow;
    public GameObject TheNPC;
    public float TargetDistance;
    public float AllowedDistance=5;
    public float FollowSpeed;
    public RaycastHit Shot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(CharacterToFollow.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
            TargetDistance = Shot.distance;
            if (TargetDistance >= AllowedDistance)
            {
                FollowSpeed = 0.09f;
                //TheNPC.GetComponent<Animation>().Play("Running");
                transform.position = Vector3.MoveTowards(transform.position, CharacterToFollow.transform.position, FollowSpeed);
            }
            else
            {
                FollowSpeed = 0;
                //TheNPC.GetComponent<Animation>().Play("Idle");
            }
        }
    }
}
