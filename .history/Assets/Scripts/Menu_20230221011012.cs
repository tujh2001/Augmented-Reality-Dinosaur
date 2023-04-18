using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
   public GameObject Video;

   public void openVideo()
   {
    Video.gameObject.setactive(true);
   }
}
