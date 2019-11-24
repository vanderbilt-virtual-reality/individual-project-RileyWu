using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudiosource : MonoBehaviour
{
    AudioSource sound;
    [SerializeField] float range;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        var leftDrumstickPos = GameObject.Find("LeftDrumstick").transform.position;
        var rightDrumstickPos = GameObject.Find("RightDrumstick").transform.position;
        if ((Mathf.Abs(leftDrumstickPos.x - transform.position.x) < range)
            && (Mathf.Abs(leftDrumstickPos.y - transform.position.y) < range)
            && (Mathf.Abs(leftDrumstickPos.z - transform.position.z) < range))
        {
            sound.Play();
        }
        if ((Mathf.Abs(rightDrumstickPos.x - transform.position.x) < range)
            && (Mathf.Abs(rightDrumstickPos.y - transform.position.y) < range)
            && (Mathf.Abs(rightDrumstickPos.z - transform.position.z) < range))
        {
            sound.Play();
        }
    }
}
