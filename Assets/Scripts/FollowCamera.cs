using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.InputSystem.LowLevel;

public class FollowCamera : MonoBehaviour
{
    PhotonView view;
    public float followSpeed = 2f;
    public float yOffset = 1f;
    public Transform target;
    void Update()
    {
       Vector3 newPos = new Vector3(target.position.x, target.position.y + yOffset, -10f);
       transform.position = Vector3.Slerp(transform.position, newPos, followSpeed * Time.deltaTime);
    }
    void Start(){
            view = GetComponent<PhotonView>();
    }
}
