using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OnlineSistem : MonoBehaviour { 

    //public Text text;
    public Text isim,Kisi, yourName;

    byte kisiSayisi;
    string Odaisim;
    string Kisiisim;
    private void Awake()
    {
        PhotonNetwork.autoJoinLobby = true;
        PhotonNetwork.ConnectUsingSettings("V1");

         kisiSayisi = byte.Parse( Kisi.text);
         Odaisim = isim.text;
         Kisiisim = yourName.text;
    }
    void OnGUI()
    {
       GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString ());
    }
    void OdaKur()
    {
        void OnGUI()
        {
            if (GUI.Button(new Rect(10, 5, 105, 50), "Yeniden Oyna"))
            {
                Application.LoadLevel(3);
                Time.timeScale = 1f;
            }


        }


        // byte kisisayisi = byte.Parse(Kisi.text);
        PhotonNetwork.JoinOrCreateRoom(Kisiisim, new RoomOptions() { MaxPlayers = kisiSayisi }, TypedLobby.Default);
            Debug.Log("Oda Kuruldu");
            PhotonNetwork.LoadLevel("OyunEkrani(Lvl1)");
    }

    void OnJoinedLobby()
    {
        Debug.Log("lobiye katıldı");
    }

    void OnJoinedRoom()
    {
        PhotonNetwork.playerName = Kisiisim;
        Debug.Log("odaya katıldı"); 
    }

    void OnPhotonJoinRoomFailed()
    {
        Debug.Log("Oda Bulunamadı");
    }
}
