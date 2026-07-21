using UnityEngine;

public class MovileAssetsManager : MonoBehaviour
{
   [SerializeField]

   private GameObject[] mobibleAssets;
   [SerializeField]

   private GameObject[] desktopAssets;

   private void Awake()
   {
     if (Application.isEditor)
        {
             SetActiveAssets(desktopAssets, true);
        }
     else if (Application.isMobilePlatform)
        {
            SetActiveAssets(mobibleAssets, true);
        }
     else
     {
      SetActiveAssets(desktopAssets, true);
     }
   }
   private void SetActiveAssets(GameObject[] assets, bool isActive)
   {
    foreach (var asset in assets)
    {
      asset.SetActive(isActive);
    }
   }
}
