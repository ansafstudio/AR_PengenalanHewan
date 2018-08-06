using UnityEngine;
using System.Collections;
using Vuforia;
public class ImageTargetPlayAudio : MonoBehaviour,ITrackableEventHandler {
   private TrackableBehaviour mTrackableBehaviour;
 //verly logic
    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();//panggil tracked marker
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);//yang sudah registrasi masuk
        }
    }
     
    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||//jika terdeteksi
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // Play musik
            GetComponent<AudioSource>().Play();
        }
        else
        {
            // Stop musik kita marker lost
            GetComponent<AudioSource>().Stop();
        }
    }   
}
