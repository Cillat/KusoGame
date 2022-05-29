using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPos : MonoBehaviour
{
    private GameObject mPlayer;
    private Vector3 mPlayerPos;
    private Vector3 mCameraPos;
    // Start is called before the first frame update
    void Start()
    {
        mPlayer = GameObject.Find("Sphere");
        mPlayerPos = GameObject.Find("Sphere").GetComponent<Transform>().position;
        mCameraPos = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        mPlayerPos = mPlayer.GetComponent<Transform>().position;
        mCameraPos = mPlayerPos - new Vector3(0f, -0.7f, 2f);
        this.gameObject.transform.position = mCameraPos;
    }
}
