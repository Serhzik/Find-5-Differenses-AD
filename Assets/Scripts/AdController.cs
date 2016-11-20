using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class AdController : MonoBehaviour {
    public static AdController Instance;
    InterstitialAd interstitial;
    void Awake()
    {
        if (Instance != null)
            Destroy(gameObject);
        else
            Instance = this; 
        RequestBanner();
        DontDestroyOnLoad(gameObject);
        //interstitial.OnAdOpening += onInterstitialStart;
        //interstitial.OnAdClosed += onInterstitialEnd;
    }
	// Use this for initialization
	void Start () {
        Debug.Log("Start");
        //RequestInterstitial();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void RequestBanner()
    {
#if UNITY_EDITOR
        string adUnitId = "unused";
#elif UNITY_ANDROID
        string adUnitId = "ca-app-pub-9394422553721458/9721826720";
#elif UNITY_IPHONE
        string adUnitId = "INSERT_IOS_BANNER_AD_UNIT_ID_HERE";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Create a 320x50 banner at the top of the screen.
        BannerView bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        //AdRequest request = new AdRequest.Builder().Build();
        // Load the banner with the request.
        bannerView.LoadAd(request);
    }
    public void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-9394422553721458/5922252324";
#elif UNITY_IPHONE
        string adUnitId = "INSERT_IOS_INTERSTITIAL_AD_UNIT_ID_HERE";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
        interstitial.OnAdLoaded += Show;
    }
    public void Show(object sender, System.EventArgs args)
    {
        
        {
            interstitial.Show();
        }
        //Debug.Log("OnLevelWas");
    }
    public void onInterstitialStart(object sender, System.EventArgs args)
    {
        if (GameManager.Instance != null)
            GameManager.Instance.paused = true;
    }
    public void onInterstitialEnd(object sender, System.EventArgs args)
    {
        if (GameManager.Instance != null)
            GameManager.Instance.paused = false;
    }
}
