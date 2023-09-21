using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWonUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameWonShow()
    {
        gameObject.SetActive(true);
    }
    public void GameWonHide()
    {
        gameObject.SetActive(false);
    }
}
