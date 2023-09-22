using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButtonUI : MonoBehaviour
{
    [SerializeField] private GameObject UITemplate;
    [SerializeField] private Button quitButton;
    private void Awake()
    {
        quitButton.onClick.AddListener(() =>
        {
            UITemplate.SetActive(false);
            Loader.Load(Loader.Scene.GameScene);
        });
    }
}
