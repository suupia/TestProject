using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    [SerializeField] private Button cutButton;
    [SerializeField] private Button damageButton;
    [SerializeField] private CutMono cutMono;
    [SerializeField] private DamageMono damageMono;

    private void Start()
    {
        cutButton.onClick.AddListener(() =>
        {
            cutMono.Cut();
        });

        damageButton.onClick.AddListener(() =>
        {
            damageMono.Damage();
        });
    }

}
