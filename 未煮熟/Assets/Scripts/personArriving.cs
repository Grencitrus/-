using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personArriving : MonoBehaviour
{
    public GameObject myPosition;
    public GameObject myTarget;
    Vector2 myTargetPos;
    private float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        myTargetPos = myTarget.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (myPosition.transform.position.x <= myTargetPos.x)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, myTargetPos, step);
        }

    }
}
