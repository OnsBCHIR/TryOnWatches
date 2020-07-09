using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WatchSelection : MonoBehaviour
{  //game object is refering to any object in the hierarchy 
    public GameObject watchModel1;
    public GameObject watchModel2;
    public GameObject watchModel3;

    public GameObject wWindow1;
    public GameObject wWindow2;
    public GameObject wWindow3 ;

    Animation w1Animation;
    Animation w2Animation;
    Animation w3Animation;

    // Start is called before the first frame update
    void Start()
    {
        w1Animation = wWindow1.GetComponent<Animation>();
        w2Animation = wWindow2.GetComponent<Animation>();
        w3Animation = wWindow3.GetComponent<Animation>();
    }
    public void WatchOneButtonClicked()
    {   // show the watch on the wrist
        watchModel1.SetActive(true);
        watchModel2.SetActive(false);
        watchModel3.SetActive(false);
        // Slides 
        w1Animation["w1animation"].speed = 1;
        w1Animation.Play();
    }
    public void WatchTwoButtonClicked()
    {
        watchModel2.SetActive(true);
        watchModel1.SetActive(false);
        watchModel3.SetActive(false);

        w2Animation["w2animation"].speed = 1;
        w2Animation.Play();

    }
    public void WatchThreeButtonClicked()
    {
        watchModel3.SetActive(true);
        watchModel2.SetActive(false);
        watchModel1.SetActive(false);

        w3Animation["w3animation"].speed = 1;
        w3Animation.Play();
    }
    public void CloseButtonClicked()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        if (buttonName == "w1close")
        {
            w1Animation["w1animation"].speed = -1;
            w1Animation["w1animation"].time = w1Animation["w1animation"].length;
            w1Animation.Play();
        }
        else if (buttonName == "w2close")
        {
            w2Animation["w2animation"].speed = -1;
            w2Animation["w2animation"].time = w2Animation["w2animation"].length;
            w2Animation.Play();
        }
        else if (buttonName == "w3close")
        {
            w3Animation["w3animation"].speed = -1;
            w3Animation["w3animation"].time = w3Animation["w3animation"].length;
            w3Animation.Play();
        }
    }


}
