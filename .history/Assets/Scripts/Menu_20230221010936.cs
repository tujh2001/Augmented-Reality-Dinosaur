using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
   public GameObject video;

   public void openVideo()
   {
    video.gameObject.setactive(true);
   }
}
