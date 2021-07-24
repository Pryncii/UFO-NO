using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class Movement : MonoBehaviour, IUnityAdsListener
{
    public Animator Gun;
    public Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float maxheight;
    public float minheight;
    public float maheight;
    public float miheight;
    public float Yin;
    public float maxlength;
    public float minlength;
    public int health;
    public GameObject Boom;
    public GameObject GameOver;
    public GameObject UFO;
    public GameObject effect;
    public GameObject effectss;
    public GameObject Laser;
    public Transform shotPoint;
    public Text healths;
    public Text scoreText;
    public Text scores;
    public Text lazs;
    public Text coin;
    public int score;
    private float timer;
    public Text highScore;
    public int rkp = 2;
    public int apa = 5;
    public int laz = 3;
    public int barya = 0;
    public int baryascore = 0;
    public int shopscore;
    public BoxCollider2D bc;
    public SpriteRenderer mr;
    static int loadCount = 0;
    bool testMode = false;
    public int skore;
    public Text cooldown;
    public float Stap = 0;
    public float StapAgain;

    string mySurfacingId = "rewardedVideo";


#if UNITY_IOS
    private string gameId = "3757528";
#elif UNITY_ANDROID
    private string gameId = "3757529";
#endif





    // Start is called before the first frame update
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
        barya = PlayerPrefs.GetInt("barya", 0);
        Advertisement.AddListener(this);
        score = PlayerPrefs.GetInt("skore", 0);
        StapAgain = PlayerPrefs.GetInt("StapAgain", 10);
        Time.timeScale = 1;
        health = PlayerPrefs.GetInt("Health", 3);
        loadCount++;

        PlayerPrefs.Save();
        Advertisement.Initialize(gameId, testMode);
    }

    // Update is called once per frame
    void Update()
    {
        cooldown.text = Stap.ToString("0");

        if (Stap >= 0)
        {
            Stap -= Time.deltaTime;
        }

        if (Stap <= 0)
        {
            cooldown.text = Stap.ToString("Ready");
        }


            healths.text = health.ToString();
        coin.text = baryascore.ToString();
        if (health <= 0)
        {
            
            GameOver.SetActive(true);
            UFO = (GameObject)Instantiate(UFO, transform.position, transform.rotation);
            gameObject.SetActive(false);
            PlayerPrefs.SetInt("barya", barya += baryascore);
            PlayerPrefs.Save();
            if (loadCount % 2 == 0)
            {
                if (Advertisement.IsReady("video"))
                {
                    Advertisement.Show("video");
                }
            }

        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxheight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
            GetComponent<AudioSource>().Play();
            Boom = (GameObject)Instantiate(Boom, transform.position, transform.rotation);
            Instantiate(effect, transform.position, Quaternion.identity);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minheight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = targetPos;
            GetComponent<AudioSource>().Play();
            Boom = (GameObject)Instantiate(Boom, transform.position, transform.rotation);
            Instantiate(effect, transform.position, Quaternion.identity);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown("w") && transform.position.y < maheight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yin);
            transform.position = targetPos;        
            GetComponent<AudioSource>().Play();
           



        }

        else if (Input.GetKeyDown("s") && transform.position.y > miheight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yin);
            transform.position = targetPos;
            GetComponent<AudioSource>().Play();
        }
        


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Boom = (GameObject)Instantiate(Boom, transform.position, transform.rotation);
            Instantiate(effectss, transform.position, Quaternion.identity);
            
            


        }

        timer += Time.deltaTime;



        
           

        
        if (health >= 0 && timer > 0.1f)
        {
                score += 1;
                scoreText.text = score.ToString("0");
            scores.text = score.ToString("0");
            lazs.text = laz.ToString("0");
                timer = 0;
     
        }

        if (score > PlayerPrefs.GetInt("highscore", 0))
        {
            PlayerPrefs.SetInt("highscore", score);
            highScore.text = score.ToString();
            
        }


        if (Input.GetKeyDown(KeyCode.Space) && rkp < apa)
        {
            Instantiate(Laser, shotPoint.position, Quaternion.Euler(0, 0, -90));
            rkp++;
            laz--;
        }

        if (Input.GetKeyDown(KeyCode.Space) && rkp > apa)
        {
            return;
        }


       




    }

    public void moveup()
    {
        if (transform.position.y < maheight && gameObject.activeSelf == true)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yin);
            transform.position = targetPos;
            GetComponent<AudioSource>().Play();
        }
    }

    public void movedown()
    {
        if (transform.position.y > miheight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yin);
            transform.position = targetPos;
            GetComponent<AudioSource>().Play();
        }
    }

    public void teledash()
    {
        if (Stap <= 0)
        {
            Boom = (GameObject)Instantiate(Boom, transform.position, transform.rotation);
            Instantiate(effectss, transform.position, Quaternion.identity);
            Stap = StapAgain;
            GetComponent<BoxCollider2D>().enabled = false;
            StartCoroutine(Normal());
        }

    }

    IEnumerator Normal()
    {
        yield return new WaitForSeconds(0.25f);
        {
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    public void lazer()
    {
        if (rkp < apa)
        {
            Instantiate(Laser, shotPoint.position, Quaternion.Euler(0, 0, -90));
            rkp++;
            laz--;
        }

        if (rkp > apa)
        {
            return;
        }
    }

    public void teleup()
    {
        if (transform.position.y < maxheight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
            GetComponent<AudioSource>().Play();
            Boom = (GameObject)Instantiate(Boom, transform.position, transform.rotation);
            Instantiate(effect, transform.position, Quaternion.identity);
        }
    }

    public void teledown()
    {
        if (transform.position.y > minheight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = targetPos;
            GetComponent<AudioSource>().Play();
            Boom = (GameObject)Instantiate(Boom, transform.position, transform.rotation);
            Instantiate(effect, transform.position, Quaternion.identity);
        }
    }

    public void SCORE()
    {
        if (PlayerPrefs.GetInt("barya", 0) >= 200 && PlayerPrefs.GetInt("skore", 0) <= 0)
        {

            PlayerPrefs.SetInt("skore", 200);
            PlayerPrefs.Save();
            int val = PlayerPrefs.GetInt("barya", 0);
            val -= 200;
            PlayerPrefs.SetInt("barya", val);
        }
    }

    public void Health()
    {
        if (PlayerPrefs.GetInt("barya", 0) >= 250)
        {
            int up = PlayerPrefs.GetInt("Health", 3);
            up += 1;
            PlayerPrefs.SetInt("Health", up);
            PlayerPrefs.Save();
            int val = PlayerPrefs.GetInt("barya", 0);
            val -= 250;
            PlayerPrefs.SetInt("barya", val);
        }
    }

    public void Stappy()
    {
        if (PlayerPrefs.GetInt("barya", 0) >= 250 && PlayerPrefs.GetInt("StapAgain", 10) > 3)
        {
            int up = PlayerPrefs.GetInt("StapAgain", 10);
            up -= 1;
            PlayerPrefs.SetInt("StapAgain", up);
            PlayerPrefs.Save();
            int val = PlayerPrefs.GetInt("barya", 0);
            val -= 250;
            PlayerPrefs.SetInt("barya", val);
        }
    }

    public void HS1()
    {
        if (PlayerPrefs.GetInt("highscore", 0) >= 500)
        {
           
            int val = PlayerPrefs.GetInt("barya", 0);
            val += 100;
            PlayerPrefs.SetInt("barya", val);
            PlayerPrefs.Save();
        }
    }

    public void HS2()
    {
        if (PlayerPrefs.GetInt("highscore", 0) >= 1000)
        {

            int val = PlayerPrefs.GetInt("barya", 0);
            val += 100;
            PlayerPrefs.SetInt("barya", val);
            PlayerPrefs.Save();
        }
    }

    public void HS3()
    {
        if (PlayerPrefs.GetInt("highscore", 0) >= 2000)
        {

            int val = PlayerPrefs.GetInt("barya", 0);
            val += 150;
            PlayerPrefs.SetInt("barya", val);
            PlayerPrefs.Save();
        }
    }

    public void HS4()
    {
        if (PlayerPrefs.GetInt("highscore", 0) >= 3000)
        {

            int val = PlayerPrefs.GetInt("barya", 0);
            val += 200;
            PlayerPrefs.SetInt("barya", val);
            PlayerPrefs.Save();
        }
    }

    public void HS5()
    {
        if (PlayerPrefs.GetInt("highscore", 0) >= 25000)
        {

            int val = PlayerPrefs.GetInt("barya", 0);
            val += 3000;
            PlayerPrefs.SetInt("barya", val);
            PlayerPrefs.Save();
        }
    }

    public void ShowRewardedVideo()
    {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(mySurfacingId))
        {
            Advertisement.Show(mySurfacingId);
            int val = PlayerPrefs.GetInt("barya", 0);
            val += 25;
            PlayerPrefs.SetInt("barya", val);
            PlayerPrefs.Save();
        }
        else
        {
            Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
        }
    }

    public void ShowRewardedVideoRevive()
    {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(mySurfacingId))
        {
            Advertisement.Show(mySurfacingId);
            
        }
        else
        {
            Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
        }
    }
    IEnumerator Revive()
    {
        yield return new WaitForSeconds(1f);
        Time.timeScale = 1;

    }
    public void OnUnityAdsDidFinish(string surfacingId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            if (surfacingId == mySurfacingId)
            {
                gameObject.SetActive(true);
                health = 1;
                Time.timeScale = 0.5f;
                StartCoroutine(Revive());
                GameOver.SetActive(false);

            }
        }

        
        else if (showResult == ShowResult.Skipped)
        {
            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsReady(string surfacingId)
    {
        // If the ready Ad Unit or legacy Placement is rewarded, show the ad:
        if (surfacingId == mySurfacingId)
        {
            // Optional actions to take when theAd Unit or legacy Placement becomes ready (for example, enable the rewarded ads button)
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string surfacingId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }

    // When the object that subscribes to ad events is destroyed, remove the listener:
    public void OnDestroy()
    {
        Advertisement.RemoveListener(this);
    }

    }


