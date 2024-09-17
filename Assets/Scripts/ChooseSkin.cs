using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChooseSkin : MonoBehaviour
{


    public SpriteRenderer skinMenu;
    public TextMeshProUGUI totalCoins;
    public TextMeshProUGUI totalCoinsInMenu;
    public Image Eliav;

    //kai
    public Image Kai;
    public GameObject kaiLocked;
    //bechor
    public Image Bechor;
    public GameObject bechorLocked;
    public GameObject bechorCanBuy;
    //maman
    public Image Maman;
    public GameObject mamanLocked;
    public GameObject mamanCanBuy;

    //Kobi
    public Image Kobi;
    public GameObject kobiLocked;
    public GameObject kobiCanBuy;

    //Yuvgal
    public Image yuvgal;
    public GameObject yuvgalLocked;

    //Gunthar
    public Image gunthar;
    public GameObject guntharLocked;
    public GameObject guntharCanBuy;

    //Kook
    public Image kook;
    public GameObject kookLocked;

    //Meny
    public Image meny;
    public GameObject menyLocked;
    public GameObject menyCanBuy;

    //Beny
    public Image beny;
    public GameObject benyLocked;
    public GameObject benyCanBuy;

    //Hendler
    public Image hendler;
    public GameObject hendlerLocked;
    public GameObject hendlerCanBuy;

    //Mosti
    public Image mosti;
    public GameObject mostiLocked;
    public GameObject mostiCanBuy;

    //Yali
    public Image yali;
    public GameObject yaliLocked;
    public GameObject yaliCanBuy;

    //secretSkin
    public Image secretSkin;
    public Sprite secretSprite;
    public GameObject DoubleCoins;

    //
    public SkinMenu sm;


     void Update()
    {
        //CoinsView
        totalCoinsInMenu.text = PlayerPrefs.GetInt("totalCoins").ToString();


        //Bechor
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 20)
        {
            bechorCanBuy.SetActive(true);
        }
        else
        {
            bechorCanBuy.SetActive(false);
        }
        //Maman
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 40)
        {
            mamanCanBuy.SetActive(true);
        }
        else
        {
            mamanCanBuy.SetActive(false);
        }

        //Kobi
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 69)
        {
            kobiCanBuy.SetActive(true);
        }
        else
        {
            kobiCanBuy.SetActive(false);
        }

        //gunthar
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 75)
        {
            guntharCanBuy.SetActive(true);
        }
        else
        {
            guntharCanBuy.SetActive(false);
        }

        //meny
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 80)
        {
            menyCanBuy.SetActive(true);
        }
        else
        {
            menyCanBuy.SetActive(false);
        }

        //beny
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 85)
        {
            benyCanBuy.SetActive(true);
        }
        else
        {
            benyCanBuy.SetActive(false);
        }

        //hendler
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 90)
        {
            hendlerCanBuy.SetActive(true);
        }
        else
        {
            hendlerCanBuy.SetActive(false);
        }

        //mosti
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 100)
        {
            mostiCanBuy.SetActive(true);
        }
        else
        {
            mostiCanBuy.SetActive(false);
        }

        //yali
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 420)
        {
            yaliCanBuy.SetActive(true);
        }
        else
        {
            yaliCanBuy.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

        //Colors if unlocked
        if (PlayerPrefs.GetString("unlocked:kai", "false") == "true")
        {
            Kai.color = new Color(255, 255, 255);
            kaiLocked.SetActive(false);
        }
        if (PlayerPrefs.GetString("unlocked:bechor", "false") == "true")
        {
            Bechor.color = new Color(255, 255, 255);
            bechorLocked.SetActive(false);
        }
        if (PlayerPrefs.GetString("unlocked:maman", "false") == "true")
        {
            Maman.color = new Color(255, 255, 255);
            mamanLocked.SetActive(false);
        }
        if (PlayerPrefs.GetString("unlocked:kobi", "false") == "true")
        {
            Kobi.color = new Color(255, 255, 255);
            kobiLocked.SetActive(false);
        }

        if (PlayerPrefs.GetString("unlocked:yuvgal", "false") == "true")
        {
            yuvgal.color = new Color(255, 255, 255);
            yuvgalLocked.SetActive(false);
        }

        if (PlayerPrefs.GetString("unlocked:gunthar", "false") == "true")
        {
            gunthar.color = new Color(255, 255, 255);
            guntharLocked.SetActive(false);
        }

        if (PlayerPrefs.GetString("unlocked:kook", "false") == "true")
        {
            kook.color = new Color(255, 255, 255);
            kookLocked.SetActive(false);
        }

        if (PlayerPrefs.GetString("unlocked:meny", "false") == "true")
        {
            meny.color = new Color(255, 255, 255);
            menyLocked.SetActive(false);
        }

        if (PlayerPrefs.GetString("unlocked:beny", "false") == "true")
        {
            beny.color = new Color(255, 255, 255);
            benyLocked.SetActive(false);
        }

        if (PlayerPrefs.GetString("unlocked:hendler", "false") == "true")
        {
            hendler.color = new Color(255, 255, 255);
            hendlerLocked.SetActive(false);
        }

        if (PlayerPrefs.GetString("unlocked:mosti", "false") == "true")
        {
            mosti.color = new Color(255, 255, 255);
            mostiLocked.SetActive(false);
        }

        if (PlayerPrefs.GetString("unlocked:yali", "false") == "true")
        {
            yali.color = new Color(255, 255, 255);
            yaliLocked.SetActive(false);
        }


        if (PlayerPrefs.GetString("unlocked:secretskin", "false") == "true")
        {
            secretSkin.sprite = secretSprite;
            DoubleCoins.SetActive(true);
        }

        //Coins on startup && checks
        totalCoins.text = PlayerPrefs.GetInt("totalCoins", 0).ToString();


        //Setting skin on start
        if (PlayerPrefs.GetString("skin") == "eliav")
        {
            skinMenu.sprite = Eliav.sprite;
        }
        if (PlayerPrefs.GetString("skin") == "kai")
        {
                skinMenu.sprite = Kai.sprite;
        }
        if (PlayerPrefs.GetString("skin") == "bechor")
        {
            skinMenu.sprite = Bechor.sprite;
        }
        if (PlayerPrefs.GetString("skin") == "maman")
        {
            skinMenu.sprite = Maman.sprite;
        }
        if (PlayerPrefs.GetString("skin") == "kobi")
        {
            skinMenu.sprite = Kobi.sprite;
        }
        if (PlayerPrefs.GetString("skin") == "yuvgal")
        {
            skinMenu.sprite = yuvgal.sprite;
        }
        if (PlayerPrefs.GetString("skin") == "gunthar")
        {
            skinMenu.sprite = gunthar.sprite;
        }
        if (PlayerPrefs.GetString("skin") == "kook")
        {
            skinMenu.sprite = kook.sprite;
        }
        if (PlayerPrefs.GetString("skin") == "meny")
        {
            skinMenu.sprite = meny.sprite;
        }
        if (PlayerPrefs.GetString("skin") == "beny")
        {
            skinMenu.sprite = beny.sprite;
        }
        if (PlayerPrefs.GetString("skin") == "hendler")
        {
            skinMenu.sprite = hendler.sprite;
        }
        if (PlayerPrefs.GetString("skin") == "mosti")
        {
            skinMenu.sprite = mosti.sprite;
        }
        if (PlayerPrefs.GetString("skin") == "yali")
        {
            skinMenu.sprite = yali.sprite;
        }
        if (PlayerPrefs.GetString("skin") == "secretskin")
        {
            skinMenu.sprite = secretSkin.sprite;
        }
    }

    //Setting skins
    public void EliavSkin()
    {
        skinMenu.sprite = Eliav.sprite;
        sm.showMenu();
        PlayerPrefs.SetString("skin", "eliav");
    }
    public void KaiSkin()
    {
        if (PlayerPrefs.GetString("unlocked:kai","false") == "true")
        {
            skinMenu.sprite = Kai.sprite;
            sm.showMenu();
            PlayerPrefs.SetString("skin", "kai");
        } else if (PlayerPrefs.GetString("unlocked:kai", "false") == "false")
        {
            
        }
    }
    public void BechorSkin()
    {
        if (PlayerPrefs.GetString("unlocked:bechor", "false") == "true")
        {
            skinMenu.sprite = Bechor.sprite;
            sm.showMenu();
            PlayerPrefs.SetString("skin", "bechor");
        } else if (PlayerPrefs.GetString("unlocked:bechor", "false") == "false")
        {

        }
    }
    public void MamanSkin()
    {
        if (PlayerPrefs.GetString("unlocked:maman", "false") == "true")
        {
            skinMenu.sprite = Maman.sprite;
            sm.showMenu();
            PlayerPrefs.SetString("skin", "maman");
        }
    }
    public void KobiSkin()
    {
        if (PlayerPrefs.GetString("unlocked:kobi", "false") == "true")
        {
            skinMenu.sprite = Kobi.sprite;
            sm.showMenu();
            PlayerPrefs.SetString("skin", "kobi");
        }
    }
    public void YuvgalSkin()
    {
        if (PlayerPrefs.GetString("unlocked:yuvgal", "false") == "true")
        {
            skinMenu.sprite = yuvgal.sprite;
            sm.showMenu();
            PlayerPrefs.SetString("skin", "yuvgal");
        }
    }
    public void GuntharSkin()
    {
        if (PlayerPrefs.GetString("unlocked:gunthar", "false") == "true")
        {
            skinMenu.sprite = gunthar.sprite;
            sm.showMenu();
            PlayerPrefs.SetString("skin", "gunthar");
        }
    }
    public void KookSkin()
    {
        if (PlayerPrefs.GetString("unlocked:kook", "false") == "true")
        {
            skinMenu.sprite = kook.sprite;
            sm.showMenu();
            PlayerPrefs.SetString("skin", "kook");
        }
    }
    public void MenySkin()
    {
        if (PlayerPrefs.GetString("unlocked:meny", "false") == "true")
        {
            skinMenu.sprite = meny.sprite;
            sm.showMenu();
            PlayerPrefs.SetString("skin", "meny");
        }
    }
    public void BenySkin()
    {
        if (PlayerPrefs.GetString("unlocked:beny", "false") == "true")
        {
            skinMenu.sprite = beny.sprite;
            sm.showMenu();
            PlayerPrefs.SetString("skin", "beny");
        }
    }
    public void HendlerSkin()
    {
        if (PlayerPrefs.GetString("unlocked:hendler", "false") == "true")
        {
            skinMenu.sprite = hendler.sprite;
            sm.showMenu();
            PlayerPrefs.SetString("skin", "hendler");
        }
    }
    public void MostiSkin()
    {
        if (PlayerPrefs.GetString("unlocked:mosti", "false") == "true")
        {
            skinMenu.sprite = mosti.sprite;
            sm.showMenu();
            PlayerPrefs.SetString("skin", "mosti");
        }
    }
    public void YaliSkin()
    {
        if (PlayerPrefs.GetString("unlocked:yali", "false") == "true")
        {
            skinMenu.sprite = yali.sprite;
            sm.showMenu();
            PlayerPrefs.SetString("skin", "yali");
        }
    }
    public void SecretSkin()
    {
        if (PlayerPrefs.GetString("unlocked:secretskin", "false") == "true")
        {
            skinMenu.sprite = secretSkin.sprite;
            sm.showMenu();
            PlayerPrefs.SetString("skin", "secretskin");
        }
    }


    //

    //buying Skins - put onClick event

    public void bechorBuying()
    {
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 20)
        {
            PlayerPrefs.SetInt("totalCoins", PlayerPrefs.GetInt("totalCoins", 0) - 20);
            PlayerPrefs.SetString("unlocked:bechor", "true");
            Bechor.color = new Color(255, 255, 255);
            bechorLocked.SetActive(false);
            bechorCanBuy.SetActive(false);
            totalCoins.text = PlayerPrefs.GetInt("totalCoins", 0).ToString();
        }
    }

    public void mamanBuy()
    {
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 40)
        {
            PlayerPrefs.SetInt("totalCoins", PlayerPrefs.GetInt("totalCoins", 0) - 40);
            PlayerPrefs.SetString("unlocked:maman", "true");
            Maman.color = new Color(255, 255, 255);
            mamanLocked.SetActive(false);
            mamanCanBuy.SetActive(false);
            totalCoins.text = PlayerPrefs.GetInt("totalCoins", 0).ToString();
        }
    }
    public void kobiBuy()
    {
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 69)
        {
            PlayerPrefs.SetInt("totalCoins", PlayerPrefs.GetInt("totalCoins", 0) - 69);
            PlayerPrefs.SetString("unlocked:kobi", "true");
            Kobi.color = new Color(255, 255, 255);
            kobiLocked.SetActive(false);
            kobiCanBuy.SetActive(false);
            totalCoins.text = PlayerPrefs.GetInt("totalCoins", 0).ToString();
        }
    }
    public void guntharBuy()
    {
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 75)
        {
            PlayerPrefs.SetInt("totalCoins", PlayerPrefs.GetInt("totalCoins", 0) - 75);
            PlayerPrefs.SetString("unlocked:gunthar", "true");
            gunthar.color = new Color(255, 255, 255);
            guntharLocked.SetActive(false);
            guntharCanBuy.SetActive(false);
            totalCoins.text = PlayerPrefs.GetInt("totalCoins", 0).ToString();
        }
    }
    public void menyBuy()
    {
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 80)
        {
            PlayerPrefs.SetInt("totalCoins", PlayerPrefs.GetInt("totalCoins", 0) - 80);
            PlayerPrefs.SetString("unlocked:meny", "true");
            meny.color = new Color(255, 255, 255);
            menyLocked.SetActive(false);
            menyCanBuy.SetActive(false);
            totalCoins.text = PlayerPrefs.GetInt("totalCoins", 0).ToString();
        }
    }
    public void benyBuy()
    {
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 85)
        {
            PlayerPrefs.SetInt("totalCoins", PlayerPrefs.GetInt("totalCoins", 0) - 85);
            PlayerPrefs.SetString("unlocked:beny", "true");
            beny.color = new Color(255, 255, 255);
            benyLocked.SetActive(false);
            benyCanBuy.SetActive(false);
            totalCoins.text = PlayerPrefs.GetInt("totalCoins", 0).ToString();
        }
    }
    public void hendlerBuy()
    {
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 90)
        {
            PlayerPrefs.SetInt("totalCoins", PlayerPrefs.GetInt("totalCoins", 0) - 90);
            PlayerPrefs.SetString("unlocked:hendler", "true");
            hendler.color = new Color(255, 255, 255);
            hendlerLocked.SetActive(false);
            hendlerCanBuy.SetActive(false);
            totalCoins.text = PlayerPrefs.GetInt("totalCoins", 0).ToString();
        }
    }
    public void mostiBuy()
    {
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 100)
        {
            PlayerPrefs.SetInt("totalCoins", PlayerPrefs.GetInt("totalCoins", 0) - 100);
            PlayerPrefs.SetString("unlocked:mosti", "true");
            mosti.color = new Color(255, 255, 255);
            mostiLocked.SetActive(false);
            mostiCanBuy.SetActive(false);
            totalCoins.text = PlayerPrefs.GetInt("totalCoins", 0).ToString();
        }
    }
    public void yaliBuy()
    {
        if (PlayerPrefs.GetInt("totalCoins", 0) >= 420)
        {
            PlayerPrefs.SetInt("totalCoins", PlayerPrefs.GetInt("totalCoins", 0) - 420);
            PlayerPrefs.SetString("unlocked:yali", "true");
            yali.color = new Color(255, 255, 255);
            yaliLocked.SetActive(false);
            yaliCanBuy.SetActive(false);
            totalCoins.text = PlayerPrefs.GetInt("totalCoins", 0).ToString();
        }
    }
}
