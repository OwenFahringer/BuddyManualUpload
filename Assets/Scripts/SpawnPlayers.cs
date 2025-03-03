using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject PlayerCamera; // Add a reference to the camera prefab
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;

    private void Start(){
        Vector2 randomPosition = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        GameObject player = PhotonNetwork.Instantiate(playerPrefab.name, randomPosition, Quaternion.identity);

        // Instantiate the camera and set its target to the instantiated player
        GameObject camera = Instantiate(PlayerCamera);
        FollowCamera followCamera = camera.GetComponent<FollowCamera>();
        if (followCamera != null)
        {
            followCamera.target = player.transform;
        }
    }
}