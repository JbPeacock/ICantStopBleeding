using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour
{
    private PlayerController player;
    private CameraAdjust mainCam;

    public Vector2 playerStartFace;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
        player.transform.position = transform.position;

        mainCam = FindObjectOfType<CameraAdjust>();
        mainCam.transform.position =
            new Vector3(transform.position.x, transform.position.y, mainCam.transform.position.z);

        player.lastMove = playerStartFace;
    }

}
