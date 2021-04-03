using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    // Attach waypoint script to the cubes(path) like tagging them.
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] float waitTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FollowPath());

    }

    // IEnumerator returns sth countable, creating co-routine with waiting for 1f, yield means give up control. we are stopping for 1 sec.
    IEnumerator FollowPath(){
        foreach ( Waypoint waypoint in path){
            //Debug.Log(waypoint.name);
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
