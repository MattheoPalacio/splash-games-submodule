using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalizationController : MonoBehaviour
{
    public static string gameLanguage;

    void Start()
    {
        if (!PlayerPrefs.HasKey("gameLanguage"))
        {
            if (Application.systemLanguage == SystemLanguage.Russian)
            {
                PlayerPrefs.SetString("gameLanguage", "ru");
            }
            else
            {
                PlayerPrefs.SetString("gameLanguage", "en");
            }
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
