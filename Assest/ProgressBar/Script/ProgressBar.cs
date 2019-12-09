using UnityEngine;
using UnityEngine.UI;


[ExecuteInEditMode]

public class ProgressBar : MonoBehaviour
{

    public ProgressBar Pb;
    
    public Text txtBataryaBitti;
    
    [Header("Title Setting")]
    public string Title;
    public Color TitleColor;
    public Font TitleFont;
    public int TitleFontSize = 10;
    public int value = 100;
    [Header("Bar Setting")]
    public Color BarColor;
    public Color BarBackGroundColor;
    public Sprite BarBackGroundSprite;
    [Range(1f, 100f)]
    public int Alert = 20;
    public Color BarAlertColor;

    [Header("Sound Alert")]
    public AudioClip sound;
    public bool repeat = false;
    public float RepeatRate = 1f;

    public Image bar, barBackground;
    
    private float nextPlay;
    private AudioSource audiosource;
    public Text txtTitle;
    private float barValue;
    public float BarValue
    {
        get { return barValue; }

        set
        {
            value = Mathf.Clamp(value, 0, 100);
            barValue = value;
            UpdateValue(barValue);

        }

    }



    private void Awake()
    {
        NewMethod();
        barBackground = GetComponent<Image>();
        if (txtTitle != null)
        {
            txtTitle = transform.Find("Text").GetComponent<Text>();
        }

        if (barBackground != null && transform !=null)
        {
            barBackground = transform.Find("BarBackground").GetComponent<Image>();
        }
        audiosource = GetComponent<AudioSource>();
    }

    private void NewMethod()
    {
        if (bar != null)
        {
            bar = transform.Find("Bar").GetComponent<Image>();
        }
        
    }

    private void Start()
    {
        if(txtTitle !=null && bar != null)
        {
            txtTitle.text = Title;
            txtTitle.color = TitleColor;
            txtTitle.font = TitleFont;
            txtTitle.fontSize = TitleFontSize;

            bar.color = BarColor;
            bar.fillAmount = 1;
        }
        

        barBackground.color = BarBackGroundColor;
        barBackground.sprite = BarBackGroundSprite;

        UpdateValue(barValue);


    }

    void UpdateValue(float val)
    {
        // bar.fillAmount = val / 100;
        //txtTitle = GetComponent<Text>();
        //txtTitle.text = Title + " " + val + "%";

        if (Alert >= val)
        {
            bar.color = BarAlertColor;
        }
        else
        {
            bar.color = BarColor;
        }



    }


    private void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            bar.fillAmount -= 0.001f;
            float batarya = bar.fillAmount;

            if (batarya == 0)
            {
                
                txtBataryaBitti.text = "BATARYA BİTTİ";
                Time.timeScale = 0;

            }
        }


        if (!Application.isPlaying)
        {
            UpdateValue(50);
            txtTitle.color = TitleColor;
            txtTitle.font = TitleFont;
            txtTitle.fontSize = TitleFontSize;

            bar.color = BarColor;
            barBackground.color = BarBackGroundColor;

            barBackground.sprite = BarBackGroundSprite;
        }
        else
        {
            if (Alert >= barValue && Time.time > nextPlay)
            {
                nextPlay = Time.time + RepeatRate;
                audiosource.PlayOneShot(sound);
            }
        }
    }

}
