using TMPro;
using UnityEngine;

public class PlayerBulletsUI : MonoBehaviour
{
    TMP_Text text;
    [SerializeField] PlayerShooting targetShooting;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        text.text = "Bullets: " + targetShooting.bulletsAmount;
    }
}
