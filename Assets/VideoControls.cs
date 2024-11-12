using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoControls : MonoBehaviour
{
    VideoPlayer vd;
    bool videoisplaying = false;
    public Material green;
    public Material red;
    // Start is called before the first frame update
    void Start()
    {
        vd = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "controller")
        {
            StoporPlay();


        }
    }

    public void StoporPlay()
    {
        if (!videoisplaying)
        {
            vd.Play();
            videoisplaying = true;
            this.gameObject.GetComponent<MeshRenderer>().material = green;
        }
        else
        {
            vd.Stop();
            videoisplaying = false;
            this.gameObject.GetComponent<MeshRenderer>().material = red;
        }
    }    

}
