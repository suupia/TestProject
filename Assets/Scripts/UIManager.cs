using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private CuttingMono cuttingMono;

    private void Start()
    {
        button.onClick.AddListener(() =>
        {
            cuttingMono.Cut();
        });
    }

}
