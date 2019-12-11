using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMain : MonoBehaviour
{
    public Text oyunBitti;

    [Header("UIPages")]
    public GameObject settingScreen;
    public GameObject createRoomScreen;
    public GameObject mainScreen;


    public void startGameOyunEkrani()
    {
        SceneManager.LoadScene("TekKisiliOyun");
            
    }

    public void StartgameOdaKur()
    {
        SceneManager.LoadScene("OdaKur");
    }
    public void StartAyarlarEkrani()
    {

        SceneManager.LoadScene("Ayarlar");
    }
    public void SkorlarEkrani()
    {

        SceneManager.LoadScene("Skorlar");
    }
    public void Settings()
    {
        mainScreen.SetActive(false);
        settingScreen.SetActive(true);


    }
    public void GeriGel()
    {
        SceneManager.LoadScene("GirisEkrani");
    }

    public void createRoom()
    {
        mainScreen.SetActive(false);
        createRoomScreen.SetActive(true);
    }

    public void Scores()
    {

    }
    public void Exit()
    {

        Application.Quit();
        Debug.Log("editörde olduğunuz için çıkış yapılmaz build etmeniz lazım ");
    }

    private void OnTriggerEnter(Collider other)
    {

        Destroy(other.gameObject);
        oyunBitti.text = "OYUN BİTTİ";
        Time.timeScale = 1;
        Debug.Log("TEMAS EDİLDİ");

    }


}
