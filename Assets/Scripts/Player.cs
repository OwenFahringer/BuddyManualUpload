using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.InputSystem.LowLevel;
public class Player : MonoBehaviour
{
    public float speed;

    // Animator anim;
    // ScoreManager scoreManager;
    GameObject coin;
    PhotonView view;

private void Start(){
    // anim = GetComponent<Animator>();
    // scoreManager = FindObjectOfType<ScoreManager>();
    view = GetComponent<PhotonView>();
}
void Update(){
    if(view.IsMine){
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position += input.normalized * speed * Time.deltaTime;

        // if(input == Vector3.zero){
        //     // anim.setBool("isWalking", false);
        // }else{
        //     // anim.setBool("isWalking", true);
        // }
    }
    }

}
