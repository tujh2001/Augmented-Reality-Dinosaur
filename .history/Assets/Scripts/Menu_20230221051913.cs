using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
   public GameObject[] video;
   public GameObject[] model_3d;

   public void openVideo()
   {
   // //  video.gameObject.SetActive(true);
   // //  model_3d.gameObject.SetActive(false);
   for (int i = 0; i < video.Length; i++)
      {
         model_3d[i].gameObject.SetActive(false);
         video[i].gameObject.SetActive(true);

      }

   }

   public void open3DModel()
   {
   // //  video.gameObject.SetActive(false);
   // //  model_3d.gameObject.SetActive(true);
   for (int i = 0; i < model_3d.Length; i++)
      {
         model_3d[i].gameObject.SetActive(true);
         video[i].gameObject.SetActive(false);

      }
   }
}
