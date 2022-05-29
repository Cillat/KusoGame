using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    private Rigidbody mRigidbody;
    private GameObject mJudgeWallRight;
    // Start is called before the first frame update
    void Start()
    {
        mRigidbody = this.gameObject.GetComponent<Rigidbody>();
        mJudgeWallRight = GameObject.Find("JudgeArea/JudgeWallRight");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            mRigidbody.AddForce(0f, 0f, 0.3f, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            mRigidbody.AddForce(0f, 0f, -0.3f, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            mRigidbody.AddForce(-0.3f, 0f, 0f, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            mRigidbody.AddForce(0.3f, 0f, 0f, ForceMode.Force);
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == mJudgeWallRight)
        {
            Vector3 instantiatePos = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, this.gameObject.transform.position.z - 0.5f);
            Instantiate(this.gameObject,instantiatePos, Quaternion.identity);
        }
    }
}
