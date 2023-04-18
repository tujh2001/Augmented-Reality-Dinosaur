using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
   public GameObject video;
   public GameObject model_3d;

   public void openVideo()
   {
    video.gameObject.SetActive(true);
    model_3d.gameObject.SetActive(false);

   }

   public void open3DModel()
   {
    video.gameObject.SetActive(false);
    model_3d.gameObject.SetActive(true);
   }
}
