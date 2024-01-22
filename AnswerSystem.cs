using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerSystem : MonoBehaviour
{
    public GameObject _falseTrigger;
    public GameObject _trueTrigger;
    public GameObject _falsePanel;
    public GameObject _truePanel;


    public bool isTrue = false;

    public AudioSource myFx;
    public AudioClip trueFx;
    public AudioClip falseFx;
    public AudioClip goldEggFx;


    public void Answer()
    {
        if (isTrue)
        {
            _truePanel.SetActive(true);
            _trueTrigger.SetActive(true);
            myFx.PlayOneShot(trueFx);
        }
        else
        {
            _falsePanel.SetActive(true);
            _falseTrigger.SetActive(true);
            myFx.PlayOneShot(falseFx);
        }
    }
    public void GoldEgg()
    {
        myFx.PlayOneShot(goldEggFx);
        Destroy(gameObject);
    }

}
