using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class LanguagePopUp : MonoBehaviour
{
    public GameObject toggle_ru, toggle_en;

    private void Start()
    {
        switch (PlayerPrefs.GetString("gameLanguage"))
        {
            case "en":
                toggle_en.SetActive(true);
                toggle_ru.SetActive(false);
                break;

            case "ru":
                toggle_en.SetActive(false);
                toggle_ru.SetActive(true);
                break;
        }
    }

    public void But_Change_Lang(string _local)
    {
        if (PlayerPrefs.GetString("gameLanguage") != _local)
        {
            PlayerPrefs.SetString("gameLanguage", _local);

            switch(_local)
            {
                case "en":
                    toggle_en.SetActive(true);
                    toggle_ru.SetActive(false);
                    break;

                case "ru":
                    toggle_en.SetActive(false);
                    toggle_ru.SetActive(true);
                    break;
            }
        }
    }
}
