using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunBaslangic : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        PhotonNetwork.Instantiate("AnimatedPlayerController", Vector3.zero, Quaternion.identity, 0);
    }

    
}
