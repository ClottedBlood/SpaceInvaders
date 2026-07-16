using UnityEngine;

public class MovileAssetsManager : MonoBehaviour
{
   [SerializeField]

   private GameObject[] mobibleAssets;
   [SerializeField]

   private GameObject[] desktopAssets;

   private void Awake()
   {
      #if UNITY_IOS || UNITY_ANDROID
        foreach (var asset in mobibleAssets)
        {
             asset.SetActive(true);
        }
       #else
      foreach (van asset in desktopAssets)
        {
            asset.SetActive(true);
        }
       #endif
   }
}
