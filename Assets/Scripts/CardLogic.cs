using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardLogic : MonoBehaviour
{
    public GameObject CardClose;
    public GameObject CardOpen;
    public GameLogic gameLogic;
    public bool isClosed = true;
    private void Start()
    {
        isClosed = true;
    }
    public void OnClick()
    {
        Debug.Log("--- BOOL: " + isClosed);
        if (isClosed)
        {
            OpenCard();
            int pos = int.Parse(name);
            gameLogic.PlayCard(pos, this);
        }
        else
        {
            ClosedCard();
        }
        Debug.Log("--- BOOL: " + isClosed);
    }
    public void OpenCard()
    {
        CardClose.SetActive(false);
        CardOpen.SetActive(true);
        isClosed = false;
    }

    public void ClosedCard()
    {
        CardClose.SetActive(true);
        CardOpen.SetActive(false);
        isClosed = true;
    }
}


