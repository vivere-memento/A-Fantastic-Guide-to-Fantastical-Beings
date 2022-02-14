using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Localization.Settings;


public class LanguageChangeDropDown : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        dropdown = transform.GetComponent<TMP_Dropdown>();
        // Wait for the localization system to initialize, loading Locales, preloading etc.
        yield return LocalizationSettings.InitializationOperation;

        // Generate list of available Locales
        var options = new List<TMP_Dropdown.OptionData>();
        int selected = 0;
        for (int i = 0; i < LocalizationSettings.AvailableLocales.Locales.Count; ++i)
        {
            var locale = LocalizationSettings.AvailableLocales.Locales[i];
            if (LocalizationSettings.SelectedLocale == locale)
                selected = i;
            options.Add(new TMP_Dropdown.OptionData(locale.name));
        }
        dropdown.options = options;

        dropdown.value = selected;
        
        dropdown.onValueChanged.AddListener(LanguageSelect);
    }

    void LanguageSelect(int index){
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
