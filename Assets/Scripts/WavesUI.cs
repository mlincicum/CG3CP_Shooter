using TMPro;
using UnityEngine;

public class WavesUI : MonoBehaviour
{
    TMP_Text text;

    private void Start()
    {
        text = GetComponent<TMP_Text>();
        WaveManager.instance.onChanged.AddListener(RefreshText);
    }

    private void RefreshText()
    {
        text.text = "Remaining Waves: " + WaveManager.instance.waves.Count;
    }
}
